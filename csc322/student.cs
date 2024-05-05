using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace StudentManagementSystem
{

    /// <summary>
    /// Represents a person
    /// </summary>

    public abstract class Person
    {
        /// <summary>
        /// Gets and set Name for the person
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets and set Email for the person
        /// </summary>

        public string Email { get; set; }

        /// <summary>
        /// Gets and set Age for the person
        /// </summary>

        public int Age { get; set; }

        /// <summary>
        /// Displays information about person
        /// </summary>

        public abstract void DisplayInfo();
    }

    public class Student : Person
    {
        /// <summary>
        /// Gets and set the StudentID, this is unique for all student instance
        /// </summary>

        private string StudentId { get; set; }

        /// <summary>
        /// Gets and set the UniversityName
        /// </summary>
        public string UniversityName { get; set; }

        /// <summary>
        /// Gets and set the Department
        /// </summary>

        public string Department { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Student Name: {Name}, Student Email: {Email}, Student Age: {Age}, Student ID: {StudentId}");
        }

        /// <summary>
        /// Initializes a new instance of the Student class.
        /// </summary>
        /// <param name="name">The name of the student.</param>
        /// <param name="email"> The email of the stude.</param>
        /// <param name="age">The age of the student.</param>
        /// <param name="universityName">The university of the student.</param>
        /// <param name="department">The student department</param>
        /// <remarks>
        /// Preconditions: The name, age, email, department and universityName  parameters must be provided and should be a string.
        /// Postconditions: A new instance of the Student class is created with the specified properties.
        /// </remarks>


        public Student(string name, string email, int age, string universityName, string department)
        {
            Name = name;
            Email = email;
            Age = age;
            StudentId = Guid.NewGuid().ToString("N").Substring(0, 8);
            UniversityName = universityName;
            Department = department;
        }

        /// <summary>
        /// Displays information about student
        /// </summary>


        /// <summary>
        /// Student study a course
        /// <param name="course" >The name of the course the student wants to study</param>
        /// </summary>
        /// <remarks>
        /// Preconditions: The course parameter must be provided and should be a string.
        /// Postconditions: A void method that prints the student is studying the specified course.
        /// </remarks>

        public void Study(string course)
        {
            if (string.IsNullOrEmpty(course))
            {
                throw new ArgumentException("course can not be null", nameof(course));
            }

            Console.WriteLine($"{Name} is studying {course}, try to understand the concept");
        }

        /// <summary>
        /// Student take a test
        /// <param name="course" >The name of the course the student wants to take test</param>
        /// </summary>
        /// <remarks>
        /// Preconditions: The course parameter must be provided and should be a string.
        /// Postconditions: A void method that prints the student is taking test for the specified course.
        /// </remarks>

        public void TakeTest(string course)
        {

            if (string.IsNullOrEmpty(course))
            {
                throw new ArgumentException("course can not be null", nameof(course));
            }

            Console.WriteLine($"{Name} is taking test for {course}");
        }

        /// <summary>
        /// Student submit assignment
        /// <param name="course" >The name of the course the student wants to submit assignment</param>
        /// <param name="assignment" >The name of the assignment the student wants to submit</param>
        /// </summary>
        /// <remarks>
        /// Preconditions: The course and assignment parameters must be provided and should be a string.
        /// Postconditions: A void method that prints the student is submitting assignment for the specified course.
        /// </remarks>

        public void SubmitAssignment(string course, string assignment)
        {

            if (string.IsNullOrEmpty(course) || string.IsNullOrEmpty(assignment))
            {
                throw new ArgumentException("course and assignment can not be null");
            }
            Console.WriteLine($"{Name} is submitting assignment for {course} with assignment {assignment}");
        }

        /// <summary>
        /// Student attend class
        /// <param name="course" >The name of the course the student wants to attend class</param>
        /// </summary>
        /// <remarks>
        /// Preconditions: The course parameter must be provided and should be a string.
        /// Postconditions: A void method that prints the student is attending class for the specified course.
        /// </remarks>
        public void AttendClass(string course)
        {
            if (string.IsNullOrEmpty(course))
            {
                throw new ArgumentException("course can not be null", nameof(course));
            }

            Console.WriteLine($"{Name} is attending class for {course}");
        }

        /// <summary>
        /// Student join student club
        /// <param name="club" >The name of the club the student wants to join</param>
        /// </summary>
        /// <remarks>
        /// Preconditions: The club parameter must be provided and should be a string.
        /// Postconditions: A void method that prints the student is joining the specified club.
        /// </remarks>

        public void JoinStudentClub(string club)
        {

            if (string.IsNullOrEmpty(club))
            {
                throw new ArgumentException("course can not be null", nameof(club));
            }

            Console.WriteLine($"{Name} is joining {club} club");
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student("David mark", "nwaekwudavid@gmail.com", 20, "University of Lagos", "Computer Science");

            myStudent.DisplayInfo();

            myStudent.Study("Computer Science");

            myStudent.TakeTest("FSC114");

            myStudent.JoinStudentClub("Nacoss");

            myStudent.AttendClass("csc 122");
    
        }

    }

}






