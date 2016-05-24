using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aveva.itemtranslator
{
    interface IItemBuilder<T> where T : class
    {
        T CreateModel(Item sitecoreItem);
        Item TranslateToItem();
    }
}
