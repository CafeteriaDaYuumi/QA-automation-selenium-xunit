# Cenários de Teste

## Objetivo

Este documento apresenta os cenários de teste planejados para validação das funcionalidades do sistema de e-commerce utilizado como base para o framework de automação.

---

# Módulo: Login

## CT001 - Login com Credenciais Válidas

### Objetivo

Validar que um usuário consiga acessar o sistema utilizando credenciais válidas.

### Resultado Esperado

O usuário deve ser autenticado e direcionado para a área principal da aplicação.

---

## CT002 - Login com Senha Inválida

### Objetivo

Validar o comportamento do sistema ao informar senha incorreta.

### Resultado Esperado

O sistema deve impedir o acesso e apresentar mensagem de erro.

---

## CT003 - Login com Campos Vazios

### Objetivo

Validar os campos obrigatórios da tela de autenticação.

### Resultado Esperado

O sistema deve solicitar o preenchimento dos campos obrigatórios.

---

# Módulo: Cadastro de Usuário

## CT004 - Cadastro de Usuário com Dados Válidos

### Objetivo

Validar o processo de criação de uma nova conta.

### Resultado Esperado

O usuário deve ser cadastrado com sucesso.

---

## CT005 - Cadastro com E-mail Já Existente

### Objetivo

Validar a restrição de e-mails duplicados.

### Resultado Esperado

O sistema deve impedir o cadastro e exibir mensagem adequada.

---

## CT006 - Cadastro sem Campos Obrigatórios

### Objetivo

Validar os campos obrigatórios do formulário de cadastro.

### Resultado Esperado

O sistema deve impedir o cadastro e informar os campos pendentes.

---

# Módulo: Pesquisa de Produtos

## CT007 - Pesquisa de Produto Existente

### Objetivo

Validar a busca de produtos cadastrados.

### Resultado Esperado

O sistema deve exibir os produtos relacionados ao termo pesquisado.

---

## CT008 - Pesquisa de Produto Inexistente

### Objetivo

Validar o comportamento da busca quando não existem resultados.

### Resultado Esperado

O sistema deve informar que nenhum produto foi encontrado.

---

# Módulo: Carrinho de Compras

## CT009 - Adicionar Produto ao Carrinho

### Objetivo

Validar a inclusão de produtos no carrinho.

### Resultado Esperado

O produto deve ser adicionado corretamente ao carrinho.

---

## CT010 - Adicionar Múltiplos Produtos ao Carrinho

### Objetivo

Validar a inclusão simultânea de vários produtos.

### Resultado Esperado

Todos os produtos selecionados devem ser adicionados ao carrinho.

---

## CT011 - Remover Produto do Carrinho

### Objetivo

Validar a remoção de produtos previamente adicionados.

### Resultado Esperado

O produto deve ser removido do carrinho.

---

# Módulo: Checkout

## CT012 - Finalizar Compra com Sucesso

### Objetivo

Validar o fluxo completo de finalização da compra.

### Resultado Esperado

O pedido deve ser criado com sucesso.

---

## CT013 - Finalizar Compra sem Dados Obrigatórios

### Objetivo

Validar os campos obrigatórios do checkout.

### Resultado Esperado

O sistema deve impedir a conclusão da compra.

---

## CT014 - Finalizar Compra com Dados Inválidos

### Objetivo

Validar as regras de negócio do processo de pagamento.

### Resultado Esperado

O sistema deve impedir a conclusão da compra e apresentar mensagem adequada.

---

# Resumo dos Cenários

| ID    | Módulo   | Cenário                      |
| ----- | -------- | ---------------------------- |
| CT001 | Login    | Login válido                 |
| CT002 | Login    | Login inválido               |
| CT003 | Login    | Campos vazios                |
| CT004 | Cadastro | Cadastro válido              |
| CT005 | Cadastro | E-mail duplicado             |
| CT006 | Cadastro | Campos obrigatórios          |
| CT007 | Produtos | Produto existente            |
| CT008 | Produtos | Produto inexistente          |
| CT009 | Carrinho | Adicionar produto            |
| CT010 | Carrinho | Adicionar múltiplos produtos |
| CT011 | Carrinho | Remover produto              |
| CT012 | Checkout | Compra com sucesso           |
| CT013 | Checkout | Dados obrigatórios           |
| CT014 | Checkout | Dados inválidos              |

---

# Status

Cenários documentados e aprovados para detalhamento dos Casos de Teste.
