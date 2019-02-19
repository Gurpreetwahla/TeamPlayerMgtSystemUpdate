using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamPlayerMgtSystemUpdate.Models
{
    public class Coach
    {
        [Key]
        public int CoachId { get; set; }
        public string CoachName { get; set; }
        public List<Player> Players { get; set; }

    }
}