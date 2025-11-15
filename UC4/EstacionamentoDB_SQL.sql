-- Inserindo novos Clientes

INSERT INTO Clientes (nome, cpf, telefone) VALUES

('Fernando Rocha', '222.333.444-55', '11666666666'),

('Luciana Martins', '333.444.555-66', '11555555555'),

('Bruno Ferreira', '444.555.666-77', NULL); -- Cliente sem telefone
 
-- Inserindo Veículos (sem registros de estacionamento)

INSERT INTO Veiculos (cliente_id, placa, modelo, cor) VALUES

-- Veículos de Fernando Rocha

(5, 'GHI1234', 'Chevrolet Onix', 'Cinza'),

(5, 'JKL5678', 'Renault Kwid', 'Vermelho'),
 
-- Veículo de Luciana Martins

(6, 'MNO9012', 'Volkswagen Polo', 'Azul'),
 
-- Veículos de Bruno Ferreira

(7, 'PQR3456', 'Hyundai HB20', 'Preto'),

(7, 'STU7890', 'Ford Ka', 'Branco');
 
 