# Planejamento de Sprints

## Objetivo

Este documento apresenta a divisão das atividades do projeto em Sprints, permitindo acompanhar a evolução do framework de automação de testes desde sua estruturação inicial até sua conclusão.

---

# Sprint 0 — Estrutura Inicial

## Objetivo

Preparar o ambiente e a estrutura base do projeto.

## Itens do Backlog

* US001 — Estrutura Inicial

## Entregas

* Projeto xUnit criado
* Estrutura de diretórios definida
* Repositório Git configurado
* Documentação inicial criada

## Status

Concluído

---

# Sprint 1 — Infraestrutura de Automação

## Objetivo

Desenvolver os componentes reutilizáveis do framework.

## Itens do Backlog

* US002 — Gerenciamento do Navegador
* US003 — Captura de Evidências
* US004 — Configuração do Ambiente

## Entregas Realizadas

### DriverFactory

* Inicialização do navegador
* Encerramento do navegador
* Configuração do ChromeDriver

### ConfigReader

* Leitura da URL da aplicação
* Configurações do ambiente

### ScreenshotHelper

* Captura automática de evidências
* Organização dos arquivos gerados

### BaseTest

* Centralização da inicialização dos testes
* Encerramento automático do navegador

### InfrastructureTests

* Validação da infraestrutura do framework

## Critério de Aceite

O navegador deve abrir, executar ações simples e encerrar corretamente.

## Status

Concluído

---

# Sprint 2 — Login

## Objetivo

Automatizar o processo de autenticação.

## Itens do Backlog

* US005 — Login Válido
* US006 — Login Inválido

## Casos de Teste

* LOGIN001 — Acesso à página de login
* CT001 — Login com credenciais válidas
* CT002 — Login com senha inválida
* CT003 — Login com campos obrigatórios vazios
* CT004 — Logout com sucesso

## Entregas Realizadas

* LoginPage.cs
* LoginTests.cs
* UserData.cs
* Users.json
* TestDataReader.cs

## Critério de Aceite

Todos os cenários devem executar conforme esperado.

## Status

Concluído

---

# Sprint 3 — Cadastro de Usuários

## Objetivo

Automatizar o processo de cadastro de usuários.

## Itens do Backlog

* US007 — Cadastro de Usuário

## Casos de Teste

* CT005 — Acesso à área de cadastro
* CT006 — Início de cadastro com dados válidos
* CT007 — Validação de e-mail já cadastrado
* CT008 — Validação de campos obrigatórios
* CT009 — Criação e exclusão de conta

## Entregas Realizadas

* CadastroPage.cs
* CadastroTests.cs
* CadastroData.cs
* CadastroUsers.json
* Ampliação do TestDataReader para múltiplas massas de dados

## Critério de Aceite

As regras de cadastro devem ser validadas corretamente.

## Status

Concluído

---

# Sprint 4 — Pesquisa de Produtos

## Objetivo

Automatizar a busca de produtos.

## Itens do Backlog

* US008 — Pesquisa de Produto

## Casos de Teste Planejados

* CT010 — Pesquisa de produto existente
* CT011 — Pesquisa de produto inexistente

## Entregas Previstas

* ProdutoPage.cs
* ProdutoTests.cs

## Critério de Aceite

Os resultados devem refletir corretamente os termos pesquisados.

## Status

Planejado

---

# Sprint 5 — Carrinho de Compras

## Objetivo

Automatizar as operações do carrinho.

## Itens do Backlog

* US009 — Adicionar Produto ao Carrinho
* US010 — Remover Produto do Carrinho

## Casos de Teste Planejados

* CT012 — Adicionar produto ao carrinho
* CT013 — Adicionar múltiplos produtos
* CT014 — Remover produto do carrinho

## Entregas Previstas

* CarrinhoPage.cs
* CarrinhoTests.cs

## Critério de Aceite

O carrinho deve refletir corretamente as ações executadas.

## Status

Planejado

---

# Sprint 6 — Checkout

## Objetivo

Automatizar a finalização da compra.

## Itens do Backlog

* US011 — Finalização da Compra

## Casos de Teste Planejados

* CT015 — Checkout com sucesso
* CT016 — Checkout sem dados obrigatórios
* CT017 — Checkout com informações inválidas

## Entregas Previstas

* CheckoutPage.cs
* CheckoutTests.cs

## Critério de Aceite

O sistema deve permitir ou bloquear a compra conforme as regras de negócio.

## Status

Planejado

---

# Sprint 7 — Data Driven Testing

## Objetivo

Implementar massa de dados externa para execução dos testes.

## Itens do Backlog

* US012 — Massa de Dados Externa

## Entregas Realizadas

* Users.json
* CadastroUsers.json
* UserData.cs
* CadastroData.cs
* TestDataReader.cs

## Entregas Futuras

* Products.json
* CartData.json
* CheckoutData.json
* Parametrização dos demais módulos

## Critério de Aceite

Os cenários devem executar utilizando dados externos.

## Status

Parcialmente Concluído

---

# Sprint 8 — Evidências e Relatórios

## Objetivo

Melhorar a rastreabilidade das execuções.

## Itens do Backlog

* US013 — Relatórios de Execução

## Entregas Realizadas

* ScreenshotHelper
* Estrutura automática de evidências

## Entregas Futuras

* Relatórios HTML
* Integração com ExtentReports

## Critério de Aceite

Cada execução deve gerar evidências rastreáveis.

## Status

Parcialmente Concluído

---

# Sprint 9 — Refatoração e Publicação

## Objetivo

Preparar o projeto para publicação final.

## Itens do Backlog

* US014 — Melhoria do Framework

## Entregas Previstas

* Refatoração do código
* Atualização da documentação
* Revisão dos testes
* Atualização do README
* Revisão dos Page Objects

## Critério de Aceite

Framework documentado, organizado e pronto para utilização.

## Status

Planejado

---

# Resumo Geral

| Sprint   | Descrição                | Status                 |
| -------- | ------------------------ | ---------------------- |
| Sprint 0 | Estrutura Inicial        | Concluído              |
| Sprint 1 | Infraestrutura           | Concluído              |
| Sprint 2 | Login                    | Concluído              |
| Sprint 3 | Cadastro                 | Concluído              |
| Sprint 4 | Pesquisa de Produtos     | Planejado              |
| Sprint 5 | Carrinho                 | Planejado              |
| Sprint 6 | Checkout                 | Planejado              |
| Sprint 7 | Data Driven Testing      | Parcialmente Concluído |
| Sprint 8 | Evidências e Relatórios  | Parcialmente Concluído |
| Sprint 9 | Refatoração e Publicação | Planejado              |

---

# Progresso do Projeto

Progresso Atual: 40%

Sprint Atual: Sprint 4 — Pesquisa de Produtos

Próxima Entrega:

* ProdutoPage.cs
* ProdutoTests.cs
* Casos CT010 e CT011
