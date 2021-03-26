using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APTask
{
    class Task
    {
        public string TaskName;
        public DateTime Created;
        public bool Completed;

        public Task(string TaskName, DateTime Created, bool Completed)
        {
            this.TaskName = TaskName;
            this.Created = Created;
            this.Completed = Completed;
            //Add to list
        }

        public string taskName
        {
            get { return TaskName; }
            set { TaskName = value; }
        }

        public DateTime created
        {
            get { return Created; }
            set { Created = value; }
        }
        public bool completed
        {
            get { return Completed; }
            set { Completed = value; }
        }


    }
}
