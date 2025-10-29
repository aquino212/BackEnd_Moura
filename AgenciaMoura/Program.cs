string[] nomes = new string[10];
float[] dinheiro = new float[10];
int totalclientes = 0;

int opcao = -1;

do
{
    Console.Clear();
    Console.WriteLine("==== Agencia do VSFN ====");
    Console.WriteLine("==== 1- Cadastrar Cliente ====");
    Console.WriteLine("==== 2- Depositar ====");
    Console.WriteLine("==== 3- Sacar ====");
    Console.WriteLine("==== 4- Transferir ====");
    Console.WriteLine("==== 5- Listar clientes ====");
    Console.WriteLine("==== 0- Sair ====");
    Console.WriteLine("==== Escolha uma opção ====");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine("Encerrando...");
            break;

        case 1:
            CadastrarClientes();
            break;

        case 2:
            Depositardinheiro();
            break;

        case 3:
            SacarDinheiro(); 
            break;
 
        case 4:
            TransferirDinheiro();
            break;        
            
        case 5:
            ListarClientes();
            break;

        default:
            Console.WriteLine("Opção Invalida");
            break;
    }




} while (opcao != 0);

void CadastrarClientes()
{
    Console.WriteLine("== Cadastro do cliente ==");

    if (totalclientes >= 10)
    {
        Console.WriteLine("Limite de cadastros atingido");
        Console.WriteLine("Digite <Enter> para continuar...");
        Console.ReadLine();
        return;
    }

    Console.Write("Digite o nome do cliente: ");
    nomes[totalclientes] = Console.ReadLine();
    
    dinheiro[totalclientes] = 0;

    totalclientes++;
    

    Console.WriteLine("Cliente cadastrado com sucesso, digite <enter> para continuar");
    Console.ReadLine();
}

void Depositardinheiro()
{
    int idcliente = BuscarCliente();
    if (idcliente == -1)
    {
        return;
    }
    Console.Write("Valor para depósito: ");
    float valor = float.Parse(Console.ReadLine());
    dinheiro[idcliente] = valor;
    Console.WriteLine($"Depósito de R$ {valor:F2} realizado");
    
    Console.WriteLine("Digite <Enter> para continuar...");
    Console.ReadLine();
}

void SacarDinheiro()
{
  Console.WriteLine("== Função em desenvolvimento ==");
}

void TransferirDinheiro()
{
  
}

void ListarClientes()
{
    for (int t = 0; t < totalclientes; t++)
    {
        Console.WriteLine($"{t} nome - {nomes[t]} dinheiro - R${dinheiro[t]}");
    }
    Console.WriteLine("Digite <Enter> para continuar...");
    Console.ReadLine();



}

int BuscarCliente()
{
    ListarClientes();
    Console.Write("Digite o número do cliente: ");
    int idcliente = int.Parse(Console.ReadLine());
    if (idcliente < 0 || idcliente >= 10)
    {
        Console.WriteLine("Cliente não encontrado");
        return -1;
    }

    return idcliente;
    
}
