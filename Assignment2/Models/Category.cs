namespace Assignment2.Models
{
    public class Category
    {
        //this is parent class

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //CHILD REFERENCE
        //here pie is getting connected
        //this is how we are connecting the class (pie and category)
        //created pie property i.e. list of pies
        public List<Pie> Pie { get; set; } //defining parent class
    }
}
