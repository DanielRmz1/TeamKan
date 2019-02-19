using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamKanBan.Models.MyModels
{
    public class UsersProjectsModel
    {
        public int Id { get; set; }
        public ProjectModel IdProject { get; set; }
        public ApplicationUser IdUser { get; set; }
    }
}