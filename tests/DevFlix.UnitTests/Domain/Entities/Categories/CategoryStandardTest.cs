using DevFlix.Domain.Entities;
using DevFlix.UnitTests.Domain.Entities.Categories.Helpers;
using System.Xml.Linq;
using Xunit;

namespace DevFlix.UnitTests.Domain.Entities.Categories
{
    public class CategoryStandardTest
    {

        [Fact(DisplayName ="Deve criar uma categoria válida")]
        [Trait("Domain","Category - Aggregates")]
        public void Constructor_WithValidData_ShouldCreateCategory()
        {
            // Arrange ( dados iniciais)
            var name = "Eletronicos";
            var description = "Monitor LED 23 polegadas";

            var dateTimeBeforeCreation = DateTime.UtcNow;

            // act (ação)
            var category = CategoryTestFixture.CreateValid(name, description);
            var dateTimeAfterCreation = DateTime.UtcNow;

            CategoryAssertions.ShouldBeCreatedCorrectly(category,
                                                        name,
                                                        description,
                                                        dateTimeBeforeCreation,
                                                        dateTimeAfterCreation);


        }
    }
}
