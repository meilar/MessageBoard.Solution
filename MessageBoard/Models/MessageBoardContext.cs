using Microsoft.EntityFrameworkCore;

namespace MessageBoard.Models
{
    public class MessageBoardContext : DbContext
    {
        public MessageBoardContext(DbContextOptions<MessageBoardContext> options)
            : base(options)
        {
        }

        public DbSet<Message> Messages {get; set;}

        protected override void OnModelCreating(ModelBuilder Builder)
        {
          Builder.Entity<Message>()
            .HasData(
              new Message {MessageId = 1, Author = "Sam Murk", Body = "A blog post about the challenges of working outside the box, and creating something unique"},
              new Message {MessageId = 2, Author = "Matthew Elderberry", Body = "The most extra ordinary blog you've ever come across"},
              new Message {MessageId = 3, Author = "Tim Roth", Body = "As borring as it gets. You do not want to read this!"},
              new Message {MessageId = 4, Author = "Jane Pickered", Body = "If I was a fruit I would ne a mango"},
              new Message {MessageId = 5, Author = "Victoria fincert", Body = "Please trust yourself. No one knows you better than yourself"}
            );
        }
    }
}