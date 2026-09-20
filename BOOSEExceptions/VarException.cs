using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOSE.Exceptions
{
    /// <summary>
    /// Exception raised by variable commands.if their expressions cannot be evaluated.
    /// </summary>
    public class VarException : BOOSEException
    {
        public VarException(String msg) : base(msg)
        {


        }
    }
}
