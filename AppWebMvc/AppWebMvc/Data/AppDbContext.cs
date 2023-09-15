﻿using App.Web.Mvc.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace AppWebMvc.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<CategoryPost>()
				.HasKey(bc => new { bc.CategoryId, bc.PostId });
			modelBuilder.Entity<CategoryPost>()
				.HasOne(bc => bc.Category)
				.WithMany(b => b.CategoryPosts)
				.HasForeignKey(bc => bc.CategoryId);
			modelBuilder.Entity<CategoryPost>()
				.HasOne(bc => bc.Post)
				.WithMany(c => c.CategoryPosts)
				.HasForeignKey(bc => bc.PostId);

			//Seed database
			
		}

		

		public DbSet<Category> Category { get; set; }
		public DbSet<Post> Post { get; set; }
		public DbSet<CategoryPost> CategoryPost { get; set; }
		public DbSet<PostImage> PostImage { get; set; }
		public DbSet<PostComment> PostComment { get; set; }
		public DbSet<Page> Page { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Setting> Setting { get; set; }




	}
}
