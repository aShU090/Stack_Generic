using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apttus.Stack
{
   public interface IStack<T>
    {
        int push(T element);
        T pop();
        void Display();
    }
}
