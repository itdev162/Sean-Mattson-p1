using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sean_Mattson_p1.Dtos.Character;
using Sean_Mattson_p1.Models;
using Sean_Mattson_p1.Services.CharacterServices;

namespace Sean_Mattson_p1.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CharacterController : ControllerBase // an MVC Controller class you should inherit from if you're not using a view for this controller
    {

        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;

        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddCharacter(AddCharacterDto newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));

        }

    }
}