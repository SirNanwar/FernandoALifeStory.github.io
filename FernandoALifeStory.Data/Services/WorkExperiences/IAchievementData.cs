﻿using FernandoALifeStory.Data.Models.WorkExperiences;
using System.Collections.Generic;

namespace FernandoALifeStory.Data.Services.WorkExperiences
{
    public interface IAchievementData
    {
        IEnumerable<Achievement> GetAll();

        Achievement GetById(int id);

        IEnumerable<Achievement> GetAchievementsByWorkId(int id);
    }
}