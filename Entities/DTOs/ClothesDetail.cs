using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ClothesDetail
    {
        public int Id { get; set; }
        public int ClothesId { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int SizeId { get; set; }
        public string CategoryName { get; set; }
        public string BrandName { get; set; }
        public string Size { get; set; }
        public string ClothesName { get; set; }
        public short ClothesInStock { get; set; }
        public decimal ClothesPrice { get; set; }
        public string ImagePath { get; set; }
    }
}
