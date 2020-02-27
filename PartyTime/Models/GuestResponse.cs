using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Who even are you?")]
        public string Name { get; set; }
        [Required(ErrorMessage = "How else am I supposed to send this super sick eVite?")]
        [RegularExpression(".+\\@.+\\..+",
ErrorMessage = "Stop messing around.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "It doesn't even have to be a real number but idk how to remove this field, so")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "I need to know who my REAL friends are, so be a real pal and say if you're coming or not")]
        public bool? WillAttend { get; set; }
    }
}