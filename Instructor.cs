using System;

namespace Lightening {
        public class Instructor : Person
        {

            public Instructor(string firstName, string lastName)
            {
                _firstName = firstName;
                _lastName = lastName;
            }

            public void AssignExercise(Student student, Exercise exercise)
            {
                student.AssignedExercises.Add(exercise);
            }


    }

}