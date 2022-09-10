# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foram consolidadas com a participação dos usuários em um trabalho de imersão feita pelos membros da equipe a partir da observação dos usuários em seu local natural e por meio de entrevistas. Os detalhes levantados nesse processo foram  consolidados na forma de personas e histórias de usuários.
<p>

</p>

## Personas

As personas levantadas durante o processo de entendimento do problema são apresentadas na Figuras que se seguem.

### <span style="color:Green">**`Éder Aleixo`**

|<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t7-pontoall/blob/main/docs/img/eder.jpg" width="160" height="160">   | **CEO de Empresa de TI** <br> 38 anos   |
|:---------------------------------------:|:-------------------------------:|
|**Principais Aplicativos Utilizados** |Visual Studio Code, QuickEdit, Linkedin, MySQL, Slack, Udacity, Eclipse, WhatsApp, Discord
|**Obejtivos** |Melhorias dos processos de gerenciamento de equipes, tornar mais versátil o modelo de trabalho dos colaboradores utilizando das modalidades home office e híbrido.
|**Desafios** |Certificar que os colaboradores cumpram os termos de contrato de trabalho.|


### <span style="color:Green">**`Mariana Ximenes`**

|<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t7-pontoall/blob/main/docs/img/mariana.jpg" width="160" height="160">   | **Gerente de Desenvolvimento** <br> 37 anos   |
|:---------------------------------------:|:-------------------------------:|
|**Principais Aplicativos Utilizados** |Trello, Visual Studio, WhatsApp, QuickEdit, Eclipse, Linkedin
|**Obejtivos** |Melhoria no gerenciamento da jornada das equipes de desenvolvimento e consulta do registro de horas trabalhadas da equipe.
|**Desafios** |Encontrar aplicações e funcionalidades que se adequem as necessidades da empresa para solucionar atuais problemas de registro.|


### <span style="color:Green">**`Rogéria Skylab`**

|<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t7-pontoall/blob/main/docs/img/rogeria.jpg" width="160" height="160">   | **Analista de RH** <br> 49 anos   |
|:---------------------------------------:|:-------------------------------:|
|**Principais Aplicativos Utilizados** |MS Office, WhatsApp, Google Suite, Linkedin, Protheus
|**Obejtivos** |Ter acesso aos registros de pontos de forma eletrônica e relatório de horas extras com agilidade, para otimizar o processo de fechamento da folha de pagamento dos funcionários.|
|**Desafios** |Assegurar que os colaboradores encontrarão facilidade na usabilidade da aplicação, de maneira simples e intuitiva.|


### <span style="color:Green">**`Paola Regina`**

|<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t7-pontoall/blob/main/docs/img/paola.jpg" width="160" height="160">   | **Assistente de Suporte** <br> 24 anos   |
|:---------------------------------------:|:-------------------------------:|
|**Principais Aplicativos Utilizados** |Google Suite, WhatsApp, Uber, Instagram, Sublime Text, Eclipse
|**Obejtivos** |Ter a carga horária registrada para poder receber o pagamento de acordo com as horas trabalhadas.|
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
|


## Requisitos

O escopo funcional do projeto é definido por meio dos requisitos funcionais que descrevem as possibilidades interação dos usuários, bem como os requisitos não funcionais que descrevem os aspectos que o sistema deverá apresentar de maneira geral. 

### Requisitos Funcionais

A tabela a seguir apresenta os requisitos do projeto, identificando a prioridade em que os mesmos devem ser entregues.

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-01 | A aplicação deve permitir o cadastro dos usuários administradores e colaboradores. | ALTA |
|RF-02 | A aplicação deve possuir um botão (ícone) para registro de ponto na tela principal. | ALTA|
|RF-03 | A aplicação deve permitir o registro de ponto do colaborador. | ALTA |
|RF-04 | A aplicação deve permitir que o colaborador emita relatórios com relação ao seu registro de ponto. | ALTA |
|RF-05 | A aplicação deve permitir o gerenciamento dos colaboradores pelo administrador. | ALTA |
|RF-06 | A aplicação deve permitir que o administrador visualize o banco de horas de todos os seus colaboradores. | ALTA |
|RF-07 | A aplicação deve fornecer uma página com relatório de horas no final do mês para o administrador. | ALTA |
|RF-08 | A aplicação deve executar o cálculo das horas trabalhadas do colaborador. | ALTA |
|RF-09 | A aplicação deve calcular o banco de horas do colaborador. | ALTA |
|RF-10 | A aplicação deve informar ao usuário a confirmação de que o ponto foi registrado, de forma instantânea. | ALTA |
|RF-11 | A aplicação deve possuir marcação de geolocalização para monitoramento do colaborador. | MÉDIA |
|RF-12 | A aplicação deve fornecer, em caso de não conformidade no registro de ponto, aviso ao administrador. (Jornada incompleta, atrasos, faltas, etc.) | BAIXA |


### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em dispositivos móveis. | ALTA | 
|RNF-002| Os relatórios devem ser emitidos em PDF. |  MÉDIA | 
|RNF-003| O sistema deve buscar localização do usuário através da Google Geocoding API. |  MÉDIA | 
|RNF-004| Deve processar requisições do usuário em no máximo 3s. |  BAIXA | 
|RNF-005| Os alertas da aplicação deverão ser enviadas para o administrador via e-mail. |  BAIXA | 
|RNF-006 | Os alertas da aplicação deverão ser enviadas para o colaborador na tela diretamente. |ALTA|


## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre. |
|02| Não poderão ser contratados prestadores de serviços para desenvolvimento do projeto.|
|02| Projeto terá foco no front-end e back end.|


## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

<!--- Eliminar após publicação
> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
------>