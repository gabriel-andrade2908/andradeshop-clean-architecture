using AndradeShop.Core.Domain.Helperrs.Extensions;
using Xunit;

namespace AndradeShop.Core.Domain.Tests.Unit.FakeEntites
{
    public class HelperTests
    {


        [Trait("Categoria", "Helpers")]
        [Fact(DisplayName = "String format to search - success")]
        public void Entity_Create_Success()
        {
            var name = "Gábriel Barcelos";
            var searchableName = "gabriel barcelos";

            Assert.Equal(name.ToSerachable(), searchableName);
        }
    }
}
