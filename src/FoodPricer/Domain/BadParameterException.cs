namespace FoodPricer {

  using System;
  
  public class BadParameterException: Exception {
    public BadParameterException()
    {
    }

    public BadParameterException(string message)
        : base(message)
    {
    }

    public BadParameterException(string message, Exception inner)
        : base(message, inner)
    {
    }
  }
}


