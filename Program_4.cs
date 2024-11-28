
using LearningApp;

//Getting input from user at runtime

List<Course> courseList = new List<Course>();
string courseName;
Console.WriteLine("Enter course details");
Console.WriteLine("=====================");

int i = 1;
//gets input from user as long as ESC key is pressed. ESC key is considered end of input
do
{
    Console.WriteLine("Please enter a name for the course");
    courseName = Console.ReadLine();
    courseList.Add(new Course(i, courseName, 1.0, CourseCategory.Certifications));
    i++;
} while (!(Console.ReadKey().Key == ConsoleKey.Escape));


//display 
foreach (Course course in courseList)
    Console.WriteLine(course.GetCourseDetails());