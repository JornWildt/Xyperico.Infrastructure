using System;


namespace Xyperico.Infrastructure.Templating
{
  public class FilebasedTemplateRepository : ITemplateRepository
  {
    #region ITemplateRepository Members

    public Template GetByName(string templateName, string language = null)
    {
      throw new NotImplementedException();
    }

    #endregion
  }
}
