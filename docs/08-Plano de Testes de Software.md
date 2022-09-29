# Plano de Testes de Software

O Plano de Testes de Software é gerado a partir da especificação do sistema e consiste em casos de testes que deverão ser executados quando a implementação estiver parcial ou totalmente pronta.

  1. Requisitos para Realização do Teste

As seguintes ferramentas serão empregadas neste projeto de testes:

- Site publicado na Internet
- Navegador da Internet - Chrome, Firefox ou Edge
- Conectividade de Internet para acesso às plataformas (APISs)
- Microsoft Visual Studio
- Banco de dados SQLite
- Biblioteca de testes xUnit

  2. Ambiente de teste

- Testes deverão ser desenvolvido com um pequeno volume de dados, baseados em testes manuais.
- Os dados serão criados em tempo real, por desenvolvedores da aplicação e usuários.
- A aplicação será desenvolvida em linguagem C#, com html, css, JSON.
- Todos os testadores deverão ter configurações de desktop similares aos que serão disponibilizadas aos colaboradores da empresa.

Os testes funcionais a serem realizados na aplicação são descritos a seguir.

  3. Abordagem e Detalhmento de Testes

| **Tipo do Teste:** | Funcional |
| --- | --- |
| **Subtipo do Teste:** | Requisitos |
| **Objetivo do Teste:** | Testar a funcionalidade de acesso a aplicação mediante usuário e senha previamente cadastrados. |
| **Requisitos que motivaram esse teste:** | RF-001 - A aplicação deverá permitir que o usuário acesse o sistema com Nome de Usuário e Senha. |

| **Tipo do Teste:** | Funcional |
| --- | --- |
| **Subtipo do Teste:** | Requisitos |
| **Objetivo do Teste:** | Testar a funcionalidade de cadastrar, editar, inativar e excluir e acesso dos usuários com perfil administrador. |
| **Requisitos que motivaram esse teste:** | RF-002 - A aplicação deve permitir o gerenciamento de usuários com o perfil de administrador. |

| **Tipo do Teste:** | Funcional |
| --- | --- |
| **Subtipo do Teste:** | Requisitos |
| **Objetivo do Teste:** | Testar a funcionalidade do botão e ao clicá-lo, o registro das informações no banco dedados. |
| **Requisitos que motivaram esse teste:** | RF-003 - A aplicação deve possuir um botão (ícone) para registro de ponto na tela principal. |

| **Tipo do Teste:** | Funcional |
| --- | --- |
| **Subtipo do Teste:** | Requisitos |
| **Objetivo do Teste:** | Testar a funcionalidade de listar o horário e data que o usuário registra o ponto na aplicação, gravando a informação no banco de dados. |
| **Requisitos que motivaram esse teste:** | RF-004 - A aplicação deve permitir o registro de ponto do colaborador. |

| **Tipo do Teste:** | Funcional |
| --- | --- |
| **Subtipo do Teste:** | Requisitos |
| **Objetivo do Teste:** | Testar a funcionalidade de gerar relatório de ponto de cada colaborador. |
| **Requisitos que motivaram esse teste:** | RF-005 - A aplicação deve permitir que o colaborador emita relatórios com relação ao seu registro de ponto, tais como horas trabalhadas na semana, resuma de horas extras e banco de horas. |

| **Tipo do Teste:** | Funcional |
| --- | --- |
| **Subtipo do Teste:** | Requisitos |
| **Objetivo do Teste:** | Testar a funcionalidade de cadastrar, editar, inativar e excluir usuários, no banco de dados. |
| **Requisitos que motivaram esse teste:** | RF-006 - A aplicação deve permitir aos administradores o gerenciamento dos colaboradores. |

| **Tipo do Teste:** | Funcional |
| --- | --- |
| **Subtipo do Teste:** | Requisitos |
| **Objetivo do Teste:** | Testar a funcionalidade de visualizar o banco de horas de cada colaborador. |
| **Requisitos que motivaram esse teste:** | RF-007 - A aplicação deve permitir que o administrador visualize o banco de horas de todos os seus colaboradores. |

| **Tipo do Teste:** | Funcional |
| --- | --- |
| **Subtipo do Teste:** | Requisitos |
| **Objetivo do Teste:** | Testar a funcionalidade de gerar relatório de ponto possui todas as informações de cada colaborador. |
| **Requisitos que motivaram esse teste:** | RF-008 - A aplicação deve permitir que o administrador emita os relatórios individuas mensais dos colaboradores. |

| **Tipo do Teste:** | Funcional |
| --- | --- |
| **Subtipo do Teste:** | Requisitos |
| **Objetivo do Teste:** | Testar a funcionalidade |
| **Requisitos que motivaram esse teste:** | RF-009 - A aplicação deve executar o cálculo das horas trabalhadas do colaborador. |

| **Tipo do Teste:** | Funcional |
| --- | --- |
| **Subtipo do Teste:** | Requisitos |
| **Objetivo do Teste:** | Testar a funcionalidade de cálculo automático das horas, mediante registro de pontos e saldo do colaborador em tela. |
| **Requisitos que motivaram esse teste:** | RF-010 - A aplicação deve calcular o banco de horas do colaborador. |

| **Tipo do Teste:** | Funcional |
| --- | --- |
| **Subtipo do Teste:** | Requisitos |
| **Objetivo do Teste:** | Testar a funcionalidade de visualização do local, no mapa, onde foi realizado o registro do ponto, através das coordenadas geográficas, no momento de registro ponto pelo colaborador. |
| **Requisitos que motivaram esse teste:** | RF-011 - A aplicação deve possuir marcação de geolocalização para monitoramento do colaborador. |

| **Tipo do Teste:** | Funcional |
| --- | --- |
| **Subtipo do Teste:** | Requisitos |
| **Objetivo do Teste:** | Testar a funcionalidade de exibição de alertas para casos de não conformidade no registro de ponto dos colabores, nos acessos com perfil de administrador. |
| **Requisitos que motivaram esse teste:** | RF-012 - A aplicação deve fornecer, em caso de não conformidade no registro de ponto, aviso ao administrador. (Jornada incompleta, atrasos, faltas, etc.) |

| **Tipo do Teste:** | Não Funcional |
| --- | --- |
| **Subtipo do Teste:** | Usabilidade |
| **Objetivo do Teste:** | Testar se a aplicação não fica distorcida quando acessado por um ambiente ou dispositivo mobile. |
| **Requisitos que motivaram esse teste:** | RNF-001 - O sistema deve ser responsivo. |

| **Tipo do Teste:** | Não Funcional |
| --- | --- |
| **Subtipo do Teste:** | Usabilidade |
| **Objetivo do Teste:** | Verificar se a aplicação está retornando todas as informações necessárias para direcionar o usuário. |
| **Requisitos que motivaram esse teste:** | RNF-002 - A aplicação deve informar ao usuário após todas as suas ações sucesso ou fracasso. |

| **Tipo do Teste:** | Não Funcional |
| --- | --- |
| **Subtipo do Teste:** | Tecnologia Envolvida |
| **Objetivo do Teste:** | Verificar e testar se o sistema está fazendo uso do banco de dados solicitado. |
| **Requisitos que motivaram esse teste:** | RNF-003 - Os dados do usuário devem ser armazenados em um banco de dados SQLite. |

| **Tipo do Teste:** | Não Funcional |
| --- | --- |
| **Subtipo do Teste:** | Implementação |
| **Objetivo do Teste:** | Testar a exportação dos relatórios gerados pelo sistema no formato solicitado. |
| **Requisitos que motivaram esse teste:** | RNF-004 - Os relatórios devem ser emitidos em PDF. |

| **Tipo do Teste:** | Não Funcional |
| --- | --- |
| **Subtipo do Teste:** | Tecnologia Envolvida |
| **Objetivo do Teste:** | Verificar e testar se o sistema está fazendo uso da API solicitada. |
| **Requisitos que motivaram esse teste:** | RNF-005 - O sistema deve buscar localização do usuário através da Google Geocoding API. |

| **Tipo do Teste:** | Não Funcional |
| --- | --- |
| **Subtipo do Teste:** | Usabilidade |
| **Objetivo do Teste:** | Testar se a navegação do usuário pela aplicação e suas funções é realizada sem interrupção. |
| **Requisitos que motivaram esse teste:** | RNF-006 - Deve processar requisições do usuário em no máximo 3s. |

| **Tipo do Teste:** | Não Funcional |
| --- | --- |
| **Subtipo do Teste:** | Implementação |
| **Objetivo do Teste:** | Testar se alertas de não conformidade são reportados conforme solicitado ao administrador da aplicação. |
| **Requisitos que motivaram esse teste:** | RNF-007 - Os alertas da aplicação deverão ser enviados para o administrador via e-mail. |