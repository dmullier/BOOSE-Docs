using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOSE.Exceptions
{
    /// <summary>
    /// Generic BOOSE Language exception
    /// Extends Exception
    /// </summary>
    public class BOOSEException : Exception
    {
        public BOOSEException(String msg) : base(msg)
        {

            
        }
    }
}
