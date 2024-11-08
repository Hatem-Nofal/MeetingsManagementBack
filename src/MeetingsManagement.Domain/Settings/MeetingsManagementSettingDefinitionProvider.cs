using Volo.Abp.Settings;

namespace MeetingsManagement.Settings;

public class MeetingsManagementSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MeetingsManagementSettings.MySetting1));
    }
}
