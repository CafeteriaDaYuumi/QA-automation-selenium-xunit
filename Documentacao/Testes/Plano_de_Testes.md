# Plano de Testes

## 1. Informações Gerais

### Projeto

QA Test Automation Framework

### Versão

1.2

### Responsável

Victor Hugo

### Data de Criação

Junho de 2026

### Última Atualização

Junho de 2026

---

# 2. Objetivo

Este documento define a estratégia, o escopo, os critérios e as abordagens utilizadas para validação automatizada de um sistema de e-commerce.

O framework foi desenvolvido utilizando Selenium WebDriver, xUnit e C#, aplicando o padrão Page Object Model (POM), geração automática de evidências e organização em camadas.

---

# 3. Escopo

## Funcionalidades Incluídas

* Login
* Cadastro de Usuário
* Recuperação de Senha
* Pesquisa de Produtos
* Adição ao Carrinho
* Remoção do Carrinho
* Checkout
* Logout

## Funcionalidades Fora do Escopo

* Testes de Performance
* Testes de Carga
* Testes de Segurança
* Testes Mobile
* Testes de Integração com Sistemas Externos

---

# 4. Objetivos dos Testes

Garantir que os principais fluxos da aplicação funcionem conforme esperado.

Validar:

* Regras de negócio
* Fluxos críticos
* Mensagens de erro
* Tratamento de exceções
* Integridade dos processos de compra
* Comportamento esperado da aplicação

---

# 5. Tipos de Teste Aplicados

## Testes Funcionais

Validação das funcionalidades conforme os requisitos.

### Exemplos

* Login
* Cadastro
* Logout
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
* Criação de conta

---

## Testes Negativos

Validação do tratamento de erros.

### Exemplos

* Senha inválida
* E-mail já cadastrado
* Campos obrigatórios vazios

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

# 7. Casos de Teste Implementados e Planejados

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

| ID    | Caso de Teste                   | Status    |
| ----- | ------------------------------- | --------- |
| CT010 | Pesquisa de produto existente   | Planejado |
| CT011 | Pesquisa de produto inexistente | Planejado |

---

## Carrinho

| ID    | Caso de Teste                 | Status    |
| ----- | ----------------------------- | --------- |
| CT012 | Adicionar produto ao carrinho | Planejado |
| CT013 | Adicionar múltiplos produtos  | Planejado |
| CT014 | Remover produto do carrinho   | Planejado |

---

## Checkout

| ID    | Caso de Teste                   | Status    |
| ----- | ------------------------------- | --------- |
| CT015 | Finalizar compra com sucesso    | Planejado |
| CT016 | Checkout sem dados obrigatórios | Planejado |
| CT017 | Checkout com dados inválidos    | Planejado |

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

---

# 14. Aprovação

O plano de testes será considerado aprovado quando:

* O escopo estiver definido
* Os cenários estiverem documentados
* Os casos de teste estiverem implementados
* As evidências estiverem sendo geradas corretamente

---

# Status Atual

Sprint Atual: Sprint 3 — Cadastro de Usuários

Concluído:

* Sprint 0 — Estrutura Inicial
* Sprint 1 — Infraestrutura do Framework
* Sprint 2 — Login
* Sprint 3 — Cadastro (implementado)

Próxima Sprint:

Sprint 4 — Pesquisa de Produtos
