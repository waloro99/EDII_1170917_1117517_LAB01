using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LAB01_2_ED2.Class;

namespace LAB01_2_ED2.Repository
{
    interface ISodasDataBase
    {
        //conexion the method in class
        List<Soda> GetSodas();

        //conexion the method in class
        void AddNewSoda(string SodaName, Soda newSoda);

        //conexion the method in class
        Soda ReturnMySoda(string SodaName);
    }
}
