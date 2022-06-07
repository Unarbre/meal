namespace FoodPricer {
  public class LitteralBoolean {

    public bool Value {get; private set;}

    private LitteralBoolean(bool value) {
      this.Value = value;
    }

    public static LitteralBooleanBuilder create() {
      return new LitteralBooleanBuilder();
    }

    public class LitteralBooleanBuilder {

      private Boolean _value;

      public LitteralBooleanBuilder() {
        
      }

      public LitteralBooleanBuilder value(string value) {
         switch (value) {
          case "yes": 
             _value = true;
            break;
          case "no": 
             _value = false;
             break;
          default: throw new UnparsableLitteralBoolean(value);
        }
        return this;
      }

      public LitteralBoolean build() {
        if (_value == null) throw new MissingParameterException("value");
        return new LitteralBoolean(_value);
      }
    }
  }
}