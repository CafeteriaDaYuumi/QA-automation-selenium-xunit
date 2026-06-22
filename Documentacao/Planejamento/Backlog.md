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

### Prioridade

Alta

### Status

Pendente

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

Pendente

---

## US004 - Configuração do Ambiente

### Descrição

Como QA Automation,

Quero centralizar as configurações da aplicação,

Para facilitar manutenção e reutilização.

### Tarefas

* Criar ConfigReader
* Configurar URL base
* Configurar parâmetros de execução

### Prioridade

Alta

### Status

Pendente

---

# Épico 3 — Login

## US005 - Login Válido

### Descrição

Como usuário,

Quero acessar o sistema utilizando credenciais válidas,

Para utilizar os recursos disponíveis.

### Casos de Teste

* CT001

### Prioridade

Alta

### Status

Pendente

---

## US006 - Login Inválido

### Descrição

Como usuário,

Quero receber uma mensagem de erro ao informar credenciais inválidas,

Para validar as regras de autenticação.

### Casos de Teste

* CT002
* CT003

### Prioridade

Alta

### Status

Pendente

---

# Épico 4 — Cadastro de Usuários

## US007 - Cadastro de Usuário

### Descrição

Como visitante,

Quero criar uma conta,

Para realizar compras no sistema.

### Casos de Teste

* CT004
* CT005
* CT006

### Prioridade

Alta

### Status

Pendente

---

# Épico 5 — Pesquisa de Produtos

## US008 - Pesquisa de Produto

### Descrição

Como usuário,

Quero localizar produtos através da busca,

Para encontrar itens específicos.

### Casos de Teste

* CT007
* CT008

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

* CT009
* CT010

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

* CT011

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

* CT012
* CT013
* CT014

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
* Criar Products.json
* Parametrizar cenários

### Prioridade

Média

### Status

Pendente

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

### Prioridade

Média

### Status

Pendente

---

# Resumo do Backlog

| ID    | História                      | Prioridade | Status    |
| ----- | ----------------------------- | ---------- | --------- |
| US001 | Estrutura Inicial             | Alta       | Concluído |
| US002 | Gerenciamento do Navegador    | Alta       | Pendente  |
| US003 | Captura de Evidências         | Alta       | Pendente  |
| US004 | Configuração do Ambiente      | Alta       | Pendente  |
| US005 | Login Válido                  | Alta       | Pendente  |
| US006 | Login Inválido                | Alta       | Pendente  |
| US007 | Cadastro de Usuário           | Alta       | Pendente  |
| US008 | Pesquisa de Produto           | Média      | Pendente  |
| US009 | Adicionar Produto ao Carrinho | Alta       | Pendente  |
| US010 | Remover Produto do Carrinho   | Alta       | Pendente  |
| US011 | Finalização da Compra         | Alta       | Pendente  |
| US012 | Massa de Dados Externa        | Média      | Pendente  |
| US013 | Relatórios de Execução        | Média      | Pendente  |
| US014 | Refatoração Final             | Média      | Pendente  |
