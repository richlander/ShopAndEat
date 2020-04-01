using DataLayer.EfClasses;
using DTO;
using DTO.MealType;
using FluentAssertions;
using NUnit.Framework;
using ServiceLayer.Concrete;

namespace Tests.UnitTests.ServiceLayer
{
    [TestFixture]
    public class MealTypeServiceTests
    {
        [Test]
        public void CreateMealType()
        {
            using var context = new InMemoryDbContext();
            var testee = new MealTypeService(new SimpleCrudHelper(context, new Mapper().CreateMapper()));
            var newMealTypeDto = new NewMealTypeDto("Lunch");

            testee.CreateMealType(newMealTypeDto);

            context.MealTypes.Should().Contain(x => x.Name == "Lunch");
        }

        [Test]
        public void DeleteMealType()
        {
            using var context = new InMemoryDbContext();
            var existingMealType = context.MealTypes.Add(new MealType("Lunch"));
            context.SaveChanges();
            var testee = new MealTypeService(new SimpleCrudHelper(context, new Mapper().CreateMapper()));
            var deleteMealTypeDto = new DeleteMealTypeDto(existingMealType.Entity.MealTypeId);

            testee.DeleteMealType(deleteMealTypeDto);

            context.MealTypes.Should().NotContain(x => x.Name == "Lunch");
        }

        [Test]
        public void GetAllMealTypes()
        {
            using var context = new InMemoryDbContext();
            context.MealTypes.Add(new MealType("Lunch"));
            context.MealTypes.Add(new MealType("Breakfast"));
            context.SaveChanges();
            var testee = new MealTypeService(new SimpleCrudHelper(context, new Mapper().CreateMapper()));

            var results = testee.GetAllMealTypes();

            results.Should().Contain(x => x.Name == "Lunch").And.Contain(x => x.Name == "Breakfast");
        }
    }
}