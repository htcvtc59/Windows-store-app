using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;

namespace BackgroundNetWorkTask
{
    class BackgroundTaskSample
    {
        public const string SampleBackgroundTaskEntryPoint = "NetworkUpdateStatus.NetworkStatusBackgroundTask";
        public const string SampleBackgroundWithConditionName = "NetworkStatusBackgroundTask";
        public static BackgroundTaskRegistration RegisterBackgroundTask(string taskEntryPoint,string name,IBackgroundTrigger trigger
            ,IBackgroundCondition condition)
        {
            var builder = new BackgroundTaskBuilder();
            builder.Name = name;
            builder.TaskEntryPoint = taskEntryPoint;
            builder.SetTrigger(trigger);
            if (condition != null)
            {
                builder.AddCondition(condition);
            }
            BackgroundTaskRegistration task = builder.Register();
            return task;
        }
        public static void UnregisterBackgroundTasks(string name)
        {
            foreach (var cur in BackgroundTaskRegistration.AllTasks)
            {
                if (cur.Value.Name == name)
                {
                    cur.Value.Unregister(true);
                }
            }

        }


    }
}
