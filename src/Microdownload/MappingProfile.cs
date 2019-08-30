using AutoMapper;
using Microdownload.Entities;
using Microdownload.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microdownload
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Institute, InstituteViewModel>();
            CreateMap<InstituteViewModel, Institute>();

            CreateMap<Courses, CourseViewModel>();
            CreateMap<CourseViewModel, Courses>();

            CreateMap<Teacher, TeacherViewModel>();
            CreateMap<TeacherViewModel, Teacher>();

            CreateMap<InstituteTeacher, InstituteTeacherViewModel>();
            CreateMap<InstituteTeacherViewModel, InstituteTeacher>();

            CreateMap<SlideShowViewModel, SlideShowImage>();

            CreateMap<Payment, PaymentViewModel>();

            CreateMap<Wallet, WalletViewModel>();
            CreateMap<WalletViewModel, Wallet>();
        }
    }
}
