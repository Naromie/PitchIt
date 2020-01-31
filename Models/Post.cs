using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PitchIt.Models
{
    public class Post
    {   [Key]
        public int ID {get;set;}
        [Required]
        public string PostTitle { get; set; }
        [Required]
        public string PostBody { get; set; }
        public int UserID { get; set; }

        public DateTime PublishDate { get; set; }

    }
}
