using Xunit;
using System;
using System.IO;
using NFluent;

namespace FoodPricer.Tests;

public class MealNameTests
{
  [Fact]
  public void should_return_name_on_non_empty_string()
  {
    var testedName = MealName.create().value("oui").build();
    Check.That(testedName.Value).IsEqualTo("oui");
  }

  [Fact]
  public void should_throw_exception_on_other_than_yes_or_no()
  {
    Assert.Throws<BadParameterException>(() => MealName.create().value("").build());
  }
}