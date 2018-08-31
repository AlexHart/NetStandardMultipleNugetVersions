using LocalLibrariesConsumer;
using System;
using Xunit;

namespace UnitTests
{
    public class NewtonsoftTests
    {
        const string expected = "\"2018-01-01T00:00:00\"";
        DateTime date = new DateTime(2018, 1, 1);

        [Fact]
        public void CallOldImplementation()
        {
            // Act.
            var res = Serializer.OldSerializer(date);

            // Assert.
            Assert.Equal(expected, res);
        }

        [Fact]
        public void CallNewImplementation()
        {
            // Act.
            var res = Serializer.NewSerializer(date);

            // Assert.
            Assert.Equal(expected, res);
        }
    }
}
