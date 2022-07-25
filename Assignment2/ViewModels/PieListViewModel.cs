using Assignment2.Models;

namespace Assignment2.ViewModels
{
    public class PieListViewModel
    {
        //2properties
        public IEnumerable<Pie> Pies { get; set; } //all the files to display
        public string CurrentCategory { get; set; } //current category of pies
    }
}
