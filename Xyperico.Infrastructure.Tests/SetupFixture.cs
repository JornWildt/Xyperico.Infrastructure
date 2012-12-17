using NUnit.Framework;
using Xyperico.Base;
using Xyperico.Base.Collections;


namespace Xyperico.Infrastructure.Tests
{
  [SetUpFixture]
  public class SetupFixture
  {
    public static void Setup(IObjectContainer container)
    {
      //Xyperico.Authentication.MongoDB.Utility.Initialize(container);

      //container.AddComponent<INameValueContextCollection, CallContextNamedValueCollection>();
      //container.AddComponent<IUserBuilder, UserBuilder>();
      //container.AddComponent<IUserNameValidator, FilebasedUserNameValidator>();
    }


    [SetUp]
    public void TestSetup()
    {
      Xyperico.Base.Testing.TestHelper.ClearObjectContainer();
      Setup(Xyperico.Base.Testing.TestHelper.ObjectContainer);
    }
  }
}
