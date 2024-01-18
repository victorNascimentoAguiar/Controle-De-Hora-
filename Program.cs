bool exibirMenu = true;
string opcao;
List<string>agenda = new List<string>();
Console.WriteLine("sua agenda ");
while(exibirMenu)
{
    //menu com as opçôes de funções
    Console.WriteLine("1-adicionar  item na agenda");
    Console.WriteLine("2-remover item da agenda");
    Console.WriteLine("3-mostrar agenda");
    Console.WriteLine("4-encerrar programa");

    opcao = Console.ReadLine();//obtendo a informação dada pelo usuario 
    switch(opcao)
    {
        case "1":
        //adicionando item na lista agenda
            Console.WriteLine("adicionando item!");
            string input = Console.ReadLine();
            agenda.Add(input);
            //tratamento de exeções caso o valor seja nulo "   "
            if (string.IsNullOrWhiteSpace(input))
            Console.WriteLine("item invalido");
            break;

        case "2":
        //removendo item da lista agenda
            Console.WriteLine("removendo item da agenda!!");
            string remover = Console.ReadLine();
            //tratamento de exeções caso o item não esteja na agenda
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
        //foreach que vai apresentar a lista agenda
            Console.WriteLine("abrindo agenda!!!");
            foreach(string item in agenda)
            {
                Console.WriteLine(item);
            }
            break;

        case "4":
        //encerrando o programa para que o loop while não fique infinito
            Console.WriteLine("encerrando o programa.......");
            exibirMenu = false;
            break;

        default:
        //tratamento de exeção caso o usuario digite uma opção que não existe
            Console.WriteLine("comando invalido");
            break;

    }
}
