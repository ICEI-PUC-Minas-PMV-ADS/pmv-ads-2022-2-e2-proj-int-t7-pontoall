# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="01-Documentação de Contexto.md"> Documentação de Contexto</a></span>

A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foram consolidadas com a participação dos usuários em um trabalho de imersão feita pelos membros da equipe a partir da observação dos usuários em seu local natural e por meio de entrevistas. Os detalhes levantados nesse processo foram  consolidados na forma de personas e histórias de usuários.
<br>


## Personas

As personas levantadas durante o processo de entendimento do problema são apresentadas na Figuras que se seguem.

### <span style="color:Green">**`Éder Aleixo`**

|<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t7-pontoall/blob/main/docs/img/eder.jpg" width="160" height="160">   | **CEO de Empresa de TI** <br> 38 anos   |
|:---------------------------------------:|:-------------------------------:|
|**Principais Aplicativos Utilizados** |Visual Studio Code, QuickEdit, Linkedin, MySQL, Slack, Udacity, Eclipse, WhatsApp, Discord
|**Objetivos** |Melhoria dos processos de gerenciamento de equipes, tornar mais versátil o modelo de trabalho dos colaboradores utilizando das modalidades home office e híbrido.
|**Desafios** |Certificar que os colaboradores cumpram os termos de contrato de trabalho.|


### <span style="color:Green">**`Mariana Ximenes`**

|<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t7-pontoall/blob/main/docs/img/mariana.jpg" width="160" height="160">   | **Gerente de Desenvolvimento** <br> 37 anos   |
|:---------------------------------------:|:-------------------------------:|
|**Principais Aplicativos Utilizados** |Trello, Visual Studio, WhatsApp, QuickEdit, Eclipse, Linkedin
|**Objetivos** |Melhoria no gerenciamento da jornada das equipes de desenvolvimento e consulta do registro de horas trabalhadas da equipe.
|**Desafios** |Encontrar aplicações e funcionalidades que se adequem as necessidades da empresa para solucionar atuais problemas de registro.|


### <span style="color:Green">**`Rogéria Skylab`**

|<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t7-pontoall/blob/main/docs/img/rogeria.jpg" width="160" height="160">   | **Analista de RH** <br> 49 anos   |
|:---------------------------------------:|:-------------------------------:|
|**Principais Aplicativos Utilizados** |MS Office, WhatsApp, Google Suite, Linkedin, Protheus
|**Objetivos** |Ter acesso aos registros de pontos de forma eletrônica e relatório de horas extras com agilidade, para otimizar o processo de fechamento da folha de pagamento dos colaboradores.|
|**Desafios** |Assegurar que os colaboradores encontrarão facilidade na usabilidade da aplicação, de maneira simples e intuitiva.|


### <span style="color:Green">**`Paola Regina`**

|<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t7-pontoall/blob/main/docs/img/paola.jpg" width="160" height="160">   | **Assistente de Suporte** <br> 24 anos   |
|:---------------------------------------:|:-------------------------------:|
|**Principais Aplicativos Utilizados** |Google Suite, WhatsApp, Uber, Instagram, Sublime Text, Eclipse
|**Objetivos** |Ter a carga horária registrada para poder receber o pagamento de acordo com as horas trabalhadas e evolução do banco de horas.|
|**Desafios** |Acesso ao relatório para conferência de registros de entrada e saída de trabalho.|
<br>

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Éder Aleixo    | Gerenciar a equipe  e monitorar o cumprimento dos requisitos legais. | Visualizar em tempo real os registros de e o status de cada colaborador.|
|Mariana Ximenes       | Manutenção da rotina de registro de ponto dos colaboradores. | Tornar flexivel e confiavel a marcação dos registros de ponto e ainda possibilitar o calculo das jornadas e possiveis creditos ou debitos  |
|Rogéria Skylab     | Fechar a folha de pagamento| Confrontar o saldo de horas e realizar o calculo dos pagamentos de acordo com o desempenho de cada colaborador. Efetivandos os devidos creditos e debitos na folha.|
|Paola Regina   | Registrar ponto e visualizar relatorios da situação do ponto. |Conseguir registrar o ponto diariamente e ter a opção de emissão de  relatório do registro de ponto|
<br>


## Requisitos

O escopo funcional do projeto é definido por meio dos requisitos funcionais que descrevem as possibilidades interação dos usuários, bem como os requisitos não funcionais que descrevem os aspectos que o sistema deverá apresentar de maneira geral. 

### Requisitos Funcionais

A tabela a seguir apresenta os requisitos do projeto, identificando a prioridade em que os mesmos devem ser entregues.

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001 | A aplicação deverá permitir que o usuário acesse o sistema com Nome de Usuário e Senha. | ALTA |
|RF-002 | A aplicação deve permitir o registro de ponto do colaborador. | ALTA |
|RF-003 | A aplicação deve permitir que o colaborador emita relatório com relação ao seu registro de ponto e banco de horas. | ALTA |
|RF-004 | A aplicação deve permitir aos administradores o gerenciamento dos colaboradores. | ALTA |
|RF-005 | A aplicação deve permitir que o administrador visualize o banco de horas de todos os seus colaboradores. | ALTA |
|RF-006 | A aplicação deve executar o cálculo das horas trabalhadas do colaborador. | ALTA |
|RF-007 | A aplicação deve possuir marcação de geolocalização para monitoramento do colaborador. | MÉDIA |



### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo. | ALTA |
|RNF-002| A aplicação deve informar ao usuario após todas as suas ações sucesso ou fracasso. |ALTA|
|RNF-003| Os dados do usuário devem ser armazenados em um banco de dados MySQL. |  ALTA |  
|RNF-004| Os relatórios devem ser emitidos em PDF. |  MÉDIA | 
|RNF-005| O sistema deve buscar localização do usuário através da Google Geocoding API. |  MÉDIA |
|RNF-006| Deve processar requisições do usuário em no máximo 3s. |  BAIXA | 
|RNF-007| Os alertas da aplicação deverão ser enviadas para o administrador via e-mail. |  BAIXA |


## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre. |
|02| Não poderão ser contratados prestadores de serviços para desenvolvimento do projeto.|
|02| Projeto terá foco no front-end e back end.|


## Diagrama de Casos de Uso

Na Linguagem de modelagem unificada (UML), o diagrama de caso de uso resume os detalhes dos usuários do seu sistema (também conhecidos como atores) e as interações deles com o sistema.

O objetivo do diagrama de caso de uso em UML é demonstrar as diferentes maneiras que o usuário pode interagir com um sistema.

![Diagrama UML](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t7-pontoall/blob/main/docs/img/diagrama2.jpg)