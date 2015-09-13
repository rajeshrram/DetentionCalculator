using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DetentionCalculatorApi
{
    /// <summary>
    /// This class provides the functionality for student. We can add more properties based on our needs.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="studentName">Name of the student.</param>
        /// <exception cref="System.ArgumentNullException">studentName</exception>
        /// <exception cref="System.ArgumentException">studentName cannot be empty</exception>
        public Student(string studentName)
        {
            if (studentName == null)
                throw new ArgumentNullException("studentName");

            if (string.IsNullOrEmpty(studentName))
                throw new ArgumentException("Student name cannot be empty");

            m_studentName = studentName;
        }
        public string StudentName
        {
            get
            {
                return m_studentName;
            }
        }

        private readonly string m_studentName;
    }
}