# Massa de Teste

## Objetivo

Este documento define as massas de dados utilizadas na execução dos testes automatizados do sistema de e-commerce utilizado como base para o framework.

A massa de teste tem como objetivo garantir padronização, rastreabilidade, reutilização dos dados e suporte ao conceito de **Data Driven Testing**, permitindo a separação entre código e dados de teste.

---

# 1. Usuários de Login

| ID      | Tipo           | E-mail                                  | Senha           | Finalidade                   |
| ------- | -------------- | --------------------------------------- | --------------- | ---------------------------- |
| USER001 | Válido         | QA-automation-selenium-xunit@gmail.com  | 123456          | Login válido                 |
| USER002 | Senha inválida | QA-automation-selenium-xunit@gmail.com  | senha_incorreta | Login inválido               |
| USER003 | Campos vazios  | -                                       | -               | Validação de obrigatoriedade |

---

# 2. Usuários de Cadastro

| ID     | Tipo              | Nome              | E-mail                                      | Finalidade                   |
| ------ | ----------------- | ----------------- | ------------------------------------------- | ---------------------------- |
| CAD001 | Novo usuário      | Usuario Teste     | usuario.teste.{timestamp}@gmail.com         | Cadastro válido              |
| CAD002 | E-mail existente  | Usuario Existente | QA-automation-selenium-xunit@gmail.com      | Cadastro duplicado           |
| CAD003 | Campos vazios     | -                 | -                                           | Validação de obrigatoriedade |
| CAD004 | Cadastro completo | Usuario Teste     | usuario.teste.{timestamp}@gmail.com         | Criação e exclusão de conta  |

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

| ID      | Produto                 | Finalidade                    |
| ------- | ----------------------- | ----------------------------- |
| PROD001 | Blue Top                | Pesquisa de produto existente |
| PROD002 | Men Tshirt              | Carrinho                      |
| PROD003 | Sleeveless Dress        | Checkout                      |
| PROD004 | Produto Inexistente XYZ | Pesquisa negativa             |

---

# 5. Carrinho de Compras

| ID      | Produto               | Quantidade | Finalidade         |
| ------- | --------------------- | ---------- | ------------------ |
| CART001 | Blue Top              | 1          | Adição simples     |
| CART002 | Blue Top + Men Tshirt | 2          | Múltiplos produtos |
| CART003 | Blue Top              | 1          | Remoção de produto |

---

# 6. Dados de Checkout

| ID       | Nome no Cartão | Número           | CVC | Mês | Ano  | Finalidade             |
| -------- | -------------- | ---------------- | --- | --- | ---- | ---------------------- |
| CHECK001 | Usuario Teste  | 4111111111111111 | 123 | 12  | 2030 | Compra válida          |
| CHECK002 | Maria Oliveira | 5555555555554444 | 456 | 10  | 2032 | Segunda massa de dados |

---

# 7. Relação com Casos de Teste

| Caso de Teste | Massa Utilizada    |
| ------------- | ------------------ |
| LOGIN001      | Não aplicável      |
| CT001         | USER001            |
| CT002         | USER002            |
| CT003         | USER003            |
| CT004         | USER001            |
| CT005         | Não aplicável      |
| CT006         | CAD001             |
| CT007         | CAD002             |
| CT008         | CAD003             |
| CT009         | CAD004             |
| CT010         | Não aplicável      |
| CT011         | PROD001            |
| CT012         | PROD004            |
| CT013         | PROD001            |
| CT014         | CART001            |
| CT015         | CART002            |
| CT016         | CART003            |
| CT017         | USER001 + CART001  |
| CT018         | USER001 + CHECK001 |
| CT019         | USER001 + CHECK001 |
| CT020         | USER001 + CHECK002 |
| CT021         | Users.json         |
| CT022         | Products.json      |
| CT023         | CartItems.json     |
| CT024         | CheckoutData.json  |

---

# 8. Arquivos Implementados

```text
TestData
│
├── Users.json
├── RegistrationUsers.json
├── Products.json
├── CartItems.json
└── CheckoutData.json