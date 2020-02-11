using System;
using Xunit;

namespace XamarinDtoApp.Tests
{
    public class AutomapperValidationTest
    {
        [Fact]
        public void AppBoostrapper_ValidateMapping_AssertCorrectness()
        {
            var mapper = AppBootstrapper.CreateMapper();
            mapper.ConfigurationProvider.AssertConfigurationIsValid();
        }
    }
}
