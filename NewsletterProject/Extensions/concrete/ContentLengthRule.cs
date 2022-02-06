using System;
using NewsletterProject.Extensions.Interface;

namespace NewsletterProject
{
    public class ContentLengthRule:IContentRules
    {
        public bool CheckRule(string content)
        {
            return true;
        }
    }
}
