using System.Collections.Generic;

namespace TeamKanBan.Models.MyModels
{
    public class UsersProjectsModel
    {
        public int Id { get; set; }
        public ProjectModel Project { get; set; }
        public ApplicationUser User { get; set; }
    }
}