namespace MauiNoteTakingApp.Src.Features.Home.Entities
{
    public class NoteEntity(string id, string title, string description)
    {
        public string Id { get; set; } = id;
        public string Title { get; set; } = title;
        public string Description { get; set; } = description;
    }
}
