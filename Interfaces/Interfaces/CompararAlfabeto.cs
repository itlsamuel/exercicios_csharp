using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class CompararAlfabeto: IComparer
    {
        int IComparer.Compare(object obj1, object obj2)
        {
            Alfabeto comp1 = (Alfabeto)obj1;
            Alfabeto comp2 = (Alfabeto)obj2;
            
            if(comp1.caract < comp2.caract)
                return -1;
            if(comp1.caract > comp2.caract)
                return 1;
            return 0;
        }
    }
}
