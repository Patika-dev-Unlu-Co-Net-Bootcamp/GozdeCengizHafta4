using System;
using NewsletterProject.Extensions.Interface;

namespace NewsletterProject
{
    public class TitleLengthRule : ITitleRules
    {
        public bool CheckRule(string title)
        {
            int length = title.Length;

            if (length < 5)
            {
                return false;
            }
            else if (length > 15)
            {
                return false;
            }
            else
            {
                return true;
            }
                
        }
    }
}
