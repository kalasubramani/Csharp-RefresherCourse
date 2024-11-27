using LearningApp;

int numOfCourses = 20;

{
    string CourseName = "Programming..",courseName1="AWS Solutions Architect";

    Console.WriteLine(CourseName + courseName1);
    Console.WriteLine(courseName1.Contains("AWS"));
    Console.WriteLine(courseName1.IndexOf("Sol"));
    Console.WriteLine(courseName1.Replace("AWS", "Azure"));
    Console.WriteLine(courseName1.Substring(14));
    Console.WriteLine(CourseName + "\n" + courseName1);
    Console.WriteLine("\\test\\escapeseq");
    Console.WriteLine(@"c:\programs");
    Console.WriteLine(@"""");
    //multi line string
    string JSONobj="""
                        {
                            Hi!
                            Welcome to programming.

                                Thank you!
                        }
                        """;
    Console.WriteLine(JSONobj+JSONobj.GetType()) ;
    //string formatting
    Console.WriteLine("Course Name {0} and the number of courses is {1}", courseName1, numOfCourses);
    Console.WriteLine($"Course Name {courseName1} and the number of courses is {numOfCourses}");
}


//arrays
int[] courseId = new int[5];
courseId = [1,2,3,4,5];
Console.WriteLine(courseId[0]);

string[] courseNames = ["c1", "c2", "c3"];
Console.WriteLine(courseNames[1]);

//selection stmts
//case a when cnd

string[] courseDescription = ["desc1", "desc2", "desc3"];

//methods
void DisplayValues(string[] coursenames, string[] coursedesc)
{
    foreach(string cn in coursenames)
        foreach(string cd in coursedesc)
            Console.WriteLine(cn +"  "+cd);
}

DisplayValues(courseNames,courseDescription);
//DisplayValues(courseDescription);


Course course1 = new Course();
Course course2 = new Course(1, "AWS Solution Architect",4.6);
//course1.CourseID = 1;
//course1.CourseName = "AWS Solution Architect";
//course1.Rating = 4.6;
//course1.setCourseDetails(1, "AWS Solution Architect", 4.6);
//course1.CourseID = 1;
//course1.CourseName = "AWS Solution Architect";
//course1.Rating = 6;//fails ratings validations, defaults to 0


//course1.DisplayCourses();

//Console.WriteLine(Course.CourseMessage);
Console.WriteLine(course1.GetCourseDetails()) ;

Console.WriteLine(course2.GetCourseDetails()) ;

Course course3 = new Course()
{
    //access the public properties set()
    CourseID = 3,
    CourseName = "C# Programming",
    Rating = 3.5
};
Console.WriteLine(course3.GetCourseDetails());


//array of obj
Course[] Courses = new Course[3];
Courses[0] = new Course(4, "VB Programming", 4.1);
Courses[1] = new Course(5, "Web Development", 3.8);
Courses[2] = new Course(6, "Full Stack Development using React, Node.js, Express, PostgreSQL", 4.3);
Console.WriteLine(Courses[0].GetCourseDetails());

Course[] Cour = new Course[]
{
    new Course(7,"Python Programming",3.9),
    new Course(8, "Mobile Application Development", 4.0)
};
Console.WriteLine(Cour[0].GetCourseDetails());

//display values in the array of objs
foreach (Course course in Courses)
{
    Console.WriteLine(course.GetCourseDetails());
}

Console.WriteLine(course1.GetFeedback());

//tuple data type
(int i, int j) numbers = (10, 20);
Console.WriteLine("Tuples "+numbers.i + " "+numbers.j);

(int cId, string cName) crs = (10, "Data Science and Machine Learning");
Console.WriteLine(crs.cId+"-"+crs.cName);

(int, string) c = (11, "API Development");
Console.WriteLine(c.Item1+"-"+c.Item2);

//tuple as return type
Console.WriteLine(course1.GetFeedback().feedback);
Console.WriteLine(course1.GetFeedback().rating);

string str = String.Empty;
Console.WriteLine(course2.GetFeedback_Out(out str));
Console.WriteLine(str);

Console.WriteLine("numberOfCourses: "+Course.TotalNoOfCourses());