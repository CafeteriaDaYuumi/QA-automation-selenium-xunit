# Cenários de Teste

## Objetivo

Este documento apresenta os cenários de teste planejados e implementados para validação das funcionalidades do sistema de e-commerce utilizado como base para o framework de automação.

---

# Módulo: Login

## LOGIN001 - Acesso à Página de Login

### Objetivo

Validar o acesso à área de autenticação da aplicação.

### Resultado Esperado

A página de login deve ser exibida corretamente.

---

## CT001 - Login com Credenciais Válidas

### Objetivo

Validar que um usuário consiga acessar o sistema utilizando credenciais válidas.

### Resultado Esperado

O usuário deve ser autenticado com sucesso e identificado como usuário logado.

---

## CT002 - Login com Senha Inválida

### Objetivo

Validar o comportamento do sistema ao informar uma senha incorreta.

### Resultado Esperado

O sistema deve impedir o acesso e exibir mensagem de erro.

---

## CT003 - Login com Campos Vazios

### Objetivo

Validar o comportamento do sistema quando os campos obrigatórios não são preenchidos.

### Resultado Esperado

O usuário deve permanecer na tela de login.

---

## CT004 - Logout com Sucesso

### Objetivo

Validar o encerramento da sessão do usuário autenticado.

### Resultado Esperado

O sistema deve retornar para a tela de login.

---

# Módulo: Cadastro de Usuário

## CT005 - Acesso à Área de Cadastro

### Objetivo

Validar o acesso à área de cadastro de novos usuários.

### Resultado Esperado

A área de cadastro deve ser exibida corretamente.

---

## CT006 - Início de Cadastro com Dados Válidos

### Objetivo

Validar o início do processo de cadastro utilizando nome e e-mail válidos.

### Resultado Esperado

O sistema deve exibir a tela de informações da conta.

---

## CT007 - Cadastro com E-mail Já Existente

### Objetivo

Validar a restrição de cadastro utilizando e-mail previamente registrado.

### Resultado Esperado

O sistema deve impedir o cadastro e exibir mensagem adequada.

---

## CT008 - Cadastro com Campos Obrigatórios Vazios

### Objetivo

Validar o comportamento do sistema quando os campos obrigatórios não são preenchidos.

### Resultado Esperado

O sistema deve impedir o avanço do cadastro.

---

## CT009 - Criação e Exclusão de Conta

### Objetivo

Validar o fluxo completo de criação e remoção de uma conta.

### Resultado Esperado

A conta deve ser criada com sucesso e posteriormente excluída.

---

# Módulo: Produtos

## CT010 - Pesquisa de Produto Existente

### Objetivo

Validar a busca de produtos cadastrados.

### Resultado Esperado

O sistema deve exibir os produtos relacionados ao termo pesquisado.

---

## CT011 - Pesquisa de Produto Inexistente

### Objetivo

Validar o comportamento da busca quando não existem resultados.

### Resultado Esperado

O sistema deve informar que nenhum produto foi encontrado.

---

# Módulo: Carrinho de Compras

## CT012 - Adicionar Produto ao Carrinho

### Objetivo

Validar a inclusão de produtos no carrinho.

### Resultado Esperado

O produto deve ser adicionado corretamente ao carrinho.

---

## CT013 - Adicionar Múltiplos Produtos ao Carrinho

### Objetivo

Validar a inclusão simultânea de vários produtos.

### Resultado Esperado

Todos os produtos selecionados devem ser adicionados ao carrinho.

---

## CT014 - Remover Produto do Carrinho

### Objetivo

Validar a remoção de produtos previamente adicionados.

### Resultado Esperado

O produto deve ser removido do carrinho.

---

# Módulo: Checkout

## CT015 - Finalizar Compra com Sucesso

### Objetivo

Validar o fluxo completo de finalização da compra.

### Resultado Esperado

O pedido deve ser criado com sucesso.

---

## CT016 - Finalizar Compra sem Dados Obrigatórios

### Objetivo

Validar os campos obrigatórios do checkout.

### Resultado Esperado

O sistema deve impedir a conclusão da compra.

---

## CT017 - Finalizar Compra com Dados Inválidos

### Objetivo

Validar as regras de negócio do processo de pagamento.

### Resultado Esperado

O sistema deve impedir a conclusão da compra e apresentar mensagem adequada.

---

# Resumo dos Cenários

| ID       | Módulo   | Cenário                      | Status         |
| -------- | -------- | ---------------------------- | -------------- |
| LOGIN001 | Login    | Acesso à página de login     | ✔ Implementado |
| CT001    | Login    | Login válido                 | ✔ Implementado |
| CT002    | Login    | Login inválido               | ✔ Implementado |
| CT003    | Login    | Campos vazios                | ✔ Implementado |
| CT004    | Login    | Logout                       | ✔ Implementado |
| CT005    | Cadastro | Acesso à área de cadastro    | ✔ Implementado |
| CT006    | Cadastro | Cadastro válido              | ✔ Implementado |
| CT007    | Cadastro | E-mail duplicado             | ✔ Implementado |
| CT008    | Cadastro | Campos obrigatórios          | ✔ Implementado |
| CT009    | Cadastro | Criar e excluir conta        | ✔ Implementado |
| CT010    | Produtos | Produto existente            | Planejado      |
| CT011    | Produtos | Produto inexistente          | Planejado      |
| CT012    | Carrinho | Adicionar produto            | Planejado      |
| CT013    | Carrinho | Adicionar múltiplos produtos | Planejado      |
| CT014    | Carrinho | Remover produto              | Planejado      |
| CT015    | Checkout | Compra com sucesso           | Planejado      |
| CT016    | Checkout | Dados obrigatórios           | Planejado      |
| CT017    | Checkout | Dados inválidos              | Planejado      |

---

# Status

Cenários das Sprints 2 e 3 implementados e automatizados.

Próxima Sprint: Produtos (CT010 e CT011).
