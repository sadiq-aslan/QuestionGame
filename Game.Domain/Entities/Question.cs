namespace Game.Domain.Entities
{
    public class Question : BaseEntity
    { 
        public string Content { get; set; }

        public IsShowed IsShowed { get; set; } = IsShowed.NotShowed;
        //relation
        public List<Answer> Answers { get; set; }

        public int DifficultLevelId { get; set; }
        public DifficultyLevel DifficultyLevel { get; set; }
       
         public Category Category { get; set; }
         public int CategoryId { get; set; }
       

    }

}
