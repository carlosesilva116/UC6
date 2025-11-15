USE estacionamentodb;

SELECT cliente.*, veiculo.placa, veiculo.modelo FROM cliente
INNER join veiculo 
ON cliente.id = veiculo.cliente_id ;