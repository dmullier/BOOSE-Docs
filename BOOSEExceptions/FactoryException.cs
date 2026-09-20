using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOSE.Exceptions
{
    /// <summary>
    /// Exception genereted by the a CommandFactory. It represents a command not being part of BOOSE.
    /// </summary>
    public class FactoryException : BOOSEException
    {
        public FactoryException(String msg) : base(msg)
        {


        }
    }
}