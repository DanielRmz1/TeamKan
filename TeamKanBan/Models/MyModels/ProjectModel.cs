using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamKanBan.Models.MyModels
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Repository { get; set; }
        public string State { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}