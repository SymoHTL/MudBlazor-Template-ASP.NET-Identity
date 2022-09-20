namespace Model.Configuration;

public class ModelDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid, ApplicationUserClaim, ApplicationUserRole, ApplicationUserLogin, ApplicationRoleClaim, ApplicationUserToken> {
    public ModelDbContext(DbContextOptions<ModelDbContext> options) : base(options) {
    }

    public DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;
    public DbSet<ApplicationRole> ApplicationRoles { get; set; } = null!;
}