using System;
using System.Data.Entity;
using System.Diagnostics;

namespace WebApplication1.Models
{
    public class MusicContext : DbContext
    {
        public MusicContext()
        {
            Database.Log = s => Debug.WriteLine(s);
        }
        public DbSet<Album> Albums { get; set; }
    }
}