using MauiNoteTakingApp.Src.Features.Home.Entities;

namespace MauiNoteTakingApp.Src.Features.Home.Models
{
    public class NoteModel(String id, String title, String description) : NoteEntity(id, title, description) { }
}
