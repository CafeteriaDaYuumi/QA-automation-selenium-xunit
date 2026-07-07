# Backlog do Projeto

## Visão Geral

Este documento reúne todas as funcionalidades, histórias de usuário, tarefas técnicas e melhorias previstas para o desenvolvimento do framework de automação de testes.

---

# Épico 1 — Estrutura do Framework

## US001 — Estrutura Inicial

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

✅ Concluído

---

# Épico 2 — Infraestrutura de Automação

## US002 — Gerenciamento do Navegador

### Status

✅ Concluído

### Tarefas

* DriverFactory
* ChromeDriver
* BaseTest
* Inicialização e encerramento do navegador

---

## US003 — Captura de Evidências

### Status

✅ Concluído

### Tarefas

* ScreenshotHelper
* Organização automática das evidências
* Captura durante os testes

---

## US004 — Configuração do Ambiente

### Status

✅ Concluído

### Tarefas

* ConfigReader
* appsettings.json
* Configuração automática do ambiente

---

# Épico 3 — Login

## US005 — Login Válido

### Casos de Teste

* LOGIN001
* CT001
* CT004

### Status

✅ Concluído

---

## US006 — Login Inválido

### Casos de Teste

* CT002
* CT003

### Status

✅ Concluído

---

# Épico 4 — Cadastro

## US007 — Cadastro de Usuário

### Casos de Teste

* CT005
* CT006
* CT007
* CT008
* CT009

### Tarefas

* CadastroPage
* CadastroTests
* CadastroData
* CadastroUsers.json
* Fluxo completo de criação
* Exclusão de conta

### Status

✅ Concluído

---

# Épico 5 — Produtos

## US008 — Pesquisa de Produtos

### Casos de Teste

* CT010 — Acessar área de produtos
* CT011 — Pesquisar produto existente
* CT012 — Pesquisar produto inexistente
* CT013 — Visualizar detalhes do produto

### Tarefas

* ProductPage
* ProductTests
* ProductData
* Products.json
* Pesquisa de produtos
* Validação de resultados
* Visualização de detalhes

### Status

✅ Concluído

---

# Épico 6 — Carrinho

## US009 — Adicionar Produtos ao Carrinho

### Casos de Teste

* CT014
* CT015

### Status

✅ Concluído

### Tarefas

* CartPage
* CartTests
* CartData
* CartItems.json
* Adição de produtos
* Adição múltipla

---

## US010 — Remover Produtos do Carrinho

### Casos de Teste

* CT016

### Status

✅ Concluído

### Tarefas

* Remoção de produtos
* Validação do carrinho atualizado

---

# Épico 7 — Checkout

## US011 — Finalização da Compra

### Casos de Teste

* CT017 — Acessar tela de checkout
* CT018 — Finalizar compra
* CT019 — Acessar tela de pagamento
* CT020 — Finalizar compra utilizando segunda massa de dados

### Tarefas

* CheckoutPage
* CheckoutTests
* CheckoutData
* CheckoutData.json
* Fluxo completo de checkout
* Pagamento
* Validação da navegação
* Segunda massa de dados

### Status

✅ Concluído

---

# Épico 8 — Data Driven Testing

## US012 — Massa de Dados Externa

### Casos de Teste

* CT021 — Leitura da massa de usuários
* CT022 — Leitura da massa de produtos
* CT023 — Leitura da massa do carrinho
* CT024 — Leitura da massa de checkout

### Tarefas

* Implementar TestDataReader genérico
* Criar TestDataModel
* Criar UserData
* Criar CadastroData
* Criar ProductData
* Criar CartData
* Criar CheckoutData
* Externalizar todas as massas de dados
* Parametrizar todos os módulos
* Validar leitura dos arquivos JSON

### Status

✅ Concluído

---

# Épico 9 — Evidências e Relatórios

## US013 — Relatórios de Execução

### Descrição

Como QA Automation,
Quero gerar relatórios automáticos,
Para facilitar a análise das execuções.

### Tarefas

* Integrar ExtentReports
* Gerar relatório HTML
* Integrar screenshots aos relatórios
* Consolidar pasta Reports
* Melhorar rastreabilidade

### Prioridade

Média

### Status

✅ Concluído

---

# Épico 10 — Refatoração Final

## US014 — Melhoria do Framework

### Tarefas

* Refatorar código
* Revisar documentação
* Revisar Page Objects
* Revisar testes
* Criar WaitHelper
* Eliminar esperas desnecessárias
* Melhorar reutilização de código
* Publicar versão final

### Prioridade

Média

### Status

✅ Concluído

---

# Resumo do Backlog

| ID    | História                       | Prioridade | Status          |
| ----- | ------------------------------ | ---------- | --------------- |
| US001 | Estrutura Inicial              | Alta       | Concluído     |
| US002 | Gerenciamento do Navegador     | Alta       | Concluído     |
| US003 | Captura de Evidências          | Alta       | Concluído     |
| US004 | Configuração do Ambiente       | Alta       | Concluído     |
| US005 | Login Válido                   | Alta       | Concluído     |
| US006 | Login Inválido                 | Alta       | Concluído     |
| US007 | Cadastro de Usuário            | Alta       | Concluído     |
| US008 | Pesquisa de Produtos           | Média      | Concluído     |
| US009 | Adicionar Produtos ao Carrinho | Alta       | Concluído     |
| US010 | Remover Produtos do Carrinho   | Alta       | Concluído     |
| US011 | Finalização da Compra          | Alta       | Concluído     |
| US012 | Data Driven Testing            | Média      | Concluído     |
| US013 | Evidências e Relatórios        | Média      | Concluído     |
| US014 | Refatoração Final              | Média      | Concluído     |

---

# Situação Atual

**Sprints concluídas:** 0 a 8

**Sprint atual:** Sprint 9 — Refatoração e Publicação

**Próxima entrega:**

* Padronização final do código-fonte em inglês
* Revisão da estrutura do framework
* Remoção de código redundante ou não utilizado
* Validação consolidada da suíte de testes
* Atualização final da documentação
* Atualização do README
* Preparação do repositório para publicação
* Finalização do framework