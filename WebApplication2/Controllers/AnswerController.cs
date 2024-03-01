using Game.Aplication.DTOs.Answer;
using Game.Aplication.Services.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        private readonly IAnswerService _answerService;
        public AnswerController(IAnswerService service)
        {
            _answerService = service;
        }
        [HttpPost("ADDAnswer")]
        public async Task<IActionResult> AddAnswer(AnswerAddRequest req)
        {
            await _answerService.AddAsync(req);
            return Ok();
        }
        [HttpPost("updateAnswer")]
        public async Task<IActionResult> updateAnswer(AnswerUpdateRequest req)
        {
            await _answerService.EditAsync(req);
            return Ok();
        }
        [HttpPost("deleteAnswer")]
        public async Task<IActionResult> DeleteAnswerById(int id)
        {
            await _answerService.DeleteByIdAsync(id);
            return Ok();
        }
        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var res =await _answerService.GetAnswerById(id);
            return Ok(res);
        }
        [HttpGet("getAllTable")]
        public async Task<IActionResult> getAllAnswers()
        {
          var res=  await _answerService.GetTable();
            return Ok(res);
        }
    }
}
