Console.WriteLine
    ("Digite 99 a qualquer momento para sair do jogo!");
Thread.Sleep(5000);

Console.Clear();

Console.WriteLine
    ("Qual seu nome jogador?");
    string nome = Console.ReadLine()!;

Console.WriteLine
    ($"Você está feliz, {nome}?");
    Console.ReadLine();
Thread.Sleep(5000);

Rotas[] aventura = new Rotas[30];

aventura[0] = new Rotas
{
    Texto = $"Este é o Complexo Platina. Uma metrópole futurista controlada por um computador manipulador, que se comporta como um tirano. Totalmente paranoico, o Computador vê traidores em toda parte e zela pela felicidade dos cidadãos - nem que para isso precise matar todos! Você é feliz {nome}?\nNão?! ZIOUF! Você foi desintegrado, um clone está vindo substituí-lo...\n\nO Complexo Platina é completamente fechado, sem regiões ao ar livre. Um vasto labirinto de corredores coloridos. As pessoas são classificadas por cores que determinam seus níveis de segurança, de acordo com os critérios do Computador. Desobedecer a um cidadão de Nível de Segurança maior que o seu, é traição. Pertencer a uma sociedade secreta é traição. Traição é punida com a morte.\n\nO Computador preparou esta aventura-solo para divertir você, cidadão. Tome suas decisões e siga as instruções. Se as instruções levarem você para parte alguma, terá sido uma falha do Computador, mas, como o Computador nunca falha, encontrar falhas é uma traição. Traição é punida com a morte.\n\nTenha uma boa aventura, {nome}. Boa Sorte.\n\nVá para 1.",
    Escolhas = new List<int> { 1 }
};

aventura[1] = new Rotas
{
    Texto = $"{nome} acostume-se com os comando de seu soberano, você não tem voz ou pensamentos, {nome} não existe. Você é Jota Serie-0205, cidadão infravermelho, a mais baixa camada social do Complexo Platina. Trabalha no P&D (Pesquisa e Desenvolvimento), a divisão do Complexo que cria novos inventos para que todos sejam felizes. Lembre-se, a felicidade é obrigatória. Quem não está feliz é um traidor. Você está feliz, cidadão?\n\nSeu trabalho no P&D é simples: realizar trabalho escravo para os cientistas e servir de cobaia para seus experimentos, que geralmente explodem na sua cara. Que felicidade, não é, cidadão?\nHoje, chegando ao local de trabalho, você recebe de seu chefe, ZECA G-JUM 2, um envelope preto (a única cor que você pode manusear - para cidadãos de Nível Infravermelho, tocar em um objeto de qualquer outra cor é traição). Zeca diz que perdeu uma chave ALF e você deve ir buscar outra para ele na Produção, Logística e Comissariado.\n\nVá para 33.",
    Escolhas = new List<int> { 30 }
};

int indiceEntradaAtual = 0;
while (indiceEntradaAtual >= 0 || indiceEntradaAtual <= 30)
{
    Console.Clear();

    Rotas entradaAtual = aventura[indiceEntradaAtual];
    Console.WriteLine($"--- {indiceEntradaAtual} ---\n{entradaAtual.Texto}\n");
    int indiceDesejado = -1;
    do
    {
        Console.Write("Seguir para: ");
        try
        {
            indiceDesejado = Convert.ToInt32(Console.ReadLine());
        }
        catch { }
    }
        while (!entradaAtual.Escolhas.Contains(indiceDesejado) || indiceDesejado != 99);
    
    indiceEntradaAtual = indiceDesejado;

    if (indiceEntradaAtual == 99)
    {
        Console.WriteLine("Fim!\nSinta-se livre para jogar novamente\nObrigada!");
    }
}