# Interface vs. Classe Abstrata

## Interface
É um contrato, ou seja, uma receita de bolo, algo que é essencial uma classe ter para ser considerada daquele contexto. No exemplo, coloquei uma interface base para documentos fiscais. Com isso, essa receita exige que para ser um documento fiscal, a classe precisa emitir, consultar e cancelar o documento. Além disso, criei também interfaces específicas dos controladores, para servirem como comunicação, isto é, escondendo a implementação para não gerar dependência em quem usar. 
Nesse projeto não implementei essa vantagem de esconder a implementação atrás de uma interface.

## Classe abstrata
É aquilo que é comum, normalmente usada para reaproveitamento de código. Como reaproveitamento, coloquei um método que extrai o número do documento pela chave de acesso. Como a chave de acesso tem a mesma estrutura para todos os documentos, faz sentido ter essa função em uma classe base.
O método abstrato serve para que as implementações definam como será retornado o elemento de uma tag do XML, pois cada documento pode ter um corpo de XML diferente.

O objetivo é concentar na classe abstrata aquilo que <b>*proporciona um melhor funcionamento*</b> para suas derivadas, e não necessariamente dizer o molde delas, já que isso quem faz é a interface.

# Livro Design Patterns - Elements of Reusable Object-Oriented Software

## Factory Method
É um padrão de projeto que consiste, como o nome diz, fabricar algo através da chamada de um método. É comum o uso quando se tem várias implementações de uma classe, e baseado em alguma condição, escolhemos uma delas.

Essa fábrica deve conter aquele cadeia chata de if (ou usar um dicionário) que decide através da condição passada. No exemplo dos motores da fórmula 1, sabemos quais os tipos de motores que existem, mas não sabemos diretamente como pegar os serviços que representam tal motor. Passando a condição para a fábrica, ela decide qual das implementações vai retornar para você. É uma vantagem ter um Factory Method não só por causa disso, mas também porque a lógica de decisão fica em um só lugar, não sendo necessário copiar e colar a lógica em diferente lugares que vão decidir qual implementação usar. Isso é possível e simples de implementar obviamente por causa da inversão de dependência, onde conversamos com as implementações através de sua interface.

## Abstract Factory
A fábrica abstrata é usada quando se trabalha com famílias de objetos, sendo um padrão para se trabalhar de forma mais complexa que o Factory Method.

O objetivo é sempre fazer com que uma classe não tenha citações de classes concretas (somente de níveis de regra de negócio), então, para o código cliente não criar essas classes concretas dos objetos que irá usar, temos a fábrica para fazer isso, onde ela é responsável por tratar todo o código, impedindo que o cliente sofra danos com a mudança das classes concretas. Neste exemplo, o código cliente poderia ficar criando _new_ Pilotos, mas isso torna a manutenção perigosa, além de ter que lidar com detalhes de implementação, isso porque exite mais de uma equipe.

Essas fábricas concretas poderiam ser resolvidas no cliente por um Factory Method, onde esse método retornaria a fábrica concreta de cada equipe, baseado em um _Enum_, por exemplo.
