﻿using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace StudentInformationSystem.Data.Configurations
{
    public class TimeOnlyComparer : ValueComparer<TimeOnly>
    {
        public TimeOnlyComparer() : base(
            (t1, t2) => t1.Ticks == t2.Ticks,
            t => t.GetHashCode())
        {

        }
    }
}
