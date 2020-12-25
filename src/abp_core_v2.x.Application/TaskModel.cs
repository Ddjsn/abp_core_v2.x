using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using abp_core_v2.x.Tasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace abp_core_v2.x
{
    public class GetAllTasksInput
    {
        public TaskState? State { get; set; }
    }

    [AutoMapFrom(typeof(AppTask))]
    public class TaskListDto : EntityDto, IHasCreationTime
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreationTime { get; set; }

        public TaskState State { get; set; }
    }

}
