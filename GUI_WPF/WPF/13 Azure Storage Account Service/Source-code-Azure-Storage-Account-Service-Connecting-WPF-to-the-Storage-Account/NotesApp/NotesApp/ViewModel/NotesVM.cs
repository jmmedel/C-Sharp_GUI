using NotesApp.Model;
using NotesApp.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp.ViewModel
{
    public class NotesVM : INotifyPropertyChanged
    {
        private bool isEditing;

        public bool IsEditing
        {
            get { return isEditing; }
            set
            {
                isEditing = value;
                OnPropertyChanged("IsEditing");
            }
        }

        public ObservableCollection<Notebook> Notebooks { get; set; }

        private Notebook selectedNotebook;

        public Notebook SelectedNotebook
        {
            get { return selectedNotebook; }
            set
            {
                selectedNotebook = value;
                ReadNotes();
                OnPropertyChanged("SelectedNotebook");
            }
        }

        private Note note;

        public Note SelectedNote
        {
            get { return note; }
            set
            {
                note = value;
                SelectedNoteChanged(this, new EventArgs());
                OnPropertyChanged("SelectedNote");
            }
        }


        public ObservableCollection<Note> Notes { get; set; }

        public NewNotebookCommand NewNotebookCommand { get; set; }
        public NewNoteCommand NewNoteCommand { get; set; }
        public BeginEditCommand BeginEditCommand { get; set; }
        public HasEditedCommand HasEditedCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler SelectedNoteChanged;

        public NotesVM()
        {
            IsEditing = false;

            NewNotebookCommand = new NewNotebookCommand(this);
            NewNoteCommand = new NewNoteCommand(this);
            BeginEditCommand = new BeginEditCommand(this);
            HasEditedCommand = new HasEditedCommand(this);

            Notebooks = new ObservableCollection<Notebook>();
            Notes = new ObservableCollection<Note>();

            ReadNotebooks();
            ReadNotes();
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public async void CreateNotebook()
        {
            Notebook newNotebook = new Notebook()
            {
                Name = "New notebook",
                UserId = App.UserId
            };

            //// DatabaseHelper.Insert(newNotebook);
            try
            {
                await App.MobileServiceClient.GetTable<Notebook>().InsertAsync(newNotebook);
            }
            catch(Exception ex)
            {

            }

            ReadNotebooks();
        }

        public async void CreateNote(string notebookId)
        {
            Note newNote = new Note()
            {
                NotebookId = notebookId,
                CreatedTime = DateTime.Now,
                UpdatedTime = DateTime.Now,
                Title = "New note"
            };

            //// DatabaseHelper.Insert(newNote);

            try
            {
                await App.MobileServiceClient.GetTable<Note>().InsertAsync(newNote);
            }
            catch (Exception ex)
            {

            }

            ReadNotes();
        }

        public async void ReadNotebooks()
        {
            ////using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(DatabaseHelper.dbFile))
            ////{
            ////    var notebooks = conn.Table<Notebook>().ToList();

            ////    Notebooks.Clear();
            ////    foreach(var notebook in notebooks)
            ////    {
            ////        Notebooks.Add(notebook);
            ////    }
            ////}

            try
            {
                var notebooks = await App.MobileServiceClient.GetTable<Notebook>().Where(n => n.UserId == App.UserId).ToListAsync();

                Notebooks.Clear();
                foreach(var notebook in notebooks)
                {
                    Notebooks.Add(notebook);
                }
            }
            catch(Exception ex)
            {

            }
        }

        public async void ReadNotes()
        {
            ////using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(DatabaseHelper.dbFile))
            ////{
            ////    if (SelectedNotebook != null)
            ////    {
            ////        var notes = conn.Table<Note>().Where(n => n.NotebookId == SelectedNotebook.Id).ToList();

            ////        Notes.Clear();
            ////        foreach(var note in notes)
            ////        {
            ////            Notes.Add(note);
            ////        }
            ////    }
            ////}

            try
            {
                try
                {
                    var notes = await App.MobileServiceClient.GetTable<Note>().Where(n => n.NotebookId == SelectedNotebook.Id).ToListAsync();

                    Notes.Clear();
                    foreach (var note in notes)
                    {
                        Notes.Add(note);
                    }
                }
                catch (Exception ex)
                {

                }
            }
            catch(Exception ex)
            {

            }
        }

        public void StartEditing()
        {
            IsEditing = true;
        }

        public async void HasRenamed(Notebook notebook)
        {
            if(notebook != null)
            {
                //// DatabaseHelper.Update(notebook);
                try
                {
                    await App.MobileServiceClient.GetTable<Notebook>().UpdateAsync(notebook);
                    IsEditing = false;
                    ReadNotebooks();
                }
                catch(Exception ex)
                {

                }
            }
        }

        public async void UpdateSelectedNote()
        {
            //// DatabaseHelper.Update(SelectedNote);
            try
            {
                await App.MobileServiceClient.GetTable<Note>().UpdateAsync(SelectedNote);
            }
            catch(Exception ex)
            {

            }
        }
    }
}
