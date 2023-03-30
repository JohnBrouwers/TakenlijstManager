using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TakenlijstManager.Data.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;

namespace TakenlijstManager.Models
{
    public class CreateTaakViewModel
    {

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Naam { get; set; }

        public int Omvang { get; set; }


        [Range(0, 10)]
        public int Prioriteit { get; set; }


        [ForeignKey(nameof(Status))]
        [DisplayName("Status")]
        public int? StatusId { get; set; }

        public SelectList Statussen { get; set; }
    }
}
