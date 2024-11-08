using Microsoft.Extensions.Localization;
using MeetingsManagement.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MeetingsManagement;

[Dependency(ReplaceServices = true)]
public class MeetingsManagementBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<MeetingsManagementResource> _localizer;

    public MeetingsManagementBrandingProvider(IStringLocalizer<MeetingsManagementResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
