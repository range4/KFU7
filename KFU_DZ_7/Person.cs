using System;
using DZ;
namespace DZ
{
    class Person
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public Person Boss { get; set; }

        public Person(string name, string department, Person boss)
        {
            Name = name;
            Department = department;
            Boss = boss;
        }

        public bool CanDoTask(Exercise task)
        {
            switch (task.Type)
            {
                case ExerciseType.Development:
                    return Department == "Разработка";
                case ExerciseType.System:
                    return Department == "Системы";
                case ExerciseType.Boss:
                    return Department == "Руководство";
            }

            return false;
        }
    }
}

