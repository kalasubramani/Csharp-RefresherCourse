using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp
{
    enum CourseCategory
    {
        Software,
        Certifications,
        Communication,
        WellBeing
    }
    internal abstract class Person
    {
        protected string? _firstName;
        protected string? _lastName;
        protected int _age;

        public Person(string firstName, string lastName,int age)
        {
            _firstName = firstName; _lastName = lastName; _age = age;
        }

        public Person()
        {
        }

        //derived class can redefine this method
        //public virtual string GetDetails() => $"First Name {_firstName} \nLast Name {_lastName} \nAge {_age}";

        //every derived classes MUST provide their own impementation of this method
        //public abstract string GetDetails();
    }

    internal class Instructor :Person,IDetails
    {
        private double _rating;
        private int _numOfStudents;
        
        public Instructor(string firstName, string lastName, int age,double rating,int numOfStudents) : base(firstName, lastName, age)
        {
            _rating = rating;
            _numOfStudents = numOfStudents;
        }

        public void setRating(double rating)=> _rating = rating;
        public double getRating() => _rating;

        public void setNumberOfStudents(int numOfStudents)=> _numOfStudents = numOfStudents;

        public string GetDetails() => $"First Name {_firstName} \nLast Name {_lastName} \nRating {_rating}";
    }

    internal class Student : Person,IDetails
    {
        private string[]? _courseList;
        private string[] _courseWishList;

        public Student(string firstName, string lastName, int age, string[] courseList, string[] courseWishList) : base(firstName, lastName, age)
        {
           _courseList = courseList;
           _courseWishList = courseWishList; 
        }

        public string[]? GetCourseList() => _courseList;
        public string[]? GetCourseWishList() => _courseWishList;

        //overriding ToString()
        public override string ToString() => $"Student Name {_firstName+_lastName} Age{_age}";

        public string GetDetails()
        {
            int numOfCourses = 0, numOfwishListCourses = 0;
            if (_courseList != null) { numOfCourses = _courseList.Length; }
            if (_courseWishList != null) { numOfwishListCourses = _courseWishList.Length; }

            return $"Student Name {_firstName+" "+_lastName}\nNumber Of Courses {numOfCourses}\nnumber of courses in wish list {numOfwishListCourses}";
        }

    }

    interface IDetails {
       public string GetDetails();

              
    }

    //structure types
    struct VideoDetails
    {
        int FrameHeight, FrameWidth, DataRate;

        public VideoDetails(int frameHeight, int frameWidth, int dataRate)
        {
            FrameHeight = frameHeight;
            FrameWidth = frameWidth;
            DataRate = dataRate;
        }

        public string DisplayVideoDetails() => $"Frame Height {FrameHeight} Frame Width {FrameWidth} Data Rate {DataRate}";
    }

    //records
    //when some one purchses a course - immutable
    //record CourseOrder
    //{
    //    public int OrderId { get; set; }
    //    public int CourseID { get; set; }
    //    public decimal PurchasePrice { get; set; }
    //}

    record CourseOrder(int OrderId,int CourseId,decimal PurchasePrice);
}
