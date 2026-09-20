using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOSE.Exceptions
{
    /// <summary>
    /// Exception genereted by the StoredProgram class when a command fails. This represents a run-time error.
    /// Any StoredProgram class should catch such an exception and report the problem to the user.
    /// </summary>
    public class CommandException : BOOSEException
    {
        public CommandException(String msg) : base(msg)
        {


        }
    }
}