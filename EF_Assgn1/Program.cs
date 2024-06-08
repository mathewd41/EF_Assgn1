using Core.Entity;
using EF_Assgn1;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {
        var dbContext = new DataContext();
        dbContext.Database.EnsureCreated();
        var user1 = new UserEntity
        {
            Name = "Maya",
            EmailAddress = "Maya@gmail.com",
            PhoneNumber = "123-456-7890"
        };
        var user2 = new UserEntity
        {
            Name = "Sweety",
            EmailAddress = "Sweety@gmail.com",
            PhoneNumber = "123-456-7891"
        };
        var user3 = new UserEntity
        {
            Name = "Jay",
            EmailAddress = "Jay@gmail.com",
            PhoneNumber = "123-456-7892"
        };
        dbContext.Users.Add(user1);
        dbContext.Users.Add(user2);
        dbContext.Users.Add(user3);
        dbContext.SaveChanges();


        var postType = new PostType
        {
            Status = Core.Status.Active,
            Name = "Nano Technology",
            Description = "Nano Technology Description"
        };

        var blogType = new BlogType
        {
            Status = Core.Status.Active,
            Name = "Science",
            Description = "Science Related Blogs"
        };
        dbContext.PostTypes.Add(postType);
        dbContext.BlogTypes.Add(blogType);
        dbContext.SaveChanges();


        var blog_Type = dbContext.BlogTypes.FirstOrDefault();
        dbContext.Blogs.Add(new Blog()
        {
            IsPublic = true,
            Url = "test.com",
            BlogTypeId = blog_Type.Id
        });
        dbContext.SaveChanges();

        var user = dbContext.Users.FirstOrDefault();
        var blog = dbContext.Blogs.FirstOrDefault();
        var post_Type = dbContext.PostTypes.FirstOrDefault();


        var post = new Post()
        {
            Title = "Adv Nano Technology",
            Content = "New Developments in Nano Technology.",
            BlogId = blog.Id,
            PostTypeId = post_Type.Id,
            UserId = user.Id
        };
        dbContext.Posts.Add(post);
        dbContext.SaveChanges();


        // To Display Details
        var users = dbContext.Users.ToList();
        Console.WriteLine("User Details");
        foreach (var u in users)
        {
            Console.WriteLine($"ID: {u.Id}, Name: {u.Name}, Email: {u.EmailAddress}, Phone: {u.PhoneNumber}");
        }

        var BlogTypes = dbContext.BlogTypes.ToList();
        Console.WriteLine("Blog Type Details");
        foreach (var BlogType in BlogTypes)
        {
            Console.WriteLine($"ID: {BlogType.Id}, Status: {BlogType.Status}, Name: {BlogType.Name}, Description: {BlogType.Description}");
        }

        var PostTypes = dbContext.PostTypes.ToList();
        Console.WriteLine("Post Type Details");
        foreach (var PostType in PostTypes)
        {
            Console.WriteLine($"ID: {PostType.Id}, Status: {PostType.Status}, Name: {PostType.Name}, Description: {PostType.Description}");
        }

        var Blogs = dbContext.Blogs.ToList();
        Console.WriteLine("Blog Details");
        foreach (var Blog in Blogs)
        {
            Console.WriteLine($"ID: {Blog.Id}, Url: {Blog.Url}, Status: {Blog.IsPublic}, BlogTypeId: {Blog.BlogTypeId}");
        }

        var posts = dbContext.Posts.ToList();
        Console.WriteLine("Post Details");
        foreach (var p in posts)
        {
            Console.WriteLine($"ID: {p.Id}, Title: {p.Title}, Content: {p.Content}, BlogId: {p.BlogId}, PostTypeId: {p.PostTypeId}, UserId: {p.UserId}");
        }

 

    }
}











