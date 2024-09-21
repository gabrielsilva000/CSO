Documento de Projeto: Sistema de Ordenação de Livros

Visão Geral O projeto é um sistema de ordenação de livros que permite ao usuário inserir informações sobre os livros e ordená-los de acordo com critérios específicos. Este sistema foi implementado em C# utilizando as melhores práticas de arquitetura e design.

Arquitetura 2.1 
Padrões de Arquitetura SOLID: 
Single Responsibility Principle: Cada classe possui uma única responsabilidade. Por exemplo, a classe OrdenacaoService é responsável apenas por ordenar livros. 
Open/Closed Principle: A aplicação é extensível, permitindo adicionar novos critérios de ordenação sem modificar o código existente. 
Liskov Substitution Principle: As interfaces garantem que as classes que as implementam podem ser substituídas sem afetar o comportamento do sistema. 
Interface Segregation Principle: As interfaces são específicas e não forçam a implementação de métodos desnecessários. 
Dependency Inversion Principle: Classes dependem de abstrações (interfaces) em vez de classes concretas.

2.3 Camadas Domain: 
Contém as entidades e interfaces do domínio. A entidade Livro e a interface IOrdenacaoService são definidas aqui. 
Application: Contém a lógica de negócios e os serviços, incluindo a classe OrdenacaoService que aplica as regras de ordenação. 
Infrastructure: Contém a lógica de configuração e a classe Program que inicia o aplicativo.

Design Patterns 
3.1 
Strategy Pattern O padrão Strategy foi aplicado na forma de OrdenacaoService e CriterioOrdenacao. 
Este padrão permite que diferentes algoritmos de ordenação sejam utilizados de maneira intercambiável. 
Novos critérios podem ser facilmente adicionados sem modificar a lógica existente. 
3.2 Builder Pattern Embora não tenha sido implementado explicitamente, o conceito de construir uma lista de critérios de ordenação pode ser considerado uma aplicação do Builder Pattern. O usuário pode definir múltiplos critérios de forma flexível.

Clean Code 
4.1 Nomes Descritivos As classes, métodos e variáveis têm nomes descritivos que indicam claramente seu propósito. Por exemplo:
OrdenacaoService: Indica que esta classe é responsável por serviços de ordenação. OrdemDeOrdenacao: Enum que define a direção da ordenação (Ascendente ou Descendente). 
Simplicidade O código foi mantido simples e legível. Métodos curtos e funções auxiliares, como PrintLivro, melhoram a clareza e a manutenção do código.
4.3 Tratamento de Exceções Um tratamento adequado de exceções foi implementado para lidar com a ausência de entradas, garantindo que o sistema se comporte de maneira robusta.

Decisões de Design 5.1
Entrada do Usuário A decisão de permitir a entrada de livros pelo console foi tomada para simplificar a interação do usuário e facilitar os testes. Isso também evita a necessidade de configurar um front-end.
5.2 
Configuração Externa Embora a configuração dos livros não tenha sido feita através de appsettings.json, a estrutura ainda permite a inclusão de configurações externas no futuro, se necessário.

Critérios de Ordenação A escolha de permitir múltiplos critérios de ordenação, com direções específicas, foi baseada na flexibilidade e na extensibilidade do sistema. Essa abordagem permite que o sistema evolua conforme novas necessidades surgem.

Conclusão Este projeto de ordenação de livros foi desenvolvido com foco em boas práticas de engenharia de software. A aplicação dos princípios SOLID, design patterns e práticas de Clean Code resultou em um sistema robusto, extensível e fácil de manter. A estrutura modular e a separação de responsabilidades garantem que futuras extensões ou modificações possam ser realizadas de maneira eficiente.
