using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Game
    {
        public int Id { set; get; }
        public String Title { set; get; }
        public int PublicationYear { set; get; }
        public int MinimumPlayers { set; get; }
        public int MaximumPlayers { set; get; }

    }
}
