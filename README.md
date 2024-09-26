Sistema de Gerenciamento de clientes de uma biblioteca

O SGC (Sistema de Gerenciamento de Clientes) é um projeto desenvolvido para gerir de forma clara e segura uma biblioteca que necessite
de uma noção limpa da clientela do lugar. Sua interface simples e descomplicada  permite que a inserção, edição e exclusão de clientes seja concluída 
com efeito imediato utilizando uma interface de Windows Forms e banco de dados SQLite.

Tecnologias ultilizadas:

* C#
* Windows Forms
* SQLite

Pré-requisitos para ultilizar o programa:

* IDE Visual Studio
* IDE DB Browser Sqlite

Pacotes Nugget:
* Microsoft.Data.Sqlite.Core
* Microsoft.EntityFrameworkCore.Sqlite

Modo de Uso:

Tela de Login:
Esta é a primeira tela que aparece ao rodar o projeto, a tela de Login é integrada com parametrização de query e 
possui as funcionalidades necessárias para confirmar a veracidade do Login e da senha fornecida pelo usuário.


![Captura de tela 2024-09-21 161507](https://github.com/user-attachments/assets/12fa03df-8648-4b37-8a89-ef03cc863ee0)



Tela Principal:
A próxima tela a ser mostrada é o coração do programa, pois é a partir desta que o usuário poderá escolher se deseja adicionar um novo cliente ao clicar 
no botão "Cadastrar novo Cliente", consultar os clientes já existentes clicando na opção "Consultar cliente já existente" ou até mesmo sair do programa.


![Captura de tela 2024-09-21 161529](https://github.com/user-attachments/assets/6f42d821-1b86-4add-ad12-4afe9d4cf897)



Tela de Cadastro:
Caso o usuário opte por clicar no primeiro botão ele será direcionado para essa página, nela contém os campos necessárias para cadastrar um cliente como: 
Nome, CPF, Email, Telefone e endereço. Logo abaixo dos campos se encontram as opções salvar, limpar e voltar, cujo as mesmas ficam atrás de um espaço dedicado
a lista onde os dados dos clientes são salvos e listados.


![Captura de tela 2024-09-21 161750](https://github.com/user-attachments/assets/b4e16892-d35a-4338-ab37-604ffe206294)



Tela de Consultas:
Por ultimo, mas não menos importante, temos a tela de consultas. Seu nome já diz sua função, trazer os clientes que estão salvos no banco de dados ligado
ao projeto a partir de um DataGridView que retorna essa requisição apenas colocando o nome ou o Cpf desejado. Além desta função a tela também possui espaço 
para retornar uma listagem destes clientes afim de que seja possível fazer edições nos campos citados anteriormente, bem como excluir clientes.


![Captura de tela 2024-09-21 161809](https://github.com/user-attachments/assets/d5808bbf-9f87-40b7-93c4-fc7b442b948d)


Projeto desenvolvido por Fabio Lourenço F Ataide e João Victor Marchiori da Silva
