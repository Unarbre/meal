
namespace FoodPricer {
  public class Meal {
    public MealName Name {get; private set;}


    private Meal(MealName name) {
      this.Name = name;
    }

    public static MealBuilder create() 
    {
      return new MealBuilder();
    }


    public class MealBuilder {
      private MealName _name;
      
      public MealBuilder() {
        
      }

      public MealBuilder name(String name) {
        _name = Name.create().value(name).build();
        return this;
      }

      public Meal build() {
        if (_name == null) throw new MissingParameterException("name");
        return new Meal(name);
      }
    }
  }
}