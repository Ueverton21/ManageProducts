using ManageProducts.Forms.Entities;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

namespace ManageProducts.Forms.Data
{
    public class DbHelper
    {
        private string _connectionString;
        public DbHelper()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["PostgresConnection"].ConnectionString;
        }
        public List<Product> GetProducts()
        {
            List<Product> listProducts = new List<Product>();
            DataTable productsTable = new DataTable();
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM product";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        // Execute a consulta e preencha o DataTable
                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            adapter.Fill(productsTable);
                        }
                    }
                    //Percorrer o DataTable e montar a lista de produtos
                    foreach (DataRow product in productsTable.Rows) {
                        Console.WriteLine(product["Name"].ToString());
                        listProducts.Add(new Product
                        {
                            Name = product["Name"].ToString(),
                            Description = product["Description"].ToString(),
                            Id = Int32.Parse(product["Id"].ToString()),
                            Price = Math.Round(Decimal.Parse(product["Price"].ToString()),2),
                            Stock = Int32.Parse(product["Stock"].ToString())
                        });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao ler produtos: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
            return listProducts;
        }
        //Retorna um booleano para sinalizar que foi inserido(true) ou erro(false)
        public bool AddProduct(Product product) {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"INSERT INTO product(name,description,price,stock) 
                                    VALUES(@name,@description,@price,@stock)";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name",product.Name);
                        command.Parameters.AddWithValue("@description", product.Description);
                        command.Parameters.AddWithValue("@price", product.Price);
                        command.Parameters.AddWithValue("@stock", product.Stock);

                        command.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao inserir produto: {ex.Message}");
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        //Deletar produto, retorna true em caso de sucesso e false em caso de erro
        public bool DeleteProduct(int id)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"DELETE FROM Product WHERE Id = @Id";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        //Caso não afete nenhuma linha,
                        //significa que não foi encontrado produto com esse id
                        var rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao excluir produto: {ex.Message}");
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public bool UpdateProduct(Product product)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"UPDATE product SET
                                    name=@name,
                                    description=@description,
                                    stock=@stock,
                                    price=@price
                                    WHERE id = @id";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", product.Id);
                        command.Parameters.AddWithValue("@name", product.Name);
                        command.Parameters.AddWithValue("@description", product.Description);
                        command.Parameters.AddWithValue("@stock", product.Stock);
                        command.Parameters.AddWithValue("@price", product.Price);

                        command.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao editar produto: {ex.Message}");
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public List<Client> GetClients()
        {
            List<Client> listClients = new List<Client>();
            DataTable clientsTable = new DataTable();
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM clients";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        // Execute a consulta e preencha o DataTable
                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            adapter.Fill(clientsTable);
                        }
                    }
                    //Percorrer o DataTable e montar a lista de clientes
                    foreach (DataRow product in clientsTable.Rows)
                    {
                        listClients.Add(new Client
                        {
                            Name = product["Name"].ToString(),
                            Address = product["Address"].ToString(),
                            Id = Int32.Parse(product["Id"].ToString()),
                            Email = product["Email"].ToString(),
                            Phone = product["Phone"].ToString()
                        });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao ler clientes: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
            return listClients;
        }
        //Retorna um booleano para sinalizar que foi inserido(true) ou erro(false)
        public bool AddClient(Client client)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"INSERT INTO clients(name,address,phone,email) 
                                    VALUES(@name,@address,@phone,@email)";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", client.Name);
                        command.Parameters.AddWithValue("@address", client.Address);
                        command.Parameters.AddWithValue("@phone", client.Phone);
                        command.Parameters.AddWithValue("@email", client.Email);

                        command.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao inserir cliente: {ex.Message}");
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public bool DeleteClient(int id)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"DELETE FROM Clients WHERE Id = @Id";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        //Caso não afete nenhuma linha,
                        //significa que não foi encontrado produto com esse id
                        var rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao excluir cliente: {ex.Message}");
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public bool UpdateClient(Client client)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"UPDATE clients SET
                                    name=@name,
                                    address=@address,
                                    phone=@phone,
                                    email=@email
                                    WHERE id = @id";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", client.Id);
                        command.Parameters.AddWithValue("@name", client.Name);
                        command.Parameters.AddWithValue("@address", client.Address);
                        command.Parameters.AddWithValue("@phone", client.Phone);
                        command.Parameters.AddWithValue("@email", client.Email);
                         
                        command.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao editar cliente: {ex.Message}");
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public List<Sale> GetSales()
        {

            List<Sale> listSales = new List<Sale>();
            DataTable salesTable = new DataTable();
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM sales";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        // Execute a consulta e preencha o DataTable
                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            adapter.Fill(salesTable);
                        }
                    }
                    //Percorrer o DataTable e montar a lista de clientes
                    foreach (DataRow product in salesTable.Rows)
                    {
                        listSales.Add(new Sale
                        {
                            ClientId = Int32.Parse(product["ClientId"].ToString()),
                            ProductId = Int32.Parse(product["ProductId"].ToString()),
                            Id = Int32.Parse(product["Id"].ToString()),
                            Quantity = Int32.Parse(product["Quantity"].ToString()),
                            SaleDate = DateTime.Parse(product["SaleDate"].ToString())
                        });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao ler clientes: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
            return listSales;
        }
        public bool AddSale(Sale sale)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"INSERT INTO sales(clientid, productid, quantity, saledate) 
                                    VALUES(@clientid,@productid,@quantity,@saledate)";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@clientid", sale.ClientId);
                        command.Parameters.AddWithValue("@productid", sale.ProductId);
                        command.Parameters.AddWithValue("@quantity", sale.Quantity);
                        command.Parameters.AddWithValue("@saledate", sale.SaleDate);

                        command.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao inserir venda: {ex.Message}");
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }

}
