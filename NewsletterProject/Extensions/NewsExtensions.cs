using System;
using System.Collections.Generic;
using NewsletterProject.Extensions.Interface;

namespace NewsletterProject.Extensions
{
    public static class NewsExtensions
    {
        public static bool IsValidTitle(this string title, List<ITitleRules> rules)
        {
            foreach (var item in rules)
            {
                if (!item.CheckRule(title))
                    return false;      
            }
            return true;
            
        }

        public static bool IsValidContent(this string content, List<IContentRules> rules)
        {
            foreach (var item in rules)
            {
                if (!item.CheckRule(content))
                    return false;
            }
            return true;
        }

    }
}
