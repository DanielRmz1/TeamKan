using System;
using System.ComponentModel.DataAnnotations;

namespace TeamKanBan.Models.MyModels
{
    public class ProjectActivitiesModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string State { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EndDate { get; set; }
        [Required]
        public ProjectModel Project { get; set; }
    }
}