using System;

namespace TeamKanBan.Models.MyModels
{
    public class UsersProjectsLogModel
    {
        public int Id { get; set; }
        public UsersProjectsModel Log { get; set; }
        public string Action { get; set; }
        public DateTime Date { get; set; }
        public int MyProperty { get; set; }
    }
}