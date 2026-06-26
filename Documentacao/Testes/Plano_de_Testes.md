# Plano de Testes

## 1. Informações Gerais

### Projeto

QA Test Automation Framework

### Versão

1.7

### Responsável

Victor Hugo

### Data de Criação

Junho de 2026

### Última Atualização

Junho de 2026

---

# 2. Objetivo

Este documento define a estratégia, o escopo, os critérios e as abordagens utilizadas para validação automatizada de um sistema de e-commerce.

O framework foi desenvolvido utilizando Selenium WebDriver, xUnit e C#, aplicando o padrão Page Object Model (POM), Data Driven Testing, geração automática de evidências e organização em camadas.

---

# 3. Escopo

## Funcionalidades Incluídas

* Login
* Cadastro de Usuário
* Pesquisa de Produtos
* Visualização de Produtos
* Carrinho de Compras
* Checkout
* Logout
* Data Driven Testing

## Funcionalidades Fora do Escopo

* Testes de Performance
* Testes de Carga
* Testes de Segurança
* Testes Mobile
* Testes de Integração com Sistemas Externos

---

# 4. Objetivo dos Testes

Garantir que os principais fluxos da aplicação funcionem conforme esperado.

Validar:

* Regras de negócio
* Fluxos críticos
* Mensagens de erro
* Tratamento de exceções
* Integridade do processo de compra
* Comportamento esperado da aplicação
* Leitura correta das massas de dados

---

# 5. Tipos de Teste Aplicados

## Testes Funcionais

Validação das funcionalidades conforme os requisitos.

### Exemplos

* Login
* Cadastro
* Pesquisa de Produtos
* Carrinho
* Checkout

---

## Testes de Regressão

Execução recorrente dos cenários automatizados para garantir que alterações futuras não impactem funcionalidades existentes.

---

## Testes Positivos

Validação de fluxos esperados.

### Exemplos

* Login válido
* Cadastro válido
* Compra realizada com sucesso

---

## Testes Negativos

Validação do tratamento de erros.

### Exemplos

* Senha inválida
* E-mail já cadastrado
* Campos obrigatórios vazios

---

## Data Driven Testing

Validação da execução dos testes utilizando massas de dados externas armazenadas em arquivos JSON.

### Exemplos

* Leitura de usuários
* Leitura de produtos
* Leitura de carrinho
* Leitura de checkout

---

# 6. Ambiente de Testes

## Sistema Operacional

Windows 11

## Linguagem

C#

## Framework de Testes

xUnit

## Ferramenta de Automação

Selenium WebDriver

## Controle de Versão

Git

## Repositório

GitHub

## Navegador Principal

Google Chrome

## Padrão de Projeto

Page Object Model (POM)

---

# 7. Casos de Teste Implementados

## Login

| ID    | Caso de Teste                 | Status       |
| ----- | ----------------------------- | ------------ |
| CT001 | Login com credenciais válidas | Implementado |
| CT002 | Login com senha inválida      | Implementado |
| CT003 | Login com campos vazios       | Implementado |
| CT004 | Logout com sucesso            | Implementado |

---

## Cadastro

| ID    | Caso de Teste                        | Status       |
| ----- | ------------------------------------ | ------------ |
| CT005 | Acesso à área de cadastro            | Implementado |
| CT006 | Início de cadastro com dados válidos | Implementado |
| CT007 | Validação de e-mail já cadastrado    | Implementado |
| CT008 | Validação de campos obrigatórios     | Implementado |
| CT009 | Criação e exclusão de conta          | Implementado |

---

## Produtos

| ID    | Caso de Teste                        | Status       |
| ----- | ------------------------------------ | ------------ |
| CT010 | Acesso à área de produtos            | Implementado |
| CT011 | Pesquisa de produto existente        | Implementado |
| CT012 | Pesquisa de produto inexistente      | Implementado |
| CT013 | Visualização dos detalhes do produto | Implementado |

---

## Carrinho

| ID    | Caso de Teste                 | Status       |
| ----- | ----------------------------- | ------------ |
| CT014 | Adicionar produto ao carrinho | Implementado |
| CT015 | Adicionar múltiplos produtos  | Implementado |
| CT016 | Remover produto do carrinho   | Implementado |

---

## Checkout

| ID    | Caso de Teste                                 | Status       |
| ----- | --------------------------------------------- | ------------ |
| CT017 | Acesso à tela de checkout                     | Implementado |
| CT018 | Finalização da compra com sucesso             | Implementado |
| CT019 | Acesso à tela de pagamento                    | Implementado |
| CT020 | Finalização utilizando segunda massa de dados | Implementado |

---

## Data Driven Testing

| ID    | Caso de Teste                | Status       |
| ----- | ---------------------------- | ------------ |
| CT021 | Leitura da massa de usuários | Implementado |
| CT022 | Leitura da massa de produtos | Implementado |
| CT023 | Leitura da massa de carrinho | Implementado |
| CT024 | Leitura da massa de checkout | Implementado |

---

# 8. Critérios de Entrada

Os testes poderão ser iniciados quando:

* Projeto compilando sem erros críticos
* Dependências instaladas
* Ambiente disponível
* Massa de testes preparada
* Navegador configurado corretamente

---

# 9. Critérios de Saída

Os testes serão considerados concluídos quando:

* Todos os cenários planejados forem executados
* Evidências forem geradas
* Defeitos forem registrados
* Resultados forem documentados

---

# 10. Riscos

| Risco                                        | Impacto |
| -------------------------------------------- | ------- |
| Mudanças na aplicação testada                | Alto    |
| Instabilidade do ambiente                    | Médio   |
| Massa de dados inconsistente                 | Médio   |
| Bloqueios causados por anúncios da aplicação | Médio   |
| Alterações na estrutura HTML                 | Médio   |
| Falhas de conexão                            | Baixo   |

---

# 11. Evidências

As evidências são armazenadas automaticamente na estrutura:

```text
Evidence
│
└── AAAA-MM-DD_HH-MM-SS
    ├── CT001_LoginValido.png
    ├── CT002_LoginSenhaInvalida.png
    ├── CT018_FinalizarCompra.png
    └── ...
```

As capturas podem ser geradas em:

* Execuções com sucesso
* Execuções com falha
* Pontos críticos dos fluxos

---

# 12. Registro de Defeitos

Todos os defeitos identificados devem ser registrados em:

```text
Documentacao
│
└── Defeitos
    └── Registro_de_Defeitos.md
```

---

# 13. Métricas Planejadas

Serão acompanhadas:

* Total de testes planejados
* Total de testes implementados
* Total de testes executados
* Total de testes aprovados
* Total de testes reprovados
* Quantidade de defeitos encontrados
* Cobertura dos fluxos automatizados
* Cobertura por módulo
* Quantidade de massas de dados utilizadas

---

# 14. Aprovação

O plano de testes será considerado aprovado quando:

* O escopo estiver definido
* Os cenários estiverem documentados
* Os casos de teste estiverem implementados
* As evidências estiverem sendo geradas corretamente

---

# Status Atual

### Sprint Atual

**Sprint 8 — Evidências e Relatórios**

### Concluído

* Sprint 0 — Estrutura Inicial
* Sprint 1 — Infraestrutura do Framework
* Sprint 2 — Login
* Sprint 3 — Cadastro
* Sprint 4 — Produtos
* Sprint 5 — Carrinho
* Sprint 6 — Checkout
* Sprint 7 — Data Driven Testing

### Próxima Sprint

**Sprint 8 — Evidências e Relatórios**