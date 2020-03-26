namespace CW_2
{
    struct TaskResult
    {
        public string name;
        public string surname;
        public string taskResult;
        public int mark;

        public TaskResult(string name, string surname, string taskResult, int mark)
        {
            this.name = name;
            this.surname = surname;
            this.taskResult = taskResult;
            this.mark = mark;
        }

        public string GetResultInfo()
        {
            return $"{name} {surname}\nTaskResult: {taskResult}\nMark: {mark}\n";
        }
    }
}
