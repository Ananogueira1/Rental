USE EMPRESA_VEICULOS;
GO

SELECT * FROM EMPRESA;
GO

SELECT * FROM MARCA;
GO

SELECT * FROM CLIENTE;
GO

SELECT * FROM MODELO;
GO

SELECT * FROM VEICULO;
GO

SELECT * FROM ALUGUEL;
GO

---listar todos os alugueis mostrando as datas de início e fim, o nome do cliente que alugou e nome do modelo do carro

SELECT dataRetirada, dataDevolucao, CLIENTE.nomeCliente, MODELO.nomeModelo 
FROM ALUGUEL
INNER JOIN CLIENTE
ON ALUGUEL.idCliente = CLIENTE.idCliente
INNER JOIN VEICULO
ON VEICULO.idVeiculo = ALUGUEL.idVeiculo
INNER JOIN MODELO
ON VEICULO.idModelo = MODELO.idModelo;
GO

--- listar os alugueis de um determinado cliente mostrando seu nome, as datas de início e fim e o nome do modelo do carro

SELECT nomeCliente, DataRetirada, DataDevolucao, nomeModelo 
FROM ALUGUEL
INNER JOIN CLIENTE
ON CLIENTE.idCliente =  ALUGUEL.idCliente
INNER JOIN VEICULO
ON VEICULO.idVeiculo = ALUGUEL.idVeiculo
INNER JOIN MODELO
ON VEICULO.idModelo = MODELO.idModelo
WHERE CLIENTE.nomeCliente = 'Laura'
GO