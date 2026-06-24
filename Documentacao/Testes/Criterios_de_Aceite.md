# Critérios de Aceite

## Objetivo

Definir as condições mínimas necessárias para que uma funcionalidade seja considerada aprovada durante a execução dos testes.

Os critérios de aceite servem como referência para validação das regras de negócio, garantindo que os resultados obtidos estejam alinhados com os requisitos esperados.

---

# Funcionalidade: Login

## CA001 - Acesso à Página de Login

### Critérios de Aceite

* A área de autenticação deve ser acessível através do menu principal.
* A página de login deve ser exibida corretamente.
* Os campos de autenticação devem estar disponíveis para preenchimento.

---

## CA002 - Login com Credenciais Válidas

### Critérios de Aceite

* O usuário deve conseguir acessar o sistema utilizando credenciais válidas.
* O sistema deve autenticar o usuário com sucesso.
* A identificação do usuário logado deve ser exibida.
* Nenhuma mensagem de erro deve ser apresentada.

---

## CA003 - Login com Credenciais Inválidas

### Critérios de Aceite

* O sistema deve impedir a autenticação.
* O usuário deve permanecer na tela de login.
* Deve ser exibida a mensagem:
  "Your email or password is incorrect!"

---

## CA004 - Login com Campos Obrigatórios Vazios

### Critérios de Aceite

* O sistema não deve autenticar o usuário.
* O usuário deve permanecer na tela de login.
* Os campos obrigatórios devem ser validados.

---

## CA005 - Logout com Sucesso

### Critérios de Aceite

* O sistema deve encerrar a sessão do usuário autenticado.
* O usuário deve retornar à tela de login.
* Os recursos autenticados não devem permanecer acessíveis.

---

# Funcionalidade: Cadastro de Usuário

## CA006 - Acesso à Área de Cadastro

### Critérios de Aceite

* A área de cadastro deve estar acessível através do menu principal.
* O formulário de cadastro deve ser exibido corretamente.

---

## CA007 - Início de Cadastro com Dados Válidos

### Critérios de Aceite

* O sistema deve aceitar nome e e-mail válidos.
* O fluxo deve avançar para a tela de informações da conta.
* Nenhuma mensagem de erro deve ser apresentada.

---

## CA008 - Cadastro com E-mail Já Existente

### Critérios de Aceite

* O sistema deve impedir o cadastro.
* Deve ser apresentada a mensagem:
  "Email Address already exist!"
* Nenhuma nova conta deve ser criada.

---

## CA009 - Cadastro com Campos Obrigatórios Vazios

### Critérios de Aceite

* O sistema não deve permitir o avanço do cadastro.
* O usuário deve permanecer na área de cadastro.
* Os campos obrigatórios devem ser validados.

---

## CA010 - Criação e Exclusão de Conta

### Critérios de Aceite

* A conta deve ser criada com sucesso.
* O sistema deve exibir a mensagem:
  "Account Created!"
* O usuário deve conseguir acessar a aplicação após o cadastro.
* A conta deve ser removida com sucesso.
* O sistema deve exibir a mensagem:
  "Account Deleted!"

---

# Funcionalidade: Pesquisa de Produtos

## CA011 - Pesquisa de Produto Existente

### Critérios de Aceite

* O produto pesquisado deve ser localizado.
* Os resultados devem corresponder ao termo informado.
* O usuário deve conseguir visualizar o produto encontrado.

---

## CA012 - Pesquisa de Produto Inexistente

### Critérios de Aceite

* Nenhum produto incorreto deve ser apresentado.
* O sistema deve informar que não existem resultados para a pesquisa.

---

# Funcionalidade: Carrinho de Compras

## CA013 - Adicionar Produto ao Carrinho

### Critérios de Aceite

* O produto deve ser incluído no carrinho.
* A quantidade de itens deve ser atualizada.
* O valor total deve refletir a inclusão do item.

---

## CA014 - Adicionar Múltiplos Produtos ao Carrinho

### Critérios de Aceite

* Todos os produtos selecionados devem ser adicionados.
* O carrinho deve exibir todos os itens corretamente.
* O valor total deve ser atualizado.

---

## CA015 - Remover Produto do Carrinho

### Critérios de Aceite

* O item removido não deve mais aparecer no carrinho.
* O valor total deve ser recalculado.
* A quantidade de itens deve ser atualizada.

---

# Funcionalidade: Checkout

## CA016 - Finalização da Compra

### Critérios de Aceite

* O pedido deve ser criado com sucesso.
* O sistema deve exibir confirmação da compra.
* O usuário deve receber confirmação do pedido.

---

## CA017 - Dados Obrigatórios do Checkout

### Critérios de Aceite

* O sistema deve validar todos os campos obrigatórios.
* A compra não deve ser concluída sem as informações necessárias.
* Devem ser exibidas mensagens de validação adequadas.

---

## CA018 - Dados Inválidos no Checkout

### Critérios de Aceite

* O sistema deve identificar informações inválidas.
* A compra deve ser bloqueada.
* O usuário deve receber uma mensagem explicando o problema encontrado.

---

# Critérios Gerais de Aprovação

Uma funcionalidade será considerada aprovada quando:

* Todos os critérios de aceite forem atendidos.
* Nenhum erro crítico for identificado.
* Os resultados obtidos estiverem de acordo com os requisitos definidos.
* As evidências forem registradas corretamente.
* Os testes automatizados forem executados com sucesso.

---

# Critérios Gerais de Reprovação

Uma funcionalidade será considerada reprovada quando:

* Algum critério de aceite não for atendido.
* O comportamento observado divergir do esperado.
* Existirem erros que impeçam a execução do fluxo principal.
* As regras de negócio não forem respeitadas.
* O teste automatizado apresentar falha.

---

# Status

Critérios de aceite das funcionalidades de Login e Cadastro implementados e validados.

Próxima atualização prevista: Sprint 4 — Pesquisa de Produtos.
