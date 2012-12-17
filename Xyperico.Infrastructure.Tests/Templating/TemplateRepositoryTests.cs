using NUnit.Framework;
using Xyperico.Infrastructure.Templating;


namespace Xyperico.Infrastructure.Tests.Templating
{
  [TestFixture]
  public class TemplateRepositoryTests : TestHelper
  {
    ITemplateRepository TemplateService = new FilebasedTemplateRepository();


    [Test]
    public void CanLoadTemplateByName()
    {
      Template t = TemplateService.GetByName("T1");
    }
  }
}
