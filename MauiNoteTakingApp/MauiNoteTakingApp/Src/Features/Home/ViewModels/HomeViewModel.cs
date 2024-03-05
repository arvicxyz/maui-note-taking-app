using MauiNoteTakingApp.Src.Core.Commands;
using MauiNoteTakingApp.Src.Core.ViewModels;
using MauiNoteTakingApp.Src.Features.Home.Entities;
using MauiNoteTakingApp.Src.Features.Home.Models;
using MauiNoteTakingApp.Src.Features.Home.Repositories;
using MauiNoteTakingApp.Src.Features.Home.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiNoteTakingApp.Src.Features.Home.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        #region Fields
        #endregion

        #region Constructors

        public HomeViewModel()
        {
            _notes = [];
        }

        #endregion

        #region Private Methods

        private async Task GetNotes()
        {
            var repository = new NoteRepository();
            var notes = await repository.GetNotes();
            Notes = new ObservableCollection<NoteEntity>(notes);
        }

        private async Task Refresh()
        {
            IsRefreshing = true;
            await Task.Delay(2000);
            await GetNotes();
            IsRefreshing = false;
        }

        private void AddNote()
        {
            var addNote = new NoteModel("1000", "Test Title", "Test Desc");
            _notes.Add(addNote);
            Notes = new ObservableCollection<NoteEntity>(_notes);
        }

        #endregion

        #region Public Methods

        public async Task LoadNotes()
        {
            await SetBusyAsync(GetNotes, 2000, "Loading beers...");
        }

        #endregion

        #region Commands

        private ICommand? _refreshCommand;
        public ICommand RefreshCommand
        {
            get { return _refreshCommand ??= new DelegateCommand(async (obj) => await Refresh()); }
        }

        private ICommand? _addNoteCommand;
        public ICommand AddNoteCommand
        {
            get { return _addNoteCommand ??= new DelegateCommand((obj) => AddNote()); }
        }

        #endregion

        #region Properties

        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set => SetProperty(ref _isRefreshing, value, nameof(IsRefreshing));
        }

        private ObservableCollection<NoteEntity> _notes;
        public ObservableCollection<NoteEntity> Notes
        {
            get => _notes;
            set => SetProperty(ref _notes, value, nameof(Notes));
        }

        #endregion
    }
}
