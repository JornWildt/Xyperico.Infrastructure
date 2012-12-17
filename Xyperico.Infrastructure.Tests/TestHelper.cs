//using Xyperico.Authentication.Tests.Builders;


namespace Xyperico.Infrastructure.Tests
{
  public class TestHelper : Xyperico.Base.Testing.TestHelper
  {
    //protected IUserNameValidator UserNameValidator = new FilebasedUserNameValidator();


    protected override void TearDown()
    {
      base.TestFixtureTearDown();
    }
  }
}
