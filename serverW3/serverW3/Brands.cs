using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serverW3
{
    [Serializable]
    public class Brands
    {
        private String name;
        private String description;

        public Brands()
        {
            this.name = "";
            this.description = "";
        }

        public Brands(String name, String description)
        {
            this.name = name;
            this.description = description;
        }

        public String getDescription()
        {
            return description;
        }

        public void setDescription(String description)
        {
            this.description = description;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        } 
    }
}
