# QA Test Automation Framework

Framework de automação de testes web desenvolvido com Selenium WebDriver, xUnit e C#, seguindo o padrão Page Object Model (POM) e boas práticas de automação de testes.

## Objetivo

Desenvolver um framework de automação capaz de validar os principais fluxos de um sistema de e-commerce, simulando um ambiente real de trabalho na área de Qualidade de Software (QA).

O projeto contempla desde o planejamento dos testes até a implementação dos cenários automatizados, incluindo documentação, evidências e organização dos artefatos de teste.

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

* Login válido
* Login inválido
* Login com campos vazios

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
* Organização automática das evidências
* Registro do local de armazenamento

---

## InfrastructureTests

Responsável pela validação da infraestrutura do framework.

### Validações

* Inicialização do WebDriver
* Navegação para a aplicação
* Captura de evidências
* Validação do carregamento da página
* Encerramento correto do navegador

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

---

# Status Atual

### Sprint Atual

Sprint 2 — Login

### Concluído

* Estrutura do Framework
* DriverFactory
* ConfigReader
* ScreenshotHelper
* InfrastructureTests
* Planejamento dos Testes
* Documentação Inicial

### Próxima Entrega

Implementação do módulo de Login utilizando Page Object Model (POM).
