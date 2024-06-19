using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DoThuThuy.Models;

    public class LTQLDb : DbContext
    {
        public LTQLDb (DbContextOptions<LTQLDb> options)
            : base(options)
        {
        }

        public DbSet<DoThuThuy.Models.Person> Person { get; set; } = default!;

public DbSet<DoThuThuy.Models.Employee> Employee { get; set; } = default!;

public DbSet<DoThuThuy.Models.HeThongPhanPhoi> HeThongPhanPhoi { get; set; } = default!;

public DbSet<DoThuThuy.Models.DaiLy> DaiLy { get; set; } = default!;
    }
