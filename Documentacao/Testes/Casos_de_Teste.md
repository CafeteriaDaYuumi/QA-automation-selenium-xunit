# Casos de Teste

## Objetivo

Documentar os procedimentos necessários para validar as funcionalidades do sistema de e-commerce utilizado como base para o framework de automação.

---

# Módulo: Login

### LOGIN001 - Acesso à Página de Login

**Prioridade:** Alta

**Pré-condição:** Nenhuma.

**Passos**

1. Acessar a aplicação.
2. Clicar em **Signup / Login**.

**Resultado Esperado**
A página de login deve ser exibida corretamente.

---

### CT001 - Login com Credenciais Válidas

**Prioridade:** Alta

**Pré-condição:** Usuário previamente cadastrado.

**Passos**

1. Acessar a página de login.
2. Informar e-mail válido.
3. Informar senha válida.
4. Clicar em **Login**.

**Resultado Esperado**
O usuário deve ser autenticado com sucesso.

---

### CT002 - Login com Senha Inválida

**Prioridade:** Alta

**Pré-condição:** Usuário previamente cadastrado.

**Passos**

1. Acessar a página de login.
2. Informar e-mail válido.
3. Informar senha inválida.
4. Clicar em **Login**.

**Resultado Esperado**
Exibir a mensagem **"Your email or password is incorrect!"**

---

### CT003 - Login com Campos Vazios

**Prioridade:** Alta

**Pré-condição:** Nenhuma.

**Passos**

1. Acessar a página de login.
2. Não preencher os campos.
3. Clicar em **Login**.

**Resultado Esperado**
O sistema deve impedir a autenticação.

---

### CT004 - Logout com Sucesso

**Prioridade:** Alta

**Pré-condição:** Usuário autenticado.

**Passos**

1. Realizar login.
2. Clicar em **Logout**.

**Resultado Esperado**
A sessão deve ser encerrada.

---

# Módulo: Cadastro

### CT005 - Acesso à Área de Cadastro

**Prioridade:** Alta

**Resultado Esperado**
Exibir corretamente a área de cadastro.

---

### CT006 - Início de Cadastro com Dados Válidos

**Prioridade:** Alta

**Resultado Esperado**
Exibir a tela **Enter Account Information**.

---

### CT007 - Cadastro com E-mail Já Existente

**Prioridade:** Alta

**Resultado Esperado**
Exibir a mensagem **"Email Address already exist!"**

---

### CT008 - Cadastro com Campos Obrigatórios Vazios

**Prioridade:** Alta

**Resultado Esperado**
Impedir o avanço do cadastro.

---

### CT009 - Criação e Exclusão de Conta

**Prioridade:** Alta

**Resultado Esperado**
Criar e remover a conta com sucesso.

---

# Módulo: Produtos

### CT010 - Acesso à Área de Produtos

**Prioridade:** Média

**Resultado Esperado**
Exibir a página de produtos.

---

### CT011 - Pesquisa de Produto Existente

**Prioridade:** Média

**Resultado Esperado**
Retornar produtos relacionados ao termo pesquisado.

---

### CT012 - Pesquisa de Produto Inexistente

**Prioridade:** Média

**Resultado Esperado**
Nenhum produto deve ser encontrado.

---

### CT013 - Visualização dos Detalhes do Produto

**Prioridade:** Média

**Resultado Esperado**
Abrir corretamente a página de detalhes do produto.

---

# Módulo: Carrinho

### CT014 - Adicionar Produto ao Carrinho

**Prioridade:** Alta

**Resultado Esperado**
Adicionar um produto ao carrinho.

---

### CT015 - Adicionar Múltiplos Produtos ao Carrinho

**Prioridade:** Alta

**Resultado Esperado**
Adicionar dois produtos ao carrinho.

---

### CT016 - Remover Produto do Carrinho

**Prioridade:** Alta

**Resultado Esperado**
Remover corretamente um item do carrinho.

---

# Módulo: Checkout

### CT017 - Acessar Tela de Checkout

**Prioridade:** Alta

**Resultado Esperado**
Exibir a página de checkout.

---

### CT018 - Finalizar Compra com Sucesso

**Prioridade:** Alta

**Resultado Esperado**
Concluir a compra e exibir **Order Placed!**

---

### CT019 - Acessar Tela de Pagamento

**Prioridade:** Alta

**Resultado Esperado**
Exibir corretamente a tela de pagamento.

---

### CT020 - Finalizar Compra com Segunda Massa de Dados

**Prioridade:** Alta

**Resultado Esperado**
Concluir a compra utilizando um segundo conjunto de dados.

---

# Módulo: Data Driven Testing

### CT021 - Leitura da Massa de Usuários

**Prioridade:** Média

**Resultado Esperado**
Carregar corretamente o arquivo **Users.json**.

---

### CT022 - Leitura da Massa de Produtos

**Prioridade:** Média

**Resultado Esperado**
Carregar corretamente o arquivo **Products.json**.

---

### CT023 - Leitura da Massa de Carrinho

**Prioridade:** Média

**Resultado Esperado**
Carregar corretamente o arquivo **CartItems.json**.

---

### CT024 - Leitura da Massa de Checkout

**Prioridade:** Média

**Resultado Esperado**
Carregar corretamente o arquivo **CheckoutData.json**.

---

# Resumo

**Total de Casos de Teste:** **25**

## Implementados

* ✔ LOGIN001
* ✔ CT001 ao CT024

## Planejados

* Nenhum

## Distribuição

* Login: 5
* Cadastro: 5
* Produtos: 4
* Carrinho: 3
* Checkout: 4
* Data Driven Testing: 4

---

# Status Geral

**Sprint 7 — Data Driven Testing concluída.**

Todo o framework encontra-se documentado e implementado até a Sprint 7, contemplando os principais fluxos de negócio da aplicação, gerenciamento de massa de dados externa e testes de leitura das massas utilizadas pelo framework.

**Próxima Sprint:** Sprint 8 — Evidências e Relatórios (ExtentReports).
