﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Timofti_Dumitrita_Lab2.Models;

namespace Timofti_Dumitrita_Lab2.Data
{
    public class Timofti_Dumitrita_Lab2Context : DbContext
    {
        public Timofti_Dumitrita_Lab2Context (DbContextOptions<Timofti_Dumitrita_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Timofti_Dumitrita_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Timofti_Dumitrita_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Timofti_Dumitrita_Lab2.Models.Author>? Author { get; set; }
    }
}
