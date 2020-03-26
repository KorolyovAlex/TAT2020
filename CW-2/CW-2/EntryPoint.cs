using System;

namespace CW_2
{
    class EntryPoint
    {
        private const byte STUDENTS_NUMBER = 10;

        static void Main(string[] args)
        {
            try
            {
                var teacher = new Teacher();

                for (int i = 0; i < STUDENTS_NUMBER; i++)
                {
                    teacher.AddNewStudent(new Student($"Name {i}", $"Surname {i}"));
                }

                teacher.GiveNewTask();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
