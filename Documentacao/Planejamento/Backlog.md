# Backlog do Projeto

## Visão Geral

Este documento contém todas as funcionalidades, tarefas técnicas e melhorias planejadas para o desenvolvimento do framework de automação de testes.

---

# Épico 1 — Estrutura do Framework

## US001 - Estrutura Inicial

### Descrição

Como QA Automation,
Quero criar a estrutura inicial do projeto,
Para organizar os componentes do framework de automação.

### Tarefas

* Criar projeto xUnit
* Configurar Git
* Criar estrutura de diretórios
* Criar documentação inicial

### Prioridade

Alta

### Status

Concluído

---

# Épico 2 — Infraestrutura de Automação

## US002 - Gerenciamento do Navegador

### Descrição

Como QA Automation,
Quero automatizar a inicialização dos navegadores,
Para reutilizar a configuração em todos os testes.

### Tarefas

* Criar DriverFactory
* Configurar ChromeDriver
* Configurar encerramento do navegador
* Criar BaseTest para centralizar inicialização e finalização do navegador

### Prioridade

Alta

### Status

Concluído

---

## US003 - Captura de Evidências

### Descrição

Como QA Automation,
Quero gerar evidências automáticas,
Para registrar os resultados das execuções.

### Tarefas

* Criar ScreenshotHelper
* Salvar screenshots em diretório específico
* Organizar evidências por execução

### Prioridade

Alta

### Status

Concluído

---

## US004 - Configuração do Ambiente

### Descrição

Como QA Automation,
Quero centralizar as configurações da aplicação,
Para facilitar manutenção e reutilização.

### Tarefas

* Criar ConfigReader
* Configurar URL base
* Configurar appsettings.json
* Configurar cópia dos arquivos de configuração para a pasta de execução dos testes

### Prioridade

Alta

### Status

Concluído

---

# Épico 3 — Login

## US005 - Login Válido

### Descrição

Como usuário,
Quero acessar o sistema utilizando credenciais válidas,
Para utilizar os recursos disponíveis.

### Casos de Teste

* LOGIN001 — Acesso à página de login
* CT001 — Login com credenciais válidas
* CT004 — Logout com sucesso

### Prioridade

Alta

### Status

Concluído

---

## US006 - Login Inválido

### Descrição

Como usuário,
Quero receber uma mensagem de erro ao informar credenciais inválidas ou campos obrigatórios vazios,
Para validar as regras de autenticação.

### Casos de Teste

* CT002 — Login com senha inválida
* CT003 — Login com campos obrigatórios vazios

### Prioridade

Alta

### Status

Concluído

---

# Épico 4 — Cadastro de Usuários

## US007 - Cadastro de Usuário

### Descrição

Como visitante,
Quero criar uma conta,
Para realizar compras no sistema.

### Casos de Teste

* CT005 — Acesso à área de cadastro
* CT006 — Início de cadastro com dados válidos
* CT007 — Validação de e-mail já cadastrado
* CT008 — Validação de campos obrigatórios
* CT009 — Criação e exclusão de conta com sucesso

### Tarefas

* Criar CadastroPage
* Criar CadastroTests
* Criar CadastroData
* Criar CadastroUsers.json
* Implementar fluxo inicial de cadastro
* Implementar fluxo completo de criação de conta
* Implementar validação de e-mail já existente
* Implementar validação de campos obrigatórios
* Implementar exclusão de conta criada

### Prioridade

Alta

### Status

Concluído

---

# Épico 5 — Pesquisa de Produtos

## US008 - Pesquisa de Produto

### Descrição

Como usuário,
Quero localizar produtos através da busca,
Para encontrar itens específicos.

### Casos de Teste

* CT010 — Acessar área de produtos
* CT011 — Pesquisar produto existente
* CT012 — Pesquisar produto inexistente

### Tarefas

* Criar ProdutoPage
* Criar ProdutoTests
* Mapear campo de busca
* Mapear botão de pesquisa
* Validar resultados encontrados
* Validar comportamento para produto inexistente

### Prioridade

Média

### Status

Pendente

---

# Épico 6 — Carrinho de Compras

## US009 - Adicionar Produto ao Carrinho

### Descrição

Como usuário,
Quero adicionar produtos ao carrinho,
Para realizar uma compra futura.

### Casos de Teste

* CT013 — Adicionar produto ao carrinho
* CT014 — Validar produto no carrinho

### Prioridade

Alta

### Status

Pendente

---

## US010 - Remover Produto do Carrinho

### Descrição

Como usuário,
Quero remover produtos do carrinho,
Para atualizar minha seleção de compras.

### Casos de Teste

* CT015 — Remover produto do carrinho

### Prioridade

Alta

### Status

Pendente

---

# Épico 7 — Checkout

## US011 - Finalização da Compra

### Descrição

Como usuário,
Quero concluir uma compra,
Para adquirir os produtos selecionados.

### Casos de Teste

* CT016 — Acessar checkout
* CT017 — Validar informações do pedido
* CT018 — Finalizar compra com sucesso

### Prioridade

Alta

### Status

Pendente

---

# Épico 8 — Data Driven Testing

## US012 - Massa de Dados Externa

### Descrição

Como QA Automation,
Quero utilizar arquivos externos de dados,
Para aumentar a reutilização e cobertura dos testes.

### Tarefas

* Criar Users.json
* Criar CadastroUsers.json
* Criar modelos de dados
* Criar TestDataReader
* Parametrizar cenários de login
* Parametrizar cenários de cadastro
* Criar Products.json futuramente

### Prioridade

Média

### Status

Parcialmente concluído

---

# Épico 9 — Relatórios e Evidências

## US013 - Relatórios de Execução

### Descrição

Como QA Automation,
Quero gerar relatórios das execuções,
Para facilitar análise dos resultados.

### Tarefas

* Estruturar diretório Reports
* Gerar relatórios de execução
* Organizar evidências
* Integrar ExtentReports futuramente

### Prioridade

Média

### Status

Pendente

---

# Épico 10 — Refatoração Final

## US014 - Melhoria do Framework

### Descrição

Como QA Automation,
Quero revisar e otimizar o framework,
Para garantir qualidade e manutenibilidade.

### Tarefas

* Refatoração de código
* Atualização da documentação
* Revisão dos Page Objects
* Revisão dos testes
* Substituir Thread.Sleep por WaitHelper
* Revisar estratégias temporárias utilizadas para contornar anúncios da aplicação de teste

### Prioridade

Média

### Status

Pendente

---

# Resumo do Backlog

| ID    | História                      | Prioridade | Status                 |
| ----- | ----------------------------- | ---------- | ---------------------- |
| US001 | Estrutura Inicial             | Alta       | Concluído              |
| US002 | Gerenciamento do Navegador    | Alta       | Concluído              |
| US003 | Captura de Evidências         | Alta       | Concluído              |
| US004 | Configuração do Ambiente      | Alta       | Concluído              |
| US005 | Login Válido                  | Alta       | Concluído              |
| US006 | Login Inválido                | Alta       | Concluído              |
| US007 | Cadastro de Usuário           | Alta       | Concluído              |
| US008 | Pesquisa de Produto           | Média      | Pendente               |
| US009 | Adicionar Produto ao Carrinho | Alta       | Pendente               |
| US010 | Remover Produto do Carrinho   | Alta       | Pendente               |
| US011 | Finalização da Compra         | Alta       | Pendente               |
| US012 | Massa de Dados Externa        | Média      | Parcialmente concluído |
| US013 | Relatórios de Execução        | Média      | Pendente               |
| US014 | Refatoração Final             | Média      | Pendente               |
