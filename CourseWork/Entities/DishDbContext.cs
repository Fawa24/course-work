using Microsoft.EntityFrameworkCore;

namespace Entities.Entities;

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

    public virtual DbSet<Menu> Menus { get; set; }

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

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.MenuId).HasName("PK__Menus__4CA0FADC2DF4812C");

            entity.Property(e => e.MenuId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("menu_id");
            entity.Property(e => e.InStock).HasColumnName("in_stock");
            entity.Property(e => e.MenuName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("menu_name");

            entity.HasMany(d => d.Dishes).WithMany(p => p.Menus)
                .UsingEntity<Dictionary<string, object>>(
                    "MenuDish",
                    r => r.HasOne<Dish>().WithMany()
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__MenuDishe__dish___47DBAE45"),
                    l => l.HasOne<Menu>().WithMany()
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__MenuDishe__menu___46E78A0C"),
                    j =>
                    {
                        j.HasKey("MenuId", "DishId").HasName("PK__MenuDish__C5524E13B703B644");
                        j.ToTable("MenuDishes");
                        j.IndexerProperty<Guid>("MenuId").HasColumnName("menu_id");
                        j.IndexerProperty<Guid>("DishId").HasColumnName("dish_id");
                    });
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
