using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class PickupCommand : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {
            var item = world.CurrentRoom.Items.FirstOrDefault(i => i.Name.ToLowerInvariant() == @params[0].ToLowerInvariant());

            if (item == null)
            {
                Console.WriteLine("This thing is not here!");
                return;
            }

            if (!item.IsPickable)
            {
                Console.WriteLine("I cannot pick this up!");
                return;
            }

            world.CurrentRoom.RemoveItem(item);
            world.Inventory.PickItem(item);
        }
    }
}
