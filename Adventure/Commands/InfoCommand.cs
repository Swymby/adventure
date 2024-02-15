using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class InfoCommand : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {
            var infoItem = world.CurrentRoom.Items.FirstOrDefault(i => i.Name.ToLowerInvariant() == @params[0].ToLowerInvariant());

            if (infoItem == null)
            {
                Console.WriteLine("This thing is not here!");
                return;
            }

            Console.WriteLine(infoItem.Description);
        }
    }
}
