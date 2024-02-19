﻿using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Concrete;

public class Context:DbContext
{
    public Context(DbContextOptions<Context> options): base(options) { }
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    //optionsBuilder.UseSqlServer("server=BEYZA\\BEYZA; Initial Catalog=ApiDb; Integrated Security=True; TrustServerCertificate=True"); 
    //}
    public DbSet<Room>  Rooms { get; set; }
    public DbSet<Service>  Services { get; set; }
    public DbSet<Staff>  Staffs { get; set; }
    public DbSet<Subscribe>  Subscribes { get; set; }
    public DbSet<Testimonial>  Testimonials { get; set; }
}
