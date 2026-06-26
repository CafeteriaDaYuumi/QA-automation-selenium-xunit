# QA Test Automation Framework

Framework de automação de testes web desenvolvido com Selenium WebDriver, xUnit e C#, seguindo o padrão Page Object Model (POM) e boas práticas de automação de testes.

## Objetivo

Desenvolver um framework de automação capaz de validar os principais fluxos de um sistema de e-commerce, simulando um ambiente real de trabalho na área de Qualidade de Software (QA).

O projeto contempla desde o planejamento dos testes até a implementação dos cenários automatizados, incluindo documentação, evidências, massa de dados, Data Driven Testing e organização dos artefatos de teste.

---

# Tecnologias Utilizadas

* C#
* .NET 10
* Selenium WebDriver
* xUnit
* Newtonsoft.Json
* ExtentReports
* Git
* GitHub

---

# Funcionalidades Implementadas

## Login

* Acesso à página de login
* Login válido
* Login inválido
* Login com campos vazios
* Logout

## Cadastro

* Cadastro válido
* Cadastro com e-mail duplicado
* Cadastro sem campos obrigatórios
* Criação e exclusão de conta

## Produtos

* Acesso à área de produtos
* Pesquisa de produto existente
* Pesquisa de produto inexistente
* Visualização dos detalhes do produto

## Carrinho

* Adicionar produto ao carrinho
* Adicionar múltiplos produtos
* Remover produto do carrinho

## Checkout

* Acesso ao checkout
* Acesso à tela de pagamento
* Finalização da compra
* Finalização utilizando múltiplas massas de dados

## Data Driven Testing

* Leitura automática de massa de usuários
* Leitura automática de produtos
* Leitura automática de carrinho
* Leitura automática de checkout

---

# Estrutura do Projeto

```text
QA-automation-selenium-xunit
│
├── Documentacao
│   ├── Planejamento
│   ├── Testes
│   └── Defeitos
│
├── Drivers
├── Models
├── Pages
├── Tests
├── Utils
├── TestData
├── Evidence
├── Reports
│
├── appsettings.json
└── README.md
```

---

# Infraestrutura Implementada

## DriverFactory

* Inicialização do ChromeDriver
* Configuração do navegador
* Gerenciamento do ciclo de vida do WebDriver

## ConfigReader

* Leitura do appsettings.json
* Recuperação da URL base

## ScreenshotHelper

* Captura automática de evidências
* Organização por data e horário

## TestDataReader

* Leitura genérica de arquivos JSON
* Suporte a Data Driven Testing
* Desserialização automática da massa de dados

## BaseTest

* Inicialização automática do navegador
* Encerramento automático da sessão
* Reutilização da infraestrutura entre os testes

---

# Testes Implementados

## Infraestrutura

* INFRA001 — Deve abrir navegador e acessar o site

## Login

* LOGIN001 — Deve acessar página de login
* CT001 — Login com credenciais válidas
* CT002 — Login com senha inválida
* CT003 — Login com campos vazios
* CT004 — Logout com sucesso

## Cadastro

* CT005 — Deve acessar área de cadastro
* CT006 — Deve iniciar cadastro com dados válidos
* CT007 — Deve validar e-mail já cadastrado
* CT008 — Deve validar campos obrigatórios no cadastro
* CT009 — Deve criar e excluir conta com sucesso

## Produtos

* CT010 — Deve acessar área de produtos
* CT011 — Deve pesquisar produto existente
* CT012 — Deve pesquisar produto inexistente
* CT013 — Deve visualizar detalhes do produto

## Carrinho

* CT014 — Deve adicionar produto ao carrinho
* CT015 — Deve adicionar múltiplos produtos ao carrinho
* CT016 — Deve remover produto do carrinho

## Checkout

* CT017 — Deve acessar tela de checkout
* CT018 — Deve finalizar compra com sucesso
* CT019 — Deve acessar tela de pagamento
* CT020 — Deve finalizar compra utilizando segunda massa de dados

## Data Driven Testing

* CT021 — Deve ler massa de usuários
* CT022 — Deve ler massa de produtos
* CT023 — Deve ler massa de carrinho
* CT024 — Deve ler massa de checkout

---

# Documentação

## Planejamento

* Plano de Desenvolvimento
* Backlog
* Planejamento de Sprints

## Testes

* Plano de Testes
* Cenários de Teste
* Casos de Teste
* Critérios de Aceite
* Massa de Teste

## Qualidade

* Registro de Defeitos
* Evidências
* Relatórios

---

# Roadmap

| Sprint | Descrição | Status |
|--------|-----------|---------|
| Sprint 0 | Estrutura Inicial |  Concluído |
| Sprint 1 | Infraestrutura do Framework | Concluído |
| Sprint 2 | Login | Concluído |
| Sprint 3 | Cadastro |  Concluído |
| Sprint 4 | Produtos | Concluído |
| Sprint 5 | Carrinho |  Concluído |
| Sprint 6 | Checkout |  Concluído |
| Sprint 7 | Data Driven Testing |  Concluído |
| Sprint 8 | Evidências e Relatórios | Em andamento |
| Sprint 9 | Refatoração e Publicação |  Planejado |

---

# Status Atual

### Sprint Atual

**Sprint 8 — Evidências e Relatórios**

### Concluído

* Estrutura do Framework
* DriverFactory
* ConfigReader
* ScreenshotHelper
* TestDataReader
* BaseTest
* LoginPage
* CadastroPage
* ProductPage
* CartPage
* CheckoutPage
* LoginTests
* CadastroTests
* ProductTests
* CartTests
* CheckoutTests
* DataDrivenTests
* UserData
* ProductData
* CartData
* CheckoutData
* TestDataModel
* Users.json
* Products.json
* CartItems.json
* CheckoutData.json
* CT001 ao CT024
* Planejamento dos Testes
* Documentação Inicial

### Próxima Entrega

Implementação da geração de relatórios automatizados, consolidação das evidências de execução e integração com ExtentReports para apresentação dos resultados dos testes.