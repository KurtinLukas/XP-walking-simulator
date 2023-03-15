using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XP_walking_simulator
{
    public class HerniPostava
    {
        private string jmeno;
        public string Jmeno {
            get { return jmeno; }
            set
            {
                if (value.Length < 11) jmeno = value;
                //else ThrowReferenceException
            }
        }
        
        public int Level { get; protected set; }
        
        public int X { get; private set; }
        public int Y { get; private set; }

        public virtual void ZmenaPozice(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return string.Format("Jmeno {0};Level {1};X {2};Y {3}",jmeno,Level,X,Y);
        }

        public HerniPostava()
        {
            X = 0;
            Y = 0;
            Level = 1;
        }
    }
}
