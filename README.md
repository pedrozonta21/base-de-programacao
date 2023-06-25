# Interface vs. Classe Abstrata

## Interface
É um contrato, ou seja, uma receita de bolo, algo que é essencial uma classe ter para ser considerada daquele contexto. No exemplo, coloquei uma interface base para documentos fiscais. Com isso, essa receita exige que para ser um documento fiscal, a classe precisa emitir, consultar e cancelar o documento. Além disso, criei também interfaces específicas dos controladores, para servirem como comunicação, isto é, escondendo a implementação para não gerar dependência em quem usar. 
Nesse projeto não implementei essa vantagem de esconder a implementação atrás de uma interface.

## Classe abstrata
É aquilo que é comum, normalmente usada para reaproveitamento de código. Como reaproveitamento, coloquei um método que extrai o número do documento pela chave de acesso. Como a chave de acesso tem a mesma estrutura para todos os documentos, faz sentido ter essa função em uma classe base.
O método abstrato serve para que as implementações definam como será retornado o elemento de uma tag do XML, pois cada documento pode ter um corpo de XML diferente.

O objetivo é concentar na classe abstrata aquilo que <b>*proporciona um melhor funcionamento*</b> para suas derivadas, e não necessariamente dizer o molde delas, já que isso quem faz é a interface.

# Desing Patterns

## Factory Method
- https://refactoring.guru/pt-br/design-patterns/factory-method

É um padrão de projeto que consiste, como o nome diz, fabricar algo através da chamada de um método. É comum o uso quando se tem várias implementações de uma classe, e baseado em alguma condição, escolhemos uma delas.

Essa fábrica deve conter aquele cadeia chata de if (ou usar um dicionário) que decide através da condição passada. No exemplo dos motores da fórmula 1, sabemos quais os tipos de motores que existem, mas não sabemos diretamente como pegar os serviços que representam tal motor. Passando a condição para a fábrica, ela decide qual das implementações vai retornar para você. É uma vantagem ter um Factory Method não só por causa disso, mas também porque a lógica de decisão fica em um só lugar, não sendo necessário copiar e colar a lógica em diferente lugares que vão decidir qual implementação usar. Isso é possível e simples de implementar obviamente por causa da inversão de dependência, onde conversamos com as implementações através de sua interface.

## Abstract Factory
- https://refactoring.guru/pt-br/design-patterns/abstract-factory

A fábrica abstrata é usada quando se trabalha com famílias de objetos, sendo um padrão para se trabalhar de forma mais complexa que o Factory Method.

O objetivo é sempre fazer com que uma classe não tenha citações de classes concretas (somente de níveis de regra de negócio), então, para o código cliente não criar essas classes concretas dos objetos que irá usar, temos a fábrica para fazer isso, onde ela é responsável por tratar todo o código, impedindo que o cliente sofra danos com a mudança das classes concretas. Neste exemplo, o código cliente poderia ficar criando _new_ Pilotos, mas isso torna a manutenção perigosa, além de ter que lidar com detalhes de implementação, isso porque exite mais de uma equipe.

Essas fábricas concretas poderiam ser resolvidas no cliente por um Factory Method, onde esse método retornaria a fábrica concreta de cada equipe, baseado em um _Enum_, por exemplo.

## Builder
- https://refactoring.guru/pt-br/design-patterns/builder

O Builder serve para construir objetos complexos por partes, normalmente usado para substituir uma sobrecarga de construtores de uma classe.

O conceito é sobre construir as partes que o cliente precisa, sem passar parâmetros ou objetos vazios, assim, caso um cliente precise ter um Produto completo por exemplo, esse cliente constrói todos os passos.
Caso precise apenas de dados dos impostos por exemplo, ele pode apenas chamar o método que é responsável por essa ação, desta forma, evita-se um construtor para cada combinação.
Depois de construído, esse Builder 'reseta' o objeto, para que possa ser construído novamente por outro cliente.

Opcionalmente, esse padão pode conter uma classe _Director_, que consiste em ser uma classe que constrói o objeto em passos específicos, ou ainda, que constrói objetos prontos já com uma sequência de passos.
É como encapsular a chamada do cliente, de modo que isso possa ser reaproveitado por clientes que precisam de objetos idênticos.

## Prototype
- https://refactoring.guru/pt-br/design-patterns/prototype

Serve para fins de clonagem de objetos já criados, retornando um novo objeto já inicializado.

Existe a clonagem superficial e a clonagem profunda. A primeira clona os conteúdos que são por tipo de valor, deixando de lado os conteúdos que são por tipos de referência. Já a segunda forma clona tanto por tipo 
de valor quanto por tipo de referência, e ambas precisam de uma implementação. Algumas linguagens fornecem uma interface _ICloneable_ para facilitar uma implementação padrão para cada uma.

## Singleton
- https://refactoring.guru/pt-br/design-patterns/singleton

Um padrão simples (e não muito elegante) que proporciona a mesma instância de uma classe ao longo da aplicação, podendo ela ser algum tipo de compartilhamento de recurso.

Encapsulando o contrutor deixando-o privado e tendo um método estático de inicialização da própria classe é como o Singleton funciona.

## Adapter
- https://refactoring.guru/pt-br/design-patterns/adapter

Chegando nos padrões estruturais, esse tem o objetivo de garantir o princípio S e O do SOLID. Usado quando o código cliente precisa de uma classe da qual não é possível conversar, seja por ter uma interface diferente, ou por ser uma classe legada (não podendo assim nem pensar em citar ela, sendo preciso usar o DIP).

Cria-se uma interface que respeite o uso do cliente, e essa interface é implementada em outra classe criada (a classe Adaptadora). Essa classe adaptadora faz o trabalho sujo de citar aquela classe incompatível ou legada (guardando uma instância dela), transformando a chamada do cliente para que ela possa ser convertida para a classe alvo, assim, o cliente não conhece a implementação de nada por estar tudo invertido graças à interface.

## Composite
- https://refactoring.guru/pt-br/design-patterns/composite

Compõe objetos em forma de árvore, tendo ênfase no uso do polimorfismo. Cada ramificação dessa árvore pode ter outras ramificações que ainda possuem outras. Isso permite que cada objeto da árvore seja tratado de forma independente.

Em alguns casos pode ser complicado, mas cria-se uma interface comum para um objeto simples e para um objeto composto para ser usada pelo cliente, e cada objeto composto pode ter ou um ojeto simples, ou ainda um objeto composto com outros objetos.

## Bridge
- https://refactoring.guru/pt-br/design-patterns/bridge

Serve para dividir classes interligadas em hierarquias diferentes, dando ênfase na composição em vez da herança. Uma das hierarquias, por meio de uma interface, é composta pela outra hierarquia.

Quando se tem uma classe que pode ter combinações com outras classes (fazendo ela ser "duplicada", por exemplo: `CadernoCapaMoleFolhaBranca`, `CadernoCapaMoleFolhaReciclavel`), o padrão entra. O tipo da folha do caderno é abstraído para outra hierarquia, tendo uma interface para todas as subclasses terem um contrato para a classe que terá ela como composição.
Na hierarquia de caderno, uma classe base implementa os comportamentos padrão, tendo por meio do construtor a injeção da interface do tipo da folha. Cada subclasse de caderno segue com seu comportamento normal, não sendo impedidas obviamente, de utilizarem a interface das folhas. Assim, um `CadernoCapaMole` não precisa ser duplicado, porque ele está "imune" em relação as dependências das classes concretas de Folhas.

## Decorator
- https://refactoring.guru/pt-br/design-patterns/decorator

Tem o objetivo de adicionar novos comportamentos, colocando-os dentro de um "container", podendo fazê-los trabalharem em conjunto.

Uma classe base do Decorator possui uma instância de seu próprio tipo (uma interface). Cada classe de comportamento implementa herda Decorator, assim, quando a classe base é instanciada, um objeto é passado pra ela, normalmente um outro comportamento para trabalhar junto com o mesmo. Tudo isso é passado para a classe base, que por meio da interface, delega as chamadas. Ou seja, toda classe filha pode ter uma outra classe filha, porém sem a depedência, assim, Uma classe A, recebe para trabalhar junto uma classe B, e a classe base é responsável por ter o(s) método(s) chamador(es). Essa classe B na classe A pode ser alterada em tempo de execução, fazendo com que A possa receber C.

## Facade
- https://refactoring.guru/pt-br/design-patterns/facade

A fachada, que pode ser substituída por uma fábrica, consiste em fornecer uma interface mais simples do que a de um subsistema (API, Framework...), tendo declarado aquilo que realmente faz sentido do cliente, já que um subsistema pode ter várias funcionalidades, e mais importante do que isso, não deixar que um classe de nível mais alto dependa do subsistema.

O uso é simples, o código cliente consome uma classe fachada, onde nela existe o contato com o(s) subsistema(s). Assim, o código cliente desconhece a existência de um software de terceiros. Como o objetivo de um Facade é ser de fácil compreensão, o ideal é ir separando-o conforme ele vai crescendo.

## Flyweight
- https://refactoring.guru/pt-br/design-patterns/flyweight

O objetivo é equilibrar o consumo de memória impedindo que objetos repetidos sejam criados. Ou seja, compartilhar objetos comuns para outros objetos.

O conceito consiste, por exemplo, em um objeto que tenha uma propriedade que será igual para todos os outros objetos do seu tipo, tendo apenas uma parte sendo específica.
Assim sendo, uma fábrica (que pode ser um Singleton) armazena os objetos que serão reaproveitados, assim, a mesma instância é reaproveitada em diversos clientes.

## Proxy
- https://refactoring.guru/pt-br/design-patterns/proxy

Esse padrão tem como objetivo encapsular aquilo que precisa ser feito antes e/ou depois do uso de uma determinada classe. Com o proxy, não é necessário duplicar o código (nem mesmo uma chamada para outra classe que contenha esse código), digamos, independente do que faz a classe alvo.

Um uso simples (existem outros mais complexos) é quando se precisa fazer uma verificação de login, por exemplo, sempre que for enviado algum arquivo para um repositório remoto ou nuvem, a partir do dispositivo local. Fazer essa verificação no código cliente é horrível, e mesmo que extrair isso para outra classe para ser usada seja uma boa ideia, o problema ainda não estaria totalmente resolvido, pois ainda assim devem ser feitas as chamadas para essa classe. O proxy implementa a mesma interface da classe alvo, porém nesse proxy que é feito, como no exemplo, a verificação de login, então o código cliente aceita receber qualquer classe da interface, e ele pode receber esse ou outro proxy, que faz a verificação do login ou algum outro trabalho sujo que precise ser executado antes e/ou depois do consumo do serviço alvo.

## Chain of Responsability
- https://refactoring.guru/pt-br/design-patterns/chain-of-responsibility

A cadeia de responsabilidades serve para ligar processos na qual um objeto precisa passar, fazendo, em uma analogia, elos como o de uma corrente.
Cada parte da cadeia (elo) é responsável por um processamento, e ele decide se processa a requisição ou se passa para o próximo validador.
Para respeitar as boas práticas, cada elo pode ser usado separadamente, sem a necessidade de depender de outro elo.

No exemplo para validar objetos de pessoas, elas precisam passar por duas validações: Serasa e antecedente criminal. Nesse caso, se o primeiro elo 
é válido, ele apenas passa para o próximo, e assim por diante. Quando todos são executados apenas passando para o próximo, significa que nenhum 
dos elos invalidou a pessoa, logo, ela é aceita.

Porém, se um não validar a pessoa, a sequência é interrompida. A forma como esse padrão é utilizado permite adicionar novas validações facilmente, 
além de existir a flexibilidade de definir uma sequência, podendo ou não usar todos os _Handlers_.

## Command
- https://refactoring.guru/pt-br/design-patterns/command

O padrão _Comando_ tem como objetivo desacoplar o emissor (que no caso do projeto, é o cliente, que por sua vez sempre acaba sendo o `Program.cs`) do objeto alvo/receptor `CaptadorService.cs`. Assim sendo, toda requisição vira um objeto, podendo ser parametrizada, onde o remetente não tem conhecimento sobre a parte específica que será executada, pois o contexto é definido fora do remetente.

O invocador `GuitarraInvoker.cs` recebe uma interface _ICommand_ para executar a ação específica da classe alvo, que como dito, não é de conhecimento dela e muito menos do remetente.