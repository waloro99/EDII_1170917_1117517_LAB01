using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LAB01_2_ED2.Class;

namespace LAB01_2_ED2.Repository
{
    interface ISodasDataBase
    {
        List<Soda> GetSodas();

        void AddNewSoda(string SodaName, Soda newSoda);

        Soda ReturnMySoda(string SodaName);
    }
}
