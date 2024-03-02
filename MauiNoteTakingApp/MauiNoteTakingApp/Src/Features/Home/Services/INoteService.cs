using MauiNoteTakingApp.Src.Features.Home.Models;

namespace MauiNoteTakingApp.Src.Features.Home.Services
{
    public interface INoteService
    {
        Task<List<NoteModel>> GetNotes();

        Task<NoteModel> GetNote(string id);
    }
}
