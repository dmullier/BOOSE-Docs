using BOOSE.BOOSEarchitecture;
using BOOSE.Commands;
using BOOSE.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOSE.Interfaces
{
    /// <summary>
    /// Runtime interface for a StoredProgram. A StoredProgram is a collection of commands that can be executed in order. It has a program counter (PC) that keeps track of the current command being executed. It also has a collection of variables that can be used in expressions. The StoredProgram can be reset, and it can be run until there are no more commands left to execute.
    /// </summary>
    public interface IStoredProgram 
    {
        /// <summary>
        /// Property the program counter, which points to the next command in the StoredProgram to be executed.
        /// </summary>
        int PC { get; set; }
           
        /// <summary>
        /// Add a Var object to the StoredProgram.
        /// </summary>
        /// <param name="Variable"></param>
        void AddVariable(Evaluation Variable);

        /// <summary>
        /// Returns true if variable has been defined in this program, false if not.
        /// </summary>
        /// <param name="variable"></param>
        /// <returns>True if variable exists.</returns>
        /// 

        bool VariableExists(String varName);

        /// <summary>
        /// Return the String value of a variable. It should throw a StoredProgramException if an attampt is made to retrieve a non-existant variable. i.e. don't try, check first.
        /// </summary>
        /// <param name="varName"></param>
        /// <returns></returns>
        String GetVarValue(String varName);

        /// <summary>
        /// Determine if the passed in string is an evaluatable expression and not a literal value.
        /// </summary>
        /// <param name="expression">Expression to be tested.</param>
        /// <returns>true if it is an expression.</returns>
        bool IsExpression(String expression);

        /// <summary>
        /// Evaluate the given expression by finding the values of any variables and passing the result as a String
        /// </summary>
        /// <param name="Exp"></param>
        /// <returns></returns>
        /// <exception cref="StoredProgramException">Throws StoredProgramException is it cannot be evaluated. Use IsExpression() before calling to prevent this exception being thrown.</exception>

        String EvaluateExpression(String Exp);

        /// <summary>
        /// Adds Command to the StoredProgram
        /// </summary>
        /// <param name="O">Object representing a program command</param>
        /// <returns>index at which member was added</returns>
        public int Add(Command C);

        /// <summary>
        /// Once a program has finished executing it needs to be reset (Program Counter set to zero)
        /// </summary>
        void ResetProgram();

        /// <summary>
        /// Are there any commands left to execute in the program?
        /// i.e. pc (Program Counter) has not yet reached the end of the program
        /// </summary>
        /// <returns>true if commands left to execute, false if the end has been reached</returns>
        bool Commandsleft();

        /// <summary>
        /// Attempt to execute the program, throws a StoredProgramException if it cannot run. 
        /// The parser object should have generated a runnable program before running.
        /// </summary>
        /// <exception cref="StoredProgramException"></exception>
        void Run();


    }
}
