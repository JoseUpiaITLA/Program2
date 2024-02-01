
namespace Program2
{
    public class Bank
    {
        private List<Client> clients = new List<Client>();

        public Bank()
        {
            this.clients.Add(new Client(1, "Jose", 500));
            this.clients.Add(new Client(2, "Maria", 900));
            this.clients.Add(new Client(3, "Luis", 10));
        }

        public string DepositOrExtraction(int idClient, int amount, BankTransaction bankTransaction)
        {
            try
            {
                Client client = this.clients.Find(c => c.Id == idClient);
                if (client == null)
                    return "Cliente no encontrado";

                if (client.Amount < amount && bankTransaction == BankTransaction.Extraction)
                    return $"El cliente {client.Name} no tiene fondos suficientes";

                client.Amount = bankTransaction == BankTransaction.Deposit
                    ? client.Amount + amount
                    : client.Amount - amount;


                return $"\n{(bankTransaction == BankTransaction.Deposit ? "Deposito" : "Extraccion")} exitoso \nCliente: {client.Name} \nMonto: {client.Amount}";
            }
            catch (Exception ex)
            {
                return $"Error al depositar: {ex.Message}";
            }
        }

        public string DepositedMoney()
        {
            return $"Monto total depositado: {clients.Sum(c => c.Amount)}";
        }
    }
}
