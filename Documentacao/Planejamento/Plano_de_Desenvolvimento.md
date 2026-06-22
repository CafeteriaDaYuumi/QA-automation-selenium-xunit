# Plano de Desenvolvimento

## 1. Informações do Projeto

### Nome do Projeto

QA Test Automation Framework

### Tipo de Projeto

Framework de Automação de Testes Web

### Tecnologias Utilizadas

* C#
* .NET
* Selenium WebDriver
* xUnit
* Git
* GitHub

### Metodologia

Desenvolvimento incremental baseado em Sprints.

---

# 2. Objetivo

Desenvolver um framework de automação de testes web utilizando Selenium WebDriver e xUnit, aplicando boas práticas de automação, reutilização de código e organização em camadas através do padrão Page Object Model (POM).

O projeto será utilizado como ambiente de estudo, demonstração de conhecimentos técnicos e composição de portfólio profissional na área de Qualidade de Software (QA).

---

# 3. Escopo

O framework deverá permitir a automação dos principais fluxos de um sistema de e-commerce.

## Funcionalidades previstas

* Login
* Cadastro de Usuários
* Recuperação de Senha
* Pesquisa de Produtos
* Adição ao Carrinho
* Remoção do Carrinho
* Checkout
* Logout

---

# 4. Estrutura do Projeto

```text
QA-test-automation-framework
│
├── Documentacao
├── Drivers
├── Pages
├── Tests
├── Utils
├── TestData
├── Evidence
├── Reports
└── README.md
```

---

# 5. Arquitetura

O projeto seguirá o padrão Page Object Model (POM).

## Camadas

### Drivers

Responsável pelo gerenciamento dos navegadores.

### Pages

Responsável pela representação das páginas da aplicação.

### Tests

Responsável pelos cenários automatizados.

### Utils

Classes auxiliares reutilizáveis.

### TestData

Massas de dados utilizadas nos testes.

### Evidence

Captura e armazenamento de evidências.

### Reports

Relatórios de execução.

---

# 6. Conceitos Aplicados

* Testes Funcionais
* Testes de Regressão
* Automação de Testes
* Selenium WebDriver
* xUnit
* Page Object Model (POM)
* Data Driven Testing
* Evidências de Teste
* Boas Práticas de Automação
* Controle de Versão com Git

---

# 7. Roadmap de Desenvolvimento

| Sprint   | Descrição                   |
| -------- | --------------------------- |
| Sprint 0 | Estrutura Inicial           |
| Sprint 1 | Infraestrutura do Framework |
| Sprint 2 | Login                       |
| Sprint 3 | Cadastro                    |
| Sprint 4 | Pesquisa de Produtos        |
| Sprint 5 | Carrinho                    |
| Sprint 6 | Checkout                    |
| Sprint 7 | Data Driven Testing         |
| Sprint 8 | Evidências e Relatórios     |
| Sprint 9 | Refatoração e Publicação    |

---

# 8. Critérios de Sucesso

O projeto será considerado concluído quando:

* Todos os cenários planejados estiverem automatizados.
* As evidências forem geradas corretamente.
* A documentação estiver atualizada.
* O código estiver organizado conforme o padrão POM.
* O framework permitir fácil manutenção e expansão.

---

# 9. Resultados Esperados

Ao final do desenvolvimento, o projeto deverá demonstrar conhecimentos em:

* Planejamento de Testes
* Automação Web
* Selenium WebDriver
* xUnit
* Estruturação de Frameworks
* Page Object Model
* Data Driven Testing
* Gestão de Evidências
* Controle de Versão
* Boas Práticas de QA

---

# 10. Status Atual

Data de Início: Junho de 2026

Situação Atual:

✔ Estrutura inicial do framework criada.

Próxima etapa:

Sprint 1 — Desenvolvimento da infraestrutura de automação.
