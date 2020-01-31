using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PitchIt.ViewModels
{
    public class AddPostViewModel
    {
        [Required]
        public string PostTitle { get; set; }
        [Required(ErrorMessage ="You must create a Post of at least 20 words")]
        public string PostBody { get; set; }
        public AddPostViewModel() { }
    }
}
