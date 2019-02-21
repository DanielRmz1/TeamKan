namespace TeamKanBan.Models.MyModels
{
    public class UsersActivitiesModel
    {
        public int Id { get; set; }
        public ProjectActivitiesModel ProjectActivities { get; set; }
        public ApplicationUser User { get; set; }
    }
}