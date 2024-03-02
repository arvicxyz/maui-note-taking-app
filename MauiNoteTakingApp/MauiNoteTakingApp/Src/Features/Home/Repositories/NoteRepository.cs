using MauiNoteTakingApp.Src.Features.Home.Entities;
using MauiNoteTakingApp.Src.Features.Home.Services;

namespace MauiNoteTakingApp.Src.Features.Home.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private readonly INoteService _service;

        public NoteRepository()
        {
            // Implement dependency injection by constructor injection here
            _service = new NoteService();
        }

        public async Task<List<NoteEntity>> GetNotes()
        {
            var notes = await _service.GetNotes();
            var entityList = new List<NoteEntity>(notes);
            return entityList;
        }

        public async Task<NoteEntity> GetNote(String id)
        {
            var note = await _service.GetNote(id);
            var entity = note as NoteEntity;
            return entity;
        }
    }
}
