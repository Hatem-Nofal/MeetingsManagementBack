using Volo.Abp.Modularity;

namespace MeetingsManagement;

[DependsOn(
    typeof(MeetingsManagementDomainModule),
    typeof(MeetingsManagementTestBaseModule)
)]
public class MeetingsManagementDomainTestModule : AbpModule
{

}
