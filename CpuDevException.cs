using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUFramework
{
    public class CpuDevException : Exception
    {
        public CpuDevException(string? message, Exception? inerexception):base(message, inerexception)
        {

        }
    }
}
