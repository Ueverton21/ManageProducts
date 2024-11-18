using System;
using System.Text;

namespace ManageProducts.Forms.ValidateForm
{
    public static class ValidateFormProduct
    {
        public static StringBuilder ExecuteValidate(string name, string price,string stock)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(stock))
            {
                errors.Append("Estoque é obrigatório\n");
            }
            else if (Int32.Parse(stock) <= 0)
            {
                errors.Append("Estoque tem que ser maior que zero\n");
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                errors.Append("Nome é obrigatório\n");
            }
            if (string.IsNullOrWhiteSpace(price))
            {
                errors.Append("Preço é obrigatório\n");
            }

            return errors;
        }
    }
}
