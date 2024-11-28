

using LearningApp;

double[] ratings = [4.5, 4.6, 4.7, 4.8, 5.0];

//SELECT * FROM Rating where ratings>4.6

//convert the ouput of query to a list and assign it to a list<double>
List<double> filteredRatings = (from rating in ratings
 where rating > 4.6
 select rating).ToList();

//display filtered ratings
foreach (double rating in filteredRatings)
    Console.WriteLine(rating);

//filtering data using LINQ
List<Course> courses = new List<Course>();
courses.Add(new Course(1, "AWS Solutions Architect", 4.5));
courses.Add(new Course(2, "C# Programming", 4.3));
courses.Add(new Course(3, "AI and Machine Learning", 3.5));
courses.Add(new Course(4, "Full Stack Web Development", 4.8));
courses.Add(new Course(5, "AWS Developer Associate", 4.9));

courses.Add(new Course(6, "AWS Solutions Architect", 4.1));
courses.Add(new Course(7, "C# Programming", 4.7));
courses.Add(new Course(8, "AI and Machine Learning", 4.1));
courses.Add(new Course(9, "Full Stack Web Development", 4.9));
courses.Add(new Course(10, "AWS Developer Associate", 3.9));

//rating >4.2
Console.WriteLine("===Courses with rating>4.2===");
List<Course> filtereedCourses = (from course in courses
                                 where course.Rating>4.2
                                 select course).ToList();

foreach(Course course in filtereedCourses)
    Console.WriteLine(course);

//course name contains "AWS
Console.WriteLine("===AWS Courses===");
List<Course> AWSCourses = (from course in courses
                           where course.CourseName.Contains("AWS")
                           select course).ToList();

foreach (Course course in AWSCourses)
    Console.WriteLine(course);

//grouping data using LINQ
Console.WriteLine("===Grouping Courses===");
var groupedCourses = (from course in courses
                               group course by course.CourseName into courseGroup
                               select courseGroup); //can not use tolist() as this returns Ienum,Igrouping - so use dynamic typing

foreach(IGrouping<string,Course> course in groupedCourses)
{
    Console.WriteLine($"{course.Key} " + course.Count()); //course name + no.of courses
}

//using Lambda expressions to filter data - using extension methods
//rating >4.2 
Console.WriteLine("===Using Lambda to filter courses ===");
List<Course> result = courses.Where(course => course.Rating > 4.2).ToList();
foreach(Course course in result)
    Console.WriteLine(course);

//get only course id and name
var courseData= courses.Select(course => (course.CourseID, course.CourseName));
foreach (var course in courseData)
    Console.WriteLine(course);