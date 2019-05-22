using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace MVCSistemaCrud.Models
{
    public class Product
    {
        [Key]
        public int Codigo { set; get; }
        public string Nombre { set; get; }
        public string Descripcion { set; get; }
        public decimal Precio { set; get; }
        [DisplayName("Ultima Compra")]
        public DateTime UltimaCompra { set; get; }
        [DisplayName("Unidades En Inventario")]
        public int UnidadesEnInventario { set; get; }

    }
}