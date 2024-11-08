using Xunit;

namespace MeetingsManagement.EntityFrameworkCore;

[CollectionDefinition(MeetingsManagementTestConsts.CollectionDefinitionName)]
public class MeetingsManagementEntityFrameworkCoreCollection : ICollectionFixture<MeetingsManagementEntityFrameworkCoreFixture>
{

}
