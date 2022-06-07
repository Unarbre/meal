
namespace FoodPricer {
  public class MealName {
    public string Value {get; private set;}


    private MealName(string value) {
      this.Value = value;
    }

    public static MealNameBuilder create() 
    {
      return new MealNameBuilder();
    }


    public class MealNameBuilder {

      private string _value;

      public MealNameBuilder() {
        
      }

      public MealNameBuilder value(string value) {
        if (string.IsNullOrEmpty(value)) throw new BadParameterException(value);
        this._value = value;
        return this;
      }

      public MealName build() {
        if (_value == null) throw new MissingParameterException("value");
        return new MealName(_value);
      }
    }
  }
}