using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Lab_Zab.Views.Shared.Components.Topbar
{
    public class TopbarViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            TopbarViewModel vm = new TopbarViewModel()
            {
                IsAdminUser = true
            };
            return View(vm);
        }
    }
}

