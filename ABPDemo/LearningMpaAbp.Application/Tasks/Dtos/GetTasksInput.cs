using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningMpaAbp.Tasks.Dtos
{
    public class GetTasksInput
    {
        public TaskState? State { get; set; }

        public int? AssignedPersonId { get; set; }
    }
}
