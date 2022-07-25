namespace Assignment2.Models
{
    public interface ICategoryRepository
    {
        //there should be only one method
        public IEnumerable<Category> AllCategories { get; }

    }
}
