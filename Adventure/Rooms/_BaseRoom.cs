using Adventure.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Rooms
{
    public abstract class BaseRoom
    {
        protected readonly List<BaseItem> items = [];
        protected readonly List<BaseRoom> neighbours = [];
        
        public abstract string Name { get; }
        public abstract string Description { get; }

        public IReadOnlyCollection<BaseItem> Items => items;
        public IReadOnlyCollection<BaseRoom> Neighbours => neighbours;

        public void RegisterNeighbour(BaseRoom room)
        {
            neighbours.Add(room);
        }

        public void RemoveItem(BaseItem item)
        {
            this.items.Remove(item);
        }
    }
}
