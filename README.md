# QA Test Automation Framework

Framework de automação de testes web desenvolvido com Selenium WebDriver, xUnit e C#, seguindo o padrão Page Object Model (POM) e boas práticas de automação de testes.

## Objetivo

Desenvolver um framework de automação capaz de validar os principais fluxos de um sistema de e-commerce, simulando um ambiente real de trabalho na área de Qualidade de Software (QA).

O projeto contempla desde o planejamento dos testes até a implementação dos cenários automatizados, incluindo documentação, evidências, relatórios, massa de dados, Data Driven Testing e organização dos artefatos de teste.

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

## Evidências e Relatórios

* Captura automática de screenshots
* Organização das evidências por execução
* Geração de relatórios HTML com ExtentReports
* Registro de logs de execução
* Registro de status dos testes
* Anexação de evidências aos relatórios

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
* Configuração de tempo de espera para localização de elementos
* Configuração de tempo máximo de carregamento das páginas
* Configuração do navegador para reduzir interferências durante a execução

## ConfigReader

* Leitura do `appsettings.json`
* Recuperação da URL base
* Leitura genérica de configurações
* Validação da existência do arquivo de configuração

## ScreenshotHelper

* Captura automática de evidências
* Organização por data e horário
* Armazenamento das evidências por execução
* Retorno do caminho da imagem gerada para integração com relatórios

## TestDataReader

* Leitura genérica de arquivos JSON
* Suporte a Data Driven Testing
* Desserialização automática da massa de dados
* Recuperação de listas de dados
* Recuperação de usuários por chave
* Validação da existência e integridade dos arquivos

## ReportHelper

* Configuração do ExtentReports
* Geração de relatórios HTML
* Registro de logs de execução
* Registro de sucesso e falha dos testes
* Anexação de screenshots ao relatório
* Informações do ambiente de execução

## BaseTest

* Inicialização automática do navegador
* Encerramento automático da sessão
* Finalização automática do relatório
* Reutilização da infraestrutura entre os testes

## Execução Sequencial

* Desabilitação da paralelização dos testes
* Redução de conflitos entre cenários
* Maior estabilidade em fluxos que compartilham estado da aplicação

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

# Resumo dos Testes

**Casos de teste funcionais e de dados implementados:** 25

* LOGIN001
* CT001 ao CT024

Além dos casos acima, o framework possui o teste de infraestrutura:

* INFRA001

---

# Relatórios

O framework gera automaticamente relatórios HTML utilizando ExtentReports.

Os relatórios incluem:

* Nome dos testes executados
* Status da execução
* Logs informativos
* Registro de sucesso
* Registro de falha
* Evidências anexadas
* Informações do ambiente

Os arquivos são gerados na estrutura:

```text
Reports
└── TestReport_AAAA-MM-DD_HH-mm-ss.html
```

---

# Evidências

As evidências são capturadas automaticamente durante a execução dos testes e armazenadas na estrutura:

```text
Evidence
└── AAAA-MM-DD_HH-mm-ss
    ├── CT001_LoginValido.png
    ├── CT010_AcessarAreaDeProdutos.png
    └── ...
```

As capturas podem ser integradas aos relatórios HTML gerados pelo ExtentReports, permitindo maior rastreabilidade das execuções.

---

# Massa de Dados

As massas de dados utilizadas pelo framework são armazenadas externamente em arquivos JSON.

```text
TestData
│
├── Users.json
├── CadastroUsers.json
├── Products.json
├── CartItems.json
└── CheckoutData.json
```

Essa abordagem permite:

* Separação entre código e dados de teste
* Reutilização das massas
* Facilidade de manutenção
* Suporte a Data Driven Testing
* Maior escalabilidade do framework

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

| Sprint   | Descrição                   | Status        |
| -------- | --------------------------- | ------------- |
| Sprint 0 | Estrutura Inicial           | Concluído     |
| Sprint 1 | Infraestrutura do Framework | Concluído     |
| Sprint 2 | Login                       | Concluído     |
| Sprint 3 | Cadastro                    | Concluído     |
| Sprint 4 | Produtos                    | Concluído     |
| Sprint 5 | Carrinho                    | Concluído     |
| Sprint 6 | Checkout                    | Concluído     |
| Sprint 7 | Data Driven Testing         | Concluído     |
| Sprint 8 | Evidências e Relatórios     | Concluído     |
| Sprint 9 | Refatoração e Publicação    | Concluído     |

---

# Status Atual

### Sprint Atual

**Sprint 9 — Refatoração e Publicação**

### Sprints Concluídas

**Sprint 0 à Sprint 8**

### Concluído

* Estrutura do Framework
* DriverFactory
* ConfigReader
* ScreenshotHelper
* TestDataReader
* ReportHelper
* BaseTest
* Execução sequencial dos testes
* LoginPage
* ProductPage
* CartPage
* CheckoutPage
* LoginTests
* ProductTests
* CartTests
* CheckoutTests
* DataDrivenTests
* InfrastructureTests
* UserData
* ProductData
* CartData
* CheckoutData
* Users.json
* Products.json
* CartItems.json
* CheckoutData.json
* LOGIN001
* CT001 ao CT024
* Relatórios com ExtentReports
* Evidências automatizadas
* Integração de screenshots aos relatórios
* Planejamento dos testes
* Documentação do framework

### Em Refatoração

* Padronização dos nomes de classes em inglês
* Padronização dos nomes de métodos em inglês
* Padronização dos nomes de variáveis em inglês
* Padronização dos Models
* Padronização dos Page Objects
* Padronização das classes de teste
* Manutenção da documentação em português
* Revisão da estrutura final do projeto

### Próxima Entrega

Refatoração final do framework, revisão dos Page Objects, padronização completa do código-fonte em inglês, melhoria das estratégias de espera, remoção de esperas fixas, revisão dos relatórios, organização final do código, atualização da documentação e preparação do projeto para publicação.

---

# Visão Geral do Projeto

Ao término da Sprint 8, o framework possui cobertura automatizada dos principais fluxos de um sistema de e-commerce, incluindo autenticação, cadastro, pesquisa de produtos, operações de carrinho, checkout, gerenciamento de massa de dados externa e geração automatizada de evidências e relatórios.

A arquitetura foi construída utilizando Page Object Model (POM), Data Driven Testing, organização em camadas, configuração externa, geração automática de evidências e integração com ExtentReports.

Atualmente, o projeto encontra-se na Sprint 9, etapa final dedicada à refatoração, padronização do código-fonte em inglês, revisão da estrutura, atualização da documentação e preparação do repositório para publicação.

A documentação do projeto permanece em português, enquanto classes, métodos, variáveis e demais elementos do código-fonte passam por padronização em inglês, seguindo convenções comuns de desenvolvimento e automação de testes.

---

# Progresso do Projeto

**Progresso Atual:** **≈95%**

## Sprint Atual

**Sprint 9 — Refatoração e Publicação**

## Próxima Entrega

* Padronização final do código-fonte em inglês
* Revisão dos Page Objects
* Revisão dos Models
* Revisão das classes de teste
* Melhoria das estratégias de espera
* Remoção de esperas fixas
* Validação consolidada da suíte de testes
* Revisão dos relatórios HTML
* Atualização final da documentação
* Atualização do README
* Preparação do repositório para publicação

Após a conclusão da Sprint 9, o projeto será considerado **100% concluído dentro do escopo planejado**.