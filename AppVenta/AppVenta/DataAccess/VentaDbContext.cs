using AppVenta.Modelos;
using AppVenta.Utilidades;
using Microsoft.EntityFrameworkCore;

namespace AppVenta.DataAccess
{
    public class VentaDbContext : DbContext
    {

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<DetalleVenta> DetalleVentas { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Producto> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conexionDb = $"Filename={ConexionDb.DevolverRuta("venta.db")}";
            optionsBuilder.UseSqlite(conexionDb);
            //optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(c => c.IdCategoria);
                entity.Property(c => c.IdCategoria).IsRequired().ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(p => p.IdProducto);
                entity.Property(p => p.IdProducto).IsRequired().ValueGeneratedOnAdd();
                entity.HasOne(p => p.RefCategoria).WithMany(c => c.Productos)
                .HasForeignKey(p => p.IdCategoria);
            });

            modelBuilder.Entity<Venta>(entity =>
            {
                entity.HasKey(v => v.IdVenta);
                entity.Property(v => v.IdVenta).IsRequired().ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DetalleVenta>(entity =>
            {
                entity.HasKey(dv => dv.IdDetalleVenta);
                entity.Property(dv => dv.IdDetalleVenta).IsRequired().ValueGeneratedOnAdd();
                entity.HasOne(dv => dv.RefVenta).WithMany(v => v.RefDetalleVenta)
                .HasForeignKey(dv => dv.IdVenta);
                entity.HasOne(dv => dv.RefProducto).WithMany(p => p.RefDetalleVenta)
               .HasForeignKey(p => p.IdProducto);
            });

            modelBuilder.Entity<Categoria>().HasData(
                new Categoria { IdCategoria = 1, Nombre = "Laptops" },
                new Categoria { IdCategoria = 2, Nombre = "Monitores" },
                new Categoria { IdCategoria = 3, Nombre = "Teclados" },
                new Categoria { IdCategoria = 4, Nombre = "Auriculares" },
                new Categoria { IdCategoria = 5, Nombre = "Memorias" },
                new Categoria { IdCategoria = 6, Nombre = "Accesorios" }
                );


            modelBuilder.Entity<Producto>().HasData(
                new Producto
                    {
                        IdProducto = 1,
                        Codigo = "111111",
                        Nombre = "laptop samsung book pro",
                        IdCategoria = 1,
                        Cantidad= 20,
                        Precio = 2500
                    },
                new Producto
                {
                    IdProducto = 2,
                    Codigo ="222222",
                    Nombre = "laptop lenovo idea pad",
                    IdCategoria = 1,
                    Cantidad = 30,
                    Precio = 2100
                },
                new Producto
                {
                    IdProducto = 3,
                    Codigo = "333333",
                    Nombre = "laptop asus zenbook duo",
                    IdCategoria = 1,
                    Cantidad = 30,
                    Precio = 2100
                },
                new Producto
                {
                    IdProducto = 4,
                    Codigo = "444444",
                    Nombre = "monitor teros gaming te-2",
                    IdCategoria = 2,
                    Cantidad = 25,
                    Precio = 1050
                },
                new Producto
                {
                    IdProducto = 5,
                    Codigo = "555555",
                    Nombre = "monitor samsung curvo",
                    IdCategoria = 2,
                    Cantidad = 15,
                    Precio = 1400
                },
                new Producto
                {
                    IdProducto = 6,
                    Codigo = "666666",
                    Nombre = "monitor huawei gamer",
                    IdCategoria = 2,
                    Cantidad = 18,
                    Precio = 1350
                },
                new Producto
                {
                    IdProducto = 7,
                    Codigo = "777777",
                    Nombre = "teclado seisen gamer",
                    IdCategoria = 3,
                    Cantidad = 30,
                    Precio = 800
                },
                new Producto
                {
                    IdProducto = 8,
                    Codigo = "888888",
                    Nombre = "teclado antryx gamer",
                    IdCategoria = 3,
                    Cantidad = 20,
                    Precio = 1000
                },
                new Producto
                {
                    IdProducto = 9,
                    Codigo = "999999",
                    Nombre = "teclado logitech",
                    IdCategoria = 3,
                    Cantidad = 20,
                    Precio = 1000
                },
                new Producto
                {
                    IdProducto = 10,
                    Codigo = "101010",
                    Nombre = "auricular logitech gamer",
                    IdCategoria = 4,
                    Cantidad = 20,
                    Precio = 800
                },
                new Producto
                {
                    IdProducto = 11,
                    Codigo = "111110",
                    Nombre = "auricular hyperx gamer",
                    IdCategoria = 4,
                    Cantidad = 20,
                    Precio = 680
                },
                new Producto
                {
                    IdProducto = 12,
                    Codigo = "121212",
                    Nombre = "auricular redragon rgb",
                    IdCategoria = 4,
                    Cantidad = 25,
                    Precio = 950
                },
                new Producto
                {
                    IdProducto = 13,
                    Codigo = "131313",
                    Nombre = "memoria kingston rgb",
                    IdCategoria = 5,
                    Cantidad = 20,
                    Precio = 200
                },
                new Producto
                {
                    IdProducto = 14,
                    Codigo = "141414",
                    Nombre = "ventilador cooler master",
                    IdCategoria = 6,
                    Cantidad = 20,
                    Precio = 200
                },
                new Producto
                {
                    IdProducto = 15,
                    Codigo = "151515",
                    Nombre = "mini ventilador lenono",
                    IdCategoria = 6,
                    Cantidad = 25,
                    Precio = 260
                }
                );
        }


    }
}
