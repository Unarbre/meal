using Xunit;
using System;
using System.IO;
using NFluent;

namespace FoodPricer.Tests;

public class LitteralBooleanTests
{
  [Fact]
  public void should_return_true_on_yes_parameter()
  {
    var testedBoolean = LitteralBoolean.create().value("yes").build();
    Check.That(testedBoolean.Value).IsEqualTo(true);
  }

  [Fact]
  public void should_return_false_on_no_parameter()
  {
    var testedBoolean = LitteralBoolean.create().value("no").build();
    Check.That(testedBoolean.Value).IsEqualTo(false);
  }

  [Fact]
  public void should_throw_exception_on_other_than_yes_or_no()
  {
    Assert.Throws<UnparsableLitteralBoolean>(() => LitteralBoolean.create().value("daoui").build());
  }
}