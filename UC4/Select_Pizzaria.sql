SELECT * FROM Clientes;
SELECT * FROM Pedidos;
SELECT * FROM Pedido_itens;
SELECT * FROM Pizzas;

SELECT pedidos.id, pizzas.sabor, pedido_itens.quantidade, pedido_itens.valor_unitario
FROM pedidos
INNER JOIN pedido_itens ON pedidos.id = pedido_itens.pedido_id
INNER JOIN pizzas ON pedido_itens.pizza_id = pizzas.id;

#1. Listar os pedidos e os nomes dos clientes que os fizeram.

#Objetivo: Queremos ver o ide data_horade cada pedido ao lado do nomecliente correspondente.

SELECT Pedidos.id, Pedidos.data_Hora, Clientes.nome                                                                                 
FROM Pedidos
INNER JOIN Clientes ON Clientes.id = pedidos.cliente_id

#2. Mostre os sabores de pizza em cada item do pedido.

#Objetivo: Queremos ver o saborde cada pizza, quantidadepedida e valor_unitarioregistrada na venda.

SELECT Pizzas.sabor,
 Pedido_Itens.quantidade,
 Pedido_Itens.Valor_unitario
 FROM Pedido_Itens
INNER JOIN Pizzas ON Pedido_Itens.Pizza_id = Pizzas.id;

#1. Listar TODOS os clientes e os pedidos que eles fizeram.

#Objetivo: Queremos garantir que todos os clientes da nossa base apliquem, mesmo aqueles que nunca atenderam. Exiba o nomedo cliente e ido do pedido.

SELECT * FROM Clientes
LEFT JOIN Pedidos ON Clientes.id = Pedidos.cliente_id
ORDER BY clientes.id;

#2. Descubra quais pizzas do cardápio nunca foram vendidas.

#Objetivo: Queremos verificar no nosso cardápio ( Pizzas) quais sabores ainda não tiveram saída. Exiba apenas o saborda pizza.

SELECT *
FROM Pizzas
LEFT JOIN Pedido_Itens ON Pizzas.id = Pedido_Itens.Pizza_id
WHERE pedido_itens.pizza_id IS NULL;


#Exercício 1: Relatório Detalhado de Itens Vendidos

#Tarefa: Crie uma consulta que mostre os detalhes de todos os itens já pedidos. A consulta deve ligar os pedidos aos seus itens e os itens às informações das pizzas.
#Campos a exibir:
#Da tabela Pedidos, mostre o campo id.
#Da tabela Pedidos, mostre o campo data_hora.
#Da tabela Pizzas, mostre o campo sabor.
#Da tabela Pedido_Itens, mostre o campo quantidade.

SELECT Pedidos.id, Pedidos.data_hora, Pizzas.Sabor, Pedido_Itens.quantidade FROM Pedidos
INNER JOIN pedido_Itens ON pedido_itens.pedido_id = Pedidos.id
INNER JOIN Pizzas ON pedido_Itens.pizza_id =Pizzas.id;

/*
Exercício 2: Quais clientes pediram quais pizzas?

Tarefa: Gere um relatório que mostre o nome do cliente e o sabor da pizza para cada item do pedido que ele fez. Isso exige ligar o cliente ao pedido, e o pedido ao item, e o item à pizza.
Campos a exibir:
Da tabela Clientes, mostre o campo nome.
Da tabela Pedidos, mostre a data_horado pedido.
Da tabela Pizzas, mostre o saborda pizza.
*/

SELECT Clientes.nome, Pedidos.data_hora as horas, Pizzas.sabor
FROM Clientes
INNER JOIN Pedidos ON Clientes.id = Pedidos.cliente_id
INNER JOIN Pedido_Itens ON Pedido_Itens.pedido_id = Clientes.id
INNER JOIN Pizzas ON Pedido_Itens.pizza_id = pizzas.id;
