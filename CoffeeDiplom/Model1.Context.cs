﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoffeeDiplom
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
   public partial class coffee_houseEntities : DbContext
    {
        private static coffee_houseEntities _context;
        public coffee_houseEntities()
            : base("name=coffee_houseEntities")
        {
        }

        public static coffee_houseEntities Getcontext()
        {
            if (_context == null)
                _context = new coffee_houseEntities();

            return _context;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Coffee> Coffee { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
