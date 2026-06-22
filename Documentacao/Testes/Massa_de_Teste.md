# Massa de Teste

## Objetivo

Este documento define os dados utilizados na execução dos testes manuais e automatizados do sistema de e-commerce.

A massa de teste tem como objetivo garantir padronização, rastreabilidade e reutilização dos dados durante os cenários de validação.

---

# 1. Usuários de Teste

| ID      | Tipo             | Usuário/E-mail                                            | Senha        | Finalidade            |
| ------- | ---------------- | --------------------------------------------------------- | ------------ | --------------------- |
| USER001 | Válido           | [usuario.teste@email.com](mailto:usuario.teste@email.com) | Senha@123    | Login válido          |
| USER002 | Inválido         | [usuario.teste@email.com](mailto:usuario.teste@email.com) | senha_errada | Login inválido        |
| USER003 | E-mail duplicado | [usuario.teste@email.com](mailto:usuario.teste@email.com) | Senha@123    | Cadastro duplicado    |
| USER004 | Novo cadastro    | [novo.usuario@email.com](mailto:novo.usuario@email.com)   | Senha@123    | Cadastro válido       |
| USER005 | Campos vazios    | -                                                         | -            | Validação obrigatória |

---

# 2. Produtos de Teste

| ID      | Produto                 | Categoria | Finalidade                      |
| ------- | ----------------------- | --------- | ------------------------------- |
| PROD001 | Camiseta                | Vestuário | Pesquisa e carrinho             |
| PROD002 | Calça Jeans             | Vestuário | Carrinho com múltiplos produtos |
| PROD003 | Tênis Esportivo         | Calçados  | Checkout                        |
| PROD004 | Produto Inexistente XYZ | -         | Pesquisa sem resultado          |

---

# 3. Dados de Checkout

| ID       | Nome | Sobrenome | Endereço       | CEP          | Cidade    | Finalidade              |
| -------- | ---- | --------- | -------------- | ------------ | --------- | ----------------------- |
| CHECK001 | João | Silva     | Rua Teste, 123 | 00000-000    | São Paulo | Checkout válido         |
| CHECK002 | -    | Silva     | Rua Teste, 123 | 00000-000    | São Paulo | Campo obrigatório vazio |
| CHECK003 | João | Silva     | -              | 00000-000    | São Paulo | Endereço vazio          |
| CHECK004 | João | Silva     | Rua Teste, 123 | CEP_INVALIDO | São Paulo | Dado inválido           |

---

# 4. Relação com Casos de Teste

| Caso de Teste | Massa Utilizada            |
| ------------- | -------------------------- |
| CT001         | USER001                    |
| CT002         | USER002                    |
| CT003         | USER005                    |
| CT004         | USER004                    |
| CT005         | USER003                    |
| CT006         | USER005                    |
| CT007         | PROD001                    |
| CT008         | PROD004                    |
| CT009         | PROD001                    |
| CT010         | PROD001, PROD002           |
| CT011         | PROD001                    |
| CT012         | USER001, PROD003, CHECK001 |
| CT013         | USER001, PROD003, CHECK002 |
| CT014         | USER001, PROD003, CHECK004 |

---

# 5. Observações

* Os dados utilizados são fictícios.
* A massa poderá ser adaptada conforme a aplicação escolhida para os testes.
* Os dados serão posteriormente organizados em arquivos JSON dentro da pasta `TestData`.
* A reutilização da massa de teste facilita a manutenção dos testes automatizados.

---

# 6. Arquivos Planejados

```text id="9tt0by"
TestData
│
├── Users.json
├── Products.json
└── CheckoutData.json
```

---

# Status

Massa de teste documentada e aguardando implementação nos arquivos externos do projeto.
