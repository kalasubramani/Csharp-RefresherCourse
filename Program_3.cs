
using System;
using System.Collections;
using System.Collections.Generic;
using LearningApp;


//collections

//ArrayList
ArrayList courseList = new ArrayList();
courseList.Add("C# programming");
courseList.Add("Programming in python");
courseList.Add("Full Stack Web Development");

foreach(string course in courseList)
    Console.WriteLine(course);

courseList.Add("AI and Machine Learning");

foreach (string course in courseList)
    Console.WriteLine(course);

Console.WriteLine($"The no. of courses available in the course list: {courseList.Count}");
Console.WriteLine("Does list contain Programming in python? " + courseList.Contains("Programming in python"));
courseList.Remove("C# programming");
Console.WriteLine("--Removed a course--\n");
foreach (string course in courseList)
    Console.WriteLine(course);


//Queue
Console.WriteLine("---Queue---");
Queue courses = new Queue();
courses.Enqueue("C# programming");
courses.Enqueue("Programming in python");
courses.Enqueue("Full Stack Web Development");

Console.WriteLine("First course in queue: "+courses.Peek());

foreach(string course in courses)
    Console.WriteLine(course);

courses.Dequeue();//removes first ele


Console.WriteLine("After dequeue: ");
foreach (string course in courses)
    Console.WriteLine(course);

//STack
Console.WriteLine("---Stack---");

Stack crs = new Stack();
crs.Push(("C# programming"));
crs.Push("Programming in python");
crs.Push("Full Stack Web Development");

crs.Pop();

foreach (string course in crs)
    Console.WriteLine(course);


//Generics
Console.WriteLine("---Generics---");
Console.WriteLine("***List<T>***");
//ArrayList   crslist = new ArrayList();
List<Course> crslist = new List<Course>();
crslist.Add(new Course(1, "AWS Certification", 4.0, CourseCategory.Certifications));
crslist.Add(new Course(2, "Microsoft Certified Developer", 4.2, CourseCategory.Certifications));

foreach(Course c in crslist)
    Console.WriteLine(c.GetCourseDetails());


Console.WriteLine("***Generics - Dictionary***");
Dictionary<int,string> dCourse = new Dictionary<int,string>();

dCourse.Add(1, "AWS Certification");
dCourse.Add(2, "Microsoft Certified Developer");
dCourse.Add(3, "Programming in python");

Console.WriteLine(dCourse[2]); //dCourse[key]

Dictionary<int,Course> dCrs= new Dictionary<int,Course>();
dCrs.Add(1, (new Course(1, "AWS Certification", 4.0, CourseCategory.Certifications)));
dCrs.Add(2, (new Course(2, "Microsoft Certified Developer", 4.2, CourseCategory.Certifications)));
Console.WriteLine(dCrs[2].GetCourseDetails());


