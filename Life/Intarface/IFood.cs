using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life
{
    internal interface IFood : IPoint
    {
        void Eated();
        bool Growed {  get; }
    }
}
