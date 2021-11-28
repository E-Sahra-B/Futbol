using Core.Entities.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class Match:IEntity
    {
        [Key]
        public int MatchId { get; set; }
        public int? HomeTeamID { get; set; }
        public Team HomeTeams { get; set; }
        public int HomeResult { get; set; }
        public int? GuestTeamID { get; set; }
        public Team GuestTeams { get; set; }
        public int GuestResult { get; set; }
    }
}
