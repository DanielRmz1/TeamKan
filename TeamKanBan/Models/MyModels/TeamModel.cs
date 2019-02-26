using System;
using System.ComponentModel.DataAnnotations;

namespace TeamKanBan.Models.MyModels
{
    public class TeamModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "El nombre del equipo es requerido.")]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public ApplicationUser Owner { get; set; }
    }
}