namespace BlazorProject.Data;

public static class Seed
{
    public static List<Author> Authors = new()
    {
        new Author
        {
            AuthorId = 1,
            Name = "John Doe",
            Articles = new List<Article>()
        },
        new Author
        {
            AuthorId = 2,
            Name = "Jane Smith",
            Articles = new List<Article>()
        }
    };

    public static List<Tag> Tags = new()
    {
        new Tag
        {
            TagId = 1,
            TagName = "Technology",
            Articles = new List<Article>()
        },
        new Tag
        {
            TagId = 2,
            TagName = "Health",
            Articles = new List<Article>()
        },
        new Tag
        {
            TagId = 3,
            TagName = "Lifestyle",
            Articles = new List<Article>()
        }
    };

    public static List<Article> Articles = new()
    {
        new Article
        {
            ArticleId = 1,
            Title = "The Future of AI",
            Content = "Artificial Intelligence is shaping the future of technology.",
            PublishDate = new DateTime(2023, 12, 1),
            Author = Authors[0],
            Tags = new List<Tag> { Tags[0] }
        },
        new Article
        {
            ArticleId = 2,
            Title = "Healthy Living Tips",
            Content = "Discover how to live a healthier and more balanced life.",
            PublishDate = new DateTime(2023, 11, 15),
            Author = Authors[1],
            Tags = new List<Tag> { Tags[1], Tags[2] }
        },
        new Article
        {
            ArticleId = 3,
            Title = "The Rise of Remote Work",
            Content = "Exploring the benefits and challenges of working remotely.",
            PublishDate = new DateTime(2023, 10, 10),
            Author = Authors[0],
            Tags = new List<Tag> { Tags[0], Tags[2] }
        }
    };
}