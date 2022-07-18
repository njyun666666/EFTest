using AutoMapper;
using EFTest.Models;
using EFTest.ViewModels;

namespace EFTest.Profiles
{
    public class PageProfile : Profile
    {
        public PageProfile()
        {
            CreateMap<TbPage, PageViewModel>();
            CreateMap<TbPageSection, PageSectionViewModel>();
        }
    }

}
