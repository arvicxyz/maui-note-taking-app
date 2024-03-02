using MauiNoteTakingApp.Src.Features.Home.Entities;

namespace MauiNoteTakingApp.Src.Features.Home.Repositories
{
    public interface INoteRepository
    {
        Task<List<NoteEntity>> GetNotes();

        Task<NoteEntity> GetNote(string id);
    }
}
