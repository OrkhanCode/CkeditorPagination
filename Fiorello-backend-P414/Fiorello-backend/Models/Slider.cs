﻿namespace Fiorello_backend.Models
{
    public class Slider : BaseEntity
    {
        public string Image { get; set; }
        public string Desc { get; set; }
        public bool Status { get; set; } = true;
    }
}
