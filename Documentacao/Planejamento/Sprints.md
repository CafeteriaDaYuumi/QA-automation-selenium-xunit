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

## Entregas Previstas

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

## Critério de Aceite

O navegador deve abrir, executar ações simples e encerrar corretamente.

## Status

Pendente

---

# Sprint 2 — Login

## Objetivo

Automatizar o processo de autenticação.

## Itens do Backlog

* US005 — Login Válido
* US006 — Login Inválido

## Casos de Teste

* CT001 — Login com credenciais válidas
* CT002 — Login com senha inválida
* CT003 — Login com campos vazios

## Entregas Previstas

* LoginPage.cs
* LoginTests.cs

## Critério de Aceite

Todos os cenários devem executar conforme esperado.

## Status

Pendente

---

# Sprint 3 — Cadastro de Usuários

## Objetivo

Automatizar o processo de cadastro.

## Itens do Backlog

* US007 — Cadastro de Usuário

## Casos de Teste

* CT004 — Cadastro válido
* CT005 — Cadastro com e-mail duplicado
* CT006 — Cadastro sem campos obrigatórios

## Entregas Previstas

* CadastroPage.cs
* CadastroTests.cs

## Critério de Aceite

As regras de cadastro devem ser validadas corretamente.

## Status

Pendente

---

# Sprint 4 — Pesquisa de Produtos

## Objetivo

Automatizar a busca de produtos.

## Itens do Backlog

* US008 — Pesquisa de Produto

## Casos de Teste

* CT007 — Pesquisa de produto existente
* CT008 — Pesquisa de produto inexistente

## Entregas Previstas

* ProductPage.cs
* ProductTests.cs

## Critério de Aceite

Os resultados devem refletir corretamente os termos pesquisados.

## Status

Pendente

---

# Sprint 5 — Carrinho de Compras

## Objetivo

Automatizar as operações do carrinho.

## Itens do Backlog

* US009 — Adicionar Produto ao Carrinho
* US010 — Remover Produto do Carrinho

## Casos de Teste

* CT009 — Adicionar produto
* CT010 — Adicionar múltiplos produtos
* CT011 — Remover produto

## Entregas Previstas

* CartPage.cs
* CartTests.cs

## Critério de Aceite

O carrinho deve refletir corretamente as ações executadas.

## Status

Pendente

---

# Sprint 6 — Checkout

## Objetivo

Automatizar a finalização da compra.

## Itens do Backlog

* US011 — Finalização da Compra

## Casos de Teste

* CT012 — Checkout com sucesso
* CT013 — Checkout sem dados obrigatórios
* CT014 — Checkout com informações inválidas

## Entregas Previstas

* CheckoutPage.cs
* CheckoutTests.cs

## Critério de Aceite

O sistema deve permitir ou bloquear a compra conforme as regras de negócio.

## Status

Pendente

---

# Sprint 7 — Data Driven Testing

## Objetivo

Implementar massa de dados externa para execução dos testes.

## Itens do Backlog

* US012 — Massa de Dados Externa

## Entregas Previstas

* Users.json
* Products.json
* Parametrização dos testes

## Critério de Aceite

Os cenários devem executar utilizando dados externos.

## Status

Pendente

---

# Sprint 8 — Evidências e Relatórios

## Objetivo

Melhorar rastreabilidade das execuções.

## Itens do Backlog

* US013 — Relatórios de Execução

## Entregas Previstas

* Screenshots automáticas
* Estrutura de relatórios
* Organização das evidências

## Critério de Aceite

Cada execução deve gerar evidências rastreáveis.

## Status

Pendente

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

## Critério de Aceite

Framework documentado, organizado e pronto para utilização.

## Status

Pendente

---

# Resumo Geral

| Sprint   | Descrição                | Status    |
| -------- | ------------------------ | --------- |
| Sprint 0 | Estrutura Inicial        | Concluído |
| Sprint 1 | Infraestrutura           | Pendente  |
| Sprint 2 | Login                    | Pendente  |
| Sprint 3 | Cadastro                 | Pendente  |
| Sprint 4 | Pesquisa de Produtos     | Pendente  |
| Sprint 5 | Carrinho                 | Pendente  |
| Sprint 6 | Checkout                 | Pendente  |
| Sprint 7 | Data Driven Testing      | Pendente  |
| Sprint 8 | Evidências e Relatórios  | Pendente  |
| Sprint 9 | Refatoração e Publicação | Pendente  |

---

# Progresso do Projeto

Progresso Atual: 10%

Sprint Atual: Sprint 1 — Infraestrutura de Automação
