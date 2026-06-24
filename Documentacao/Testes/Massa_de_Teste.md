# Massa de Teste

## Objetivo

Este documento define os dados utilizados na execução dos testes manuais e automatizados do sistema de e-commerce utilizado como base para o framework de automação.

A massa de teste tem como objetivo garantir padronização, rastreabilidade e reutilização dos dados durante os cenários de validação.

---

# 1. Usuários de Login

| ID      | Tipo           | E-mail                                                                                  | Senha           | Finalidade                   |
| ------- | -------------- | --------------------------------------------------------------------------------------- | --------------- | ---------------------------- |
| USER001 | Válido         | [QA-automation-selenium-xunit@gmail.com](mailto:QA-automation-selenium-xunit@gmail.com) | 123456          | Login válido                 |
| USER002 | Senha inválida | [QA-automation-selenium-xunit@gmail.com](mailto:QA-automation-selenium-xunit@gmail.com) | senha_incorreta | Login inválido               |
| USER003 | Campos vazios  | -                                                                                       | -               | Validação de obrigatoriedade |

---

# 2. Usuários de Cadastro

| ID     | Tipo              | Nome              | E-mail                                                                                  | Finalidade                   |
| ------ | ----------------- | ----------------- | --------------------------------------------------------------------------------------- | ---------------------------- |
| CAD001 | Novo usuário      | Usuario Teste     | [usuario.teste.automatico@gmail.com](mailto:usuario.teste.automatico@gmail.com)         | Cadastro válido              |
| CAD002 | E-mail existente  | Usuario Existente | [QA-automation-selenium-xunit@gmail.com](mailto:QA-automation-selenium-xunit@gmail.com) | Cadastro duplicado           |
| CAD003 | Campos vazios     | -                 | -                                                                                       | Validação de obrigatoriedade |
| CAD004 | Cadastro completo | Usuario Teste     | usuario.teste.{timestamp}@gmail.com                                                     | Criação e exclusão de conta  |

---

# 3. Dados Complementares de Cadastro

## Dados da Conta

| Campo  | Valor  |
| ------ | ------ |
| Gênero | Mr     |
| Senha  | 123456 |
| Dia    | 10     |
| Mês    | Maio   |
| Ano    | 2000   |

## Dados de Endereço

| Campo     | Valor          |
| --------- | -------------- |
| Nome      | Usuario        |
| Sobrenome | Teste          |
| Endereço  | Rua Teste, 123 |
| País      | Canada         |
| Estado    | Ontario        |
| Cidade    | Toronto        |
| CEP       | 00000          |
| Celular   | 11999999999    |

---

# 4. Produtos de Teste

| ID      | Produto                 | Finalidade          |
| ------- | ----------------------- | ------------------- |
| PROD001 | Blue Top                | Pesquisa de produto |
| PROD002 | Men Tshirt              | Pesquisa e carrinho |
| PROD003 | Sleeveless Dress        | Checkout            |
| PROD004 | Produto Inexistente XYZ | Pesquisa negativa   |

---

# 5. Dados de Checkout

| ID       | Nome | Sobrenome | Endereço       | CEP       | Cidade    | Finalidade              |
| -------- | ---- | --------- | -------------- | --------- | --------- | ----------------------- |
| CHECK001 | João | Silva     | Rua Teste, 123 | 00000     | São Paulo | Checkout válido         |
| CHECK002 | -    | Silva     | Rua Teste, 123 | 00000     | São Paulo | Campo obrigatório vazio |
| CHECK003 | João | Silva     | -              | 00000     | São Paulo | Endereço vazio          |
| CHECK004 | João | Silva     | CEP_INVALIDO   | São Paulo | São Paulo | Dados inválidos         |

---

# 6. Relação com Casos de Teste

| Caso de Teste | Massa Utilizada   |
| ------------- | ----------------- |
| CT001         | USER001           |
| CT002         | USER002           |
| CT003         | USER003           |
| CT004         | USER001           |
| CT005         | CAD001            |
| CT006         | CAD001            |
| CT007         | CAD002            |
| CT008         | CAD003            |
| CT009         | CAD004            |
| CT010         | PROD001           |
| CT011         | PROD004           |
| CT012         | PROD001           |
| CT013         | PROD001, PROD002  |
| CT014         | PROD001           |
| CT015         | USER001, CHECK001 |
| CT016         | USER001, CHECK002 |
| CT017         | USER001, CHECK004 |

---

# 7. Arquivos Implementados

```text
TestData
│
├── Users.json
├── CadastroUsers.json
```

---

# 8. Arquivos Planejados

```text
TestData
│
├── Products.json
├── CheckoutData.json
```

---

# Observações

* Os dados utilizados são exclusivamente para testes.
* Os usuários de cadastro utilizam e-mails dinâmicos para evitar conflitos entre execuções.
* Parte da massa de dados já foi externalizada em arquivos JSON.
* Novas massas serão adicionadas conforme a implementação dos módulos Produtos, Carrinho e Checkout.

---

# Status

Massa de teste parcialmente implementada.

Concluído:

* Users.json
* CadastroUsers.json
* Login
* Cadastro

Próxima atualização prevista:
Sprint 4 — Pesquisa de Produtos.
