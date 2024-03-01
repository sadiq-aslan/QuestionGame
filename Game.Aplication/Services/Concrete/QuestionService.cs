using Game.Aplication.Dto.Category;
using Game.Aplication.DTOs.Question;
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
    public class QuestionService : IQuestionService
    {
        private readonly  IQuestionRepository _questionRepository;
        public QuestionService(IQuestionRepository respository)
        {
            _questionRepository = respository;
        }

        public async Task AddAsync(QuestionAddRequest question)
        {
            Question qu = new Question 
            {
               Content = question.Content,
               DifficultLevelId =question.DifficultyId    
            };
            await _questionRepository.CreateAsync(qu);

        }

        public async Task DeleteByIdAsync(int id)
        {
           var qu = await _questionRepository.FindByIdAsync(id);
            await _questionRepository.DeActivate(qu);
        }

        public async Task EditAsync(QuestionUpdateRequest question)
        {
            Question ques = new Question
            {
                Id= question.Id,
                Content = question.Content,
                DifficultLevelId = question.DifficultyLevelId

            };
            await _questionRepository.UpdateAsync(ques);
        }

        public async Task<QuestionTableResponse> GetQuestionById(int id)
        {
         var res =   await _questionRepository.FindByIdAsync(id);
            QuestionTableResponse response = new QuestionTableResponse
            { 
                Id=res.Id,
                Content= res.Content,
                DiffiultyLevelId=res.DifficultLevelId
            };
            return response;

        }

        public async Task<List<QuestionTableResponse>> GetTable()
        {
            List<QuestionTableResponse> res = new List<QuestionTableResponse>();    
            List<Question> Questions = await _questionRepository.FindAllActiveAsync();
            foreach (Question item in Questions)
            {
                QuestionTableResponse qu = new QuestionTableResponse 
                {
                    Id=item.Id,
                    Content=item.Content,
                    DiffiultyLevelId=item.DifficultLevelId
                };
                res.Add(qu);
            }
            return res;
        }
    }
}
