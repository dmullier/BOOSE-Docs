using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOSE.Interfaces
{
    /// <summary>
    /// To add commands to BOOSE you must create a CommandFactory that uses this interface.
    /// You should extend the existing BOOSE:CommandFactory (which implements this interface) and then
    /// implement the MakeCommand() method. It shoudld create a new command object based on the string passed.
    /// Any standard BOOSE commands can then be made by calling base.MakeCommand();
    /// If you do not extend the existing CommandFactory you must implement this interface and create a MakeCommand() method that creates all commands, including the standard BOOSE commands.
    /// </summary>
    public interface ICommandFactory
    {
        /// <summary>
        /// Make a BOOSE Command based on the string passed to it. It should throw a Factory exception if the command does not exist.
        /// </summary>
        /// <param name="commandType"></param>
        /// <returns>Reference to new Command object.</returns>
        ICommand MakeCommand(String commandType);
    }
}
