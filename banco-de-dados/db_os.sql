SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_os`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_cliente`
--

CREATE TABLE `tb_cliente` (
  `id_cliente` int(11) NOT NULL,
  `nome_cliente` varchar(80) NOT NULL,
  `endereco_cliente` varchar(120) NOT NULL,
  `bairro_cliente` varchar(60) NOT NULL,
  `cidade_cliente` varchar(60) NOT NULL,
  `telefone_cliente` varchar(10) DEFAULT NULL,
  `celular_cliente` varchar(11) DEFAULT NULL,
  `cpf_cliente` varchar(14) DEFAULT NULL,
  `email_cliente` varchar(150) DEFAULT NULL,
  `id_usuario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_fornecedor`
--

CREATE TABLE `tb_fornecedor` (
  `id_fornecedor` int(11) NOT NULL,
  `nome_fornecedor` varchar(80) NOT NULL,
  `endereco_fornecedor` varchar(120) NOT NULL,
  `bairro_fornecedor` varchar(60) NOT NULL,
  `cidade_fornecedor` varchar(60) NOT NULL,
  `telefone_fornecedor` varchar(10) DEFAULT NULL,
  `celular_fornecedor` varchar(11) DEFAULT NULL,
  `cpfcnpj_fornecedor` varchar(14) DEFAULT NULL,
  `email_fornecedor` varchar(150) DEFAULT NULL,
  `id_usuario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_funcionario`
--

CREATE TABLE `tb_funcionario` (
  `id_funcionario` int(11) NOT NULL,
  `nome_funcionario` varchar(80) NOT NULL,
  `endereco_funcionario` varchar(120) NOT NULL,
  `bairro_funcionario` varchar(60) NOT NULL,
  `cidade_funcionario` varchar(60) NOT NULL,
  `celular_funcionario` varchar(11) NOT NULL,
  `cpf_funcionario` varchar(14) NOT NULL,
  `data_ad_funcionario` date DEFAULT NULL,
  `situacao_funcionario` tinyint(1) NOT NULL,
  `id_usuario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `tb_funcionario`
--


-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_item_os`
--

CREATE TABLE `tb_item_os` (
  `id_item_os` int(11) NOT NULL,
  `qtd_item_os` int(11) NOT NULL,
  `id_produto` int(11) NOT NULL,
  `id_os` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_item_venda`
--

CREATE TABLE `tb_item_venda` (
  `id_item_venda` int(11) NOT NULL,
  `qtd_item_venda` int(11) NOT NULL,
  `id_produto` int(11) NOT NULL,
  `id_venda` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `tb_item_venda`
--


-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_os`
--

CREATE TABLE `tb_os` (
  `id_os` int(11) NOT NULL,
  `data_entrada_os` date NOT NULL,
  `retorno_os` tinyint(1) NOT NULL,
  `equipamento_os` varchar(20) NOT NULL,
  `marca_os` varchar(20) NOT NULL,
  `modelo_os` varchar(20) NOT NULL,
  `senha_os` varchar(25) DEFAULT NULL,
  `defeito_relatado_os` varchar(244) NOT NULL,
  `observacoes_os` varchar(244) DEFAULT NULL,
  `data_saida_os` date DEFAULT NULL,
  `preco_servico_os` decimal(10,2) DEFAULT NULL,
  `defeito_constatado_os` varchar(244) DEFAULT NULL,
  `servico_executado_os` varchar(244) DEFAULT NULL,
  `finalizado_os` tinyint(1) NOT NULL,
  `id_cliente` int(11) NOT NULL,
  `id_funcionario` int(11) DEFAULT NULL,
  `id_usuario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_produto`
--

CREATE TABLE `tb_produto` (
  `id_produto` int(11) NOT NULL,
  `nome_produto` varchar(80) NOT NULL,
  `marca_produto` varchar(60) NOT NULL,
  `categoria_produto` varchar(45) NOT NULL,
  `estoque_produto` int(11) NOT NULL,
  `custo_produto` decimal(10,2) NOT NULL,
  `venda_produto` decimal(10,2) NOT NULL,
  `id_fornecedor` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_usuario`
--

CREATE TABLE `tb_usuario` (
  `id_usuario` int(11) NOT NULL,
  `nome_usuario` varchar(45) NOT NULL,
  `senha_usuario` varchar(8) NOT NULL,
  `situacao_usuario` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `tb_usuario`
--

INSERT INTO `tb_usuario` (`id_usuario`, `nome_usuario`, `senha_usuario`, `situacao_usuario`) VALUES
(1, 'admin', '1234', 1),
(2, 'user', '1234', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_venda`
--

CREATE TABLE `tb_venda` (
  `id_venda` int(11) NOT NULL,
  `operacao_venda` varchar(9) NOT NULL,
  `parcelamento_venda` int(11) NOT NULL,
  `vencimento_venda` date NOT NULL,
  `desconto_venda` decimal(10,2) NOT NULL,
  `acrescimo_venda` decimal(10,2) NOT NULL,
  `id_funcionario` int(11) NOT NULL,
  `id_cliente` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `data_venda` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_cliente`
--
ALTER TABLE `tb_cliente`
  ADD PRIMARY KEY (`id_cliente`),
  ADD KEY `fk_tb_cliente_td_usuario_idx` (`id_usuario`);

--
-- Indexes for table `tb_fornecedor`
--
ALTER TABLE `tb_fornecedor`
  ADD PRIMARY KEY (`id_fornecedor`),
  ADD KEY `fk_tb_fornecedor_td_usuario1_idx` (`id_usuario`);

--
-- Indexes for table `tb_funcionario`
--
ALTER TABLE `tb_funcionario`
  ADD PRIMARY KEY (`id_funcionario`),
  ADD KEY `fk_tb_funcionario_td_usuario1_idx` (`id_usuario`);

--
-- Indexes for table `tb_item_os`
--
ALTER TABLE `tb_item_os`
  ADD PRIMARY KEY (`id_item_os`),
  ADD KEY `fk_tb_item_os_tb_produto1_idx` (`id_produto`),
  ADD KEY `fk_tb_item_os_tb_os1_idx` (`id_os`);

--
-- Indexes for table `tb_item_venda`
--
ALTER TABLE `tb_item_venda`
  ADD PRIMARY KEY (`id_item_venda`),
  ADD KEY `fk_tb_item_venda_tb_produto1_idx` (`id_produto`),
  ADD KEY `fk_tb_item_venda_tb_venda1_idx` (`id_venda`);

--
-- Indexes for table `tb_os`
--
ALTER TABLE `tb_os`
  ADD PRIMARY KEY (`id_os`),
  ADD KEY `fk_tb_os_tb_cliente1_idx` (`id_cliente`),
  ADD KEY `fk_tb_os_tb_funcionario1_idx` (`id_funcionario`),
  ADD KEY `fk_tb_os_td_usuario1_idx` (`id_usuario`);

--
-- Indexes for table `tb_produto`
--
ALTER TABLE `tb_produto`
  ADD PRIMARY KEY (`id_produto`),
  ADD KEY `fk_tb_produto_tb_fornecedor1_idx` (`id_fornecedor`),
  ADD KEY `fk_tb_produto_td_usuario1_idx` (`id_usuario`);

--
-- Indexes for table `tb_usuario`
--
ALTER TABLE `tb_usuario`
  ADD PRIMARY KEY (`id_usuario`);

--
-- Indexes for table `tb_venda`
--
ALTER TABLE `tb_venda`
  ADD PRIMARY KEY (`id_venda`),
  ADD KEY `fk_tb_venda_tb_funcionario1_idx` (`id_funcionario`),
  ADD KEY `fk_tb_venda_tb_cliente1_idx` (`id_cliente`),
  ADD KEY `fk_tb_venda_td_usuario1_idx` (`id_usuario`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_cliente`
--
ALTER TABLE `tb_cliente`
  MODIFY `id_cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tb_fornecedor`
--
ALTER TABLE `tb_fornecedor`
  MODIFY `id_fornecedor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tb_funcionario`
--
ALTER TABLE `tb_funcionario`
  MODIFY `id_funcionario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tb_item_os`
--
ALTER TABLE `tb_item_os`
  MODIFY `id_item_os` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=77;

--
-- AUTO_INCREMENT for table `tb_item_venda`
--
ALTER TABLE `tb_item_venda`
  MODIFY `id_item_venda` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;

--
-- AUTO_INCREMENT for table `tb_os`
--
ALTER TABLE `tb_os`
  MODIFY `id_os` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT for table `tb_produto`
--
ALTER TABLE `tb_produto`
  MODIFY `id_produto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tb_usuario`
--
ALTER TABLE `tb_usuario`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tb_venda`
--
ALTER TABLE `tb_venda`
  MODIFY `id_venda` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `tb_cliente`
--
ALTER TABLE `tb_cliente`
  ADD CONSTRAINT `fk_tb_cliente_td_usuario` FOREIGN KEY (`id_usuario`) REFERENCES `tb_usuario` (`id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `tb_fornecedor`
--
ALTER TABLE `tb_fornecedor`
  ADD CONSTRAINT `fk_tb_fornecedor_td_usuario1` FOREIGN KEY (`id_usuario`) REFERENCES `tb_usuario` (`id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `tb_funcionario`
--
ALTER TABLE `tb_funcionario`
  ADD CONSTRAINT `fk_tb_funcionario_td_usuario1` FOREIGN KEY (`id_usuario`) REFERENCES `tb_usuario` (`id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `tb_item_os`
--
ALTER TABLE `tb_item_os`
  ADD CONSTRAINT `fk_tb_item_os_tb_os1` FOREIGN KEY (`id_os`) REFERENCES `tb_os` (`id_os`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tb_item_os_tb_produto1` FOREIGN KEY (`id_produto`) REFERENCES `tb_produto` (`id_produto`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `tb_item_venda`
--
ALTER TABLE `tb_item_venda`
  ADD CONSTRAINT `fk_tb_item_venda_tb_produto1` FOREIGN KEY (`id_produto`) REFERENCES `tb_produto` (`id_produto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tb_item_venda_tb_venda1` FOREIGN KEY (`id_venda`) REFERENCES `tb_venda` (`id_venda`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `tb_os`
--
ALTER TABLE `tb_os`
  ADD CONSTRAINT `fk_tb_os_tb_cliente1` FOREIGN KEY (`id_cliente`) REFERENCES `tb_cliente` (`id_cliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tb_os_tb_funcionario1` FOREIGN KEY (`id_funcionario`) REFERENCES `tb_funcionario` (`id_funcionario`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tb_os_td_usuario1` FOREIGN KEY (`id_usuario`) REFERENCES `tb_usuario` (`id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `tb_produto`
--
ALTER TABLE `tb_produto`
  ADD CONSTRAINT `fk_tb_produto_tb_fornecedor1` FOREIGN KEY (`id_fornecedor`) REFERENCES `tb_fornecedor` (`id_fornecedor`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tb_produto_td_usuario1` FOREIGN KEY (`id_usuario`) REFERENCES `tb_usuario` (`id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `tb_venda`
--
ALTER TABLE `tb_venda`
  ADD CONSTRAINT `fk_tb_venda_tb_cliente1` FOREIGN KEY (`id_cliente`) REFERENCES `tb_cliente` (`id_cliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tb_venda_tb_funcionario1` FOREIGN KEY (`id_funcionario`) REFERENCES `tb_funcionario` (`id_funcionario`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tb_venda_td_usuario1` FOREIGN KEY (`id_usuario`) REFERENCES `tb_usuario` (`id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
