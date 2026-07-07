# Casos de Teste

## Objetivo

Documentar os procedimentos necessários para validar as funcionalidades do sistema de e-commerce utilizado como base para o framework de automação.

O documento contempla os fluxos funcionais automatizados, validações de infraestrutura, leitura de massas de dados externas e integração progressiva de evidências e relatórios de execução.

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

1. Realizar login com credenciais válidas.
2. Validar que o usuário está autenticado.
3. Clicar em **Logout**.

**Resultado Esperado**

A sessão deve ser encerrada e a página de login deve ser exibida novamente.

---

# Módulo: Cadastro

### CT005 - Acesso à Área de Cadastro

**Prioridade:** Alta

**Pré-condição:** Nenhuma.

**Passos**

1. Acessar a aplicação.
2. Acessar a área de **Signup / Login**.
3. Validar a exibição da área de cadastro.

**Resultado Esperado**

Exibir corretamente a área de cadastro.

---

### CT006 - Início de Cadastro com Dados Válidos

**Prioridade:** Alta

**Pré-condição:** Utilizar um e-mail ainda não cadastrado.

**Passos**

1. Acessar a área de cadastro.
2. Informar um nome válido.
3. Informar um e-mail único.
4. Clicar no botão de cadastro.

**Resultado Esperado**

Exibir a tela **Enter Account Information**.

---

### CT007 - Cadastro com E-mail Já Existente

**Prioridade:** Alta

**Pré-condição:** Utilizar um e-mail previamente cadastrado.

**Passos**

1. Acessar a área de cadastro.
2. Informar um nome.
3. Informar um e-mail já existente.
4. Tentar iniciar o cadastro.

**Resultado Esperado**

Exibir a mensagem **"Email Address already exist!"**

---

### CT008 - Cadastro com Campos Obrigatórios Vazios

**Prioridade:** Alta

**Pré-condição:** Nenhuma.

**Passos**

1. Acessar a área de cadastro.
2. Não preencher os campos obrigatórios.
3. Acionar o botão de cadastro.

**Resultado Esperado**

O sistema deve impedir o avanço do cadastro.

---

### CT009 - Criação e Exclusão de Conta

**Prioridade:** Alta

**Pré-condição:** Utilizar um e-mail único.

**Passos**

1. Acessar a área de cadastro.
2. Informar nome e e-mail válidos.
3. Preencher as informações da conta.
4. Preencher os dados de endereço.
5. Criar a conta.
6. Validar a criação da conta.
7. Continuar para a aplicação.
8. Excluir a conta criada.
9. Validar a exclusão.

**Resultado Esperado**

A conta deve ser criada e posteriormente removida com sucesso.

---

# Módulo: Produtos

### CT010 - Acesso à Área de Produtos

**Prioridade:** Média

**Pré-condição:** Nenhuma.

**Passos**

1. Acessar a aplicação.
2. Navegar para a página de produtos.
3. Validar a exibição dos elementos da página.

**Resultado Esperado**

Exibir corretamente a página de produtos.

---

### CT011 - Pesquisa de Produto Existente

**Prioridade:** Média

**Pré-condição:** Produto existente na aplicação.

**Passos**

1. Acessar a página de produtos.
2. Informar o nome de um produto existente.
3. Executar a pesquisa.
4. Validar os resultados.

**Resultado Esperado**

Retornar produtos relacionados ao termo pesquisado.

---

### CT012 - Pesquisa de Produto Inexistente

**Prioridade:** Média

**Pré-condição:** Utilizar um termo sem correspondência na aplicação.

**Passos**

1. Acessar a página de produtos.
2. Informar um produto inexistente.
3. Executar a pesquisa.
4. Validar os resultados.

**Resultado Esperado**

A área de resultados deve ser exibida sem produtos correspondentes.

---

### CT013 - Visualização dos Detalhes do Produto

**Prioridade:** Média

**Pré-condição:** Produto disponível na aplicação.

**Passos**

1. Acessar a página de produtos.
2. Abrir os detalhes do primeiro produto.
3. Validar a página de detalhes.

**Resultado Esperado**

Abrir corretamente a página de detalhes do produto.

---

# Módulo: Carrinho

### CT014 - Adicionar Produto ao Carrinho

**Prioridade:** Alta

**Pré-condição:** Produto disponível na aplicação.

**Passos**

1. Acessar a página de produtos.
2. Adicionar o primeiro produto ao carrinho.
3. Acessar o carrinho.
4. Validar a presença do produto.

**Resultado Esperado**

Adicionar um produto ao carrinho com sucesso.

---

### CT015 - Adicionar Múltiplos Produtos ao Carrinho

**Prioridade:** Alta

**Pré-condição:** Produtos disponíveis na aplicação.

**Passos**

1. Adicionar o produto de ID 1 ao carrinho.
2. Adicionar o produto de ID 2 ao carrinho.
3. Acessar a página do carrinho.
4. Validar a quantidade de itens.

**Resultado Esperado**

O carrinho deve apresentar dois produtos.

---

### CT016 - Remover Produto do Carrinho

**Prioridade:** Alta

**Pré-condição:** Produto previamente adicionado ao carrinho.

**Passos**

1. Adicionar um produto ao carrinho.
2. Acessar a página do carrinho.
3. Validar a presença do produto.
4. Remover o primeiro produto.
5. Validar o estado final do carrinho.

**Resultado Esperado**

O produto deve ser removido corretamente e o carrinho deve ficar vazio.

---

# Módulo: Checkout

### CT017 - Acessar Tela de Checkout

**Prioridade:** Alta

**Pré-condição:** Usuário autenticado e produto presente no carrinho.

**Passos**

1. Realizar login.
2. Adicionar um produto ao carrinho.
3. Acessar o carrinho.
4. Validar a presença do produto.
5. Avançar para o checkout.

**Resultado Esperado**

Exibir corretamente a página de checkout com os detalhes de endereço e revisão do pedido.

---

### CT018 - Finalizar Compra com Sucesso

**Prioridade:** Alta

**Pré-condição:** Usuário autenticado e produto presente no carrinho.

**Passos**

1. Realizar login.
2. Adicionar um produto ao carrinho.
3. Acessar o checkout.
4. Informar um comentário para o pedido.
5. Avançar para o pagamento.
6. Preencher os dados de pagamento.
7. Confirmar o pedido.

**Resultado Esperado**

Concluir a compra e exibir **Order Placed!**

---

### CT019 - Acessar Tela de Pagamento

**Prioridade:** Alta

**Pré-condição:** Usuário autenticado e checkout disponível.

**Passos**

1. Realizar login.
2. Adicionar um produto ao carrinho.
3. Acessar o checkout.
4. Informar o comentário do pedido.
5. Clicar em **Place Order**.
6. Validar a tela de pagamento.

**Resultado Esperado**

Exibir corretamente a tela de pagamento e seus campos obrigatórios.

---

### CT020 - Finalizar Compra com Segunda Massa de Dados

**Prioridade:** Alta

**Pré-condição:** Usuário autenticado e segundo produto disponível.

**Passos**

1. Realizar login.
2. Adicionar o produto de ID 2 ao carrinho.
3. Acessar o checkout.
4. Informar um segundo conjunto de dados.
5. Preencher os dados de pagamento.
6. Confirmar o pedido.

**Resultado Esperado**

Concluir a compra utilizando um segundo conjunto de dados.

---

# Módulo: Data Driven Testing

### CT021 - Leitura da Massa de Usuários

**Prioridade:** Média

**Pré-condição:** Arquivo **Users.json** disponível no diretório de massas de teste.

**Passos**

1. Carregar o arquivo **Users.json**.
2. Validar que a coleção não está vazia.
3. Validar a existência do usuário identificado pela chave **validUser**.

**Resultado Esperado**

Carregar corretamente a massa de usuários.

---

### CT022 - Leitura da Massa de Produtos

**Prioridade:** Média

**Pré-condição:** Arquivo **Products.json** disponível no diretório de massas de teste.

**Passos**

1. Carregar o arquivo **Products.json**.
2. Validar que a coleção não está vazia.
3. Validar a existência de um produto preenchido.

**Resultado Esperado**

Carregar corretamente a massa de produtos.

---

### CT023 - Leitura da Massa de Carrinho

**Prioridade:** Média

**Pré-condição:** Arquivo **CartItems.json** disponível no diretório de massas de teste.

**Passos**

1. Carregar o arquivo **CartItems.json**.
2. Validar que a coleção não está vazia.
3. Validar a existência de um item com nome de produto preenchido.

**Resultado Esperado**

Carregar corretamente a massa de carrinho.

---

### CT024 - Leitura da Massa de Checkout

**Prioridade:** Média

**Pré-condição:** Arquivo **CheckoutData.json** disponível no diretório de massas de teste.

**Passos**

1. Carregar o arquivo **CheckoutData.json**.
2. Validar que a coleção não está vazia.
3. Validar a existência de dados de cartão preenchidos.

**Resultado Esperado**

Carregar corretamente a massa de checkout.

---

# Infraestrutura de Evidências e Relatórios

O framework possui suporte para geração e gerenciamento de evidências de execução.

## ScreenshotHelper

Responsável por:

* Capturar screenshots durante a execução dos testes.
* Organizar evidências por execução.
* Armazenar arquivos no diretório **Evidence**.
* Retornar o caminho completo das capturas para integração com relatórios.

## ReportHelper

Responsável por:

* Criar relatórios HTML com ExtentReports.
* Registrar início das execuções.
* Registrar informações dos testes.
* Registrar resultados de sucesso.
* Registrar falhas e exceções.
* Anexar screenshots aos testes.
* Registrar informações do ambiente de execução.
* Gravar o relatório final em disco.

---

# Resumo

**Total de Casos de Teste:** **25**

## Implementados

* ✔ LOGIN001
* ✔ CT001 ao CT024

## Planejados

* Nenhum caso funcional adicional no escopo atual.

## Distribuição

* Login: 5
* Cadastro: 5
* Produtos: 4
* Carrinho: 3
* Checkout: 4
* Data Driven Testing: 4

**Total:** 25 casos de teste.

---

# Status Geral

**Sprint 9 — Refatoração e Publicação em andamento.**

O framework contempla atualmente:

* Automação dos principais fluxos funcionais da aplicação.
* Organização baseada em Page Object Model (POM).
* Massa de dados externa em arquivos JSON.
* Data Driven Testing.
* Captura automática de screenshots.
* Organização de evidências por execução.
* Integração com ExtentReports.
* Registro de sucesso e falha durante as execuções.
* Anexação de evidências aos relatórios HTML.
* Execução sequencial dos testes automatizados.
* Configuração centralizada da aplicação.
* Gerenciamento centralizado do WebDriver.
* Separação entre páginas, testes, modelos, utilitários e massas de dados.

A Sprint 8 — Evidências e Relatórios foi concluída com a implementação da infraestrutura de geração de relatórios HTML, captura de screenshots e integração das evidências aos testes automatizados.

A Sprint 9 concentra-se na revisão final da arquitetura do framework, padronização da nomenclatura do código em inglês, refatoração das classes e métodos, revisão da documentação e preparação do repositório para publicação.

Entre as atividades finais estão:

* Padronização dos nomes de classes, arquivos, métodos e variáveis em inglês.
* Manutenção da documentação funcional e técnica em português.
* Revisão da estrutura Page Object Model.
* Revisão dos Models utilizados pelas massas de dados.
* Padronização dos testes automatizados.
* Revisão da integração com ExtentReports.
* Validação da geração consolidada dos relatórios.
* Revisão das evidências geradas durante as execuções.
* Remoção de código redundante ou não utilizado.
* Revisão final dos arquivos JSON.
* Atualização do README.
* Validação completa da suíte automatizada.
* Preparação do repositório para publicação.

**Próxima etapa:** concluir a Sprint 9, executar a validação final da suíte completa e publicar a versão estável do framework.

---

# Encerramento Previsto

Após a conclusão da Sprint 9, o projeto será considerado finalizado dentro do escopo definido.

A versão final deverá contemplar:

* 25 casos de teste implementados.
* Fluxos de Login, Cadastro, Produtos, Carrinho e Checkout.
* Data Driven Testing com arquivos JSON.
* Page Object Model.
* Evidências automáticas.
* Relatórios HTML com ExtentReports.
* Estrutura de código padronizada em inglês.
* Documentação mantida em português.
* Suíte automatizada validada.
* Repositório preparado para apresentação profissional e publicação.

**Sprint Final:** Sprint 9 — Refatoração e Publicação.
