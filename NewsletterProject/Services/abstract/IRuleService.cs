using System;
using System.Collections.Generic;
using NewsletterProject.Extensions.Interface;

namespace NewsletterProject.Services
{
    public interface IRuleService
    {
        List<ITitleRules> GetTitleRules();
    }
}
