using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamKanBan.Models.MyModels
{
    public class UsersProjectsLogModel
    {
        public int Id { get; set; }
        public UsersProjectsModel Log { get; set; }
        public string Action { get; set; }
    }
}