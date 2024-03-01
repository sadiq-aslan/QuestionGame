﻿using Game.Aplication.Dto.Category;
using Game.Aplication.DTOs.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Aplication.Services.Abstract
{ 
   public interface IQuestionService
    {
        Task AddAsync(QuestionAddRequest question);
        Task EditAsync(QuestionUpdateRequest question);
        Task<QuestionTableResponse> GetQuestionById(int id);
        Task<List<QuestionTableResponse>> GetTable();
        Task DeleteByIdAsync(int id);
    }
}
