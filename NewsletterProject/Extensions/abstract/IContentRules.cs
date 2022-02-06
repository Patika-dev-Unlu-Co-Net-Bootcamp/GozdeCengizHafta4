using System;
namespace NewsletterProject.Extensions.Interface
{
    public interface IContentRules
    {
        bool CheckRule(string content);
    }
}
