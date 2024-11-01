﻿using TodoServerApp.Components.Pages;
using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Service
{
    public class MemoryDataService : IDataService
    {

        public static IEnumerable<TaskItem> Tasks { get; } = [

          new() { Id = 1, Title = "Задача 1", Description = "Описание задачи 1", CreatedData = DateTime.Now },
          new() { Id = 1, Title = "Задача 2", Description = "Описание задачи 2", CreatedData = DateTime.Now },
          new() { Id = 3, Title = "Задача 1", Description = "Описание задачи 3", CreatedData = DateTime.Now },
         ];


        public async Task<IEnumerable<TaskItem>> GetTaskItemsAsync()
        {
            await Task.Delay(1000);
            return await Task.FromResult(Tasks);
        }
    }
}