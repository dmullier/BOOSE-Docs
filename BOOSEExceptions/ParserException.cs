using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOSE.Exceptions
{
    /// <summary>
    /// Exception genereted by the Parser class to denote syntax errors. ANy systax error should proivide information about what the error is.
    /// A Parser shoudl catch these exceptions, append a line number and generate a syntax error list.
    /// </summary>
    public class ParserException : BOOSEException
    {
        public ParserException(String msg) : base(msg)
        {


        }
    }
}