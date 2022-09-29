# Plano de Testes de Usabilidade

O teste de usabilidade permite avaliar a qualidade da interface com o usuário da aplicação móvel.

Método Utilizado: Medição e Avaliação

Para cada tarefa do participante é possível medir:

- Facilidade em realizar a ação;
- Efetivação da tarefa;
- Quantos erros ocorreram em cada ação;
- Quanto tempo foi necessário para concluí-la;
- Se a interface do sistema é apresentável.

| **CASOS DE USO** | **ID** | **PASSOS** | **RESULTADO ESPERADO** |
| --- | --- | --- | --- |
| Registro de Ponto | 1 | Acessar página home do site | Página home será exibida |
| --- | 2 | Fazer login | A aplicação deve efetuar login com sucesso |
| --- | 3 | Selecionar o botão "Registrar Ponto" | A aplicação exibe uma mensagem de sucesso "Ponto registrado com sucesso." |

| **CASOS DE USO** | **ID** | **PASSOS** | **RESULTADO ESPERADO** |
| --- | --- | --- | --- |
| Gerenciamento De Colaboradores | 1 | Acessar página home do site | Página home será exibida |
| --- | 2 | Fazer login | A aplicação deve efetuar login com sucesso |
| --- | 3 | Selecionar o botão "Registrar Ponto" | A aplicação exibe uma mensagem de sucesso "Ponto registrado com sucesso." |

| **CASOS DE USO** | **ID** | **PASSOS** | **RESULTADO ESPERADO** |
| --- | --- | --- | --- |
| Saldo do Banco de Horas do Colaborador | 1 | Acessar página home do site | Página home será exibida |
| --- | 2 | Fazer login | A aplicação deve efetuar login com sucesso |
| --- | 3 | Navegar até "Meus Pontos" | A aplicação exibe a tabela com os registros de ponto e ao final o somatório de horas no período. |

| **CASOS DE USO** | **ID** | **PASSOS** | **RESULTADO ESPERADO** |
| --- | --- | --- | --- |
| Alerta de Não Conformidade no Registro de Ponto | 1 | Acessar página home do site | Página home será exibida |
| --- | 2 | Fazer login | A aplicação deve efetuar login com sucesso |
| --- | 3 | Selecionar o botão "Registrar Ponto" em situação de não conformidade. | A aplicação apresenta a mensagem de erro "Não foi possível registrar o ponto. Horário de registro inválido." |

| **CASOS DE USO** | **ID** | **PASSOS** | **RESULTADO ESPERADO** |
| --- | --- | --- | --- |
| Inclusão de Usuário por Nível | 1 | Acessar página home do site | Página home será exibida |
| --- | 2 | Fazer login com o usuário Administrador | A aplicação deve efetuar login com sucesso |
| --- | 3 | Navegar até a tela Configurações Sistema | A página com os campos de configurações do sistema será exibida |
| --- | 4 | Selecionar a opção "Incluir Usuário Master" | A página com os campos de cadastro de usuário administrador será exibida. |
| --- | 5 | Preencher os campos obrigatórios | Os campos devem receber os dados digitados |
| --- | 6 | Clicar em "Finalizar Cadastro" | A aplicação apresenta a mensagem "Usuário cadastrado com sucesso". |

| **CASOS DE USO** | **ID** | **PASSOS** | **RESULTADO ESPERADO** |
| --- | --- | --- | --- |
| Relatório do Registro de Ponto | 1 | Acessar página home do site | Página home será exibida |
| --- | 2 | Fazer login | A aplicação deve efetuar login com sucesso |
| --- | 3 | Navegar até a tela Relatórios | A página com os campos de para selecionar colaborador e o período desejado será exibida |
| --- | 4 | Selecionar a opção "Gerar Relatório" | A página com o relatório com os filtros selecionados deverá ser exibida com todos os registros de ponto encontrados na aplicação |