using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microdownload.DataLayer.Context;
using Microdownload.Entities;
using Microdownload.Entities.Identity;
using Microdownload.Services.Contracts.Identity;
using Microdownload.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microdownload.Services
{
    public interface ICourseService
    {
        Task<PagingViewModel<CourseViewModel>> GetCourseListAsync(int UserId, int? page, int? rows);
        Task<List<CourseViewModel>> GetTopCourseListAsync(int rows);

        Task<CourseViewModel> GetCourseByIdAsync(int? Id);
        Task<IdentityResult> DeleteCourseByIdAsync(int Id);
        IdentityResult AddCourse(CourseViewModel model);
        IdentityResult EditCourse(CourseViewModel model);
    }

    public class CourseService : ICourseService
    {
        private readonly IMapper _mapper;

        private readonly IUnitOfWork _uow;
        private readonly IApplicationUserManager _userManager;
        private readonly DbSet<Courses> _Course;
        private readonly DbSet<InstituteCourse> _InstituteCourse;

        

        public CourseService( IUnitOfWork uow, IApplicationUserManager userManager, IMapper mapper)
        {
            _uow = uow;
            _userManager = userManager;
            _Course = uow.Set<Courses>();
            _mapper = mapper;
            _InstituteCourse = uow.Set<InstituteCourse>();
        }

        public IdentityResult AddCourse(CourseViewModel model)
        {
            var U = new Courses();
            _mapper.Map(model, U);
            _uow.Entry(U).State = EntityState.Added;
            _uow.SaveChanges();

            return IdentityResult.Success;
        }

        public async Task<IdentityResult> DeleteCourseByIdAsync(int Id)
        {
            var Cou = await _Course.FindAsync(Id);


            if (Cou == null)
            {
                return IdentityResult.Failed(new IdentityError
                {
                    Code = "CrsNotFound",
                    Description = "رکورد مورد نظر یافت نشد."
                });
            }
            else
            {
                _uow.Entry(Cou).State = EntityState.Deleted;

                return IdentityResult.Success;

            }
        }

        public IdentityResult EditCourse(CourseViewModel model)
        {
            var U = new Courses();
            _mapper.Map(model, U);

            _uow.Entry(U).State = EntityState.Modified;
            return IdentityResult.Success;
        }

        public Task<CourseViewModel> GetCourseByIdAsync(int? Id)
        {
            return _Course.AsNoTracking().Where(c => c.Id == Id).ProjectTo<CourseViewModel>().FirstOrDefaultAsync();
        }

        public async Task<PagingViewModel<CourseViewModel>> GetCourseListAsync(int UserId, int? page, int? rows)
        {
            var offset = ((page - 1) * rows);

            var query = await (from p in _Course
                               .Include(c=>c.CoursesStudent)
                               .Include(c=>c.InstituteCourse)
                               .Include(c=>c.TeacherCourse)
                               select new CourseViewModel
                               {
                                   Id = p.Id,
                                   CourseName = p.CourseName,
                                   CourseStatus = p.CourseStatus,
                                   CreatedDate = p.CreatedDate,
                                   CoursesStudent = p.CoursesStudent,
                                   InstituteCourse = p.InstituteCourse,
                                   Link = p.Link,
                                   Price = p.Price,
                                   StartDate = p.StartDate,
                               })
                               .OrderByDescending(c => c.Id)
                               .ToListAsync();

            return new PagingViewModel<CourseViewModel>
            {
                Paging =
                {
                    TotalItems =  query.Count()
                },
                List = query.Skip(offset.Value).Take(rows.Value).ToList()
            };
        }

        public async Task<List<CourseViewModel>> GetTopCourseListAsync(int rows)
        {

            var query = await(from p in _Course
                              select new CourseViewModel
                              {
                                  Id = p.Id,
                                  CourseName = p.CourseName,
                                  CourseStatus = p.CourseStatus,
                                  CreatedDate = p.CreatedDate,
                                  CoursesStudent = p.CoursesStudent,
                                  InstituteCourse = p.InstituteCourse,
                                  Link = p.Link,
                                  Price = p.Price,
                                  StartDate = p.StartDate,
                                  ImageUrl=p.ImageUrl
                              })
                               .OrderByDescending(c => c.Id)
                               .ToListAsync();

            return query.Take(rows).ToList();
        }
    }
}