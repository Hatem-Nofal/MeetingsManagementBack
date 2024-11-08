using MeetingsManagement.Samples;
using Xunit;

namespace MeetingsManagement.EntityFrameworkCore.Applications;

[Collection(MeetingsManagementTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<MeetingsManagementEntityFrameworkCoreTestModule>
{

}
