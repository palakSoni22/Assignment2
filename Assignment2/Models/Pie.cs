namespace Assignment2.Models
{
    public class Pie
    {
        //this is child class

        public int PieId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        //public string AllergyInformation { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsPieOfTheWeek { get; set; }
        //public bool FruitPie { get; set; }
        public bool InStock { get; set; }
        


        //parent child relationship
        public int CategoryId { get; set; } //linking pie and category class
        public Category Category { get; set; } //this gives category details (directly get name and description)
        //it is object of category 
    }
}
