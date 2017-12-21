﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Abp.Application.Services;
using LearningMpaAbp.Tasks.Dtos;
using System.Threading.Tasks;


namespace LearningMpaAbp.Tasks
{
    public interface ITaskAppService : IApplicationService
    {
        GetTasksOutput GetTasks(GetTasksInput input);

        void UpdateTask(UpdateTaskInput input);

        int CreateTask(CreateTaskInput input);

        Task<TaskDto> GetTaskByIdAsync(int taskId);

        TaskDto GetTaskById(int taskId);

        void DeleteTask(int taskId);

        IList<TaskDto> GetAllTasks();
    }
}
