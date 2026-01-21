using DevFlix.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DevFlix.UnitTests.Domain.Entities.Categories.Helpers
{
    public static class CategoryAssertions
    {

        public static void ShouldBeCreatedCorrectly(
            Category category, string name, string description, DateTime beforeCreation, DateTime afterCreation)
        {
            AssertBasicData(category, name, description);
            AssertDefaultState(category);
            AssertTimestamps(category, beforeCreation, afterCreation);
        }


        private static void AssertBasicData(Category category, string name, string description)
        {
            Assert.NotNull(category);
            Assert.Equal(name, category.Name);
            Assert.Equal(description, category.Description);
        }

        private static void AssertDefaultState(Category category)
        {
            Assert.NotEqual(default(Guid), category.Id);
            Assert.NotEqual(default(DateTime), category.CreateDateTime);
            Assert.True(category.IsActive);
        }

        private static void AssertTimestamps(Category category, DateTime beforeCreation, DateTime afterCreation)
        {
            Assert.True(category.CreateDateTime >= beforeCreation);
            Assert.True(category.CreateDateTime <= afterCreation.AddMilliseconds(5));
        }
    }
}
