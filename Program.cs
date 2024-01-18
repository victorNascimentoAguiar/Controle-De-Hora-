bool exibirMenu = true;
string opcao;
List<string>agenda = new List<string>();
Console.WriteLine("sua agenda ");
while(exibirMenu)
{
    Console.WriteLine("1-adicionar  item na agenda");
    Console.WriteLine("2-remover item da agenda");
    Console.WriteLine("3-mostrar agenda");
    Console.WriteLine("4-encerrar programa");

    opcao = Console.ReadLine();
    switch(opcao)
    {
        case "1":
            Console.WriteLine("adicionando item!");
            string input = Console.ReadLine();
            agenda.Add(input);
            if (string.IsNullOrWhiteSpace(input))
            Console.WriteLine("item invalido");
            break;

        case "2":
            Console.WriteLine("removendo item da agenda!!");
            string remover = Console.ReadLine();
            
            if(agenda.Contains(remover))
            {
                agenda.Remove(remover);
                Console.WriteLine($"item {remover} saiu da agenda");
            }
            else
            {
                Console.WriteLine("item não encontrado na agenda");
            }
            break;

        case "3":
            Console.WriteLine("abrindo agenda!!!");
            foreach(string item in agenda)
            {
                Console.WriteLine(item);
            }
            break;

        case "4":
            Console.WriteLine("encerrando o programa.......");
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("comando invalido");
            break;

    }
}
