using Volo.Abp.Modularity;

namespace MeetingsManagement;

[DependsOn(
    typeof(MeetingsManagementApplicationModule),
    typeof(MeetingsManagementDomainTestModule)
)]
public class MeetingsManagementApplicationTestModule : AbpModule
{

}
