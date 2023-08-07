using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace HairSalon.Models
{
    public class ClientCreateViewModel
    {
        [Required(ErrorMessage = "Please enter the client's name.")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Stylist")]
        [Required(ErrorMessage = "Please select a stylist.")]
        public int? StylistId { get; set; }

        public List<SelectListItem> Stylists { get; set; } = new List<SelectListItem>();
    }
}
