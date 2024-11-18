using ManageProducts.Forms.ValidateForm;
using Xunit;

namespace ManageProducts.Tests
{
    public class TestFormManageProducts
    {
        /*
         Testes para validação dos formulários de produtos.
        Validação que é usada para inserir e alterar produtos
         */
        [Fact]
        public void Success()
        {
            //Arrange
            string name = "Smartphone";
            string price = "1200";
            string stock = "10";

            //Act
            var formvalidation = ValidateFormProduct.ExecuteValidate(
                name: name,
                price: price,
                stock: stock
                );

            //Assert
            Assert.True(formvalidation.Length == 0, "Nenhum erro encontrado");
        }
        [Fact]
        public void ErrorNameIsEmpty()
        {
            //Arrange
            string name = "";
            string price = "1200";
            string stock = "10";

            //Act
            var formvalidation = ValidateFormProduct.ExecuteValidate(
                name: name,
                price: price,
                stock: stock
                );

            //Assert
            Assert.Contains("Nome é obrigatório", formvalidation.ToString());
        }
        [Fact]
        public void ErrorPriceIsEmpty()
        {
            //Arrange
            string name = "Smartphone";
            string price = "";
            string stock = "10";

            //Act
            var formvalidation = ValidateFormProduct.ExecuteValidate(
                name: name,
                price: price,
                stock: stock
                );

            //Assert
            Assert.Contains("Preço é obrigatório", formvalidation.ToString());
        }
        [Fact]
        public void ErrorStockIsEmpty()
        {
            //Arrange
            string name = "Smartphone";
            string price = "1200";
            string stock = "";

            //Act
            var formvalidation = ValidateFormProduct.ExecuteValidate(
                name: name,
                price: price,
                stock: stock
                );

            //Assert
            Assert.Contains("Estoque é obrigatório", formvalidation.ToString());
        }
        [Fact]
        public void ErrorStockIsGreaterThanZero()
        {
            //Arrange
            string name = "Smartphone";
            string price = "1200";
            string stock = "0";

            //Act
            var formvalidation = ValidateFormProduct.ExecuteValidate(
                name: name,
                price: price,
                stock: stock
                );

            //Assert
            Assert.Contains("Estoque tem que ser maior que zero", formvalidation.ToString());
        }
    }
}
