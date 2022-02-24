#language: pt

@cadastro
Funcionalidade: Cadastro

@cadastrovalido
Esquema do Cenario: Efetuar cadastro válido
Dado que eu esteja no site demoblaze
Quando clico em inscrever-se
E preencho o nome do usuario
E preencho a senha
E clico em se inscrever 
E clico em ok no pop up de alerta 
Então volto para tela inicial

@cadastroinvalido
Esquema do Cenario: Efetuar cadastro inválido
Dado que eu esteja no site demoblaze
Quando clico em inscrever-se
E preencho o nome do usuario
E preencho a senha
E clico em se inscrever 
E clico em ok no pop up de alerta de erro
Então permanesso na tela de cadastro