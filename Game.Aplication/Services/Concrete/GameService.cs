using Game.Aplication.DTOs.Answer;
using Game.Aplication.DTOs.Category;
using Game.Aplication.DTOs.DifficultyLevel;
using Game.Aplication.DTOs.Game;
using Game.Aplication.DTOs.Question;
using Game.Aplication.Services.Abstract;
using Game.Domain.Entities;
using Game.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Game.Aplication.Services.Concrete
{
    public class GameService : IGameService
    {
        private readonly IDifficultyLevelRepository _difficultyLevelRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IAnswerRepository _answerRepository;
        private readonly IQuestionRepository _questionRepository;
        public GameService(ICategoryRepository category, IAnswerRepository answer, IQuestionRepository question, IDifficultyLevelRepository difficultyLevel)
        {
            _categoryRepository = category;
            _answerRepository = answer;
            _questionRepository = question;
            _difficultyLevelRepository = difficultyLevel;
        }

        public async Task<List<CategoryNameDto>> Categories()
        {
            List<CategoryNameDto> res = new List<CategoryNameDto>();
            var category = await _categoryRepository.FindAllActiveAsync();
            foreach (var item in category)
            {
                CategoryNameDto dto = new CategoryNameDto
                {
                    Name = item.Name,
                    Id = item.Id
                };

                res.Add(dto);

            }
            return res;
        }

        public async Task<bool> AcceptAnswer( int answerId)
        {
            Answer a = await _answerRepository.FindByConditionFirstOrDefaultAsync(a => a.Id == answerId);
            return a.IsTrue == IsTrue.True;
        }

        public async Task<List<DifficultyLevelResponse>> difficultyLevelResponses(int CategoryId)
        {

            // List<DifficultyLevel> difficultyLevels = await _difficultyLevelRepository.FindByConditionAsync(d => d.CategoryId ==CategoryId);
            // List<DifficultyLevelResponse> resp = new List<DifficultyLevelResponse>();
            // foreach (var item in difficultyLevels)
            // {
            //     DifficultyLevelResponse response = new DifficultyLevelResponse
            //     {
            //         Id = item.Id,
            //         Difficulty = item.Difficulty
            //     };
            //     resp.Add(response);

            // }
            //return resp;
            return null;

        }

        public async Task<QuestionDto> GetQuestion(int categoryId, int difficultyId)
        {
            List<AnswerDto> re = new List<AnswerDto>();
            var category = await _categoryRepository.FindAllActiveAsync();
            var questions = await _questionRepository.FindAllActiveAsync();
            var answers = await _answerRepository.FindAllActiveAsync();
            var x = from cat in category
                    join question in questions
                   on cat.Id equals question.CategoryId
                
                    where question.DifficultLevelId == difficultyId
                    && question.IsShowed == IsShowed.NotShowed
                    select new QuestionDto
                    {
                        Id = question.Id,
                        QValue = question.Content,
                        Answers = answers.Where(a => a.QuestionId == question.Id).Select(a => new AnswerDto { Id = a.Id, Value = a.Value }).ToList()

                    };
            var t = x.FirstOrDefault();
            if (t != null)
            {
                var l = await _questionRepository.FindByIdAsync(t.Id);
                l.IsShowed = IsShowed.Showed;
                await _questionRepository.UpdateAsync(l);

                return t;
            }
            return new QuestionDto();

        }

        public async Task Reset()
        {
            var a = await _questionRepository.FindAllActiveAsync();
            foreach (var item in a)
            {
                item.IsShowed = IsShowed.NotShowed;
            }
            foreach (var item in a)
            {
                await _questionRepository.UpdateAsync(item);
            }
        }
    }
}
