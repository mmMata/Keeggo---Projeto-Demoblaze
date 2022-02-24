#language: pt

@carrinho
Funcionalidade: Adicinar e remover item do carrinho

@adicionar
Esquema do Cenario: Adicionar um item no carrinho de compras
Dado que eu esteja no site do demoblaze
Quando clico em login 
E preencho o meu usuario
E preencho a minha senha
E realizo o login
E seleciono um item
E adicono um item carrinho 
E valido o pop up de alerta
Então permanesso na tela da descricao do produto

@remover
Esquema do Cenario: Remover um item do carrinho
Dado que eu esteja no site do demoblaze
Quando clico em login 
E preencho o meu usuario
E preencho a minha senha
E realizo o login
E seleciono um item
E adicono um item carrinho 
E valido o pop up de alerta
E clico no carrinho
E clico em delete
Então valido que o item foi removido