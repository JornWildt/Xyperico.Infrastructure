namespace Xyperico.Infrastructure.Templating
{
  public interface ITemplateRepository
  {
    Template GetByName(string templateName, string language = null);
  }
}
