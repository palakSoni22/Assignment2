namespace Assignment2.Models
{
    public interface IPieRepository
    {
        /*1. using IEnumerable to enumerate the pies. so that public can only read the data.
          2. LIST OBJECT
            * we can also use list object but then anyone can add, remove, delete data
            * List<Pie> AllPie { get; }
        */
        IEnumerable<Pie> AllPies { get; } //2nd page
        IEnumerable<Pie> PieOfTheWeek { get; } //1st(home) page
        Pie GetPieById(int pieId); // details page (gives details about pie when you click on them)
        IEnumerable<Pie> FruitPie { get; }
        IEnumerable<Pie> CheesePie { get; }
        IEnumerable<Pie> SeasonalPie { get; }
        
    }
}
