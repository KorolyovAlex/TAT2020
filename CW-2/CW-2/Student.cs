using System;
using System.Text;

namespace CW_2
{
    class Student : ITaskPerformer
    {
        private const byte TASK_LENGTH = 8;

        private StringBuilder _taskResult;

        public event Action<string, string, string> TaskIsDone;

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
            _taskResult = new StringBuilder();
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void DoTask()
        {
            if(_taskResult.ToString() != String.Empty)
            {
                return;
            }

            for(int i = 0; i < TASK_LENGTH; i++)
            {
                _taskResult.Append((char)Randomizer.GetRandomInt());
            }

            TaskIsDone?.Invoke(Name, Surname, _taskResult.ToString());
        }
    }
}
