using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsAndModelBinding.Models
{
    /// <summary>
    /// Represents an individual student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// The unique identifier for the student
        /// </summary>
        public int StudentId { get; set; }

        /// <summary>
        /// The legal first and last name of the student
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The day the student was born, time is ignored
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// The student email( ends with @cptc.edu )
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Home phone number
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
