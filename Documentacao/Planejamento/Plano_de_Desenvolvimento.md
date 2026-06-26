# Plano de Desenvolvimento

## 1. Informações do Projeto

### Nome do Projeto

QA Test Automation Framework

### Tipo de Projeto

Framework de Automação de Testes Web

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

### Login

* Acesso à página de login
* Login válido
* Login inválido
* Login com campos vazios
* Logout

### Cadastro de Usuários

* Cadastro válido
* Validação de e-mail duplicado
* Validação de campos obrigatórios
* Criação e exclusão de conta

### Produtos

* Acesso à área de produtos
* Pesquisa de produto existente
* Pesquisa de produto inexistente
* Visualização dos detalhes do produto

### Carrinho

* Adição de produto ao carrinho
* Adição de múltiplos produtos
* Remoção de produtos

### Checkout

* Acesso à tela de checkout
* Finalização de compra
* Acesso à tela de pagamento
* Finalização utilizando segunda massa de dados

### Data Driven Testing

* Externalização da massa de dados
* Leitura automática dos arquivos JSON
* Validação da integridade da massa de dados

---

# Estrutura do Projeto

```text
QA-automation-selenium-xunit
│
├── Documentacao
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

# Conceitos Aplicados

* Testes Funcionais
* Testes de Regressão
* Selenium WebDriver
* xUnit
* Page Object Model (POM)
* Data Driven Testing
* Massa de Dados Externa (JSON)
* Organização em Camadas
* Evidências Automatizadas
* Separação entre código e dados
* Controle de Versão com Git

---

# Roadmap de Desenvolvimento

| Sprint   | Descrição                   | Status          |
| -------- | --------------------------- | --------------- |
| Sprint 0 | Estrutura Inicial           | ✅ Concluído     |
| Sprint 1 | Infraestrutura do Framework | ✅ Concluído     |
| Sprint 2 | Login                       | ✅ Concluído     |
| Sprint 3 | Cadastro                    | ✅ Concluído     |
| Sprint 4 | Produtos                    | ✅ Concluído     |
| Sprint 5 | Carrinho                    | ✅ Concluído     |
| Sprint 6 | Checkout                    | ✅ Concluído     |
| Sprint 7 | Data Driven Testing         | ✅ Concluído     |
| Sprint 8 | Evidências e Relatórios     | 🚧 Em andamento |
| Sprint 9 | Refatoração e Publicação    | ⏳ Planejado     |

---

# Status Atual

**Data de Início**

Junho de 2026

## Situação Atual

✔ Estrutura inicial do framework criada

✔ Infraestrutura de automação implementada

✔ Framework baseado em Page Object Model (POM)

✔ Captura automática de evidências

✔ Leitura de configurações via appsettings.json

✔ Login automatizado

✔ Cadastro automatizado

✔ Pesquisa de produtos automatizada

✔ Carrinho de compras automatizado

✔ Checkout automatizado

✔ Massa de dados totalmente externalizada

✔ TestDataReader implementado

✔ Data Driven Testing implementado

✔ Modelos de dados separados por funcionalidade

✔ Arquivos JSON independentes para cada módulo

✔ Testes de validação das massas de dados (CT021–CT024)

✔ Mais de 20 cenários automatizados implementados

---

# Próxima Etapa

## Sprint 8 — Evidências e Relatórios

### Objetivos

* Implementar ExtentReports
* Gerar relatórios HTML automaticamente
* Integrar screenshots aos relatórios
* Melhorar a rastreabilidade das execuções
* Consolidar a documentação técnica do framework

---

# Visão Geral do Projeto

Ao término da Sprint 7, o framework possui cobertura automatizada dos principais fluxos de um sistema de e-commerce, incluindo autenticação, cadastro, pesquisa de produtos, operações de carrinho, checkout e gerenciamento de massa de dados externa.

A arquitetura foi construída utilizando Page Object Model (POM), Data Driven Testing, organização em camadas e geração automática de evidências, proporcionando uma base sólida para evolução do framework e para demonstração de boas práticas de automação de testes em projetos reais.
