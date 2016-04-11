﻿namespace InheritanceAndPolymorphism.Courses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LocalCourse : Course
    {
        public string Lab { get; set; }

        public LocalCourse(
            string courseName, string teacherName = null, List<string> students = null)
            : base(courseName, teacherName, students)
        {
            this.Lab = null;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("LocalCourse {");
            result.Append(base.ToString());
            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }
            result.Append(" }");
            return result.ToString();
        }
    }
}
