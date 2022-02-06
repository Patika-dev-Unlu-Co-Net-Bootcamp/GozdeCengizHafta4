using System;
using System.Collections.Generic;
using NewsletterProject.Extensions.Interface;

namespace NewsletterProject.Services.concrete
{
    public class TitleService : IRuleService
    {
        

        public List<ITitleRules> GetTitleRules()
        {
            ITitleRules titleRules = new FirstCharRule();
            ITitleRules titleRules1 = new TitleLengthRule();

            List<ITitleRules> titleRulesList = new();

            titleRulesList.Add(titleRules);
            titleRulesList.Add(titleRules1);

            return titleRulesList;
        }
    }
}
