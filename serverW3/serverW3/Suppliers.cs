using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serverW3
{
    [Serializable]
    public class Suppliers
    {
        private String name;
        private String address;
        private long telephone;
        private long inn;

        public Suppliers()
        {
            this.name = "";
            this.address = "";
            this.telephone = 0;
            this.inn = 0;
        }

        public Suppliers(String name, String address, long telephone, long inn)
        {
            this.name = name;
            this.address = address;
            this.telephone = telephone;
            this.inn = inn;
        }

        public String getAddress()
        {
            return address;
        }

        public void setAddress(String address)
        {
            this.address = address;
        }

        public long getInn()
        {
            return inn;
        }

        public void setInn(long inn)
        {
            this.inn = inn;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public long getTelephone()
        {
            return telephone;
        }

        public void setTelephone(long telephone)
        {
            this.telephone = telephone;
        }
    }
}
