using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TeamKanBan.Models.MyModels
{
    public class ProjectModel
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Description { get; set; }
        public string Repository { get; set; }
        public string State { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<ApplicationUser> Owner { get; set; }
        public TeamModel Team { get; set; }
    }
}