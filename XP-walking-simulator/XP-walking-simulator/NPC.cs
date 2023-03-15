using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XP_walking_simulator
{
    public class NPC : HerniPostava
    {
        public NPC(PopisPrace popisPrace, bool sila) 
        { 
            PopisNPC = popisPrace;
            Sila= sila;
        }
        public NPC(PopisPrace popisPrace)
        {
            PopisNPC = popisPrace;
        }
        public enum PopisPrace { obchodnik, nepritel, obyvatel };
        public PopisPrace PopisNPC { get; private set; }
        /// <summary>
        /// 1 == boss 0 == neni boss
        /// </summary>
        public bool Sila { get; private set; }

        public override void ZmenaPozice(int x, int y)
        {
            return;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("PopisNPC - {0} {1}",PopisNPC,(Sila?"Boss":"Minion"));
        }
    }
}
