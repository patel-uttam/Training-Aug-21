using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstNewDatabaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entity FrameWork");

        /* Blog and Post */

            /*using (var data_context = new Context_of_Blogging())
            {
                Blog blog = new Blog();
                bool while_flag = true;


                while (while_flag)
                {
                    Console.WriteLine("Enter Your Choice");
                    Console.WriteLine("\t 1 for insert BlogName");
                    Console.WriteLine("\t 2 for Search BlogName");
                    Console.WriteLine("\t 3 for Delete BlogName");
                    Console.WriteLine("\t 4 for update BlogName");
                    var choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter Blog name you want to insert");
                            string blog_insert_db = Console.ReadLine();
                            blog.Name = blog_insert_db;
                            data_context.blogs.Add(blog);
                            data_context.SaveChanges();

                            break;

                        case 2:
                            Console.WriteLine("Enter name of blog you want to search");
                            string search_blog = Console.ReadLine();
                            var blog_fetch_db = from b in data_context.blogs where b.Name == search_blog orderby b.BlogId select b;

                            Console.WriteLine("----------------------------------------");
                            foreach (var item in blog_fetch_db)
                            {
                                Console.WriteLine("BlogId : " + item.BlogId + "\t" + "Blog : " + item.Name);
                            }
                            Console.WriteLine("----------------------------------------");

                            break;

                        case 3:
                            Console.WriteLine("enter name of blog to delete");
                            string delete_blog = Console.ReadLine();
                            var blog_delete_db = from b in data_context.blogs where b.Name == delete_blog select b;

                            data_context.blogs.RemoveRange(blog_delete_db);
                            data_context.SaveChanges();
                            break;

                        case 4:
                            Console.WriteLine("enter name of blog you want to update");
                            string update_blog = Console.ReadLine();
                            var blog_update_db = from b in data_context.blogs where b.Name == update_blog select b;
                            Console.WriteLine("enter name new name");
                            string updated_blog = Console.ReadLine();
                            foreach (var i in data_context.blogs)
                            {
                                i.Name = updated_blog;
                                data_context.SaveChanges();
                            }

                            break;

                        case 5:
                            while_flag = false;
                            break;

                        default:
                            Console.WriteLine("You enter wrong choice.");
                            break;
                    }

                    Console.WriteLine("----------------------------------------");
                    var blog_display_db = from b in data_context.blogs orderby b.BlogId select b;

                    foreach (var i in data_context.blogs)
                    {
                        Console.WriteLine("BlogId : " + i.BlogId + "\t" + "Blog : " + i.Name);
                    }
                    Console.WriteLine("----------------------------------------");
                }
            }*/

        /* Student and Course */

            using(var school_context = new SchoolContext())
            {
                var student = new Student();

                var course = new Course();

/*                student.StudentName = "Uttam";
                student.CourseId = 1;

                school_context.Students.Add(student);
                school_context.SaveChanges();*/


/*                student.StudentName = "Meet";
                student.CourseId = 2;

                school_context.Students.Add(student);
                school_context.SaveChanges();*/

                var student_fetch_db = from s_db in school_context.Students orderby s_db.Id select s_db;
                
                foreach(var i in student_fetch_db)
                {
                    Console.WriteLine("StudentName : "+ i.StudentName+" \t "+"Student's ID : "+i.Id);
                }
            }
        }
    }

}

public class Blog
{
    public int BlogId { get; set; }
    public string Name { get; set; }

    public virtual List<Post> Posts { get; set; }
}

public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public int BlogId { get; set; }
    public virtual Blog Blog { get; set; }
}

public class Context_of_Blogging : DbContext
{
    public DbSet<Blog> blogs
    {
        get;
        set;
    }
    public DbSet<Post> posts
    {
        get;
        set;
    }
}



/*----------------------------------------------------------------------------------------------------------------------------------------------*/
             

