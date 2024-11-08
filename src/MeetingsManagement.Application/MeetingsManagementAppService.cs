using System;
using System.Collections.Generic;
using System.Text;
using MeetingsManagement.Localization;
using Volo.Abp.Application.Services;

namespace MeetingsManagement;

/* Inherit your application services from this class.
 */
public abstract class MeetingsManagementAppService : ApplicationService
{
    protected MeetingsManagementAppService()
    {
        LocalizationResource = typeof(MeetingsManagementResource);
    }
}
