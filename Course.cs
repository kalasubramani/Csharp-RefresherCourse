using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp
{
    internal class Course
    {
        //public readonly int _courseID=1; //can not have set()
        public int _courseID;
        public string _courseName;
        public double _rating=1;

        private static int numberOfCourses=0; //class level variable

        public const string CourseMessage = "This is a new course";
        public int CourseID
        {
            get { return _courseID; }
            set { _courseID = value; }
        }
        public string CourseName
        {
            get { return _courseName; }
            set { _courseName = value; }
        }
        public double Rating
        {
            get { return _rating; }
            set {
                if (value > 0 && value < 5)
                    _rating = value; 
            }
        }

        //constructor
        public Course()
        {
            //set defaults
            _courseID = 1;
            _courseName = "This is a course";
            _rating = 1;
        }

        public Course(int courseID, string courseName,double rating)
        {
            _courseID = courseID;   
            _courseName = courseName;
            _rating = rating;
            numberOfCourses++;
        }

        public static int TotalNoOfCourses()
        {
            return numberOfCourses;
        }
        public void setCourseDetails(int  courseID, string courseName,double rating)
        {
            this.CourseID = courseID;
            this._courseName = courseName;
            if (rating > 0 && rating<5)
            {
                this._rating = rating;
            }
        }

        public void DisplayCourses()
        {
            Console.WriteLine($"Course ID {_courseID}");
            Console.WriteLine($"Course Name {_courseName}");
            Console.WriteLine($"Course Rating {_rating}");
        }

        public string GetCourseDetails()
        {
            string CourseDetails = $"Course ID {_courseID}\nCourse Name {_courseName}\nCourse Rating {_rating}";
            return CourseDetails;
        }

        //using tuple return type
        public (string feedback,double rating) GetFeedback()
        {
            switch (_rating)
            {
                case (>= 4.5):
                    return ("The course is doing very well",_rating);
                case (< 4.5) when _rating >= 4.0:
                    return ("The course is up to the mark", _rating);
                case (< 4.5):
                    return ("The course needs improvement", _rating);
                default:
                    return ("The rating needs to be set properly", _rating);
            }
        }

        //set out parameter
        public string GetFeedback_Out(out string courseRating)
        {
            courseRating = $"The rating for this course is {_rating}";
            switch (_rating)
            {
                case (>= 4.5):
                    return "The course is doing very well";
                case (< 4.5) when _rating >= 4.0:
                    return "The course is up to the mark";
                case (< 4.5):
                    return "The course needs improvement";
                default:
                    return "The rating needs to be set properly";
            }
        }
    }
}
