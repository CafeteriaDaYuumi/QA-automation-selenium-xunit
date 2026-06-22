# Casos de Teste

## Objetivo

Documentar os procedimentos necessários para validar as funcionalidades do sistema de e-commerce utilizado como base para o framework de automação.

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
2. Informar usuário válido.
3. Informar senha válida.
4. Clicar no botão Entrar.

## Dados de Teste

Usuário: usuario_teste

Senha: senha_valida

## Resultado Esperado

O sistema deve autenticar o usuário e direcioná-lo para a página principal.

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
2. Informar usuário válido.
3. Informar senha inválida.
4. Clicar em Entrar.

## Dados de Teste

Usuário: usuario_teste

Senha: senha_invalida

## Resultado Esperado

O sistema deve impedir o acesso e exibir mensagem de erro.

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
3. Clicar em Entrar.

## Resultado Esperado

O sistema deve solicitar o preenchimento dos campos obrigatórios.

---

# CT004 - Cadastro com Dados Válidos

## Módulo

Cadastro

## Prioridade

Alta

## Pré-Condição

E-mail não cadastrado.

## Passos

1. Acessar tela de cadastro.
2. Informar dados válidos.
3. Confirmar cadastro.

## Resultado Esperado

O usuário deve ser cadastrado com sucesso.

---

# CT005 - Cadastro com E-mail Duplicado

## Módulo

Cadastro

## Prioridade

Alta

## Pré-Condição

E-mail já cadastrado.

## Passos

1. Acessar tela de cadastro.
2. Informar e-mail existente.
3. Confirmar cadastro.

## Resultado Esperado

O sistema deve impedir o cadastro e exibir mensagem de erro.

---

# CT006 - Cadastro sem Campos Obrigatórios

## Módulo

Cadastro

## Prioridade

Alta

## Pré-Condição

Nenhuma.

## Passos

1. Acessar tela de cadastro.
2. Deixar campos obrigatórios vazios.
3. Confirmar cadastro.

## Resultado Esperado

O sistema deve informar os campos obrigatórios pendentes.

---

# CT007 - Pesquisa de Produto Existente

## Módulo

Produtos

## Prioridade

Média

## Pré-Condição

Produto cadastrado na aplicação.

## Passos

1. Acessar catálogo.
2. Informar produto existente.
3. Executar pesquisa.

## Resultado Esperado

O produto pesquisado deve ser exibido.

---

# CT008 - Pesquisa de Produto Inexistente

## Módulo

Produtos

## Prioridade

Média

## Pré-Condição

Nenhuma.

## Passos

1. Acessar catálogo.
2. Informar produto inexistente.
3. Executar pesquisa.

## Resultado Esperado

O sistema deve informar que não existem resultados.

---

# CT009 - Adicionar Produto ao Carrinho

## Módulo

Carrinho

## Prioridade

Alta

## Pré-Condição

Produto disponível para compra.

## Passos

1. Acessar produto.
2. Selecionar produto.
3. Adicionar ao carrinho.

## Resultado Esperado

O produto deve ser incluído no carrinho.

---

# CT010 - Adicionar Múltiplos Produtos ao Carrinho

## Módulo

Carrinho

## Prioridade

Alta

## Pré-Condição

Produtos disponíveis.

## Passos

1. Selecionar diversos produtos.
2. Adicionar ao carrinho.

## Resultado Esperado

Todos os produtos devem ser adicionados.

---

# CT011 - Remover Produto do Carrinho

## Módulo

Carrinho

## Prioridade

Alta

## Pré-Condição

Produto presente no carrinho.

## Passos

1. Acessar carrinho.
2. Selecionar remover produto.

## Resultado Esperado

O produto deve ser removido do carrinho.

---

# CT012 - Finalizar Compra com Sucesso

## Módulo

Checkout

## Prioridade

Alta

## Pré-Condição

Carrinho contendo produtos.

## Passos

1. Acessar checkout.
2. Informar dados válidos.
3. Confirmar compra.

## Resultado Esperado

O pedido deve ser criado com sucesso.

---

# CT013 - Finalizar Compra sem Dados Obrigatórios

## Módulo

Checkout

## Prioridade

Alta

## Pré-Condição

Carrinho contendo produtos.

## Passos

1. Acessar checkout.
2. Omitir informações obrigatórias.
3. Confirmar compra.

## Resultado Esperado

O sistema deve impedir a conclusão da compra.

---

# CT014 - Finalizar Compra com Dados Inválidos

## Módulo

Checkout

## Prioridade

Alta

## Pré-Condição

Carrinho contendo produtos.

## Passos

1. Acessar checkout.
2. Informar dados inválidos.
3. Confirmar compra.

## Resultado Esperado

O sistema deve impedir a conclusão da compra e apresentar mensagem adequada.

---

# Resumo

Total de Casos de Teste: 14

Distribuição:

* Login: 3
* Cadastro: 3
* Produtos: 2
* Carrinho: 3
* Checkout: 3

Status: Aguardando implementação dos testes automatizados.
