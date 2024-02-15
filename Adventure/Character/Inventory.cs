using Adventure.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Character
{
    public class Inventory
    {
        private readonly List<BaseItem> items = [];

        public IReadOnlyCollection<BaseItem> Items => items;

        public void PickItem(BaseItem item)
        {
            if (item.IsPickable)
            {
                items.Add(item);
            }
        }
    }
}
