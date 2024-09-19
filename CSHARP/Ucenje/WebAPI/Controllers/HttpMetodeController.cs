using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class HttpMetodeController: ControllerBase
    {

        // ovdje pocinje ruta
        [HttpGet]
        public string Pozdravi()
        {
            return "Hello world!";
        }
        // odje zavrsava ruta


        // ovdje pocinje ruta
        [HttpGet]
        [Route("Pozdravi")]

        public string Pozdravi(string ime)
        { 
            return "Hello " + ime;
        }
        // zavrsava

        //ovdje pocinje

        [HttpGet]
        [Route("Zbroj")]
        public int Zbroj(int i, int j)
        {
            return i + j;
        }
        // ovdje zarsava

        //ovdje pocinje

        [HttpGet]
        [Route("Hello")]
        public IActionResult Pozdravi(int ID, string ime)
        {
            return Ok(new {id = ID, ime = ime});
        }
        // zavrsava


        //ovdje pocinje

        [HttpPost]
        public IActionResult Post()
        {
            return BadRequest(new { greska = true, poruka = "Nesto ne valja!"});
        }
        //ovdje zavrsava

        //ovdje pocinje

        [HttpPut]
        public IActionResult Put(Osoba osoba)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(new { greska = true, poruka = "Nije dobar parametar!" });
            }
            osoba.Prezime = "g. " + osoba.Prezime;
            return StatusCode(StatusCodes.Status206PartialContent, osoba);
        }
        // ovdje zavrsava


        // ovdje pocinje

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return NotFound(new {id = id , poruka = "Ne mogu pronaci", greska = true});
        }


    }
}
