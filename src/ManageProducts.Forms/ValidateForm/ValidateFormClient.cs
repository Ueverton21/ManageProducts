using System.Text;

namespace ManageProducts.Forms.ValidateForm
{
    public static class ValidateFormClient
    {
        public static StringBuilder ExecuteValidate(string name, string address,string email, string phone)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(name))
            {
                errors.Append("Nome é obrigatório\n");
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                errors.Append("Endereço é obrigatório\n");
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                errors.Append("Email é obrigatório\n");
            }
            if (string.IsNullOrWhiteSpace(phone))
            {
                errors.Append("Telefone é obrigatório\n");
            }

            return errors;
        }
    }
}
