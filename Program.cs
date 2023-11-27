Console.WriteLine
    ("Digite 99 a qualquer momento para sair do jogo!");
Thread.Sleep(4000);

Console.Clear();

Console.WriteLine
    ("Qual seu nome jogador?");
string nome = Console.ReadLine()!;

Console.WriteLine
    ($"Você está feliz, {nome}?");
    Console.ReadKey();
Console.WriteLine
    ("\nNão importa!\nÓbvio que está, este é o Complexo Platina, a felicidade é obrigatória!");


Entrada[] aventura = new Entrada[1];

aventura[0] = new Entrada
{
    Texto = "Este é o Complexo Alfa. Uma metrópole futurista controlada por um computador louco, que se comporta como um tirano fascista. Totalmente paranoico, o Computador vê traidores em toda parte e zela pela felicidade dos cidadãos - nem que para isso precise matar todos! Você é feliz cidadão? Não?! ZIOUF! Você foi desintegrado, um clone está vindo substituí-lo...\n\nO Complexo Alfa é completamente fechado, sem regiões ao ar livre. Um vasto labirinto de corredores coloridos. As pessoas são classificadas por cores que determinam seus níveis de segurança, de acordo com os critérios do Computador. Desobedecer a um cidadão de Nível de Segurança maior que o seu, é traição. Ser Comunista é traição (embora você nem faça ideia do que seja um Comunista). Pertencer a uma sociedade secreta é traição. Traição é punida com a morte.\n\nO Computador preparou esta aventura-solo para divertir você, cidadão. Tome suas decisões e siga as instruções. Se as instruções levarem você para parte alguma, terá sido uma falha do Computador, mas, como o Computador nunca falha, encontrar falhas é uma traição. Traição é punida com a morte.\n\nTenha uma boa aventura, cidadão. Boa Sorte.\n\nVá para 1.",
    Alternativas = new List<int> { 1 }
};












class Entrada
{
    public string? Texto;
    public List<int> Alternativas = new();
}

/*

string nome.textcolor(GREEN);

void textcolor(object gREEN)
{
    throw new NotImplementedException();
}

void rgb(int v1, int v2, int v3)
{
    throw nome();
}
rgb(177, 201, 0);



*/