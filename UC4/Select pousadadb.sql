USE pousadadb;

SELECT * FROM cliente;

SELECT * FROM telefone;

# SELECT * FROM cliente
# INNER JOIN telefone
# ON cliente.codcliente = telefone.codcliente;

SELECT cliente.codCliente, cliente.nomeCliente, telefone.telefone FROM cliente
INNER JOIN telefone
ON cliente.codcliente = telefone.codcliente;

SELECT cliente.nomeCliente, hospedagem.estado, hospedagem.dataInicio, hospedagem.dataFim FROM cliente
INNER JOIN hospedagem
ON cliente.codCliente = hospedagem.codCliente;

SELECT  hospedagem.estado, hospedagem.datainicio, hospedagem.datafim, chale.localizacao FROM hospedagem
INNER JOIN chale
ON hospedagem.codhospedagem = chale.codchale;