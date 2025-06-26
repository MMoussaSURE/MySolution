using MySolution.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MySolution.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MySolutionController : AbpControllerBase
{
    protected MySolutionController()
    {
        LocalizationResource = typeof(MySolutionResource);
    }
}
