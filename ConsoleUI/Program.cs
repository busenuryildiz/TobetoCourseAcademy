using Business;
using Business.Concretes;
using Entities.Concretes;

Category category = new Category();
category.Id=1;
category.Name = "Programlama";

CategoryManager categoryManager = new CategoryManager();
categoryManager.Add(category);

User user1 = new User();
user1.UserId = 1;
user1.UserName = "Buse";
user1.Password = "1234";
user1.Email = "buse@gmail.com";
user1.Phone = 3;

UserManager kullanici = new UserManager();
kullanici.Add(user1);
kullanici.Update(user1);
kullanici.Delete(user1);

Course java = new Course();
java.CourseId = 1;
java.CourseName = "Java + React kursu";
java.Instructor = "Engin Demiroğ";
java.Category = "programlama";
java.Description = "2023 java kursu";
java.Price = 150;

CourseManager courseManager = new CourseManager();
courseManager.Add(java);
courseManager.Delete(java);
