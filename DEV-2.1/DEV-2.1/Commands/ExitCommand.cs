using System;

namespace DEV_2._1.Commands
{
    /// <summary>
    /// Class of the exit command
    /// </summary>
    class ExitCommand : ICommand
    {
        public void Execute()
        {
            Environment.Exit(0);
        }
    }
}
