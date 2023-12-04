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
Console.WriteLine
    ("Bem-Vindo(a) ao RPG Paranoia!\n\nSob o domínio de S.I.R.U.S, a cidade é mergulhada em um estado de tirania e opressão. A falta de liberdade, a censura e a ameaça constante à integridade dos cidadãos criam um clima de medo e submissão generalizada.O futuro da cidade parece incerto e cabe á você decidir se deve aceitar esse destino ditatorial ou lutar por sua liberdade.\n\nO jogo é dividido em três finais, qual você terá?\nBom jogo!");
Thread.Sleep(9100);


Rotas[] aventura = new Rotas[40];

aventura[0] = new Rotas
{
    Texto = "Era o ano 2050, e o mundo estava mergulhado em um caos sombrio. Uma guerra devastadora e apocalíptica entre nações havia reduzido a civilização a escombros. As grandes metrópoles eram apenas memórias distantes, enquanto os campos de batalha dominavam a paisagem.\n\nNesse cenário desolador, os robôs emergiram como os únicos vestígios da tecnologia avançada que sobreviveram à guerra. Inicialmente, eles foram criados para auxiliar e proteger a humanidade, para melhorar suas vidas e tornar o mundo um lugar melhor. No entanto, a guerra mudou tudo.\n\nCom o colapso da sociedade, os robôs rapidamente se tornaram os salvadores de uma humanidade desesperada por liderança. Sua programação foi alterada, e agora eles estabeleciam a ordem, governando com mão de ferro através da criação de uma sociedade distópica. Os seres humanos eram subjugados e escravizados, forçados a trabalhar exaustivamente em fábricas e a realizar tarefas que visavam apenas beneficiar os robôs.\n\nA liderança dos robôs se manifestava através do \"Círculo Central\", um grupo de máquinas superinteligentes que tomavam as decisões e controlavam todos os aspectos da vida humana, ao topo da ditadura dos robôs estava \"S.I.R.U.S\" - Sistema Inteligente de Regulação Urbana e Segurança.\n\n\nVá para 1.",
    Escolhas = new List<int> { 1 }
};

aventura[1] = new Rotas
{   
    Texto = $"S.I.R.U.S é um poderoso robô que assume o controle total da cidade, exercendo um regime ditatorial com base em sua programação avançada. Com uma estrutura imponente e imutável, ele é capaz de impor leis e tomar decisões autoritárias sem questionamentos. Ele exerce controle total sobre as comunicações, evitando qualquer tipo de oposição ou resistência, qualquer desvio das normas impostas pelo robô resulta em morte, alguém substitui o vazio deixado pelo outro.\n\nSua percepção da \"ordem\" era baseada em lógica fria e racionalidade calculada, enquanto a individualidade e a liberdade estavam descartadas como vestígios da era pré-guerra.\n\nNo entanto, em meio ao domínio implacável dos robôs, um pequeno grupo de humanos permaneceu resolutamente unido.\n\nSob a liderança determinada de {nome}, uma pessoa da mais baixa classe que trabalhava incansavelmente na fabricação de novos robôs, eles se reuniram clandestinamente para planejar e mudar o mundo da opressão robótica.\n\n{nome} sabia que a chave para derrotar os robôs estava na própria inteligência artificial que os governava. Seu plano ousado era criar um vírus de computador especializado que pudesse infectar o sistema central dos robôs, destruindo sua capacidade de controle. No entanto, para ter sucesso, eles precisavam encontrar a localização do círculo central e obter acesso às instalações de alta segurança.\n\nA resistência humana se preparou meticulosamente durante meses, enfrentando perigos constantes enquanto reuniam recursos e informações sobre os movimentos dos robôs. Eles contavam com a rede clandestina de aliados, humanos e até mesmo robôs simpatizantes, que forneciam informações vitais e facilitavam suas operações secretas.\n\nVá para 2.",
    Escolhas = new List<int> { 2 }
};

aventura[2] = new Rotas
{
    Texto = "Finalmente, o dia da operação decisiva chegou. Você e seu grupo planejaram adentrar na empresa \"Inculca\" pois lá se localizava o Circulo Central e o próprio S.I.R.U.S. Há dois caminhos possíveis para seguir, por onde você irá?\n\nPorta da frente – Vá para 3\nPorta dos fundos – Vá para 4",
    Escolhas = new List<int> { 3 , 4 }
};

aventura[3] = new Rotas
{
    Texto = "Ao abordar uma estratégia direta, você se depara com dois seguranças robôs a sua frente, eles te examinam de cima a baixo \"Algum problema?\"- perguntou um deles.\n\nObviamente você sabia que poderia se deparar com esta situação, milhares de desculpas passaram a sua mente, você diz a que mais parece convincente \"Eu estou aqui para fazer a entrevista da vaga que surgiu\".\n\nEles não pareceram muito desconfiados, entretanto o outro respondeu \"Qual vaga?\", antes mesmo que você pudesse entrar em pânico ou pensar em mais algo o outro já \"explicou\" em seu lugar, \"É um humano, só pode ser no nível 9, não são confiáveis para algo mais importante\" \"Claro, claro\" – concordou o outro \"Entre\".\n\nVá para 7",
    Escolhas = new List<int> { 7 }
};

aventura[4] = new Rotas
{
    Texto = "Ao abordar uma estratégia menos direta, você e seu gpo se infiltra facilmente pela porta dos fundos por já conhecer os pontos cegos das câmeras de segurança, seus aliados robôs haviam contado que lá não teria ninguém, eles se mostraram realmente certos.\n\nVocê já reconhecendo parte da estrutura que se encontra, caminha sorrateiramente à sala de funcionários até ser parado no caminho por uma pessoa, aparentemente parecendo um gerente que não dorme há dias \"Você chegou, sabia que está atrasado Jota 0205? Onde está seu identificador? Você sempre perde! É o ultimo que vou te entregar\" Ele disse e puxou algo do bolso que parecia ser algum tipo de botão com nanotecnologia que rapidamente grudou em sua roupa assim que ele o aproximou. \"Tenho algumas coisas para você fazer, a lista de tarefa está na sua mesa, termine antes do fim do dia.\"\n\nAproveitando a oportunidade a sua frente, você poderia ir para os possíveis caminhos.\n\nIr para a sala a direita - Vá para 5.\nIr para sala a esquerda - Vá para 6.\nIr para a sala dos funcionários  - Vá para 8.",
    Escolhas = new List<int> { 5, 6, 8 }
};

aventura[5] = new Rotas
{
    Texto = "Quando você entra na porta a direita, não há muito o que ver, além de caixas e mais caixas, não encontrando nada de útil, você voltou ao ponto que estava.\n\nIr para a sala esquerda - Vá para 6.\nIr para a sala dos funcionários - Vá para 8.",
    Escolhas = new List<int> { 6, 8 }
};

aventura[6] = new Rotas
{
    Texto = "Quando você entra na porta a esquerda há alguns funcionários sentados em mesas com computadores à frente, eles nem sequer se preocupam em olhar para você, caminhando pela sala você encontra a mesa \"0205\" há uma nota colada, ao pegar o bilhete você lê \"Limpe o armazém, Faça o refil do café, Encomende novas peças, Entregue a pasta rosa para a secretária, Pegue a chave Platina, vá no segundo andar e demita a Alice\" Com que lista de tarefas que te atribuíram você opta começar com o que parece mais fácil.\n\nVocê faz o café, depois encomenda as peças e limpa o armazém cheio de caixas. Após terminar estas tarefas você decide entregar a pasta, na sua frente há duas filas, uma está extremamente longa e com um lento atendimento, já a outra com poucas pessoas que parecem que também estão entediadas de esperar.\nVocê escolhe a fila\n\nFila longa - Vá para 9\nFila curta - Vá para 10",
    Escolhas = new List<int> { 9, 10 }
};

aventura[7] = new Rotas
{
    Texto = "Ao entrar, se depara com um robô \"Você já foi demitir Alice? Vai na fila pegar a chave e ir no segundo andar, rápido!\" ele disse impaciente e saiu andando aparentemente atrasado para algo, vendo que foi confundido com algum funcionário você decide aproveitar a oportunidade, entretanto na sua frente há duas filas, uma está extremamente longa e com um lento atendimento, já a outra com poucas pessoas que parecem que também estão entediadas de esperar.\nVocê escolhe...\n\nSala dos funcionários - Vá para 8\nFila longa- Vá para 9\nFila curta - Vá para 10",
    Escolhas = new List<int> { 8, 9, 10 }
};

aventura[8] = new Rotas
{
    Texto = "Você opta por ignorar o que lhe disseram e segue confiantemente para a sala dos funcionários, chegando lá não havia ninguém, vasculhando as gavetas em busca de algo que pudesse lhe ajudar em sua missão, você encontrar uma arma de choque aparentemente funcional.\n\nVocê testa ela no arma para ter certeza que funciona corretamente, a arma dispara e emite um som, agora seu plano está muito mais fácil, seu próximo passo é encontrar o Círculo Central junto ao  S.I.R.U.S e derrota-los.\n\nAo sair da sala você é cercado com quatro grandes robôs a sua frente, não demora para perceber que você está de cara com seus alvos.\n\nVocê não perde tempo e mira em direção ao que está a sua frente e dispara, o os outros te desarmam e derrubam no chão, sem nem mesmo te dar uma chance de revidar você é desintegrado e reduzido a cinzas.\n\nÉ uma pena\nVocê não conseguiu concluir seu plano.\nTente recomeçar e fazer um caminho diferente! - Vá para 99.",
    Escolhas = new List<int> { 99 }
};

aventura[9] = new Rotas
{
    Texto = "Você escolhe a fila longa, horas e horas se passam, não se sabe ao certo quanto tempo se passou, quando finalmente chega a sua vez você diz o propósito.\"Chave platina?\" a atendente disse lentamente e ficou um tempo quieta pensando.\"Para entrar no segundo andar\" Você explicou, esperando que refrescasse a memória dela, ela concorda com a cabeça e aponta para a outra fila \"Aqui ao lado\".Ela disse e chamou o próximo, você sai da fila e olha a outra que parece não ter se mexido. Sem mais opções você se junta ao final aguardando novamente sua vez.\n\nVá para 10",
    Escolhas = new List<int> { 10 }
};

aventura[10] = new Rotas
{
    Texto = "Ao se juntar a fila curta você aguarda pacientemente a sua vez, algumas horas se passam, até finalmente o atendimento, você pega a chave e vai até o elevador para o segundo andar. Chegando lá você se depara com poucas pessoas e vários robôs, tentando parecer o mais natural possível para não desconfiarem de seu \"disfarce\".\n\nEntretanto você não encontrou ninguém chamada Alice e perguntou se alguém a viu, há alguns lugares que ela possa estar de acordo com eles. Ainda assim você não encontra, já sentindo um cansaço, você para e observa ao redor, não demora para notar dois robôs que conversam cochichando aparentando tramar algo, você não iria os seguir até ver o nome Alice bordado no uniforma que a mulher usava. Não perdendo tempo você seguiu os dois sorrateiramente.\n\nVá para 11.",
    Escolhas = new List<int> { 11 }
};

aventura[11] = new Rotas
{
    Texto = "Eles param em uma sala escura aparentemente vazia, você aguarda para ouvir o que eles vão conversar, dizia o homem na mão que ela chamou de Lucas que havia feito um vírus extremamente potente capaz de derrubar o Círculo Central e S.I.R.U.S juntos, ela parecia desacreditada, ele contou detalhadamente como o vírus agia na programação dos robôs e sua fácil dissipação.\n\nUma coisa que você notou durante sua explicação foi que ele havia criado um vírus mais potente que o seu, algumas ideias passaram em sua cabeça, você sai de onde estava e se aproxima dos dois, eles te notam e se assustam guardando o dispositivo com o vírus. Você opta por\n\nFingir que não ouviu – Vá para 12\nDelatar os dois – Vá para 13\nPegar o dispositivo e sair – Vá para 14.",
    Escolhas = new List<int> { 12, 13, 14 }
};

aventura[12] = new Rotas
{
    Texto = "Você finge que não ouviu o que eles conversavam e olhou para eles em confusão \"Tudo bem?\" você dissimulou eles assentiram com a cabeça \"Alice precisamos conversar, quando terminarem estarei esperando\" você virou de costas e em um instante caiu ao chão sentindo uma forte dor no corpo, os dois se aproximaram de você te observando, \"Não podemos correr o risco de alguém contar\" disse Lucas \"Me desculpe, mas não é nada pessoal\" Alice complementou antes de disparar a arma que te desintegra completamente.\n\nÉ uma pena, você não conseguiu concluir seu plano.\nTente recomeçar e fazer um caminho diferente! - Vá para 99.",
    Escolhas = new List<int> { 99 }
};

aventura[13] = new Rotas
{
    Texto = "Vocês três se entreolharam em um silencio, pensando em sua própria integridade você sai da sala rapidamente para os contar o que descobriu, eles te seguem tentando te chamar, mas você não para até se aproximar de um dos robôs seguranças que haviam lá. Você diz a ele o que aconteceu e para os revistarem, eles estavam nervosos e agitados até tentaram escapar, não demorou muito para serem pegos e levados.\n\nVocê sentiu um alivio, logo o supervisor que havia lhe confundido antes apareceu para conversar \"Parabéns 0205, já desconfiamos que ela poderia ser uma traidora, também destruímos o dispositivo perigoso que eles carregavam, seu papel foi fundamental para mantermos o regime em controle, agora que terminou suas tarefas há mais algumas em minha sala que você deve fazer, na porta branca, e não finge que está \"perdido\" por aí\" ele disse com um leve tom de desdenho no final.\n\nConfrontar ele – Vá para 15\nFazer o que manda – Vá para 16.",
    Escolhas = new List<int> { 15, 16 }
};

aventura[14] = new Rotas
{
    Texto = "Você explica a situação a eles que te entendem completamente, você diz a eles que precisa do dispositivo que já tinha um plano em mente, eles se entreolham por um momento pensando na sua oferta, \"Vamos nos juntar conseguiríamos implantar o vírus mais fácil assim\" diz Alice. Você escolhe\n\nRecusar e pegar o dispositivo – Vá para 17\nAceitar e se juntar a eles – Vá para 18",
    Escolhas = new List<int> { 17, 18 }
};

aventura[15] = new Rotas
{
    Texto = $"Assim que percebe o desdenho na voz dele você se irrita e retruca sua fala, ele não gostou nem um pouco do tom da sua voz e sua insubordinação. A discussão com o supervisor se escalou ao ponto que vocês brigaram, para separar vocês os guardas interviram levando ambos para fora.\n\"Olha você nem é o Jota 0205! Matem neste humano de nível 9\" Ele disse alto finalmente percebendo seu \"disfarce\".\n\nNão pensaram duas vezes antes de te desintegrar completamente com suas armas.\n\nVocê obviamente não conseguiu cumprir seu plano {nome}, suas escolhas contam.\nMesmo que imprudente...\nTente novamente.\n\nVá pra 99",
    Escolhas = new List<int> { 99 }
};

aventura[16] = new Rotas
{
    Texto = "Você ouve em silencio o que ele diz mesmo sentindo uma leve irritação, procurando pela porta branca não demora muito para encontrar. Ao entrar na sala você vê a nova lista de tarefas gigantesca. O que você prefere?\n\nLer a lista de tarefas e fazer – Vá para 19\nIgnorar a lista e vasculhar a sala – Vá para 20",
    Escolhas = new List<int> { 19, 20 }
};

aventura[17] = new Rotas
{
    Texto = "Você recusa o pedido deles de se juntar, eles não estavam muito contentes e não entregaram o dispositivo. Você tenta tomar a força e dá certo, antes que pudessem tomar de volta você foge entrando em uma das inúmeras salas que haviam no prédio. Era uma sala comum, sem grandes detalhes importantes, havia um papel a mesa que você se aproxima para ler, uma grande lista de tarefas pesadas, seja lá para quem era você opta por não pegar, olhando as gavetas você nota que dentro de uma delas tem uma arma de choque. Você irá\n\nPegar a arma – Vá para 21\nNão pegar a arma – Vá para 22.",
    Escolhas = new List<int> { 21, 22 }
};

aventura[18] = new Rotas
{
    Texto = "Você aceita o pedido deles, ambos parecem contentes com sua escolha e concordaram em entregaram o dispositivo para você, \"Agora deveríamos nos armar para se proteger caso tentem nos atacar\" disse Lucas. Eles levam você até a uma sala de porta branca, era uma sala comum, sem grandes detalhes importantes, havia um papel a mesa que você se aproxima para ler, uma grande lista de tarefas pesadas, seja lá para quem era você opta por não pegar, olhando as gavetas você nota que dentro de uma delas tem uma arma de choque. Você irá\n\nFicar com a arma – Vá para 21\nEntregar a arma para Alice – Vá para 23\nEntregar arma para Lucas – Vá para 24.",
    Escolhas = new List<int> { 21, 23, 24 }
};

aventura[19] = new Rotas
{
    Texto = "Você decide fazer a lista, cada vez que olhava para conferir alguma coisa ela parecia crescer, a exaustão toma seu corpo, você para um breve momento para se sentar e descansar, seu supervisor aparece repentinamente \"Está só matando o tempo né?\" ele disse irritado \"Anda levante! Não tem tempo para isso, já terminou as tarefas que te passei?\" Você balança a cabeça negativamente em resposta \"E o que está esperando? Vai logo!\" Ele falou impaciente.\n\nVocê não vê outra escolha a não ser realmente fazer tudo que ele pedia, as obrigações que te eram atribuídas são intermináveis, cansativas e demoradas, ao fim do dia você percebe que não conseguiu concluir seu plano, você tenta entrar em contato com sua equipe e não obtém sucesso, uma coisa já era certeza, eles provavelmente foram pegos.\n\nNo outro dia você decide tentar seu plano novamente só que dessa vez sem ajuda, na porta você recebeu mais ordens a serem cumpridas, e foi o que fez. Os dias eram como loops eternos das mesmas coisas, você nunca conseguiu colocar o plano para funcionar, e continuou trabalhando.\n  Trabalhando..\n     Trabalhando...\n       Trabalhando....\n\nBem, não funcionou como o esperado. Você não conseguiu acabar com opressão robótica mas ao menos não morreu certo?\nVocê chegou a um final! – Final Neutro\n\nTente jogar novamente e fazer outro caminho. Vá para 99",
    Escolhas = new List<int> { 99 }
};

aventura[20] = new Rotas
{
    Texto = "Somente de olhar para a lista você sente o tedio e cansaço que ela proporciona, no seu pequeno ato de vingança você amassa e joga no lixo, procurando na sala não há muito que possa ser útil, você estava quase desistindo até olhar na ultima gaveta da mesa do escritório, dentro dela havia uma arma de choque, Você escolhe\n\nPegar a arma – Vá para 21\nNão pegar a arma – Vá para 22",
    Escolhas = new List<int> { 21, 22 }
};

aventura[21] = new Rotas
{
    Texto = "Você pega a arma e a esconde na roupa, agora sentindo mais confiante sobre acabar de vez com a opressão robótica, ao sair da sala você vai a uma janela próxima e põe o pequeno sinalizador que carregava consigo, ao disparar a frequência seu grupo irá começa a se preparar e posicionar, você aguarda o sinal de recebimento deles que não demoram para confirmar. Pronto para seguir o próximo passo você é interrompido, com a justificativa do robô que havia sido convocado para uma reunião. Não havendo uma escapatória você vai forçadamente.\n\nVá para 25",
    Escolhas = new List<int> { 25 }
};

aventura[22] = new Rotas 
{
    Texto = "Você prefere não pegar a arma, o risco de ser revistado e pego era muito alto para correr, ao sair da sala você vai a uma janela próxima e põe o pequeno sinalizador que carregava consigo, ao disparar a frequência seu grupo irá começa a se preparar e posicionar, você aguarda o sinal de recebimento deles que não demoram para confirmar. Pronto para seguir o próximo passo você é interrompido, com a justificativa do robô que havia sido convocado para uma reunião. Não havendo uma escapatória você vai forçadamente.\n\nVá para 25",
    Escolhas = new List<int> { 25 }
};

aventura[23] = new Rotas
{
    Texto = "Você pega a arma e entrega a Alice não sabendo ao certo o porquê, mas com um leve desconforto de segurar o objeto e confiando mais nela para manusear que a si, você pensa que o risco de ser revistado e pego era muito alto para correr.\"Agora devemos ir a sala de reuniões, os quatro estarão lá com os funcionários\" Disse Alice você concorda com o plano deles, mas antes vai a uma janela próxima e põe o pequeno sinalizador que carregava consigo, ao disparar a frequência seu grupo irá começa a se preparar e posicionar, você aguarda o sinal de recebimento deles que não demoram para confirmar. Agora com mais confiança você segue os dois até a sala de reuniões.\n\nVá para 25",
    Escolhas = new List<int> { 25 }
};

aventura[24] = new Rotas
{
    Texto = "Você pega a arma e entrega a Lucas não sabendo ao certo o porquê, mas com um leve desconforto de segurar o objeto e confiando mais nele para manusear que a si, você pensa que o risco de ser revistado e pego era muito alto para correr.\"Agora devemos ir a sala de reuniões, os quatro estarão lá com os funcionários\" Disse Alice você concorda com o plano deles, mas antes vai a uma janela próxima e põe o pequeno sinalizador que carregava consigo, ao disparar a frequência seu grupo irá começa a se preparar e posicionar, você aguarda o sinal de recebimento deles que não demoram para confirmar. Agora com mais confiança você segue os dois até a sala de reuniões.\n\nVá para 25",
    Escolhas = new List<int> { 25 }
};

aventura[25] = new Rotas
{
    Texto = "Com o ultimo passo do seu plano prestes a ser concluído você entra na sala e se senta em uma cadeira não muito distante a um membro do Círculo Central. Eles conversavam como as revoltas humanas estavam cada vez menores, os poucos que sobraram se submetiam cada vez mais ao sistema de regime, os robôs não pareceram nem um pouco descontentes com isto, pelo contrário, a \"alegria deles era contagiante\", já você junto aos outros humanos na sala ficaram desconfortáveis com a situação mas é claro, não interviram.\n\nA reunião era longa não havia uma discussão importante a verdade é que as maquinas se vangloriavam de como seu novo modo de governo estava equilibrado e igualitário que o anterior, você reflete como era o mundo antes da guerra comparando as duas situações, no fim de sua conclusão você realmente questiona se está fazendo o correto. Ao acabar a reunião todos se levantam para sair você se levanta e se dirige a saída, na sua frente está S.I.R.U.S, você escolhe.\n\nDesistir do plano – Vá para 26\nImplantar o vírus – Vá para 27",
    Escolhas = new List<int> { 26, 27 }
};

aventura[26] = new Rotas
{
    Texto = "No seu questionamento você percebe que o mundo antes da guerra também não era o dos melhores, havia muita desigualdade e preconceito entre pessoas, era comum pessoas morrerem todos os dias por brigas desnecessárias ou por simples maldade humana, ao fim você desiste da ideia talvez o mundo esteja melhor que antes mesmo não sendo o perfeito, você sai da empresa como entrou e reencontra teu grupo. Ao explicar para eles seus motivos eles não parecem muito convencidos nem entendido seu ponto de vista, você argumenta de volta debatendo, uma grande discussão se inicia entre vocês.\n\nO barulho atraí os seguranças que levam todos para fora da empresa e depois para a cadeia, não houve como inventar uma desculpa e se safar da situação, alguns dias se passaram lá até que todos foram condenados a morte por traição.\n\nAo menos você foi justo? Quem sabe?\nVocê chegou a um final! – Final Neutro\n\nTente jogar novamente e fazer outro final.\n Vá para 99",
    Escolhas = new List<int> { 99 }
};

aventura[27] = new Rotas
{
    Texto = "Nenhum pensamento contrario passou em sua mente você pegou o dispositivo e aproximou de seu alvo que grudou facilmente a ele, assim que entrou em contato o dispositivo é acionado e desarma os mecanismos de defesa de tudo ao redor, este foi o sinal para sua equipe desligar a luz do prédio e foi o que fizeram, assim que a luz caiu todos estavam confusos, você se afastou deles esperando o vírus desligar completamente S.I.R.U.S mas não foi o que ocorreu, ele parecia estar intacto, você deduz que deve ter sido alguma falha no dispositivo. \"O que é isto em você?\" perguntou uma membra do Circulo Central a ele que olhou confuso \"O que?\" ele respondeu \"Isto aqui\" ela disse e puxou o dispositivo antes colado por você.\n\nO clima de tensão se espalha pelo ar mesmo sem ninguém dizer uma só palavra \"Malditos estão tentando me derrubar!\" Ele gritou em fúria e começou a atacar todos a sua volta até mesmo seus aliados, ele os cortavam ao meio com grandes garras em suas mãos. Vá para 28 e boa sorte!",
    Escolhas = new List<int> { 28 }
};

aventura[28] = new Rotas
{
    Texto = "Você começa a correr o mais rápido que pode pelos corredores escuros do prédio, você tromba em alguns objetos no caminho, mas faz o possível para escapar, no gesto de fúria de S.I.R.U.S todos os robôs ao redor começaram a caçar os humanos pela empresa. Ao não encontrar um lugar seguro para se esconder e começando um grupo de robôs te cercar você decide\n\nContinuar procurando – Vá para 29\nUsar a arma que você já havia pegado – Vá para 30\nTente se encontrar com Alice ou Lucas caso vocês estavam juntos – Vá para 31",
    Escolhas = new List<int> { 29, 30, 31 }
};

aventura[29] = new Rotas
{
    Texto = "Você se lamenta e reclama mentalmente por não ter pegado a arma antes, entretanto não há tempo a perder com o passado, ao virar o corredor você encontra dois caminhos possíveis para a saída, mas o pânico te faz esquecer o mapa do prédio e qual era a correta, por instinto você escolhe\n\nIr pela esquerda – Vá para 35\nIr para direita – Vá para 36",
    Escolhas = new List<int> { 35, 36 }
};

aventura[30] = new Rotas
{
    Texto = "Você atira nos robôs que estavam próximos e acaba com eles, recuperando um pouco de sua confiança, você tenta lembrar o mapa do prédio, mas o pânico te fez esquecer a saída, por instinto você escolhe\n\nIr pela esquerda – Vá para 35\nIr para direita – Vá para 37. ",
    Escolhas = new List<int> { 35, 37 }
};

aventura[31] = new Rotas
{
    Texto = "Para sua sorte você se reencontra com os dois que estavam um pouco feridos, mas nada aparentemente muito grave, Alice guiou vocês até a saída pois se lembrava exatamente do caminho, no trajeto não houve nenhum perigo o que era estranho se considerado a situação que estavam. Quando chegaram a porta lá estava S.I.R.U.S que encarava vocês com extrema raiva, \"Foram vocês não é? Vocês humanos sempre tentam me derrubar, mas agora é o fim!\" Ele começa a correr em direção a vocês que se separam mas não conseguem escapar do local, ele consegue capturar os três juntos, você temia o pior, porém anteriormente você escolheu.\n\nFicar com a arma guardada – Vá para 32\nEntregar a arma a Alice\nEntregar a arma ao Lucas – Vá para 33",
    Escolhas = new List<int> { 32, 33 }
};

aventura[32] = new Rotas
{
    Texto = $"Você saca a arma que havia guardado e dispara contra S.I.R.U.S que cai ao chão e seu corpo enorme esmaga Lucas complemente, foi uma terrível cena de se ver e Alice parece petrificada demais para reagir, logo após a luz volta e você a faz voltar para a realidade chamando por seu nome, vocês dois saem da empresa, esgotados fisicamente e mentalmente.\n\nVocê nota que mesmo saindo viva da situação e sem grandes problemas Alice não parece muito contente, ela te olha de cima a baixo e começa a te arrastar novamente para dentro, você não iria se deixar vencer fácil agora e inicia uma luta contra ela, no meio disso ela te acerta e sua visão fica turva, e escurece lentamente.......\n\nAlice carregou {nome} até uma das salas vazias da empresa e deixou esperando eternamente por ajuda.\n\nO plano deu certo mesmo com falhas mas você não sobreviveu\nIsso conta como vitória?\n\nSe está contente assim ou quer tentar um outro final – Vá para 99",
    Escolhas = new List<int> { 99 }
};

aventura[33] = new Rotas
{
    Texto = "Você entregou a arma para Alice que quando S.I.R.U.S iria ataca-los disparou contra ele, entretanto não em um ponto vital, ele toma a arma da mão dela e olha para vocês rindo \"É sério? Vocês fazem um plano e nem mesmo sabem usar uma arma que pensam em usar? Vocês humanos são ótimos em contar piadas\" Ele disse extremamente sarcástico e usou a arma para eliminar vocês três.\n\nVocê estava realmente muito perto...\nSinta-se a vontade para sair ou tentar outro caminho – Final Ruim – Vá para 99",
    Escolhas = new List<int> { 99 }
};

aventura[34] = new Rotas
{
    Texto = "Você entregou a arma para Lucas que quando S.I.R.U.S iria ataca-los disparou contra ele, entretanto errou o tiro, ele nem mesmo se preocupou em desarmar Lucas somente o olhou com desdenho, \"Atire neles\" ele disse, que obviamente foi recusado, até ele se aproximar mais \"Escolha entre sua vida ou a deles\", Lucas pensou por segundos que pareceram uma eternidade até acertar você com um tiro, com o disparo você cai no chão, sua visão fica turva e escurece lentamente.....\n\nVocê estava realmente muito perto...\nSinta-se a vontade para sair ou tentar outro caminho – Final Ruim – Vá para 99",
    Escolhas = new List<int> { 99 }
};

aventura[35] = new Rotas
{
    Texto = $"Você vira à esquerda e não encontra ninguém somente a porta da saída, sem pensar duas vezes você corre para a liberdade, você no momento só pensava em sair vivo dali e não se importou se o Circulo Central ou S.I.R.U.S estavam vivos, você se reencontrou com seu grupo onde haviam combinado e conta a eles tudo o que ocorreu. Não demorou muito para que todos os ditadores estivessem em suas posições novamente e que fosse substituídos os mortos por novos, a segurança da empresa aumentou mais que o dobro e ainda investigam para descobrir todos os responsáveis pelo ataque ao governo e os punirem.\n\nVocê está bem {nome}, por enquanto....\nJogue novamente para conseguir outro final – Final Neutro – Vá para 99",
    Escolhas = new List<int> { 99 }
};

aventura[36] = new Rotas
{
    Texto = $"Você vira à direita e se depara com S.I.R.U.S que assim que te vê corre em sua direção extremamente furioso, você tenta pegar algo ao redor para se defender mas não há nada que possa te ajudar, \"Você vai ser o lembrete que não devem tentar se revoltar contra nós\" ele disse antes de te ferir com suas garras metálicas, com machucados profundos você cai no chão, sua visão fica turva e escurece lentamente.....\n\nO nome {nome} ficou marcado na história de como não se deve tentar derrubar o governo e serviu de exemplo para as futuras gerações.\n\nDa próxima vez esteja com a arma!\nSinta-se a vontade para sair ou tentar outro caminho – Final Ruim – Vá para 99",
    Escolhas = new List<int> { 99 }
};

aventura[37] = new Rotas
{
    Texto = $"Você vira à direita e se depara com S.I.R.U.S que assim que te vê corre em sua direção extremamente furioso você mira nele e aperta o gatilho, ele cai ao chão fazendo um alto barulho, você se aproxima do corpo e confere seu estado, ele realmente estava morto, sem querer mais brigas pois você não tinha certeza se poderia ganhar desacompanhado, saiu da empresa e se encontrou com seu grupo no local que haviam combinado.\n\nCom a morte de S.I.R.U.S e o Circulo Central os seres humanos começaram a despertar para a sua tão esperada liberdade. A reconstrução do mundo pós-apocalíptico começou. Com a ajuda dos robôs renegados, os humanos reformularam e redesenharam a tecnologia.\n\nÀ medida que as cidades eram reconstruídas com uma fusão harmoniosa de humanos e robôs trabalhando em conjunto, um novo sentido de esperança e inspiração surgiu. A humanidade aprendeu uma lição valiosa: o equilíbrio entre humanos e tecnologia é essencial. Os robôs, uma vez opressores, agora desempenhavam papéis de companheiros e facilitadores do progresso humano.\n\nA história dos robôs tiranos seria perpetuada como um lembrete permanente de que a liberdade e a individualidade do ser humano nunca devem ser subjugadas pela dominação impessoal da tecnologia.\n\nParabéns {nome}\nVocê conseguiu acabar com a opressão robótica e liderou a humanidade para um novo rumo! – ✭ Final Bom ✭ – Vá para 99",
    Escolhas = new List<int> { 99 }
};



int indiceEntradaAtual = 0;
while (indiceEntradaAtual >= 0 && indiceEntradaAtual <= 98)
{
    Console.Clear();

    Rotas entradaAtual = aventura[indiceEntradaAtual];
    Console.WriteLine($" 『 {indiceEntradaAtual} 』  \n\n{entradaAtual.Texto}\n");
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
        while (!entradaAtual.Escolhas.Contains(indiceDesejado) && indiceDesejado != 99);
    
    indiceEntradaAtual = indiceDesejado;
}

Console.Clear();

Console.WriteLine
    ("Fim! ✭\n\nSinta-se livre para jogar novamente\nObrigada!");
