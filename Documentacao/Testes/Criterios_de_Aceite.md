# Critérios de Aceite

## Objetivo

Definir as condições mínimas necessárias para que uma funcionalidade seja considerada aprovada durante a execução dos testes.

Os critérios de aceite servem como referência para validação das regras de negócio, garantindo que os resultados obtidos estejam alinhados com os requisitos esperados.

---

# Funcionalidade: Login

## CA001 - Login com Credenciais Válidas

### Critérios de Aceite

* O usuário deve conseguir acessar o sistema utilizando credenciais válidas.
* O sistema deve redirecionar o usuário para a página principal.
* Nenhuma mensagem de erro deve ser apresentada.

---

## CA002 - Login com Credenciais Inválidas

### Critérios de Aceite

* O sistema deve impedir a autenticação.
* O usuário deve permanecer na tela de login.
* Uma mensagem informando credenciais inválidas deve ser exibida.

---

## CA003 - Campos Obrigatórios

### Critérios de Aceite

* O sistema deve exigir o preenchimento dos campos obrigatórios.
* O acesso não deve ser permitido com campos vazios.
* A validação deve ocorrer antes da autenticação.

---

# Funcionalidade: Cadastro de Usuário

## CA004 - Cadastro com Dados Válidos

### Critérios de Aceite

* O cadastro deve ser concluído com sucesso.
* Os dados devem ser registrados no sistema.
* O usuário deve receber confirmação do cadastro.

---

## CA005 - Cadastro com E-mail Duplicado

### Critérios de Aceite

* O sistema deve impedir o cadastro.
* Deve ser apresentada mensagem informando que o e-mail já está cadastrado.
* Nenhum novo registro deve ser criado.

---

## CA006 - Campos Obrigatórios de Cadastro

### Critérios de Aceite

* Todos os campos obrigatórios devem ser validados.
* O cadastro não deve ser concluído com informações incompletas.
* O sistema deve informar os campos pendentes.

---

# Funcionalidade: Pesquisa de Produtos

## CA007 - Pesquisa de Produto Existente

### Critérios de Aceite

* O produto pesquisado deve ser localizado.
* Os resultados devem corresponder ao termo informado.
* O usuário deve conseguir acessar os detalhes do produto.

---

## CA008 - Pesquisa de Produto Inexistente

### Critérios de Aceite

* Nenhum produto incorreto deve ser apresentado.
* O sistema deve informar que não existem resultados para a pesquisa.

---

# Funcionalidade: Carrinho de Compras

## CA009 - Adicionar Produto ao Carrinho

### Critérios de Aceite

* O produto deve ser incluído no carrinho.
* A quantidade de itens deve ser atualizada.
* O valor total deve refletir a inclusão do item.

---

## CA010 - Adicionar Múltiplos Produtos

### Critérios de Aceite

* Todos os produtos selecionados devem ser adicionados.
* O carrinho deve exibir todos os itens corretamente.
* O valor total deve ser atualizado.

---

## CA011 - Remover Produto do Carrinho

### Critérios de Aceite

* O item removido não deve mais aparecer no carrinho.
* O valor total deve ser recalculado.
* A quantidade de itens deve ser atualizada.

---

# Funcionalidade: Checkout

## CA012 - Finalização da Compra

### Critérios de Aceite

* O pedido deve ser criado com sucesso.
* O sistema deve exibir confirmação da compra.
* O usuário deve receber o número ou confirmação do pedido.

---

## CA013 - Dados Obrigatórios do Checkout

### Critérios de Aceite

* O sistema deve validar todos os campos obrigatórios.
* A compra não deve ser concluída sem as informações necessárias.
* Devem ser exibidas mensagens de validação adequadas.

---

## CA014 - Dados Inválidos no Checkout

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

---

# Critérios Gerais de Reprovação

Uma funcionalidade será considerada reprovada quando:

* Algum critério de aceite não for atendido.
* O comportamento observado divergir do esperado.
* Existirem erros que impeçam a execução do fluxo principal.
* As regras de negócio não forem respeitadas.

---

# Status

Critérios de aceite documentados e aprovados para utilização durante a execução dos testes manuais e automatizados.
