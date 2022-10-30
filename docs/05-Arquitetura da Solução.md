# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

![Diagrama UML](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t7-pontoall/blob/a6d36a56f08b4bc09efebb8b21b8fe5cb5dd7583/docs/img/Diagrama%20de%20Classes%20-%20171022.png)

## Modelo ER (Projeto Conceitual)

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.

![Modelo Entidade Relacional](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t7-pontoall/blob/a6d36a56f08b4bc09efebb8b21b8fe5cb5dd7583/docs/img/Diagrama%20ER%20-%20171022.png)


## Projeto da Base de Dados

O projeto da base de dados corresponde à representação das entidades e relacionamentos identificadas no Modelo ER, no formato de tabelas, com colunas e chaves primárias/estrangeiras necessárias para representar corretamente as restrições de integridade.
 
![Projeto da Base de Dados](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t7-pontoall/blob/a6d36a56f08b4bc09efebb8b21b8fe5cb5dd7583/docs/img/Projeto%20de%20banco%20de%20dados%20-%20171022A.png)
![Projeto da Base de Dados](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t7-pontoall/blob/a6d36a56f08b4bc09efebb8b21b8fe5cb5dd7583/docs/img/Projeto%20de%20banco%20de%20dados%20-%20171022B.png)

## Tecnologias Utilizadas

Estão sendo importantes no processo de desenvolvimento desta aplicação: o github como versionador de código onde é armazenada as partes prontas do projeto e por possuir compatibilidade com o Visual Basic. Foi escolhido o Trello, onde são organizadas e separadas as tarefas. O MavellAPP como ferramenta de edição dos wireframes. Para a elaboração dos diagramas do nosso projeto esta sendo utulizada a plataforma do Lucid Chart, que contribui para a concepção de forma mais facil dos diagramas.
Temos também os aplicativos e sites de comunicação com whattsap e discord. A junção destas tecnologias vai permitir a interação de todos os integrantes do grupo se comunicar e fazer as devidas tarefas.

Linguagens de progamação utilizadas:

C#: Linguagem de progamação utilizada para desenvolvimento do backend da solução.
HTML: Linguagem de marcação utilizada para a construção das páginas web.
CSS: Linguagem de folhas de estilos utilizada para aplicar estilos nos elementos HTML.
Razor: Sintaxe de marcação que permite inserir código baseado em .NET em páginas web junto ao HTML.

Frameworks utilizados:

ASP.NET Core MVC: Framework implementando o padrão Model-View-Controller, será utilizado como base para desenvolvimento da solução.
Entity Framework Core: Framework de mapeamento objeto-relacional (técnica utilizada para resolver o problema da impedância entre o modelo orientado a objetos e o modelo relacional) para a plataforma .NET, será utilizado para facilitar a manipulação e consulta do banco de dados relacional utilizado aplicação.

IDE utilizada: Visual Studio Community 2022, escolhido pela integração com o Framework ASP.NET e outras ferramentas utilizadas no projeto como o MySQL.

Sistema gerenciador de banco de dados: MySQL Server, escolhido por sua boa integração com o editor de código e para facilitar a migração do banco de dados para o serviço de hospedagem nas fases mais avançadas do projeto.


## Hospedagem

O site será hospedado na plataforma do GitHub Pages e também disponível em servidor particular via URL: https://www.bamumi.com/pontoall

A publicação do site no servidor particular é feita por meio de uma sincronização do repositório para o domínmio informado via FTP.

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t7-pontoall
