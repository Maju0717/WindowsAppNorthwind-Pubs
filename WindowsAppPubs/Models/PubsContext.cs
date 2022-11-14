using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsAppPubs.Models
{
    public partial class PubsContext : DbContext
    {
        public PubsContext()
            : base("name=PubsContext")
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<PubInfo> Pubinfos { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<TitleAuthor> TitleAuthors { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Roysched> Royscheds { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .Property(e => e.au_id)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.au_lname)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.au_fname)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .HasMany(e => e.titleAuthors)
                .WithRequired(e => e.author)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmpId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.FName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Minit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.LName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.PubId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.job_desc)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .HasMany(e => e.employees)
                .WithRequired(e => e.Job)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PubInfo>()
                .Property(e => e.pub_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PubInfo>()
                .Property(e => e.pr_info)
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.pub_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.pub_name)
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<Publisher>()
                .HasMany(e => e.employees)
                .WithRequired(e => e.Publisher)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Publisher>()
                .HasOptional(e => e.pub_info)
                .WithRequired(e => e.publisher);

            modelBuilder.Entity<Sale>()
                .Property(e => e.stor_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sale>()
                .Property(e => e.ord_num)
                .IsUnicode(false);

            modelBuilder.Entity<Sale>()
                .Property(e => e.payterms)
                .IsUnicode(false);

            modelBuilder.Entity<Sale>()
                .Property(e => e.title_id)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.stor_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.stor_name)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.stor_address)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.state)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.sales)
                .WithRequired(e => e.store)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TitleAuthor>()
                .Property(e => e.au_id)
                .IsUnicode(false);

            modelBuilder.Entity<TitleAuthor>()
                .Property(e => e.title_id)
                .IsUnicode(false);

            modelBuilder.Entity<Title>()
                .Property(e => e.TitleId)
                .IsUnicode(false);

            modelBuilder.Entity<Title>()
                .Property(e => e.Title1)
                .IsUnicode(false);

            modelBuilder.Entity<Title>()
                .Property(e => e.Type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Title>()
                .Property(e => e.PubId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Title>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Title>()
                .Property(e => e.Advance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Title>()
                .Property(e => e.Notes)
                .IsUnicode(false);

            modelBuilder.Entity<Title>()
                .HasMany(e => e.Sales)
                .WithRequired(e => e.title)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Title>()
                .HasMany(e => e.TitleAuthors)
                .WithRequired(e => e.title)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Title>()
                .HasOptional(e => e.Roysched)
                .WithRequired(e => e.title);

            modelBuilder.Entity<Discount>()
                .Property(e => e.discounttype)
                .IsUnicode(false);

            modelBuilder.Entity<Discount>()
                .Property(e => e.stor_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Discount>()
                .Property(e => e.discount1)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Roysched>()
                .Property(e => e.title_id)
                .IsUnicode(false);
        }
    }
}
