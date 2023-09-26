using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatToCookForm.Models
{
    internal class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Gluten { get; set; }
        public bool Vegan { get; set; }
        public bool Vegeterian { get; set; }
        public bool TransFat { get; set; }
        public bool SimpleSugar { get; set; }
        public bool Lactose { get; set; }
        public bool Fiber { get; set; }
    }
}
