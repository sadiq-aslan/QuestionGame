using Game.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Aplication.Dto.Category
{
    public class CategoryUpdateRequest
    {

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
