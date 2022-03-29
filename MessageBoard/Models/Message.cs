using System;

namespace MessageBoard.Models
{
  public class Message
  {
    public Message()
    {
      DatePublished = DateTime.Now;
    }
    public int MessageId {get; set;}
    public string Author {get; set;}
    public string Body {get; set;}
    public DateTime DatePublished {get;}

  }
}