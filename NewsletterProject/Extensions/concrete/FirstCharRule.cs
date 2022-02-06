using System;
using NewsletterProject.Extensions.Interface;

namespace NewsletterProject
{
    public class FirstCharRule:ITitleRules
    {
        public bool CheckRule(string title)
        {
            return true;
        }
    }
}
