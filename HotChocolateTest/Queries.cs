namespace HotChocolateTest

{
  class Message
  {
    public string Text { get; set; }
  }

  class QuitMessage : Message
  {
    public string Reason { get; set; }
  }

  class Robot : User
  {
    public string Bleep { get; set; }
  }

  class User
  {
    public string Name { get; set; }
    public IQueryable<Message> Messages { get; set; }
  }

  class QueryType
  {
    public IEnumerable<Message> GetMessages()
    {
      throw new NotImplementedException();
    }
  }
}
