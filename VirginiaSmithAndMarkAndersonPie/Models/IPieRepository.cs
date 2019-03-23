using System.Collections.Generic;

namespace VirginiaSmithAndMarkAndersonPie.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();

        Pie GetPieById(int pieId);
    }
}