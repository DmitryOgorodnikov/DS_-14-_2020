using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serverW3
{
    [Serializable]
    public class Warranty
    {
        private String type;
        private int duration;

        public Warranty()
        {
            this.type = "";
            this.duration = 0;
        }

        public Warranty(String type, int duration)
        {
            this.type = type;
            this.duration = duration;
        }

        public int getDuration()
        {
            return duration;
        }

        public void setDuration(int duration)
        {
            this.duration = duration;
        }

        public String getType()
        {
            return type;
        }

        public void setType(String type)
        {
            this.type = type;
        }
    }
}
