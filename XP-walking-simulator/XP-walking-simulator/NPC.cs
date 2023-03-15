using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XP_walking_simulator
{
    public class NPC : HerniPostava
    {
        public string PopisNPC { get; private set; }
        public int Sila { get; private set; }
        public bool Boss { get; private set; }

        public override void ZmenaPozice(int x, int y)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
