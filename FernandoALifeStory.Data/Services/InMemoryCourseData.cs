﻿using FernandoALifeStory.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FernandoALifeStory.Data.Services
{
    public class InMemoryCourseData : ICourseData
    {
        List<Course> courses;

        public InMemoryCourseData()
        {
            courses = new List<Course>()
            {
                new Course{ Id = 1,
                            Name ="ASP.NET MVC 5 Fundamentals",
                            Description ="TBD",
                            Skills = new List<Skills>{Skills.CSharp,
                                                      Skills.ASPdotNET,
                                                      Skills.dotNET,
                                                      Skills.MVC,
                                                      Skills.VisualStudio}}
            };
        }

        public IEnumerable<Course> GetAll()
        {
            return courses.OrderBy(r => r.Name);
        }

        public Course GetById(int id)
        {
            return courses.FirstOrDefault(x => x.Id.Equals(id));
        }
    }
}
