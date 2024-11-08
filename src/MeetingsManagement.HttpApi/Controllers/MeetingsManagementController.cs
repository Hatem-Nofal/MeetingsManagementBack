using MeetingsManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MeetingsManagement.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MeetingsManagementController : AbpControllerBase
{
    protected MeetingsManagementController()
    {
        LocalizationResource = typeof(MeetingsManagementResource);
    }
}
