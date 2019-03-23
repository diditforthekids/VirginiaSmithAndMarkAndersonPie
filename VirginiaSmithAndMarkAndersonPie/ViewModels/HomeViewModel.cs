using System.Collections.Generic;
using VirginiaSmithAndMarkAndersonPie.Models;

namespace VirginiaSmithAndMarkAndersonPie.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Pie> Pies { get; set; }
    }
}