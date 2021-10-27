using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerWebApp.Models
{
    public class Soccer
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public string Manager { get; set; }
        public bool ChampionsLeague { get; set; }
        

        public Soccer()
        {

        }
    }
}
