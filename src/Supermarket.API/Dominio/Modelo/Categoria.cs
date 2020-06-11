using System.Collections.Generic;
namespace Supermarket.API.Dominio.Modelos
{
	public class Categoria
	{
	public int id { get; set; }
	public string nombre { get; set; }
	public IList<Producto> productos { get; set; } //Relacion entre tablas (categoria y productos)
	}
}
