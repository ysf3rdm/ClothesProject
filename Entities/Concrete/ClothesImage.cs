using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ClothesImage:IEntity
    {
        public int Id { get; set; }
        public int ClothesId { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }
    }
}
