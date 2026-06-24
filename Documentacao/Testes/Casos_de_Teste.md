# Casos de Teste

## Objetivo

Documentar os procedimentos necessários para validar as funcionalidades do sistema de e-commerce utilizado como base para o framework de automação.

---

# LOGIN001 - Acesso à Página de Login

## Módulo

Login

## Prioridade

Alta

## Pré-Condição

Nenhuma.

## Passos

1. Acessar a aplicação.
2. Clicar em "Signup / Login".

## Resultado Esperado

A área de login deve ser exibida corretamente.

---

# CT001 - Login com Credenciais Válidas

## Módulo

Login

## Prioridade

Alta

## Pré-Condição

Usuário previamente cadastrado.

## Passos

1. Acessar a página de login.
2. Informar e-mail válido.
3. Informar senha válida.
4. Clicar em Login.

## Resultado Esperado

O sistema deve autenticar o usuário e exibir a identificação do usuário logado.

---

# CT002 - Login com Senha Inválida

## Módulo

Login

## Prioridade

Alta

## Pré-Condição

Usuário previamente cadastrado.

## Passos

1. Acessar a página de login.
2. Informar e-mail válido.
3. Informar senha inválida.
4. Clicar em Login.

## Resultado Esperado

O sistema deve exibir a mensagem:

"Your email or password is incorrect!"

---

# CT003 - Login com Campos Vazios

## Módulo

Login

## Prioridade

Alta

## Pré-Condição

Nenhuma.

## Passos

1. Acessar a página de login.
2. Deixar os campos vazios.
3. Clicar em Login.

## Resultado Esperado

O usuário deve permanecer na tela de login.

---

# CT004 - Logout com Sucesso

## Módulo

Login

## Prioridade

Alta

## Pré-Condição

Usuário autenticado.

## Passos

1. Realizar login.
2. Clicar em Logout.

## Resultado Esperado

O sistema deve encerrar a sessão e retornar à tela de login.

---

# CT005 - Acesso à Área de Cadastro

## Módulo

Cadastro

## Prioridade

Alta

## Pré-Condição

Nenhuma.

## Passos

1. Acessar a aplicação.
2. Clicar em "Signup / Login".

## Resultado Esperado

A área de cadastro deve ser exibida corretamente.

---

# CT006 - Início de Cadastro com Dados Válidos

## Módulo

Cadastro

## Prioridade

Alta

## Pré-Condição

E-mail não cadastrado.

## Passos

1. Acessar a área de cadastro.
2. Informar nome válido.
3. Informar e-mail válido.
4. Clicar em Signup.

## Resultado Esperado

O sistema deve exibir a tela "Enter Account Information".

---

# CT007 - Cadastro com E-mail Já Existente

## Módulo

Cadastro

## Prioridade

Alta

## Pré-Condição

E-mail previamente cadastrado.

## Passos

1. Acessar a área de cadastro.
2. Informar nome válido.
3. Informar e-mail já cadastrado.
4. Clicar em Signup.

## Resultado Esperado

O sistema deve exibir a mensagem:

"Email Address already exist!"

---

# CT008 - Cadastro com Campos Obrigatórios Vazios

## Módulo

Cadastro

## Prioridade

Alta

## Pré-Condição

Nenhuma.

## Passos

1. Acessar a área de cadastro.
2. Não preencher os campos.
3. Clicar em Signup.

## Resultado Esperado

O sistema deve impedir o avanço do cadastro e permanecer na área de cadastro.

---

# CT009 - Criação e Exclusão de Conta

## Módulo

Cadastro

## Prioridade

Alta

## Pré-Condição

E-mail não cadastrado.

## Passos

1. Iniciar cadastro com dados válidos.
2. Preencher informações da conta.
3. Preencher endereço.
4. Criar conta.
5. Confirmar criação.
6. Excluir conta.

## Resultado Esperado

A conta deve ser criada com sucesso e posteriormente removida do sistema.

---

# CT010 - Pesquisa de Produto Existente

## Módulo

Produtos

## Prioridade

Média

## Status

Planejado

---

# CT011 - Pesquisa de Produto Inexistente

## Módulo

Produtos

## Prioridade

Média

## Status

Planejado

---

# CT012 - Adicionar Produto ao Carrinho

## Módulo

Carrinho

## Prioridade

Alta

## Status

Planejado

---

# CT013 - Adicionar Múltiplos Produtos ao Carrinho

## Módulo

Carrinho

## Prioridade

Alta

## Status

Planejado

---

# CT014 - Remover Produto do Carrinho

## Módulo

Carrinho

## Prioridade

Alta

## Status

Planejado

---

# CT015 - Checkout com Sucesso

## Módulo

Checkout

## Prioridade

Alta

## Status

Planejado

---

# CT016 - Checkout sem Dados Obrigatórios

## Módulo

Checkout

## Prioridade

Alta

## Status

Planejado

---

# CT017 - Checkout com Dados Inválidos

## Módulo

Checkout

## Prioridade

Alta

## Status

Planejado

---

# Resumo

Total de Casos de Teste: 18

## Implementados

✔ LOGIN001
✔ CT001
✔ CT002
✔ CT003
✔ CT004
✔ CT005
✔ CT006
✔ CT007
✔ CT008
✔ CT009

## Planejados

□ CT010
□ CT011
□ CT012
□ CT013
□ CT014
□ CT015
□ CT016
□ CT017

## Distribuição

* Login: 5
* Cadastro: 5
* Produtos: 2
* Carrinho: 3
* Checkout: 3

Status Geral: Sprint 3 concluída.
