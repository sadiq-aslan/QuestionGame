using Game.Aplication.DTOs.Answer;
using Game.Aplication.Services.Abstract;
using Game.Domain.Entities;
using Game.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Aplication.Services.Concrete
{
    public class AnswerService : IAnswerService
    {
        private readonly IAnswerRepository _answerRepository;
        public AnswerService(IAnswerRepository repository)
        {
            _answerRepository =repository;
        }
        public async Task AddAsync(AnswerAddRequest answer)
        {
            Answer answer1 = new Answer 
            { 
                Value = answer.answer,
                IsTrue=answer.IsTrue,
                QuestionId =answer.QuestionId
            };
            await _answerRepository.CreateAsync(answer1);
        }

        public async Task DeleteByIdAsync(int id)
        {
            var answer = await _answerRepository.FindByIdAsync(id);
            await  _answerRepository.DeActivate(answer);
        }

        public async Task EditAsync(AnswerUpdateRequest answer)
        {
            Answer answer1 = new Answer
            {
                Id=answer.Id,
                Value = answer.answer,
                IsTrue = answer.IsTrue,
                QuestionId = answer.QuestionId
            };
            await _answerRepository.UpdateAsync(answer1);
        }

        public async Task<AnswerTableResponse> GetAnswerById(int id)
        {
           var item=  await _answerRepository.FindByIdAsync(id);
            AnswerTableResponse res = new AnswerTableResponse
            { 
                Id= item.Id,
                answer = item.Value,
                IsTrue= item.IsTrue,
                QuestionId = item.QuestionId
            };
            return res;

        }

        public async Task<List<AnswerTableResponse>> GetTable()
        {
            List<AnswerTableResponse> res = new List<AnswerTableResponse>();
            var items = await _answerRepository.FindAllActiveAsync();
            foreach(var item in items)
            {
                AnswerTableResponse response = new AnswerTableResponse
                {
                    Id = item.Id,
                    answer = item.Value,
                    IsTrue = item.IsTrue,
                    QuestionId = item.QuestionId
                };
                res.Add(response);
            }
            return res;
        }
    }
}
