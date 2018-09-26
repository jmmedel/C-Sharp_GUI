using NotesApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NotesApp.ViewModel.Commands
{
    public class DeleteNoteCommand : ICommand
    {
        public NotesVM ViewModel { get; set; }

        public event EventHandler CanExecuteChanged;

        public DeleteNoteCommand(NotesVM vm)
        {
            ViewModel = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var note = parameter as Note;

            if (note != null)
                ViewModel.DeleteNote(note);
        }
    }
}
