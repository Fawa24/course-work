using Microsoft.EntityFrameworkCore;

namespace Entities;

public partial class DishDbContext : DbContext
{
    public DishDbContext()
    {
    }

    public DishDbContext(DbContextOptions<DishDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dish> Dishes { get; set; }

    public virtual DbSet<UserQuestion> UserQuestions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dish>(entity =>
        {
            entity.HasKey(e => e.DishId).HasName("PK__Dishes__9F2B4CF9A543A9EF");

            entity.Property(e => e.DishId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("dish_id");
            entity.Property(e => e.DishName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("dish_name");
            entity.Property(e => e.DishPrice).HasColumnName("dish_price");
            entity.Property(e => e.DishType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("dish_type");
            entity.Property(e => e.InStock).HasColumnName("in_stock");
            entity.Property(e => e.RestaurantType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("restaurant_type");
        });

        modelBuilder.Entity<UserQuestion>(entity =>
        {
            entity.HasKey(e => e.QuestionId).HasName("PK__UserQues__2EC215496477954B");

            entity.Property(e => e.QuestionId)
                .ValueGeneratedNever()
                .HasColumnName("question_id");
            entity.Property(e => e.QuestionText)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("question_text");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
