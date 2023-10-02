using Microsoft.AspNetCore.Mvc;
using WebAPIAutores.Entidades;


namespace WebAPIAutores.Controllers
{
    

        //Hy una clase base para controllers. Heredamos
        //Agrego atributo APi COntroller, me permite hacer validaciones a entradas
        //Con atributo Route defino rutas

    [ApiController]
    [Route("api/autores")]
    public class AutoresController:ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Autor>> Get()
        {
            
            return new List<Autor>() 
            {
                //{new Autor() {id=1,nombre="Guido"}}
                new Autor(1,"Guido"), new Autor(2,"Juli")
            };
        }




    }






}