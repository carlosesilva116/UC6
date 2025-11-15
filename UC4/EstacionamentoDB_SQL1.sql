SELECT
Clientes.id,
Clientes.nome,
Clientes.cpf,
Veiculos.placa,
Veiculos.modelo

FROM 
Clientes
INNER JOIN
Veiculos ON Clientes.id = Veiculos.cliente_id

SELECT * FROM Clientes;

SELECT * FROM Veiculos;

DELETE FROM Clientes WHERE id = 2;

DELETE FROM Clientes WHERE id = 4;

