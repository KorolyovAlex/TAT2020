using System;
using System.Collections.Generic;

namespace CW_2
{
    class Teacher
    {
        private List<Student> _studentList;
        private List<TaskResult> _taskResults;

        public Teacher()
        {
            _studentList = new List<Student>();
            _taskResults = new List<TaskResult>();
        }

        public void AddNewStudent(Student student)
        {
            student.TaskIsDone += GetTaskResult;

            _studentList.Add(student);
        }

        public void GiveNewTask()
        {
            foreach(var student in _studentList)
            {
                student.DoTask();
            }
        }

        private void GetTaskResult(string studentName, string studentSurname, string result)
        {
            _taskResults.Add(new TaskResult(studentName, studentSurname, result, CountMark(result)));

            if (_taskResults.Count == _studentList.Count)
            {
                ShowTaskResults();
            }
        }

        private int CountMark(string result)
        {
            int charSum = 0;

            foreach(char symbol in result)
            {
                charSum += (int)symbol;
            }

            return charSum % 10;
        }

        private void ShowTaskResults()
        {
            foreach(var result in _taskResults)
            {
                Console.WriteLine(result.GetResultInfo());
            }
        }
    }
}
