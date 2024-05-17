namespace AMS3ASales.API.Domain
{
    public class Category
    {
        public Guid Id { get; set; } = Guid.NewGuid();
<<<<<<< HEAD
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string ImageURL { get; set; }
        public ICollection<Product> Product { get; set;}
        
=======
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public string? ImageURL { get; set; }
        public ICollection<Product> Product { get; set;}
>>>>>>> e1f48c40c2081beffff86cd095d9e4baca72c3d2


    }
}
