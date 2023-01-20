using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFContactForm
{
    //changes saved
    public class RelayCommand : ICommand
    {
        #region command
        Action Command;
        Action openCommand;
       public RelayCommand(Action cmd)
        {
            Command = cmd;
            
        }
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            Command();
            
        }
        #endregion
    }
}
