using System;
using System.Collections.Generic;
using System.Text;

namespace zadacha3
{
    internal class Student
    {
        private string names;
        private int facultyNumber;
        private string specialty;
        private string course;


        public Student()
        {
            names = "Иван Иванов Иванов";
            facultyNumber = 1;
            specialty = "Информатика";
            course = "1 курс";
        }


        public Student(string names, int facultyNumber)
        {
            ValidateNames(names);
            ValidateFacultyNumber(facultyNumber);

            this.names = names;
            this.facultyNumber = facultyNumber;

            specialty = "Не е зададена";
            course = "Не е зададен";
        }


        public Student(
            string names,
            int facultyNumber,
            string specialty,
            string course)
        {
            ValidateNames(names);
            ValidateFacultyNumber(facultyNumber);
            ValidateText(specialty, "Специалността");
            ValidateText(course, "Курсът");

            this.names = names;
            this.facultyNumber = facultyNumber;
            this.specialty = specialty;
            this.course = course;
        }

        private void ValidateNames(string names)
        {
            if (string.IsNullOrWhiteSpace(names) || names.Length < 3)
            {
                throw new ArgumentException(
                    "Имената трябва да съдържат минимум 3 символа!"
                );
            }
        }
        private void ValidateFacultyNumber(int facultyNumber)
        {
            if (facultyNumber <= 0)
            {
                throw new ArgumentException(
                    "Факултетният номер трябва да бъде положително число!"
                );
            }
        }


        private void ValidateText(string text, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(text) || text.Length < 3)
            {
                throw new ArgumentException(
                    $"{fieldName} трябва да съдържа минимум 3 символа!"
                );
            }
        }


        public void DisplayInfo()
        {
            Console.WriteLine("Имена: " + names);
            Console.WriteLine("Факултетен номер: " + facultyNumber);
            Console.WriteLine("Специалност: " + specialty);
            Console.WriteLine("Курс: " + course);
        }
    }
}
