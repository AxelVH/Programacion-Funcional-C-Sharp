﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Azucena.Vasquez.Infrastructure.Data.University.Entities
{
    public partial class Courses
    {
        public Courses()
        {
            Scores = new HashSet<Scores>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? State { get; set; }

        public virtual ICollection<Scores> Scores { get; set; }
    }
}