using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OnlineShop.Controllers;
using OnlineShop.Data;
using OnlineShop.Repositories;

namespace OnlineShop.Tests
{
    [TestClass]
    public class CategoryControllerTest
    {

        private CategoryController _controller;
        private readonly Mock<IRepository<Category>> _repositoryMock;

        public CategoryControllerTest()
        {
            _repositoryMock = new Mock<IRepository<Category>>();
            _controller = new CategoryController(_repositoryMock.Object);
        }

        [TestMethod]
        public void CanGetExistingUser() {
	        const int id = 1;
	        _repositoryMock.Setup(mock => mock.Get(id)).Returns(new Category() {
		        Id = 1,
				Name = "Category"
	        });

			var actual = _controller.Get(id);

			_repositoryMock.Verify(mock => mock.Get(id), Times.Exactly(1));

            Assert.IsNotNull(actual);
			Assert.IsInstanceOfType(actual, typeof(OkResult));
        }


		//ToDo: test for return BadRequest of Category not found

		//ToDo: test to check that existing category could be updated

		//ToDo: test to check that unexisted category could not be updated - bad request returned

		//ToDo: fix controllers to make test passing
	}
}
