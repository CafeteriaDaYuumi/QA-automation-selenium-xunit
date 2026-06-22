# QA Test Automation Framework

Framework de automação de testes web desenvolvido com Selenium WebDriver, xUnit e C#, seguindo boas práticas de automação, organização em camadas e o padrão Page Object Model (POM).

## Objetivo

Este projeto tem como objetivo demonstrar a construção de um framework de automação de testes capaz de validar os principais fluxos de um sistema de e-commerce, abrangendo desde o planejamento dos testes até a implementação dos cenários automatizados.

Além da automação, o projeto contempla a documentação dos principais artefatos utilizados no ciclo de vida de testes (STLC), simulando um ambiente real de trabalho para profissionais de Qualidade de Software (QA).

---

# Tecnologias Utilizadas

* C#
* .NET
* Selenium WebDriver
* xUnit
* Git
* GitHub

---

# Conceitos Aplicados

* Testes Funcionais
* Testes de Regressão
* Automação de Testes Web
* Page Object Model (POM)
* Data Driven Testing
* Evidências de Teste
* Controle de Versão
* Organização em Camadas
* Boas Práticas de QA

---

# Estrutura do Projeto

```text
QA-test-automation-framework
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
└── README.md
```

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

* Adicionar produto
* Adicionar múltiplos produtos
* Remover produto

## Checkout

* Finalização da compra
* Validação de campos obrigatórios
* Validação de dados inválidos

---

# Documentação do Projeto

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
* Evidências de Teste
* Relatórios de Execução

---

# Roadmap

| Sprint   | Descrição                   | Status       |
| -------- | --------------------------- | ------------ |
| Sprint 0 | Estrutura Inicial           | Concluído    |
| Sprint 1 | Infraestrutura do Framework | Em andamento |
| Sprint 2 | Login                       | Planejado    |
| Sprint 3 | Cadastro                    | Planejado    |
| Sprint 4 | Pesquisa de Produtos        | Planejado    |
| Sprint 5 | Carrinho                    | Planejado    |
| Sprint 6 | Checkout                    | Planejado    |
| Sprint 7 | Data Driven Testing         | Planejado    |
| Sprint 8 | Evidências e Relatórios     | Planejado    |
| Sprint 9 | Refatoração e Publicação    | Planejado    |

---

# Objetivos de Aprendizagem

Este projeto foi criado para demonstrar conhecimentos em:

* Planejamento de Testes
* Execução de Testes
* Automação Web
* Selenium WebDriver
* xUnit
* Git e GitHub
* Estruturação de Frameworks
* Gestão de Evidências
* Documentação de QA

---

# Status Atual

Estrutura inicial do framework criada.

Documentação de planejamento e testes concluída.

Próxima etapa: desenvolvimento da infraestrutura de automação e implementação dos primeiros cenários automatizados.
