using Game.Aplication.Services.Abstract;
using Game.Aplication.Services.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gamesService;

        public GameController(IGameService gamesService)
        {
            _gamesService = gamesService;
        }
        [HttpGet("getallCategories")]
        public async Task<IActionResult> GetAllCategories()
        {
         var res =  await _gamesService.Categories();
            return Ok(res);

        }
        [HttpGet("getQuestionandAnswers")]
        public async Task<IActionResult> GetQuestionsAndAnswers(int categoryid,int difficultyId)
        { 
            var res = await _gamesService.GetQuestion(categoryid,difficultyId);
            return Ok(res);
        }
        [HttpGet("AcceptAnswers")]
        public async Task<IActionResult> AcceptAnswers(int AnswerId)
        {
          var a =   await _gamesService.AcceptAnswer(AnswerId);
            return Ok(a);
        }
        [HttpGet("getDifficultyLevels")]
        public async Task<IActionResult> GetDifficultyLevels(int categoryId)
        {
          var res =   await _gamesService.difficultyLevelResponses(categoryId);
            return Ok(res);
        }
        [HttpGet("Reset")]
        public async Task<IActionResult> Reset()
        {
            await _gamesService.Reset();
            return Ok();
        }
    }
}
