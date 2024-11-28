

using LearningApp;

//Records

//user purchases a course
CourseOrder order = new CourseOrder(101,2,30.99m);
//order.PurchasePrice = 40.00; //does not work as records are immutable
CourseOrder modifiedOrder = order with { PurchasePrice = 40.00m };

CourseOrder clonedOrder = new CourseOrder(101, 2, 30.99m);

//order.OrderId = 101;
//order.CourseID = 2;
//order.PurchasePrice = 30.99m;//represent the number as decimal

Console.WriteLine(modifiedOrder.ToString()); //displays type and also the values unlike classes which only displays type in this case
Console.WriteLine(order == clonedOrder); //true - in records the values are compared eventhough it is a reference type


Course course = new Course(101,"Artificial Intelligence",3.9,CourseCategory.Software);
Course.CourseOrder neworder = new Course.CourseOrder(1101, 101, 40.99m);
course.PurchaseCourse(neworder);