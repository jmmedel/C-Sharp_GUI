using NotesApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NotesApp.ViewModel.Commands
{
    public class DeleteNotebookCommand : ICommand
    {
        public NotesVM ViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public DeleteNotebookCommand(NotesVM vm)
        {
            this.ViewModel = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var notebook = parameter as Notebook;

            if (notebook != null)
                ViewModel.DeleteNotebook(notebook);
        }
    }
}
