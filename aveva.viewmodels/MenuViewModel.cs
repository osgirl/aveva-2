using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aveva.viewmodels
{
    public class MenuViewModel
    {
        public string Name { get; set; }

        public string Link { get; set; }

        public IList<MenuViewModel> SubMenus { get; set; }
        public MenuViewModel()
        {
            SubMenus = new List<MenuViewModel>();
        }
    }
}
