# Plano de Testes de Software

O Plano de Testes de Software é gerado a partir da especificação do sistema e consiste em casos de testes que deverão ser executados quando a implementação estiver parcial ou totalmente pronta.

##  1. Requisitos para Realização do Teste

As seguintes ferramentas serão empregadas neste projeto de testes:

- Site publicado na Internet
- Navegador da Internet - Chrome, Firefox ou Edge
- Conectividade de Internet para acesso às plataformas (APISs)
- Microsoft Visual Studio
- Banco de dados MySQL
- Biblioteca de testes xUnit

##  2. Ambiente de teste

- Testes deverão ser desenvolvido com um pequeno volume de dados, baseados em testes manuais.
- Os dados serão criados em tempo real, por desenvolvedores da aplicação e usuários.
- A aplicação será desenvolvida em linguagem C#, com html, css, JSON.
- Todos os testadores deverão ter configurações de desktop similares aos que serão disponibilizadas aos colaboradores da empresa.

Os testes funcionais a serem realizados na aplicação são descritos a seguir.

##  3. Abordagem e Detalhmento de Testes

|**Caso de Teste**|**CT-01 –Login**|
| :-: | :-: |
|Requisito Associado|<p>RF-001 - A aplicação deverá permitir que o usuário acesse o sistema com Nome de Usuário e Senha.</p><p></p>|
|Objetivo do Teste|Verificar se o usuário consegue realizar cadastro e efetuar login no sistema.|
|Passos|<p>-Acessar o navegador.</p><p>-Informar ao navegador à URL da aplicação .All.</p><p>-Selecionar no menu da aplicação a opção login.</p><p>-Informar dados de login.</p><p>-Selecionar o botão ENTRAR para efetuar o login.</p><p></p>|
|Critério do Êxito|- O usuário consegue acessar, informar todos os dados cadastrais e efetuar login sem entraves no sistema.|

|**Caso de Teste**|<p>**CT-02– Efetuar registro de ponto eletrônico**</p><p></p>|
| :-: | :-: |
|Requisito Associado|<p>RF-002 A aplicação deve permitir o registro de ponto do colaborador.</p><p></p>|
|Objetivo do Teste|<p></p><p>Verificar se o usuário já logado consegue efetuar o batimento do ponto eletrônico e obter registro.</p><p></p>|
|Passos|<p>- Acessar o navegador<br>- Informar a URL da aplicação. ALL<br>- Realizar login no site.<br>- Na página inicial já logada o usuário deve acionar o botão (registrar ponto)<br>- Aguardar a confirmação do registro por mensagem na tela.</p><p></p><p></p><p></p>|
|Critério do Êxito|<p>-Aparecerá na tela da aplicação “Registro realizado com sucesso”, informado a hora exata da realização do ponto.</p><p></p>|

|**Caso de Teste**|<p>**CT-03 Emissão de Relatórios** </p><p></p>|
| :-: | :-: |
|Requisito Associado|<p>RF-003 A aplicação deve permitir que o colaborador emita relatório com relação ao seu registro de ponto e banco de horas.</p><p></p>|
|Objetivo do Teste|<p></p><p>Verificar se o usuário terá sucesso no processo de emissão de relatórios (horas trabalhadas, resuma de horas, banco de horas)</p><p></p>|
|Passos|<p>` `Acessar o navegador<br>- Informar a URL da aplicação .ALL<br>- Realizar login no site<br>- Na página inicial já logada no perfil do usuário, acessar menu na opção Relatórios.</p><p>-Navegar na página Relatórios </p><p>-Selecionar relatório desejado no menu de seleção. </p><p>-Emitir relatório clicando no botão Gerar Relatório.</p><p></p>|
|Critério do Êxito|<p></p><p>-Ser capaz de selecionar e emitir relatório desejado.</p><p></p>|

|**Caso de Teste**|<p>**CT-04 Gerenciamento de colaboradores**</p><p></p>|
| :-: | :-: |
|Requisito Associado|<p>RF-004 A aplicação deve permitir aos administradores o gerenciamento dos colaboradores.</p><p></p>|
|Objetivo do Teste|<p>- Verificar que o administrador terá acesso ao gerenciamento dos colaboradores.</p><p></p>|
|Passos|<p>-Acessar o navegador<br>- Informar a URL da aplicação .ALL<br>- Realizar login no site como adm.</p><p>- Na página inicial já logada no perfil administrador, acessar menu Colaboradores.</p><p>-Clicar no botão Incluir/Editar Colaborador.</p>|
|Critério do Êxito|<p>- O usuário logado como adm consegue incluir colaborador e ou editar os dados.</p><p></p>|

|**Caso de Teste**|**CT-05 Visualização de Banco de Horas pelo ADM**|
| :-: | :-: |
|Requisito Associado|<p>RF-005A aplicação deve permitir que o administrador visualize o banco de horas de todos os seus colaboradores.</p><p></p>|
|Objetivo do Teste|<p>- Verificar que o administrador terá acesso ao Banco de Horas dos colaboradores.</p><p></p>|
|Passos|<p>-Acessar o navegador<br>- Informar a URL da aplicação .ALL<br>- Realizar login no site como adm.</p><p>- Na página inicial já logada no perfil administradior, acessar menu na opção Banco de Horas.</p><p>-Navegar na página Banco de Horas. </p><p>-Na opção selecionar ciclo de banco de horas, filtrar pelo ciclo desejado.</p><p>-Visualizar dados do Banco de Horas dos colaboradores.</p><p></p>|
|Critério do Êxito|<p>- O usuário logado como administrador consegue ter acesso às informações solicitadas.</p><p></p>|

|**Caso de Teste**|**CT-06 Cálculo de horas**|
| :-: | :-: |
|Requisito Associado|<p>RF-006 A aplicação deve executar o cálculo das horas trabalhadas do colaborador.</p><p></p>|
|Objetivo do Teste|<p>-Verificar se o usuário conseguirá realizar os cálculos de horas trabalhadas pela aplicação.</p><p></p>|
|Passos|<p>` `Acessar o navegador<br>- Informar a URL da aplicação .ALL<br>- Realizar login no site<br>- Na página inicial já logada no perfil do usuário, acessar menu na opção Relatórios.</p><p>-Navegar na página Relatórios </p><p>-Selecionar relatório desejado no menu de seleção. </p><p>-Emitir relatório clicando no botão Gerar Relatório.</p><p></p>|
|Critério do Êxito|- O usuário logado consegue ter acesso às informações solicitadas.|

|**Caso de Teste**|**CT-07 Opção de Geolocalização**|
| :-: | :-: |
|Requisito Associado|<p>RF-007 A aplicação deve possuir marcação de geolocalização para monitoramento do colaborador.</p><p></p>|
|Objetivo do Teste|-Verificar o envio das informações de geolocalização do usuário. |
|Passos|<p>- Acessar o navegador<br>- Informar a URL da aplicação. ALL<br>- Realizar login no site.<br>- Na página inicial já logada o usuário deve acionar o botão (registrar ponto)<br>- Aguardar a confirmação do registro por mensagem na tela.</p><p>- A informação da localização deverá aparecer na tela.</p><p></p><p></p>|
|Critério do Êxito|- O endereço do local do usuário deverá ser informado.|

