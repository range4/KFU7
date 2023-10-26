using System;
using DZ;

namespace DZ
{
    enum ExerciseType
    {
        Development,
        System,
        Boss

    }

    class Exercise
    {
        public string Name { get; set; }
        public Person Assigner { get; set; }
        public Person Executor { get; set; }
        public ExerciseType Type { get; set; }

        public Exercise(string name, Person assigner, Person executor, ExerciseType type)
        {
            Name = name;
            Assigner = assigner;
            Executor = executor;
            Type = type;
        }
    }
}
