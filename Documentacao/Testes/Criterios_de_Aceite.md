# Critérios de Aceite

## Objetivo

Definir as condições mínimas necessárias para que uma funcionalidade seja considerada aprovada durante a execução dos testes automatizados.

Os critérios de aceite servem como referência para validação dos comportamentos esperados da aplicação, garantindo alinhamento entre os cenários documentados, os casos de teste implementados e os resultados obtidos durante a execução da suíte automatizada.

---

# Funcionalidade: Login

## CA001 - Acesso à Página de Login

### Critérios de Aceite

* A área de autenticação deve estar acessível através da aplicação.
* A página de login deve ser exibida corretamente.
* Os campos de autenticação devem estar disponíveis para preenchimento.

---

## CA002 - Login com Credenciais Válidas

### Critérios de Aceite

* O usuário deve conseguir informar credenciais válidas.
* O sistema deve autenticar o usuário com sucesso.
* A identificação do usuário autenticado deve ser exibida.
* Nenhuma mensagem de erro de autenticação deve ser apresentada.

---

## CA003 - Login com Credenciais Inválidas

### Critérios de Aceite

* O sistema deve impedir a autenticação.
* O usuário deve permanecer sem acesso autenticado.
* Deve ser exibida a mensagem:
  **"Your email or password is incorrect!"**

---

## CA004 - Login com Campos Obrigatórios Vazios

### Critérios de Aceite

* O sistema não deve autenticar o usuário.
* O fluxo não deve avançar para uma sessão autenticada.
* O usuário deve permanecer na área de login.

---

## CA005 - Logout com Sucesso

### Critérios de Aceite

* O sistema deve encerrar a sessão do usuário autenticado.
* A área de login deve voltar a ser exibida.
* O usuário não deve permanecer identificado como autenticado.

---

# Funcionalidade: Cadastro de Usuário

## CA006 - Acesso à Área de Cadastro

### Critérios de Aceite

* A área de cadastro deve estar acessível através da aplicação.
* O formulário inicial de cadastro deve ser exibido corretamente.
* A seção **"New User Signup!"** deve estar disponível.

---

## CA007 - Início de Cadastro com Dados Válidos

### Critérios de Aceite

* O sistema deve aceitar nome e e-mail válidos.
* O fluxo deve avançar para a tela de informações da conta.
* A seção **"Enter Account Information"** deve ser exibida.
* Nenhuma mensagem de erro impeditiva deve ser apresentada.

---

## CA008 - Cadastro com E-mail Já Existente

### Critérios de Aceite

* O sistema deve impedir o avanço do cadastro.
* Deve ser apresentada a mensagem:
  **"Email Address already exist!"**
* O fluxo não deve avançar para a criação de uma nova conta.

---

## CA009 - Cadastro com Campos Obrigatórios Vazios

### Critérios de Aceite

* O sistema não deve permitir o avanço do cadastro.
* O usuário deve permanecer na área de cadastro.
* A tela de informações da conta não deve ser acessada sem os dados obrigatórios.

---

## CA010 - Criação e Exclusão de Conta

### Critérios de Aceite

* O sistema deve aceitar os dados necessários para criação da conta.
* A conta deve ser criada com sucesso.
* O sistema deve exibir **"Account Created!"**
* O fluxo deve permitir continuar após a criação.
* A conta deve ser removida com sucesso.
* O sistema deve exibir **"Account Deleted!"**

---

# Funcionalidade: Produtos

## CA011 - Acesso à Área de Produtos

### Critérios de Aceite

* A página de produtos deve ser acessada corretamente.
* A URL deve corresponder à área de produtos.
* O campo de pesquisa de produtos deve estar disponível.

---

## CA012 - Pesquisa de Produto Existente

### Critérios de Aceite

* O sistema deve aceitar o termo de pesquisa informado.
* A área **"Searched Products"** deve ser exibida.
* Ao menos um produto deve ser retornado para a pesquisa válida.
* O usuário deve conseguir visualizar os resultados encontrados.

---

## CA013 - Pesquisa de Produto Inexistente

### Critérios de Aceite

* O sistema deve processar o termo de pesquisa informado.
* A área **"Searched Products"** deve ser exibida.
* Nenhum produto deve ser retornado para o termo inexistente utilizado no cenário.
* Produtos não relacionados não devem ser apresentados como resultado válido.

---

## CA014 - Visualização dos Detalhes do Produto

### Critérios de Aceite

* A página de detalhes do produto deve ser aberta corretamente.
* A URL deve corresponder à rota de detalhes de produto.
* As informações de categoria devem estar disponíveis.
* As informações de disponibilidade devem estar disponíveis.

---

# Funcionalidade: Carrinho de Compras

## CA015 - Adicionar Produto ao Carrinho

### Critérios de Aceite

* O produto deve ser incluído no carrinho.
* O carrinho deve conter ao menos um item após a inclusão.
* O produto adicionado deve permanecer disponível na visualização do carrinho.

---

## CA016 - Adicionar Múltiplos Produtos

### Critérios de Aceite

* Os produtos definidos no cenário devem ser adicionados ao carrinho.
* O carrinho deve exibir os itens adicionados.
* A quantidade de registros de produto no carrinho deve corresponder ao total esperado.
* Para o cenário automatizado atual, devem existir exatamente dois produtos no carrinho.

---

## CA017 - Remover Produto do Carrinho

### Critérios de Aceite

* O carrinho deve possuir produto antes da operação de remoção.
* O comando de exclusão deve remover o item selecionado.
* Após a remoção do único produto utilizado no cenário, nenhum item deve permanecer no carrinho.
* O carrinho deve ser identificado como vazio.

---

# Funcionalidade: Checkout

## CA018 - Acesso à Tela de Checkout

### Critérios de Aceite

* O usuário deve estar autenticado.
* O carrinho deve possuir ao menos um produto.
* O usuário deve conseguir iniciar o checkout.
* A seção **"Address Details"** deve ser exibida.
* A seção **"Review Your Order"** deve ser exibida.

---

## CA019 - Finalização da Compra

### Critérios de Aceite

* O usuário deve estar autenticado.
* O carrinho deve possuir produto.
* A tela de checkout deve ser acessada corretamente.
* O comentário do pedido deve poder ser informado.
* Os dados de pagamento devem poder ser preenchidos.
* O pagamento deve ser confirmado.
* O sistema deve exibir **"Order Placed!"**
* A compra deve ser concluída corretamente.

---

## CA020 - Acesso à Tela de Pagamento

### Critérios de Aceite

* O usuário deve conseguir avançar do checkout para o pagamento.
* A URL deve corresponder à área de pagamento.
* O campo de nome no cartão deve estar disponível.
* O campo de número do cartão deve estar disponível.
* O campo de CVC deve estar disponível.
* Os campos de mês e ano de expiração devem estar disponíveis.
* O botão de confirmação do pagamento deve estar disponível.

---

## CA021 - Finalização com Segunda Massa de Dados

### Critérios de Aceite

* O fluxo deve aceitar um segundo conjunto de dados.
* O segundo produto definido no cenário deve ser utilizado.
* Os dados alternativos de pagamento devem poder ser preenchidos.
* O pedido deve ser concluído com sucesso.
* O sistema deve exibir **"Order Placed!"**

---

# Funcionalidade: Data Driven Testing

## CA022 - Leitura da Massa de Usuários

### Critérios de Aceite

* O arquivo **Users.json** deve ser localizado corretamente.
* O conteúdo deve ser desserializado sem erros.
* A lista resultante não deve estar vazia.
* Deve existir um usuário identificado pela chave **"validUser"**.

---

## CA023 - Leitura da Massa de Produtos

### Critérios de Aceite

* O arquivo **Products.json** deve ser localizado corretamente.
* O conteúdo deve ser desserializado sem erros.
* A lista resultante não deve estar vazia.
* Deve existir ao menos um registro com produto existente preenchido.

---

## CA024 - Leitura da Massa de Carrinho

### Critérios de Aceite

* O arquivo **CartItems.json** deve ser localizado corretamente.
* O conteúdo deve ser desserializado sem erros.
* A lista resultante não deve estar vazia.
* Deve existir ao menos um item com nome de produto válido.

---

## CA025 - Leitura da Massa de Checkout

### Critérios de Aceite

* O arquivo **CheckoutData.json** deve ser localizado corretamente.
* O conteúdo deve ser desserializado sem erros.
* A lista resultante não deve estar vazia.
* Deve existir ao menos um registro com número de cartão preenchido.

---

# Critérios Gerais de Aprovação

Uma funcionalidade será considerada aprovada quando:

* Os critérios de aceite aplicáveis ao cenário forem atendidos.
* Nenhuma falha crítica impedir a execução do fluxo principal.
* Os resultados observados estiverem de acordo com o comportamento esperado.
* As asserções automatizadas forem concluídas com sucesso.
* As evidências previstas forem geradas corretamente quando aplicável.
* O resultado da execução for registrado no relatório quando aplicável.

---

# Critérios Gerais de Reprovação

Uma funcionalidade será considerada reprovada quando:

* Algum critério obrigatório aplicável ao cenário não for atendido.
* O comportamento observado divergir do resultado esperado.
* Existirem falhas que impeçam a conclusão do fluxo principal.
* As validações automatizadas apresentarem resultado inesperado.
* Uma asserção obrigatória falhar.
* A execução for interrompida por erro funcional ou técnico relacionado ao cenário.

---

# Rastreabilidade entre Critérios e Casos de Teste

| Critério de Aceite | Caso de Teste |
| ------------------ | ------------- |
| CA001 | LOGIN001 |
| CA002 | CT001 |
| CA003 | CT002 |
| CA004 | CT003 |
| CA005 | CT004 |
| CA006 | CT005 |
| CA007 | CT006 |
| CA008 | CT007 |
| CA009 | CT008 |
| CA010 | CT009 |
| CA011 | CT010 |
| CA012 | CT011 |
| CA013 | CT012 |
| CA014 | CT013 |
| CA015 | CT014 |
| CA016 | CT015 |
| CA017 | CT016 |
| CA018 | CT017 |
| CA019 | CT018 |
| CA020 | CT019 |
| CA021 | CT020 |
| CA022 | CT021 |
| CA023 | CT022 |
| CA024 | CT023 |
| CA025 | CT024 |

---

# Cobertura dos Critérios de Aceite

## Funcionalidades contempladas

* Login
* Cadastro
* Produtos
* Carrinho
* Checkout
* Data Driven Testing

## Quantidade de Critérios

| Funcionalidade | Quantidade |
| -------------- | ---------- |
| Login | 5 |
| Cadastro | 5 |
| Produtos | 4 |
| Carrinho | 3 |
| Checkout | 4 |
| Data Driven Testing | 4 |

**Total de Critérios de Aceite:** **25**

---

# Status

**Documento revisado na Sprint 9 — Refatoração e Publicação.**

Todos os critérios de aceite previstos para o escopo atual do framework encontram-se documentados e associados aos respectivos casos de teste automatizados.

A revisão final contempla:

* Alinhamento entre critérios de aceite e comportamento realmente validado pelos testes.
* Revisão da rastreabilidade entre critérios e casos de teste.
* Atualização dos critérios relacionados ao Data Driven Testing.
* Revisão das validações de evidências e relatórios.
* Padronização da documentação.
* Compatibilidade com a estrutura final do framework.
* Preparação para publicação definitiva.

---

# Situação Atual

O projeto encontra-se na:

**Sprint 9 — Refatoração e Publicação**

Esta é a última Sprint planejada para o escopo atual do framework.

Durante esta etapa final, os critérios de aceite passam por revisão de consistência com:

* Casos de teste automatizados.
* Page Objects.
* Modelos de dados.
* Arquivos JSON.
* Evidências geradas.
* Relatórios HTML.
* Asserções implementadas.
* Nomenclatura técnica final do código-fonte.

Após a conclusão da revisão e da execução final da suíte automatizada, o documento será considerado definitivo para a versão de publicação do projeto.

---

# Conclusão

Os **25 critérios de aceite** documentados representam as condições de aprovação dos **25 casos de teste** contemplados pelo framework.

A rastreabilidade entre critérios de aceite e casos automatizados permite verificar de forma objetiva quais comportamentos são validados em cada cenário.

Com a conclusão da **Sprint 9 — Refatoração e Publicação**, este documento passa a representar a versão final dos critérios de aceite do projeto.