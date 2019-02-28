using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using TeamKanBan.Models.MyModels;

namespace TeamKanBan.Models
{
    // Para agregar datos de perfil del usuario, agregue más propiedades a su clase ApplicationUser. Visite https://go.microsoft.com/fwlink/?LinkID=317594 para obtener más información.
    public class ApplicationUser : IdentityUser
    {
        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string Apellido { get; set; }

        public bool Activo { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
                                               // Tenga en cuenta que el valor de authenticationType debe coincidir con el definido en CookieAuthenticationOptions.AuthenticationType
        var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Agregar aquí notificaciones personalizadas de usuario
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<ProjectActivitiesModel> ProjectActivities { get; set; }
        public DbSet<ProjectModel> Projects { get; set; }
        public DbSet<TeamModel> Teams { get; set; }
        public DbSet<UsersActivitiesModel> UsersActivities { get; set; }
        public DbSet<UsersProjectsLogModel> UserLogs { get; set; }
        public DbSet<UsersProjectsModel> UsersProjects { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProjectModel>().HasRequired(x => x.Team);
            modelBuilder.Entity<UsersProjectsLogModel>().HasRequired(x => x.Log);
            modelBuilder.Entity<UsersProjectsModel>().HasRequired(x => x.Project);
            modelBuilder.Entity<UsersProjectsModel>().HasRequired(x => x.User);
            modelBuilder.Entity<ProjectActivitiesModel>().HasRequired(x => x.Project);
            modelBuilder.Entity<UsersActivitiesModel>().HasRequired(x => x.User);
            modelBuilder.Entity<UsersActivitiesModel>().HasRequired(x => x.ProjectActivities);
            modelBuilder.Entity<ProjectModel>().HasRequired(x => x.Owner);
            base.OnModelCreating(modelBuilder);
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}