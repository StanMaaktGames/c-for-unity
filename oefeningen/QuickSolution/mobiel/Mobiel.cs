using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone
{
    public class Telephone
    {
        public string type;
        public string model;
        public string OS;
        public string CEO;
        public float price;

        public Telephone(string nType, string nModel, string nOS, string nCEO, float nPrice)
        {
            type = nType;
            model = nModel;
            OS = nOS;
            CEO = nCEO;
            price = nPrice;
        }
    }
}
