create database integrador;

CREATE TABLE `usuarios` (
  `id` int(15) DEFAULT NULL,
  `nome` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `telefone` varchar(255) DEFAULT NULL,
  `valor_total` decimal(20,2) DEFAULT NULL,
  `valor_com_desconto` decimal(20,2) DEFAULT NULL
);

CREATE TABLE `dependentes` (
  `id` int(15) NOT NULL,
  `usuario_id` int(15) NOT NULL,
  `dependente_de_id` int(15) NOT NULL
) 