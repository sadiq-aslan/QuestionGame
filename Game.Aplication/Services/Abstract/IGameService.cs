using Game.Aplication.DTOs.Category;
using Game.Aplication.DTOs.DifficultyLevel;
using Game.Aplication.DTOs.Game;
using Game.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Aplication.Services.Abstract
{
    public interface IGameService
    {
        Task<List<CategoryNameDto>> Categories();
        Task<QuestionDto> GetQuestion(int categoryId, int difficultyId);
        Task<bool> AcceptAnswer(int answerId);

        Task<List<DifficultyLevelResponse>> difficultyLevelResponses(int categoryId);
        Task Reset();



    }
}
