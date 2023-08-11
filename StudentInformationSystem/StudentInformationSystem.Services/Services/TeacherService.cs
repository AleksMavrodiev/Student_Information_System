﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentInformationSystem.Data;
using StudentInformationSystem.Services.Contracts;
using StudentInformationSystem.Web.ViewModels.Teacher;

namespace StudentInformationSystem.Services.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly StudentInformationDbContext dbContext;

        public TeacherService(StudentInformationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<List<SelectListItem>> GetTeachersForListItemAsync()
        {
            var teachers = await this.dbContext.Teachers.Select(t => new TeacherListViewModel()
            {
                Id = t.Id.ToString(),
                FullName = t.FirstName + " " + t.LastName,
            }).ToListAsync();

            var teachersForListItem = teachers.Select(t => new SelectListItem()
            {
                Text = t.FullName,
                Value = t.Id
            }).ToList();

            return teachersForListItem;
        }
    }
}