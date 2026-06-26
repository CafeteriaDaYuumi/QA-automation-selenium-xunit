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

O sistema deve retornar para a tela inicial.

---

# Módulo: Cadastro

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

## CT010 - Acesso à Área de Produtos

### Objetivo

Validar o acesso à página de produtos.

### Resultado Esperado

A listagem de produtos deve ser exibida corretamente.

---

## CT011 - Pesquisa de Produto Existente

### Objetivo

Validar a busca de produtos cadastrados.

### Resultado Esperado

O sistema deve exibir os produtos relacionados ao termo pesquisado.

---

## CT012 - Pesquisa de Produto Inexistente

### Objetivo

Validar o comportamento da busca quando não existem resultados.

### Resultado Esperado

O sistema deve informar que nenhum produto foi encontrado.

---

## CT013 - Visualização dos Detalhes do Produto

### Objetivo

Validar a abertura da página de detalhes de um produto.

### Resultado Esperado

As informações completas do produto devem ser exibidas.

---

# Módulo: Carrinho

## CT014 - Adicionar Produto ao Carrinho

### Objetivo

Validar a inclusão de um produto no carrinho.

### Resultado Esperado

O produto deve ser adicionado corretamente ao carrinho.

---

## CT015 - Adicionar Múltiplos Produtos ao Carrinho

### Objetivo

Validar a inclusão simultânea de vários produtos.

### Resultado Esperado

Todos os produtos selecionados devem ser adicionados ao carrinho.

---

## CT016 - Remover Produto do Carrinho

### Objetivo

Validar a remoção de produtos previamente adicionados.

### Resultado Esperado

O produto deve ser removido corretamente do carrinho.

---

# Módulo: Checkout

## CT017 - Acesso à Tela de Checkout

### Objetivo

Validar que o usuário consiga iniciar o processo de checkout.

### Resultado Esperado

A tela de checkout deve ser exibida corretamente.

---

## CT018 - Finalizar Compra com Sucesso

### Objetivo

Validar o fluxo completo de finalização da compra.

### Resultado Esperado

O pedido deve ser criado com sucesso e a mensagem **Order Placed!** deve ser exibida.

---

## CT019 - Acesso à Tela de Pagamento

### Objetivo

Validar a navegação para a tela de pagamento após selecionar **Place Order**.

### Resultado Esperado

A tela de pagamento deve ser exibida contendo os campos para preenchimento do cartão.

---

## CT020 - Finalizar Compra com Segunda Massa de Dados

### Objetivo

Validar o fluxo completo de checkout utilizando um segundo conjunto de dados.

### Resultado Esperado

O pedido deve ser concluído com sucesso utilizando uma massa de dados alternativa.

---

# Módulo: Data Driven Testing

## CT021 - Leitura da Massa de Usuários

### Objetivo

Validar a leitura do arquivo **Users.json**.

### Resultado Esperado

Os usuários devem ser carregados corretamente.

---

## CT022 - Leitura da Massa de Produtos

### Objetivo

Validar a leitura do arquivo **Products.json**.

### Resultado Esperado

Os produtos devem ser carregados corretamente.

---

## CT023 - Leitura da Massa de Carrinho

### Objetivo

Validar a leitura do arquivo **CartItems.json**.

### Resultado Esperado

Os itens do carrinho devem ser carregados corretamente.

---

## CT024 - Leitura da Massa de Checkout

### Objetivo

Validar a leitura do arquivo **CheckoutData.json**.

### Resultado Esperado

Os dados de checkout devem ser carregados corretamente.

---

# Resumo dos Cenários

| ID       | Módulo      | Cenário                           | Status         |
| -------- | ----------- | --------------------------------- | -------------- |
| LOGIN001 | Login       | Acesso à página de login          | ✔ Implementado |
| CT001    | Login       | Login válido                      | ✔ Implementado |
| CT002    | Login       | Login inválido                    | ✔ Implementado |
| CT003    | Login       | Campos vazios                     | ✔ Implementado |
| CT004    | Login       | Logout                            | ✔ Implementado |
| CT005    | Cadastro    | Acesso à área de cadastro         | ✔ Implementado |
| CT006    | Cadastro    | Cadastro válido                   | ✔ Implementado |
| CT007    | Cadastro    | E-mail duplicado                  | ✔ Implementado |
| CT008    | Cadastro    | Campos obrigatórios               | ✔ Implementado |
| CT009    | Cadastro    | Criar e excluir conta             | ✔ Implementado |
| CT010    | Produtos    | Acesso à área de produtos         | ✔ Implementado |
| CT011    | Produtos    | Pesquisa de produto existente     | ✔ Implementado |
| CT012    | Produtos    | Pesquisa de produto inexistente   | ✔ Implementado |
| CT013    | Produtos    | Visualização dos detalhes         | ✔ Implementado |
| CT014    | Carrinho    | Adicionar produto                 | ✔ Implementado |
| CT015    | Carrinho    | Adicionar múltiplos produtos      | ✔ Implementado |
| CT016    | Carrinho    | Remover produto                   | ✔ Implementado |
| CT017    | Checkout    | Acesso ao checkout                | ✔ Implementado |
| CT018    | Checkout    | Finalizar compra                  | ✔ Implementado |
| CT019    | Checkout    | Acesso à tela de pagamento        | ✔ Implementado |
| CT020    | Checkout    | Compra com segunda massa de dados | ✔ Implementado |
| CT021    | Data Driven | Leitura da massa de usuários      | ✔ Implementado |
| CT022    | Data Driven | Leitura da massa de produtos      | ✔ Implementado |
| CT023    | Data Driven | Leitura da massa de carrinho      | ✔ Implementado |
| CT024    | Data Driven | Leitura da massa de checkout      | ✔ Implementado |

---

# Status

**Todos os cenários previstos até a Sprint 7 foram implementados e automatizados.**

### Próxima Sprint

**Sprint 8 — Evidências e Relatórios (ExtentReports e geração de relatórios automatizados).**
