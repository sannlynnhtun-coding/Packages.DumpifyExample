// See https://aka.ms/new-console-template for more information
using Dumpify;

Console.WriteLine("Hello, World!");

new { Name = "Dumpify", Description = "Dump any object to Console" }.Dump();

Blog blog = new Blog()
{
    Id = Guid.NewGuid().ToString(),
    Author = "Test Author",
    Content = "Test Content",
    Title = "Test Title"
};
blog.Dump();

var lst = Enumerable.Range(1, 3).Select(x =>
{
    Blog blog = new Blog()
    {
        Id = Guid.NewGuid().ToString(),
        Author = "Test Author",
        Content = "Test Content",
        Title = "Test Title"
    };
    return blog;
});
lst.Dump();

Console.ReadLine();

public class Blog
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Content { get; set; }
}