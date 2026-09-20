using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOSE.Exceptions
{
    /// <summary>
    /// Exception that should be thrown by operations that fail on the Canvas.
    /// </summary>
    /// <seealso cref="BOOSEException" />
    public class CanvasException : BOOSEException
    {

        public CanvasException(String msg) : base(msg)
        {

            
        }
    }
}
