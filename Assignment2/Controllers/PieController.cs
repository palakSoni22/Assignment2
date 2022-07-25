using Assignment2.Models;
using Assignment2.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    public class PieController : Controller //pie controller is coming from base class of controller
    {
        private readonly IPieRepository _pieRepository; //field- declaring obj for pie repository. it is pointing to null. then we can invoke
        public PieController(IPieRepository pieRepository)//this will create object (in this we have to make changes in program.cs file)
        {
            _pieRepository = pieRepository;//object of PieRepository class
        }
        //----------------------------------------------------------------------------------------------------------
        //ACTION METHOD FOR MENU (LIST PAGE)
        public IActionResult List() //we will invoke this method from url. it returns some pies data inside view
        {           
            var pies = _pieRepository.AllPies; //invoking pie repository. got pie data

            PieListViewModel pieListViewModel = new PieListViewModel();//creating object for pie list view model
            pieListViewModel.Pies = pies;
            
            return View(pieListViewModel);//passing data to view
        }
        //----------------------------------------------------------------------------------------------------------
        //ACTION METHOD FOR HOME PAGE (pies of the week)
        public IActionResult PieOfTheWeek()
        {
            var piesOfTheWeek = _pieRepository.PieOfTheWeek; //invoking pie repository. got pie data

            PieListViewModel pieListViewModel = new PieListViewModel();//creating object for pie list view model
            pieListViewModel.Pies = piesOfTheWeek;
            return View(piesOfTheWeek);//passing data to view
        }
        public IActionResult FruitPie()
        {
            var pies = _pieRepository.FruitPie; //invoking pie repository. got pie data
            return View(pies);//passing data to view
        }
        public IActionResult SeasonalPie()
        {
            var pies = _pieRepository.SeasonalPie; //invoking pie repository. got pie data

            return View(pies);//passing data to view
        }
        public IActionResult CheesePie()
        {
            var pies = _pieRepository.CheesePie; //invoking pie repository. got pie data
            return View(pies);//passing data to view
        }

        //ACTION METHOD FOR DETAILS PAGE 

        public IActionResult Details(int id)
        {
            var GetPieById = _pieRepository.GetPieById(id);
            return View(GetPieById);
        }

    }
}

















/* line 9.------------------------------------------------------------------------------------------------------
          * INSTANTIATING OBJECT- (here we don't have to make changes in program.cs file)
          * private readonly IPieRepository _pieRepository; = new PieRepository();
        */

//OR

/* private readonly IPieRepository pieRepository; 
public PieController(IPieRepository pieRepository)
{
    this.pieRepository = pieRepository;
}

OR
 */

//LISTING ALL THE PIES

/* line 16.------------------------------------------------------------------------------------------------------
 * OR 
ViewBag.CurrentCategory = "Cheese cakes";
//this pie repository will give data because controller cannot generate data. it will request data from repository
//it is object of pie repository
return View(_pieRepository.AllPies);
------------------------------------------------------------------------------------------------------*/
//ViewBag.CurrentCategory = "Cheese cakes";//current category