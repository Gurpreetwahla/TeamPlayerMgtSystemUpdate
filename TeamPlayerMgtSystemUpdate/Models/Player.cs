using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamPlayerMgtSystemUpdate.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        
        public string Name { get; set; }
        public string Position { get; set; }
        public string Mobile { get; set; }
        public string Gender { get; set; }
        public int CoachId { get; set; }
        public Coach Coach { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }

    }
}