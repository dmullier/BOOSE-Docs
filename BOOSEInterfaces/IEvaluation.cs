using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOSE.Interfaces
{
    /// <summary>
    /// IEvaluation adds properties to get and set an Evaluations name, value and expression.
    /// An evaluation can be a variable declaration, such as "int total" or "real area".
    /// It can be change an exprerssion to change the value of a variable, such as "total = total + 1", the part after the "=" is an referred to as an "expression".
    /// In the first two cases the parser will generate an Int object and a Real Object. In the third case it will generate a "Evaluation" object.
    /// Not currently used in the standard implementation of BOOSE.
    /// </summary>
    public interface IEvaluation : ICommand
    {
        string VarName { get; set; }
        Object Value { get; set; }
        string Expression { get; set; }
    }
}
