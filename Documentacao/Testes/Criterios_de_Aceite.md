# Critérios de Aceite

## Objetivo

Definir as condições mínimas necessárias para que uma funcionalidade seja considerada aprovada durante a execução dos testes.

Os critérios de aceite servem como referência para validação das regras de negócio, garantindo que os resultados obtidos estejam alinhados com os requisitos esperados.

---

# Funcionalidade: Login

## CA001 - Acesso à Página de Login

### Critérios de Aceite

* A área de autenticação deve estar acessível através do menu principal.
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
  **"Your email or password is incorrect!"**

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
* O usuário deve retornar à tela inicial.
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
  **"Email Address already exist!"**
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
* O sistema deve exibir **"Account Created!"**
* O usuário deve conseguir acessar a aplicação.
* A conta deve ser removida com sucesso.
* O sistema deve exibir **"Account Deleted!"**

---

# Funcionalidade: Produtos

## CA011 - Acesso à Área de Produtos

### Critérios de Aceite

* A página de produtos deve ser acessada corretamente.
* A listagem de produtos deve ser exibida.

---

## CA012 - Pesquisa de Produto Existente

### Critérios de Aceite

* O produto pesquisado deve ser localizado.
* Os resultados devem corresponder ao termo informado.
* O usuário deve conseguir visualizar o produto encontrado.

---

## CA013 - Pesquisa de Produto Inexistente

### Critérios de Aceite

* Nenhum produto incorreto deve ser apresentado.
* O sistema deve informar que não existem resultados para a pesquisa.

---

## CA014 - Visualização dos Detalhes do Produto

### Critérios de Aceite

* A página de detalhes deve ser aberta corretamente.
* As informações do produto devem ser exibidas.

---

# Funcionalidade: Carrinho de Compras

## CA015 - Adicionar Produto ao Carrinho

### Critérios de Aceite

* O produto deve ser incluído no carrinho.
* A quantidade de itens deve ser atualizada.
* O valor total deve refletir a inclusão do item.

---

## CA016 - Adicionar Múltiplos Produtos

### Critérios de Aceite

* Todos os produtos selecionados devem ser adicionados.
* O carrinho deve exibir todos os itens corretamente.
* A quantidade total deve ser atualizada.

---

## CA017 - Remover Produto do Carrinho

### Critérios de Aceite

* O item removido não deve mais aparecer.
* A quantidade de produtos deve ser atualizada.
* O valor total deve ser recalculado.

---

# Funcionalidade: Checkout

## CA018 - Acesso à Tela de Checkout

### Critérios de Aceite

* O usuário deve conseguir iniciar o checkout.
* As informações de endereço e pedido devem ser exibidas.

---

## CA019 - Finalização da Compra

### Critérios de Aceite

* O pedido deve ser criado com sucesso.
* O sistema deve exibir **"Order Placed!"**
* A compra deve ser concluída corretamente.

---

## CA020 - Acesso à Tela de Pagamento

### Critérios de Aceite

* Após clicar em **Place Order**, a tela de pagamento deve ser exibida.
* Os campos do cartão devem estar disponíveis para preenchimento.

---

## CA021 - Finalização com Segunda Massa de Dados

### Critérios de Aceite

* O fluxo deve aceitar um segundo conjunto de dados.
* O pedido deve ser concluído com sucesso.
* O sistema deve exibir **"Order Placed!"**

---

# Funcionalidade: Data Driven Testing

## CA022 - Leitura da Massa de Usuários

### Critérios de Aceite

* O arquivo **Users.json** deve ser carregado corretamente.
* Os dados devem ser desserializados sem erros.

---

## CA023 - Leitura da Massa de Produtos

### Critérios de Aceite

* O arquivo **Products.json** deve ser carregado corretamente.
* Todos os produtos devem estar disponíveis para utilização.

---

## CA024 - Leitura da Massa de Carrinho

### Critérios de Aceite

* O arquivo **CartItems.json** deve ser carregado corretamente.
* Os produtos do carrinho devem ser recuperados sem inconsistências.

---

## CA025 - Leitura da Massa de Checkout

### Critérios de Aceite

* O arquivo **CheckoutData.json** deve ser carregado corretamente.
* Os dados de pagamento devem estar disponíveis para os testes automatizados.

---

# Critérios Gerais de Aprovação

Uma funcionalidade será considerada aprovada quando:

* Todos os critérios de aceite forem atendidos.
* Nenhum erro crítico for identificado.
* Os resultados estiverem de acordo com os requisitos definidos.
* As evidências forem registradas corretamente.
* Os testes automatizados forem executados com sucesso.

---

# Critérios Gerais de Reprovação

Uma funcionalidade será considerada reprovada quando:

* Algum critério de aceite não for atendido.
* O comportamento observado divergir do esperado.
* Existirem erros que impeçam o fluxo principal.
* As regras de negócio não forem respeitadas.
* O teste automatizado apresentar falha.

---

# Status

**Documento atualizado até a Sprint 7 — Data Driven Testing.**

### Funcionalidades contempladas

* Login
* Cadastro
* Produtos
* Carrinho
* Checkout
* Data Driven Testing

### Próxima atualização prevista

**Sprint 8 — Evidências e Relatórios**