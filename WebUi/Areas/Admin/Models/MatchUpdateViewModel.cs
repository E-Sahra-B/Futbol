using Entities.Concrete;
using System.Collections.Generic;

namespace WebUi.Areas.Admin.Models
{
    public class MatchUpdateViewModel
    {
        public Match Match { get; set; }
        public List<Team> Teams { get; set; }
    }
}
