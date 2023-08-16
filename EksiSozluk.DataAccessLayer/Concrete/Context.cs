using EksiSozluk.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-VHTU727\\SQLEXPRESS;initial catalog=eksisozlukDb;integrated security=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<TermsOfUse> TermsOfUses { get; set; }
        public DbSet<Policy> Policies { get; set; }
        public DbSet<AdminMessage> AdminMessages { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
