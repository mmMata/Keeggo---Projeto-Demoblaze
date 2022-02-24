#language: pt

@login
Funcionalidade: Login

@loginvalido
Esquema do Cenario: Efetuar Login válido
Dado que eu esteja no site 
Quando clico em Conecte-se
E preencho o usuario
E preencho senha
E clico em Conecte se
Então realizo o login

@logininvalido
Esquema do Cenario: Efetuar Login inválido
Dado que eu esteja no site 
Quando clico em Conecte-se
E preencho o usuario
E preencho senha
E clico em Conecte se
E clico em ok no pop up de alerta de erro
Então permanesso na tela de login
