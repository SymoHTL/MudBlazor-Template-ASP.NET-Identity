namespace Model.Configuration;

public class ModelDbContext : IdentityDbContext {
    public ModelDbContext(DbContextOptions<ModelDbContext> options) : base(options) {
    }
}