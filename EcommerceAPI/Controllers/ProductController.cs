using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly _productoService = new ProductoService();
        [HttpGet("GetListado")]
        public ActionResult<List<Producto>> GetListadoProductos()
        {
            var response = _productoService.ListarProductos();
            return Ok(response);
        }

        [HttpGet("GetListado/{id}")]
        public ActionResult<Producto> GetProductoPorId(int id)
        {
            var response = _productoService.ListarProductosPorId(id);
            return Ok(response);
        }

        [HttpPost("PostProducto")]
        public ActionResult<Producto> PostProducto([FromBody] Producto producto )
        {
            var response = _productoService.AgregarProducto(producto);
            return Ok(response);
        }

        [HttpPut("PutProducto/{id}")]
        public ActionResult<Producto> PutProducto(int id, [FromBody] Producto producto)
        {
            var response = _productoService.ActualizarProducto(id, producto);
            return Ok(response);
        }

        [HttpDelete("DeleteProducto/{id}")]
        public ActionResult<Producto> PutProducto(int id)
        {
            var response = _productoService.EliminarProducto(id);
            return Ok(response);
        }
    }
}
