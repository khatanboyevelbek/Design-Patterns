using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Interfaces
{
    public interface ICountry
    {
        public string Capital();
        public string Location();
        public long Population();
    }
}
