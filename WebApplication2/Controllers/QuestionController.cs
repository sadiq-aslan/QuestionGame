using Game.Aplication.DTOs.Question;
using Game.Aplication.Services.Abstract;
using Game.Aplication.Services.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _questionService;
        public QuestionController(IQuestionService service)
        {
            _questionService = service;
        }
        [HttpPost("addQuestion")]
        public async Task<IActionResult> addQuestion(QuestionAddRequest req)
        { 
            await _questionService.AddAsync(req);
            return Ok();
        }
        [HttpPost("deleteQuestion")]
        public async Task<IActionResult> DeleteQuestion(int id)
        {
            await _questionService.DeleteByIdAsync(id);
            return Ok();
        }
        [HttpPost("updateQuestion")]
        public async Task<IActionResult> UpdateQuestion(QuestionUpdateRequest req)
        { 
           await _questionService.EditAsync(req);
            return Ok();
        }
        [HttpGet("GetQuestionByid")]
        public async Task<IActionResult> GetQuestionByid(int id)
        {
            var res = await _questionService.GetQuestionById(id);
            return Ok(res);
        }
        [HttpGet("getallQuestions")]
        public async Task<IActionResult> GetallQuestions()
        {
            var res=  await _questionService.GetTable();
            return Ok(res);
        }
    } 
}
