using Microsoft.EntityFrameworkCore;

namespace BlazorProject.Data;

public class NewsContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Article> Articles { get; set; }
    
    public DbSet<Comment> Comments { get; set; }
    
    public NewsContext(DbContextOptions<NewsContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSeeding((context, _) =>
        {
            Console.WriteLine("❗ Seeding Database");
            var testArticle = context.Set<Article>().FirstOrDefault();
            if (testArticle == null)
            {
                Console.WriteLine("❗ Seeding Database II");
                context.Set<Author>().AddRange(Seed.Authors);
                context.Set<Tag>().AddRange(Seed.Tags);
                context.Set<Article>().AddRange(Seed.Articles);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("❗ Weird Sh*t");
            }
        });
        
        base.OnConfiguring(optionsBuilder);
    }
}

public class Article
{
    public int ArticleId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime PublishDate { get; set; }
        
    public Author Author { get; set; }
    public List<Tag> Tags { get; set; }
    public List<Comment> Comments { get; set; }
}

public class Author
{
    public int AuthorId { get; set; }
    public string Name { get; set; }
        
    public List<Article> Articles { get; set; }
}

public class Tag
{
    public int TagId { get; set; }
    public string TagName { get; set; }
        
    public List<Article> Articles { get; set; }
}

public class Comment
{
    public int CommentId { get; set; }
    public string UserName { get; set; }
    public string Content { get; set; }
    
    public Article Article { get; set; }
}