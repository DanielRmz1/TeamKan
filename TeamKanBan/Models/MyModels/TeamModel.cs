using System;

namespace TeamKanBan.Models.MyModels
{
    public class TeamModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public ApplicationUser Owner { get; set; }
    }
}