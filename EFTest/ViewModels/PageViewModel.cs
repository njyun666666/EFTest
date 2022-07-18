using EFTest.Models;

namespace EFTest.ViewModels
{
    public class PageViewModel
    {
        public int PageId { get; set; }
        public string Title { get; set; }

        public ICollection<PageSectionViewModel> TbPageSection { get; set; }
    }

    public  class PageSectionViewModel
    {
        public int Id { get; set; }
        public int PageId { get; set; }
        public int SectionId { get; set; }
    }
}