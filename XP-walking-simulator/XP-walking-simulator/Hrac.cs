using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace XP_walking_simulator
{
    public class Hrac : HerniPostava
    {
        public Hrac(BarvaVlasu barvaVlasu, Oblicej oblicej, Vlasy vlasy, string specializace) 
        { 
        
        }
        private string specializace;
        public string Specializace
        {
            get { return specializace; }
            set
            {
                if (value != "Kouzelník" && value != "Berserker" && value != "Inženýr" && value != "Cizák")
                    specializace = value;
            }
        }
        public enum BarvaVlasu { Hneda, Cerna, Blond, Zrzava };
        public enum Oblicej { VelkyNos, Usoplesk, MakeUp }
        public enum Vlasy { Drdol, Culik, Pleska};

        public BarvaVlasu barvaVlasu;
        public Oblicej oblicej;
        public Vlasy vlasy;

        public int XP { get; private set; }

        public void PridejXP(int xp)
        {
            XP += xp;
            if (XP > Level * 100)
            {
                XP -= Level * 100;
                Level++;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(" Specializace - {0} BarvaVlasu - {1} Oblicej - {2} Vlasy - {3} XP - {4}",Specializace,barvaVlasu,oblicej,vlasy,XP);
        }
    }
}
