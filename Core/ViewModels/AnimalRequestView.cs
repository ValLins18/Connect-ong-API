namespace Connect_ong_API.Core.ViewModels {
    public record AnimalRequestView(string Name, string? ImgPath, DateTime? BirthDate,
        string Gender, string Breed, string Specie, DateTime RescueDate, bool Castred, 
        bool Available, int PersonId);
}
