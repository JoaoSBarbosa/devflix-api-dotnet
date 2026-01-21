using DevFlix.Domain.Entities;

namespace DevFlix.UnitTests.Domain.Entities.Categories.Helpers
{
    public static class CategoryTestFixture
    {

        public static Category CreateValid(string? name, string? description) => new Category( name ?? "Categoria Teste", description ?? "Descrição da categoria teste");
    }
}
