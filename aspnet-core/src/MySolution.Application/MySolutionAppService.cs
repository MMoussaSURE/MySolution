using System;
using System.Collections.Generic;
using System.Text;
using MySolution.Localization;
using Volo.Abp.Application.Services;

namespace MySolution;

/* Inherit your application services from this class.
 */
public abstract class MySolutionAppService : ApplicationService
{
    protected MySolutionAppService()
    {
        LocalizationResource = typeof(MySolutionResource);
    }
}
