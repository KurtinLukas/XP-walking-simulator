using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XP_walking_simulator
{
    public class Hrac : HerniPostava
    {
        public enum Specializace { Drevorubec, Rybar, Tesar, Lovec };
        public enum BarvaVlasu { Hneda, Cerna, Blond, Zrzava };
        public enum Oblicej { VelkyNos, Usoplesk, MakeUp }
        public enum Vlasy { Drdol, Culik, Pleska};

        public Specializace specializace;
        public BarvaVlasu barvaVlasu;
        public Oblicej oblicej;
        public Vlasy vlasy;

        public int XP { get; private set; }

        public void PridejXP(int xp)
        {
            XP += xp;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
