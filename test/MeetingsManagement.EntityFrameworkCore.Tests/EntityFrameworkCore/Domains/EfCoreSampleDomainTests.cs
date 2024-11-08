using MeetingsManagement.Samples;
using Xunit;

namespace MeetingsManagement.EntityFrameworkCore.Domains;

[Collection(MeetingsManagementTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<MeetingsManagementEntityFrameworkCoreTestModule>
{

}
