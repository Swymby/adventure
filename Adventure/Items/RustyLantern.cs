using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items
{
    public class RustyLantern : BaseItem
    {
        public override string Name => "lantern";

        public override string Description => "Old rusty lantern, have seen better days, maybe it will still work?";

        public override bool IsPickable => true;
    }
}
