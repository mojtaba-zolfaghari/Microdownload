using AutoMapper;
using Microdownload.DataLayer.Context;
using Microdownload.Entities;
using Microdownload.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microdownload.ViewModels;
using System.Threading.Tasks;
using System.Linq;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Identity;

namespace Microdownload.Services
{
    public interface ISlideShowImageService
    {
        void AddSlide(SlideShowImage slideShow, IList<SlideShowImage> otherSlideShows);
        IdentityResult DeleteSlide(int slideId);
        void EditSlide(SlideShowImage slideShow, IList<SlideShowImage> otherSlideShows);
        Task<IList<SlideShowViewModel>> GetSlideShowImages();
        Task<SlideShowViewModel> GetSlideShow(int slideShowId);
    }

    public class SlideShowImageService : ISlideShowImageService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly DbSet<SlideShowImage> _slideShowImages;


        public SlideShowImageService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _slideShowImages = unitOfWork.Set<SlideShowImage>();
            _mapper = mapper;
        }

        public void AddSlide(SlideShowImage slideShow, IList<SlideShowImage> otherSlideShows)
        {

            _slideShowImages.Add(slideShow);
            FixOrder(otherSlideShows);
        }


        private void FixOrder(IList<SlideShowImage> otherSlideShows)
        {
            foreach (var slideShow in otherSlideShows)
            {
                _slideShowImages.Attach(slideShow);
                _unitOfWork.Entry(slideShow).Property(slide => slide.Order).IsModified = true;
            }
        }


        public IdentityResult DeleteSlide(int slideId)
        {
            var entity = new SlideShowImage() { Id = slideId };

            _unitOfWork.Entry(entity).State = EntityState.Deleted;
            return IdentityResult.Success;
        }

        public void EditSlide(SlideShowImage slideShow, IList<SlideShowImage> otherSlideShows)
        {
            _slideShowImages.Attach(slideShow);
            _unitOfWork.Entry(slideShow).State = EntityState.Modified;


            FixOrder(otherSlideShows);
        }

        public async Task<IList<SlideShowViewModel>> GetSlideShowImages()
        {
            return await _slideShowImages
                        .AsNoTracking()
                        .OrderBy(slide => slide.Order).ThenByDescending(slide => slide.CreatedDate)
                        .ProjectTo<SlideShowViewModel>().ToListAsync();
                      
        }

        public async Task<SlideShowViewModel> GetSlideShow(int slideShowId)
        {
            return await _slideShowImages.Where(slideShow => slideShow.Id == slideShowId)
                .ProjectTo<SlideShowViewModel>().FirstOrDefaultAsync();
        }
    }
}
