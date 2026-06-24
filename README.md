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

* Acesso à área de cadastro
* Cadastro válido
* Cadastro com e-mail duplicado
* Cadastro sem campos obrigatórios
* Criação e exclusão de conta

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

* Leitura de arquivos JSON
* Separação entre dados e código
* Apoio ao conceito de Data Driven Testing

---

## BaseTest

Responsável por centralizar a inicialização e o encerramento do navegador.

### Funcionalidades

* Inicialização do WebDriver
* Encerramento automático do navegador
* Reutilização de código

---

# Testes Implementados

## Infraestrutura

* INFRA001 — Deve abrir navegador e acessar o site

---

## Login

* LOGIN001 — Deve acessar página de login
* CT001 — Login com credenciais válidas
* CT002 — Login com senha inválida
* CT003 — Login com campos vazios
* CT004 — Logout com sucesso

---

## Cadastro

* CT005 — Acessar área de cadastro
* CT006 — Iniciar cadastro com dados válidos
* CT007 — Validar e-mail já cadastrado
* CT008 — Validar campos obrigatórios
* CT009 — Criar e excluir conta

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
| Sprint 3 | Cadastro                    | Em validação |
| Sprint 4 | Pesquisa de Produtos        | Planejado    |
| Sprint 5 | Carrinho                    | Planejado    |
| Sprint 6 | Checkout                    | Planejado    |
| Sprint 7 | Data Driven Testing         | Planejado    |
| Sprint 8 | Evidências e Relatórios     | Planejado    |
| Sprint 9 | Refatoração e Publicação    | Planejado    |

---

# Status Atual

### Sprint Atual

Sprint 3 — Cadastro de Usuários

### Concluído

* Estrutura do Framework
* DriverFactory
* ConfigReader
* ScreenshotHelper
* TestDataReader
* BaseTest
* InfrastructureTests
* LoginPage
* LoginTests
* CadastroPage
* CadastroTests
* UserData
* CadastroData
* Users.json
* CadastroUsers.json
* CT001 ao CT008
* Planejamento dos Testes
* Documentação Inicial

### Em Validação

* CT009 — Criação e exclusão de conta

### Próxima Entrega

Implementação do módulo de Pesquisa de Produtos utilizando Page Object Model (POM).
