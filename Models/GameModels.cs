using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Game
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Studio { get; set; }
        public string? Style { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string? GameMode { get; set; }
        public int CopiesSold { get; set; }
    }
}
