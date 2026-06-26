# QA Test Automation Framework

Framework de automação de testes web desenvolvido com Selenium WebDriver, xUnit e C#, seguindo o padrão Page Object Model (POM) e boas práticas de automação de testes.

## Objetivo

Desenvolver um framework de automação capaz de validar os principais fluxos de um sistema de e-commerce, simulando um ambiente real de trabalho na área de Qualidade de Software (QA).

O projeto contempla desde o planejamento dos testes até a implementação dos cenários automatizados, incluindo documentação, evidências, massa de dados e organização dos artefatos de teste.

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

# Funcionalidades Planejadas

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

* Finalização da compra
* Validação de campos obrigatórios
* Validação de dados inválidos

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

Responsável pelo gerenciamento do navegador durante a execução dos testes.

### Funcionalidades

* Inicialização do ChromeDriver
* Configuração do navegador
* Gerenciamento de tempo de espera
* Encerramento seguro do navegador

---

## ConfigReader

Responsável pela leitura das configurações da aplicação.

### Funcionalidades

* Leitura do arquivo appsettings.json
* Recuperação da URL base da aplicação
* Tratamento de erros de configuração

---

## ScreenshotHelper

Responsável pela geração automática de evidências.

### Funcionalidades

* Captura de screenshots
* Organização automática das evidências por execução
* Registro do local de armazenamento

---

## TestDataReader

Responsável pela leitura da massa de dados utilizada nos testes.

### Funcionalidades

* Leitura de arquivos JSON
* Separação entre dados de teste e código
* Apoio ao conceito de Data Driven Testing

---

## BaseTest

Responsável por centralizar a inicialização e o encerramento do navegador.

### Funcionalidades

* Inicialização do WebDriver antes dos testes
* Encerramento automático do navegador após a execução
* Redução de duplicação de código nas classes de teste

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

| Sprint   | Descrição                   | Status       |
| -------- | --------------------------- | ------------ |
| Sprint 0 | Estrutura Inicial           | Concluído    |
| Sprint 1 | Infraestrutura do Framework | Concluído    |
| Sprint 2 | Login                       | Concluído    |
| Sprint 3 | Cadastro                    | Concluído    |
| Sprint 4 | Produtos                    | Concluído    |
| Sprint 5 | Carrinho                    | Concluído    |
| Sprint 6 | Checkout                    | Em andamento |
| Sprint 7 | Data Driven Testing         | Planejado    |
| Sprint 8 | Evidências e Relatórios     | Planejado    |
| Sprint 9 | Refatoração e Publicação    | Planejado    |

---

# Status Atual

### Sprint Atual

Sprint 6 — Checkout

### Concluído

* Estrutura do Framework
* DriverFactory
* ConfigReader
* ScreenshotHelper
* BaseTest
* LoginPage
* LoginTests
* CadastroPage
* CadastroTests
* ProductPage
* ProductTests
* CartPage
* CartTests
* UserData
* ProductData
* CartData
* Users.json
* Products.json
* CartItems.json
* CT001 ao CT016
* Planejamento dos Testes
* Documentação Inicial

### Próxima Entrega

Implementação do módulo de Checkout utilizando Selenium WebDriver, xUnit e Page Object Model (POM).
