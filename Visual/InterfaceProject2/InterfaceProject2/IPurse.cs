using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProject2
{
    interface IPurse
    {
        int Sum { get; set; }

        void AddMoney(int);
        int DecMoney(int);
    }
}
