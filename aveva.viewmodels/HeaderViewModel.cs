using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aveva.viewmodels
{
    public class HeaderViewModel
    {
        public string LogoUrl { get; set; }

        public string Title { get; set; }

        public IList<MenuViewModel> Menus { get; set; }

        public HeaderViewModel()
        {
            Menus = new List<MenuViewModel>();
        }
    }
}
