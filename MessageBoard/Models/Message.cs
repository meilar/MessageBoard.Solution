using System;
using Swashbuckle.AspNetCore.Annotations;

namespace MessageBoard.Models
{
  [SwaggerSchema(Required = new[] { "Description "})]
  public class Message
  {
    public Message()
    {
      DatePublished = DateTime.Now;
    }
    [SwaggerSchema("Unique message ID number")]
    public int MessageId {get; set;}

    [SwaggerSchema("The author of the message")]
    public string Author {get; set;}

    [SwaggerSchema("The body text of the message")]
    public string Body {get; set;}

    [SwaggerSchema("The date the message was published", Format = "date")]
    public DateTime DatePublished {get; set;}

  }
}