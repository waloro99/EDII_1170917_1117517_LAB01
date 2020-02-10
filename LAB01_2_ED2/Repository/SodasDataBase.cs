using LAB01_2_ED2.Class;
using System;
using System.Collections.Generic;

namespace LAB01_2_ED2.Repository
{
    public class SodasDataBase:ISodasDataBase
    {
        //My Database
        BTree<String, Soda> myTree = new BTree<String, Soda>(5); //instance class btree

        public List<Soda> GetSodas()
        {
            List<Soda> rtrnList = new List<Soda>();
            myTree.InOrden(ref rtrnList);
            return rtrnList;
        }

        public void AddNewSoda(string SodaName, Soda newSoda)
        {
            myTree.Insert(SodaName, newSoda);
        }

        public Soda ReturnMySoda(string SodaName)
        {
            return null;
        }
    }

}
