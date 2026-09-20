using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOSE.Exceptions
{
    /// <summary>
    /// Exception thrown when restrictions are breached.
    /// If you get this you need to write your own code for the facility.
    /// This only occurs when using the library code from a DLL. If you are writing your own classes this exception is irrelevant.
    /// </summary>
    public class RestrictionException : BOOSEException
    {
        public RestrictionException(String msg) : base(msg)
        {


        }
    }
}
