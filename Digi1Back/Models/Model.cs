using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Digi1Back.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) :base(options) 
        { 
            
        }

        public DbSet<Producto> Producto { get; set; }
        public DbSet<Inventario> Inventario { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Factura> Factura { get; set; }

        public DbSet<view_inventarios> view_inventarios { get; set; }

        public DbSet<view_compras> view_compras { get; set; }

    }

    public class view_inventarios 
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int cantidad { get; set; }
    }

    public class view_compras
    {
        public string nombre { get; set; }
        public DateTime fecha_naci { get; set; }
        public int edad { get; set; }
        public int fac_id { get; set; }

        public DateTime fecha_compra { get; set; }
    }

    public class Producto
    {
        [Key]
        public int pro_Id { get; set; }
        public string pro_nombre { get; set; }
        public int pro_precio { get; set; }
        public string pro_medida { get; set; }
    }

    public class Inventario
    {
        [Key]
        public int inv_Id { get; set; } 
        public int  inv_pro_Id { get; set; }
        public int inv_cantidad { get; set; }
    }

    public class Cliente
    {
        [Key]
        public int cli_Id { get; set; }
        public string cli_nombre { get; set; }
        public DateTime cli_fecha_naci { get; set; }
    }

    public class Factura
    {
        [Key]
        public int fac_Id { get; set; }
        public int fac_cli_Id { get; set; }
        public int fac_inv_Id { get; set; }
        public DateTime fac_fecha_compra { get; set; }
        public int fac_pro_Id { get; set; }
        public int fac_cantidad { get; set; }
        public int fac_valor { get; set; }
    }
}
