using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOSE.Exceptions
{
    /// <summary>
    /// Exception genereted by the StoredProgram class. This excption should be thrown by a StoredProgram if an operation like returning the value of a non-existant variable or attempt to call a non-existant method happens.
    /// </summary>
    public class StoredProgramException : BOOSEException
    {
        public StoredProgramException(String msg) : base(msg)
        {


        }
    }
}
