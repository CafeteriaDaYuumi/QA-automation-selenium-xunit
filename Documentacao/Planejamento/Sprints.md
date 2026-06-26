# Planejamento de Sprints

## Objetivo

Este documento apresenta a divisão das atividades do projeto em Sprints, permitindo acompanhar a evolução do framework de automação de testes desde sua estruturação inicial até sua conclusão.

---

# Sprint 0 — Estrutura Inicial

## Objetivo

Preparar o ambiente e a estrutura base do projeto.

### Itens do Backlog

* US001 — Estrutura Inicial

### Entregas

* Projeto xUnit criado
* Estrutura de diretórios definida
* Repositório Git configurado
* Documentação inicial criada

**Status:** ✅ Concluído

---

# Sprint 1 — Infraestrutura de Automação

## Objetivo

Desenvolver os componentes reutilizáveis do framework.

### Itens do Backlog

* US002 — Gerenciamento do Navegador
* US003 — Captura de Evidências
* US004 — Configuração do Ambiente

### Entregas

* DriverFactory
* ConfigReader
* ScreenshotHelper
* BaseTest
* InfrastructureTests

### Critério de Aceite

O navegador deve abrir, executar ações e encerrar corretamente.

**Status:** ✅ Concluído

---

# Sprint 2 — Login

## Objetivo

Automatizar o processo de autenticação.

### Itens do Backlog

* US005 — Login Válido
* US006 — Login Inválido

### Casos de Teste

* LOGIN001
* CT001
* CT002
* CT003
* CT004

### Entregas

* LoginPage.cs
* LoginTests.cs
* UserData.cs
* Users.json

### Critério de Aceite

Todos os cenários de login devem executar com sucesso.

**Status:** ✅ Concluído

---

# Sprint 3 — Cadastro

## Objetivo

Automatizar o fluxo de cadastro de usuários.

### Itens do Backlog

* US007 — Cadastro de Usuário

### Casos de Teste

* CT005
* CT006
* CT007
* CT008
* CT009

### Entregas

* CadastroPage.cs
* CadastroTests.cs
* CadastroData.cs
* CadastroUsers.json

### Critério de Aceite

Todas as regras de cadastro devem ser validadas.

**Status:** ✅ Concluído

---

# Sprint 4 — Produtos

## Objetivo

Automatizar o módulo de produtos.

### Itens do Backlog

* US008 — Pesquisa de Produtos

### Casos de Teste

* CT010
* CT011
* CT012
* CT013

### Entregas

* ProductPage.cs
* ProductTests.cs
* ProductData.cs
* Products.json

### Critério de Aceite

Todos os cenários de pesquisa e visualização de produtos devem executar corretamente.

**Status:** ✅ Concluído

---

# Sprint 5 — Carrinho

## Objetivo

Automatizar as operações do carrinho de compras.

### Itens do Backlog

* US009 — Adicionar Produto
* US010 — Remover Produto

### Casos de Teste

* CT014
* CT015
* CT016

### Entregas

* CartPage.cs
* CartTests.cs
* CartData.cs
* CartItems.json

### Critério de Aceite

O carrinho deve refletir corretamente todas as operações realizadas.

**Status:** ✅ Concluído

---

# Sprint 6 — Checkout

## Objetivo

Automatizar o fluxo completo de checkout.

### Itens do Backlog

* US011 — Checkout

### Casos de Teste

* CT017
* CT018
* CT019
* CT020

### Entregas

* CheckoutPage.cs
* CheckoutTests.cs
* CheckoutData.cs
* CheckoutData.json

### Critério de Aceite

O checkout deve validar corretamente o fluxo de compra e pagamento.

**Status:** ✅ Concluído

---

# Sprint 7 — Data Driven Testing

## Objetivo

Externalizar a massa de dados utilizada pelo framework.

### Itens do Backlog

* US012 — Data Driven Testing

### Casos de Teste

* CT021
* CT022
* CT023
* CT024

### Entregas

* TestDataReader.cs
* TestDataModel.cs
* Users.json
* CadastroUsers.json
* Products.json
* CartItems.json
* CheckoutData.json
* DataDrivenTests.cs

### Critério de Aceite

Todas as massas de dados devem ser carregadas corretamente durante a execução dos testes.

**Status:** ✅ Concluído

---

# Sprint 8 — Evidências e Relatórios

## Objetivo

Melhorar a rastreabilidade das execuções automatizadas.

### Itens do Backlog

* US013 — Evidências e Relatórios

### Entregas Planejadas

* ExtentReports
* Relatórios HTML
* Registro automático de falhas
* Captura de screenshots integrada aos relatórios

### Critério de Aceite

Cada execução deve gerar um relatório detalhado contendo evidências dos testes.

**Status:** 🚧 Em andamento

---

# Sprint 9 — Refatoração e Publicação

## Objetivo

Preparar o framework para publicação.

### Itens do Backlog

* US014 — Refatoração Final

### Entregas Planejadas

* Refatoração do código
* Revisão dos Page Objects
* Atualização da documentação
* Revisão do README
* Organização final do projeto

### Critério de Aceite

Framework documentado, organizado e pronto para publicação.

**Status:** ⏳ Planejado

---

# Resumo Geral

| Sprint   | Descrição                | Status          |
| -------- | ------------------------ | --------------- |
| Sprint 0 | Estrutura Inicial        | ✅ Concluído     |
| Sprint 1 | Infraestrutura           | ✅ Concluído     |
| Sprint 2 | Login                    | ✅ Concluído     |
| Sprint 3 | Cadastro                 | ✅ Concluído     |
| Sprint 4 | Produtos                 | ✅ Concluído     |
| Sprint 5 | Carrinho                 | ✅ Concluído     |
| Sprint 6 | Checkout                 | ✅ Concluído     |
| Sprint 7 | Data Driven Testing      | ✅ Concluído     |
| Sprint 8 | Evidências e Relatórios  | 🚧 Em andamento |
| Sprint 9 | Refatoração e Publicação | ⏳ Planejado     |

---

# Progresso do Projeto

**Progresso Atual:** **≈80%**

## Sprint Atual

**Sprint 8 — Evidências e Relatórios**

## Próxima Entrega

* Implementação do ExtentReports
* Geração de relatórios HTML
* Integração das evidências aos relatórios
* Finalização da documentação do framework
