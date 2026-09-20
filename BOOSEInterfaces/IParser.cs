using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOSE.Interfaces
{
    /// <summary>
    /// The Parser Class takes a BOOSE program as a String with each line seperated by '\n'
    /// and creates command objects for each valid command and stores them in the passed in StoredProgram.
    /// Exceptions shoulod bee generated for any syntax errors by the comand objects themselves. The parser should catch these exceptions and add them to an error list.
    /// When each valid command is generated its Compile() method is called.
    /// The valid command will have its parameters processed and any variables identified.
    /// It is the role of StoredProgram to run the commands.
    /// </summary>
    public interface IParser
    {
        
        /// <summary>
        /// Parse a single command.
        /// Takes a single line of a BOOSE program "-command- -parameterlist-" or "-variable- = -expression-"
        /// It seperates the command from the parameter list or the variable from the expression.
        /// An Object of the command is made. its parameter list/expression is set and its Compile() method is called.
        /// The command object is added to the StoredProgram.  
        /// </summary>
        /// <param name="Line">"-command- -parameterlist-" or "-variable- = -expression-"</param>
        /// <returns>ICommand Object which can then be executed</returns>
        ICommand ParseCommand(string Line);

        /// <summary>Parse the entrire program, by calling ParseCommand for every line An errorlist string is generated containing any systax error messages.</summary>
        /// <param name="program">big string of a complete program seperated by newlines</param>
        /// <exception>Complete list of sysntax errors seperated by a return character</exception>
        void ParseProgram(String program);


    }
}
