using Microsoft.EntityFrameworkCore;
using BlogAppMVC.Entity;


namespace BlogAppMVC.Data.Concrete.EFCore
{
    public class BlogContext: DbContext
    {
       
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {

        }
        public DbSet<Post> Posts => Set<Post>();
        public DbSet<Comment> Comments => Set<Comment>();
        public DbSet<Tag> Tags => Set<Tag>();
        public DbSet<User> Users => Set<User>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Comment>().HasOne(u => u.User).WithMany(x=>x.Comments).HasForeignKey(u => u.UserId).OnDelete(DeleteBehavior.NoAction);
                
                
        }
    }
}
