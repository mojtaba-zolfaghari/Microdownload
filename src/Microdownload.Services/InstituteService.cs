using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microdownload.DataLayer.Context;
using Microdownload.Entities;
using Microdownload.Services.Contracts.Identity;
using Microdownload.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Microdownload.Services
{
    public interface IInstituteService
    {
        IdentityResult AddTeacher(TeacherViewModel model);
        IdentityResult DeleteTeacher(TeacherViewModel model);
        IdentityResult EditTeacher(TeacherViewModel model);
        Task<TeacherViewModel> GetTeacherByIdAsync(int Id);
        IdentityResult AddCourseToTeacherById(int Id, int CourseId);
        Task<PagingViewModel<TeacherViewModel>> GetTeachersListAsync(int UserId, int page, int rows);
        Task<IList<TeacherViewModel>> GetTeachersListForViewBagAsync();
        Task<List<InstituteViewModel>> GetTopInstituteListAsync(int rows);




        IdentityResult AddTeacherReuest(TeacherRequestViewModel model);
        IdentityResult DeleteTeacherReuest(TeacherRequestViewModel model);
        IdentityResult EditTeacherReuest(TeacherRequestViewModel model);
        Task<TeacherRequestViewModel> GetTeacheReuestrByIdAsync(int Id);
        Task<PagingViewModel<TeacherRequestViewModel>> GetTeacherRequestListAsync(int UserId, int? page, int? rows);


        IdentityResult AddInstituteRequest(InstituteRequestViewModel model);
        IdentityResult DeleteInstituteRequest(InstituteRequestViewModel model);
        IdentityResult EditInstituteRequest(InstituteRequestViewModel model);
        Task<InstituteRequestViewModel> GetInstituteRequesByIdAsync(int Id);
        Task<PagingViewModel<InstituteRequestViewModel>> GetInstituteRequestListAsync(int UserId, int? page, int? rows);



        IdentityResult AddInstitute(InstituteViewModel model);
        Task<IdentityResult> DeleteInstituteByIdAsync(int Id);
        IdentityResult EditInstitute(InstituteViewModel model);
        Task<InstituteViewModel> GetInstituteByIdAsync(int Id);
        Task<InstituteViewModel> GetInstituteByUserIdAsync(int UserId);

        Task<PagingViewModel<InstituteViewModel>> GetInstituteListAsync();
        IdentityResult AddInstituteToTeacherById(int TeacherId, int InstituteId);
        Task<PagingViewModel<InstituteViewModel>> GetInstituteStudentsListAsync(int UserId, int page, int rows, InstituteUserViewModel instituteUserModel);
        IList<InstituteCourseViewModel> GetInstituteCoursesList();
        IList<InstituteCourseViewModel> GetInstituteCoursesById(int CourseId, int? UserId);
        Task<IList<InstituteCourseViewModel>> GetCourseInstituteById(int? InstituteId);
        Task<IList<InstituteViewModel>> GetInstituteListForAddAsync();

        Task<IdentityResult> AddInstituteCourse(InstituteCourseViewModel model);






    }

    public class InstituteService : IInstituteService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;
        private readonly IApplicationUserManager _userManager;
        private readonly DbSet<Institute> _Institute;
        private readonly DbSet<Teacher> _Teacher;
        private readonly DbSet<InstituteCourse> _InstituteCourse;
        private readonly DbSet<TeacherCourse> _TeacherCourse;
        private readonly DbSet<TeacherRequest> _TeacherRequest;
        private readonly DbSet<InstituteRequest> _InstituteRequest;
        private readonly ICourseService _courseService;

        public InstituteService(ICourseService courseService, IUnitOfWork uow, IApplicationUserManager userManager, IMapper mapper)
        {
            _mapper = mapper;
            _uow = uow;
            _userManager = userManager;
            _Institute = uow.Set<Institute>();
            _Teacher = _uow.Set<Teacher>();
            _InstituteCourse = _uow.Set<InstituteCourse>();
            _courseService = courseService;
            _TeacherCourse = _uow.Set<TeacherCourse>();
            _TeacherRequest = _uow.Set<TeacherRequest>();
            _InstituteRequest = _uow.Set<InstituteRequest>();
        }

        public IdentityResult AddInstitute(InstituteViewModel model)
        {
            var Institute = new Institute();
            var a = _mapper.Map(model, Institute);
            _uow.Entry(a).State = EntityState.Added;

            return IdentityResult.Success;
        }

        public IdentityResult AddTeacher(TeacherViewModel model)
        {
            var Teacher = new Teacher();
            _mapper.Map(model, Teacher);
            _uow.Entry(Teacher).State = EntityState.Added;
            _uow.SaveChanges();


            return IdentityResult.Success;
        }

        public async Task<IdentityResult> DeleteInstituteByIdAsync(int Id)
        {
            Institute Institute = await _Institute.FindAsync(Id);


            if (Institute == null)
            {
                return IdentityResult.Failed(new IdentityError
                {
                    Code = "InstituteNotFound",
                    Description = "رکورد مورد نظر یافت نشد."
                });
            }
            else
            {
                _uow.Entry(Institute).State = EntityState.Deleted;

                return IdentityResult.Success;

            }
        }
        public IdentityResult EditInstitute(InstituteViewModel model)
        {
            var U = new Institute();
            _mapper.Map(model, U);

            _uow.Entry(U).State = EntityState.Modified;
            return IdentityResult.Success;
        }

        public IdentityResult EditTeacher(TeacherViewModel model)
        {
            var T = new InstituteTeacher();

            _mapper.Map(model, T);

            _uow.Entry(T).State = EntityState.Modified;
            return IdentityResult.Success;
        }

        public async Task<PagingViewModel<InstituteViewModel>> GetInstituteListAsync()
        {
            var query = await (from p in _Institute
                               select p)
                               .OrderByDescending(c => c.Id)
                               .ProjectTo<InstituteViewModel>()
                               .ToListAsync();

            return new PagingViewModel<InstituteViewModel>
            {
                Paging =
                {
                    TotalItems =  query.Count()
                },
                List = query.ToList()
            };
        }
        public Task<InstituteViewModel> GetInstituteByIdAsync(int Id)
        {
            return _Institute.AsNoTracking().Where(c => c.Id == Id).ProjectTo<InstituteViewModel>().FirstOrDefaultAsync();
        }




        public async Task<PagingViewModel<TeacherViewModel>> GetTeachersListAsync(int UserId, int page, int rows)
        {
            var offset = ((page - 1) * rows);

            var query = await (from p in _Teacher
                    .Include(c => c.User)
                               select new TeacherViewModel
                               {
                                   InstituteTeacher = p.InstituteTeacher,
                                   Id = p.Id,
                                   User = p.User,
                                   UserId = p.UserId
                               })
                               .OrderByDescending(c => c.Id)
                               .ToListAsync();

            return new PagingViewModel<TeacherViewModel>
            {
                Paging =
                {
                    TotalItems =  query.Count()
                },
                List = query.Skip(offset).Take(rows).ToList()
            };
        }


        public async Task<IList<TeacherViewModel>> GetTeachersListForViewBagAsync()
        {
            var query = await (from p in _Teacher
                    .Include(c => c.User)
                               select new TeacherViewModel
                               {
                                   InstituteTeacher = p.InstituteTeacher,
                                   Id = p.Id,
                                   UserId = p.UserId,
                                   User = p.User

                               })
                    .OrderByDescending(c => c.Id)
                    .ToListAsync();

            return query;
        }

        public async Task<PagingViewModel<InstituteViewModel>> GetInstituteStudentsListAsync(int UserId, int page, int rows, InstituteUserViewModel instituteUserModel)
        {
            var offset = ((page - 1) * rows);

            var query = await GetInstituteListAsync();
            var q2 = query.List.Where(c => c.InstituteName == instituteUserModel.Institute.InstituteName)
                               .OrderByDescending(c => c.Id);

            return new PagingViewModel<InstituteViewModel>
            {
                Paging =
                {
                    TotalItems =  q2.Count()
                },
                List = q2.Skip(offset).Take(rows).ToList()
            };
        }

        public PagingViewModel<InstituteCourse> GetInstituteCoursesList(int UserId, int page, int rows, InstituteCourseViewModel InstituteCourseViewModel)
        {
            var offset = ((page - 1) * rows);

            var query = _InstituteCourse.Where(c => c.Institute.InstituteName == InstituteCourseViewModel.Institute.InstituteName && c.Courses == InstituteCourseViewModel.Courses)
                               .OrderByDescending(c => c.Id);


            return new PagingViewModel<InstituteCourse>
            {
                Paging =
                {
                    TotalItems =  query.Count()
                },
                List = query.Skip(offset).Take(rows).ToList()
            };
        }

        public IdentityResult DeleteTeacher(TeacherViewModel model)
        {
            var T = new InstituteTeacher();

            _mapper.Map(model, T);

            _uow.Entry(T).State = EntityState.Deleted;
            return IdentityResult.Success;
        }

        Task<PagingViewModel<InstituteViewModel>> IInstituteService.GetInstituteStudentsListAsync(int UserId, int page, int rows, InstituteUserViewModel instituteUserModel)
        {
            throw new System.NotImplementedException();
        }

        public IList<InstituteCourseViewModel> GetInstituteCoursesList()
        {
            List<InstituteCourseViewModel> model;

            var query2 = (from p in _InstituteCourse
   .Include(c => c.Courses)
   .Include(c => c.Institute)
                          select new InstituteCourseViewModel
                          {
                              Courses = p.Courses,
                              CoursesId = p.CoursesId,
                              Institute = p.Institute,
                              InstituteId = p.InstituteId,
                              Id = p.Id

                          })

     .OrderByDescending(c => c.Id)
     .ToList();
            model = query2;
            return query2;


        }

        public async Task<IList<InstituteViewModel>> GetInstituteListForAddAsync()
        {
            var allUser = await _userManager.GetAllUsersAsync();
            var query = (from p in _Institute

                         select new InstituteViewModel
                         {
                             Id = p.Id,
                             InstituteName = p.InstituteName,

                         }).ToList();

            return query;
        }

        public async Task<TeacherViewModel> GetTeacherByIdAsync(int Id)
        {
            return await _Institute.AsNoTracking().Where(c => c.Id == Id).ProjectTo<TeacherViewModel>().FirstOrDefaultAsync();

        }

        public IdentityResult AddInstituteToTeacherById(int TeacherId, int InstituteId)
        {
            var InstituteTeacherViewModel = new InstituteTeacherViewModel();
            InstituteTeacherViewModel.InstituteId = InstituteId;
            InstituteTeacherViewModel.TeacherId = TeacherId;

            var TeacherCourse = new InstituteTeacher();
            var a = _mapper.Map(InstituteTeacherViewModel, TeacherCourse);

            _uow.Entry(a).State = EntityState.Added;
            return IdentityResult.Success;

        }

        public IdentityResult AddCourseToTeacherById(int TeacherId, int CourseId)
        {
            var TeacherCourseViewModel = new TeacherCourseViewModel();
            TeacherCourseViewModel.CoursesId = CourseId;
            TeacherCourseViewModel.TeacherId = TeacherId;

            var TeacherCourse = new TeacherCourse();
            var a = _mapper.Map(TeacherCourseViewModel, TeacherCourse);

            _uow.Entry(a).State = EntityState.Added;
            return IdentityResult.Success;

        }

        public IdentityResult AddTeacherReuest(TeacherRequestViewModel model)
        {
            var TeacherRequest = new TeacherRequest();
            var a = _mapper.Map(model, TeacherRequest);
            _uow.Entry(a).State = EntityState.Added;

            return IdentityResult.Success;
        }

        public IdentityResult DeleteTeacherReuest(TeacherRequestViewModel model)
        {
            var T = new TeacherRequest();

            _mapper.Map(model, T);

            _uow.Entry(T).State = EntityState.Deleted;
            return IdentityResult.Success;
        }

        public IdentityResult EditTeacherReuest(TeacherRequestViewModel model)
        {
            var T = new TeacherRequest();

            _mapper.Map(model, T);

            _uow.Entry(T).State = EntityState.Modified;
            return IdentityResult.Success;
        }

        public async Task<TeacherRequestViewModel> GetTeacheReuestrByIdAsync(int Id)
        {
            return await _Institute.AsNoTracking().Where(c => c.Id == Id).ProjectTo<TeacherRequestViewModel>().FirstOrDefaultAsync();
        }

        public async Task<PagingViewModel<TeacherRequestViewModel>> GetTeacherRequestListAsync(int UserId, int? page, int? rows)
        {
            var offset = ((page - 1) * rows);

            var query = await (from p in _TeacherRequest
                    .Include(c => c.User)
                               select new TeacherRequestViewModel
                               {
                                   Description = p.Description,
                                   RequestedLesson = p.RequestedLesson,
                                   RequestResponseStatus = p.RequestResponseStatus,
                                   ResumeFile = p.ResumeFile,
                                   UserId = p.UserId,
                                   User = p.User

                               })
                               .OrderByDescending(c => c.Id)
                               .ToListAsync();

            return new PagingViewModel<TeacherRequestViewModel>
            {
                Paging =
                {
                    TotalItems =  query.Count()
                },
                List = query.Skip(offset.Value).Take(rows.Value).ToList()
            };
        }

        public IdentityResult AddInstituteRequest(InstituteRequestViewModel model)
        {
            var TeacherRequest = new InstituteRequest();
            var a = _mapper.Map(model, TeacherRequest);
            _uow.Entry(a).State = EntityState.Added;

            return IdentityResult.Success;
        }

        public IdentityResult DeleteInstituteRequest(InstituteRequestViewModel model)
        {
            var T = new InstituteRequest();

            _mapper.Map(model, T);

            _uow.Entry(T).State = EntityState.Deleted;
            return IdentityResult.Success;
        }

        public IdentityResult EditInstituteRequest(InstituteRequestViewModel model)
        {
            var T = new InstituteRequest();

            _mapper.Map(model, T);

            _uow.Entry(T).State = EntityState.Modified;
            return IdentityResult.Success;
        }

        public async Task<InstituteRequestViewModel> GetInstituteRequesByIdAsync(int Id)
        {
            return await _Institute.AsNoTracking().Where(c => c.Id == Id).ProjectTo<InstituteRequestViewModel>().FirstOrDefaultAsync();
        }

        public async Task<PagingViewModel<InstituteRequestViewModel>> GetInstituteRequestListAsync(int UserId, int? page, int? rows)
        {
            var offset = ((page - 1) * rows);

            var query = await (from p in _InstituteRequest
                    .Include(c => c.User)
                               select new InstituteRequestViewModel
                               {
                                   Description = p.Description,
                                   RequestedCourse = p.RequestedCourse,
                                   RequestStatus = p.RequestStatus,
                                   RegisterdFile = p.RegisterdFile,
                                   UserId = p.UserId,
                                   User = p.User
                               })
                               .OrderByDescending(c => c.Id)
                               .ToListAsync();

            return new PagingViewModel<InstituteRequestViewModel>
            {
                Paging =
                {
                    TotalItems =  query.Count()
                },
                List = query.Skip(offset.Value).Take(rows.Value).ToList()
            };
        }

        public IList<InstituteCourseViewModel> GetInstituteCoursesById(int CourseId, int? UserId)
        {
            List<InstituteCourseViewModel> model;
            if (UserId == null)
            {
                var query = (from p in _InstituteCourse
       .Include(c => c.Courses)
       .Include(c => c.Institute)
       .Where(c => c.CoursesId == CourseId)
                             select new InstituteCourseViewModel
                             {
                                 Courses = p.Courses,
                                 CoursesId = p.CoursesId,
                                 Institute = p.Institute,
                                 InstituteId = p.InstituteId,
                                 Id = p.Id

                             })

         .OrderByDescending(c => c.Id)
         .ToList();
                model = query;
                return query;
            }

            var query1 = (from p in _InstituteCourse
         .Include(c => c.Courses)
         .Include(c => c.Institute)
         .Where(c => c.Institute.UserId == CourseId)
                          select new InstituteCourseViewModel
                          {
                              Courses = p.Courses,
                              CoursesId = p.CoursesId,
                              Institute = p.Institute,
                              InstituteId = p.InstituteId,
                              Id = p.Id

                          })

         .OrderByDescending(c => c.Id)
         .ToList();
            model = query1;
            return query1;

        }

        public async Task<IList<InstituteCourseViewModel>> GetCourseInstituteById(int? InstituteId)
        {
            List<InstituteCourseViewModel> model;
            var query1 = await (from p in _InstituteCourse
          .Include(c => c.Courses)
          .Include(c => c.Institute)
          .Where(c => c.InstituteId == InstituteId)
                                select new InstituteCourseViewModel
                                {
                                    Courses = p.Courses,
                                    CoursesId = p.CoursesId,
                                    Institute = p.Institute,
                                    InstituteId = p.InstituteId,
                                    Id = p.Id

                                })

         .OrderByDescending(c => c.Id)
         .ToListAsync();
            model = query1;
            return query1;
        }

        public async Task<IdentityResult> AddInstituteCourse(InstituteCourseViewModel model)
        {
            var InstituteCourse = new InstituteCourse();
            var a = _mapper.Map(model, InstituteCourse);
            _uow.Entry(a).State = EntityState.Added;

            return IdentityResult.Success;
        }

        public Task<InstituteViewModel> GetInstituteByUserIdAsync(int UserId)
        {
            return _Institute.AsNoTracking().Where(c => c.UserId == UserId).ProjectTo<InstituteViewModel>().FirstOrDefaultAsync();
        }

        public async Task<List<InstituteViewModel>> GetTopInstituteListAsync(int rows)
        {
            var query = await(from p in _Institute
                              select new InstituteViewModel
                              {
                                  Id = p.Id,
                                  Address=p.Address,
                                  Description=p.Description,
                                  InstituteName=p.InstituteName,
                                  InstituteStudent=p.InstituteStudent,
                                  InstituteTeacher=p.InstituteTeacher,
                                  InstituteCourse = p.InstituteCourse,
                                  InstituteType=p.InstituteType,
                                  Phone=p.Phone,
                                  User=p.User,
                                  UserId=p.UserId
                              })
                    .OrderByDescending(c => c.Id)
                    .ToListAsync();

            return query.Take(rows).ToList();
        }
    }
}