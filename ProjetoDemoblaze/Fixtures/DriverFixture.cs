using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Demoblaze.Fixtures
{
    [CollectionDefinition("Chrome Driver")]
    public class DriverFixture : ICollectionFixture<Home>
    {
    }
}
