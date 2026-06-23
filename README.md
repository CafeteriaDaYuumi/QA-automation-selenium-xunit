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

## Produtos

* Pesquisa de produto existente
* Pesquisa de produto inexistente

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

* Leitura do arquivo Users.json
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
| Sprint 2 | Login                       | Em andamento |
| Sprint 3 | Cadastro                    | Planejado    |
| Sprint 4 | Pesquisa de Produtos        | Planejado    |
| Sprint 5 | Carrinho                    | Planejado    |
| Sprint 6 | Checkout                    | Planejado    |
| Sprint 7 | Data Driven Testing         | Planejado    |
| Sprint 8 | Evidências e Relatórios     | Planejado    |
| Sprint 9 | Refatoração e Publicação    | Planejado    |

---

# Conceitos Aplicados

* Testes Funcionais
* Testes de Regressão
* Selenium WebDriver
* xUnit
* Page Object Model (POM)
* Data Driven Testing
* Evidências de Teste
* Organização em Camadas
* Controle de Versão com Git
* Separação de massa de dados
* Reutilização de componentes

---

# Como Executar os Testes

Execute todos os testes:

```bash
dotnet test
```

Execute com detalhes no console:

```bash
dotnet test --logger "console;verbosity=detailed"
```

Execute um teste específico:

```bash
dotnet test --filter CT001
```

---

# Status Atual

### Sprint Atual

Sprint 2 — Login

### Concluído

* Estrutura inicial do framework
* Infraestrutura de automação
* DriverFactory
* ConfigReader
* ScreenshotHelper
* BaseTest
* InfrastructureTests
* LoginPage
* LoginTests
* Massa de dados para login
* Evidências automáticas
* Planejamento dos testes
* Documentação inicial

### Próxima Entrega

Finalização da Sprint 2 com revisão dos testes de Login e preparação para a Sprint 3 — Cadastro de Usuário.
