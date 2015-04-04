using DBP.Core.DAL.Pages;

namespace DBP.Core.BL.Services.Page
{
    public class PageService : IPageService
    {
        private readonly IPageRepository _pageRepository;

        public PageService(IPageRepository pageRepository)
        {
            _pageRepository = pageRepository;
        }

        public void A()
        {
            _pageRepository.A();
        }
    }
}
