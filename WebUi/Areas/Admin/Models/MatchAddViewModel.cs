using Entities.Concrete;
using System.Collections.Generic;

namespace WebUi.Areas.Admin.Models
{
    public class MatchAddViewModel
    {
        public Match Match { get; set; }
        public List<Team> Teams { get; set; }
        public Team HomeTeams { get; set; }
        public int HomeResult { get; set; }
        public Team GuestTeams { get; set; }
        public int GuestResult { get; set; }
    }
}
