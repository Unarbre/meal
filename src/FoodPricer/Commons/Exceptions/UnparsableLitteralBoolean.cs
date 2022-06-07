namespace FoodPricer {

  using System;
  
  public class UnparsableLitteralBoolean: Exception {
    public UnparsableLitteralBoolean()
    {
    }

    public UnparsableLitteralBoolean(string message)
        : base(message)
    {
    }

    public UnparsableLitteralBoolean(string message, Exception inner)
        : base(message, inner)
    {
    }
  }
}

