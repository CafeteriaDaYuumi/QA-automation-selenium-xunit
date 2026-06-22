# Plano de Testes

## 1. Informações Gerais

### Projeto

QA Test Automation Framework

### Versão

1.0

### Responsável

Victor Hugo

### Data de Criação

Junho de 2026

---

# 2. Objetivo

Este documento tem como objetivo definir a estratégia, o escopo, os critérios e as abordagens de teste utilizadas no projeto de automação de testes web.

O foco do projeto é validar os principais fluxos de um sistema de e-commerce através de testes automatizados desenvolvidos com Selenium WebDriver e xUnit.

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
* Comportamentos esperados
* Integridade dos processos de compra

---

# 5. Tipos de Teste Aplicados

## Testes Funcionais

Validação das funcionalidades conforme os requisitos.

### Exemplos

* Login
* Cadastro
* Checkout

---

## Testes de Regressão

Execução recorrente dos fluxos automatizados para garantir que novas alterações não impactem funcionalidades já existentes.

---

## Testes Positivos

Validação de cenários esperados.

### Exemplo

Login com credenciais válidas.

---

## Testes Negativos

Validação do tratamento de erros.

### Exemplo

Login com senha incorreta.

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

---

# 7. Casos de Teste Planejados

| ID    | Caso de Teste                          |
| ----- | -------------------------------------- |
| CT001 | Login válido                           |
| CT002 | Login inválido                         |
| CT003 | Login com campos vazios                |
| CT004 | Cadastro válido                        |
| CT005 | Cadastro com e-mail duplicado          |
| CT006 | Cadastro sem campos obrigatórios       |
| CT007 | Pesquisa de produto existente          |
| CT008 | Pesquisa de produto inexistente        |
| CT009 | Adicionar produto ao carrinho          |
| CT010 | Adicionar múltiplos produtos           |
| CT011 | Remover produto do carrinho            |
| CT012 | Checkout com sucesso                   |
| CT013 | Checkout sem preenchimento obrigatório |
| CT014 | Checkout com dados inválidos           |

---

# 8. Critérios de Entrada

Os testes poderão ser iniciados quando:

* Ambiente disponível
* Projeto compilando sem erros
* Dependências instaladas
* Massa de testes preparada

---

# 9. Critérios de Saída

Os testes serão considerados concluídos quando:

* Todos os cenários planejados forem executados
* Evidências forem geradas
* Defeitos encontrados forem registrados
* Resultados forem documentados

---

# 10. Riscos

| Risco                         | Impacto |
| ----------------------------- | ------- |
| Instabilidade do ambiente     | Médio   |
| Mudanças na aplicação testada | Alto    |
| Massa de dados inconsistente  | Médio   |
| Falhas de conexão             | Baixo   |

---

# 11. Evidências

As evidências geradas durante as execuções serão armazenadas na estrutura:

```text
Evidence/
└── Screenshots/
```

As capturas poderão ser geradas em:

* Execuções com sucesso
* Execuções com falha
* Pontos críticos do fluxo

---

# 12. Registro de Defeitos

Todos os defeitos identificados durante a execução dos testes deverão ser registrados no documento:

```text
Documentacao/Defeitos/Registro_de_Defeitos.md
```

---

# 13. Métricas Planejadas

Serão acompanhadas as seguintes métricas:

* Total de testes planejados
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
* Os casos de teste estiverem cadastrados
* A estratégia de execução estiver validada

---

# Status Atual

Plano de Testes elaborado e aguardando execução das primeiras sprints de automação.
