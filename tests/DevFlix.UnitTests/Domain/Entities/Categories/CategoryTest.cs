using DevFlix.Domain.Entities;
using Xunit;

namespace DevFlix.UnitTests.Domain.Entities.Categories
{
    public class CategoryTest
    {

        [Fact(DisplayName ="Deve criar uma categoria válida")]
        [Trait("Domain","Category - Aggregates")]
        public void Constructor_WithValidDate_ShouldCreateCategory()
        {
            // Arrange ( dados iniciais)
            var name = "Categoria Teste";
            var description = "Descrição da Categoria Teste";

     
            // act (ação)
            var category = new Category(name, description);

            // assert (verificação)
            Assert.NotNull(category);
            Assert.Equal(name, category.Name);
            Assert.Equal(description, category.Description);
           

        }
    }
}
