CREATE DATABASE callisto;
USE callisto;

/*********************************************
 *                                           *
 *           Criação das tabelas             *
 *                                           *
 *********************************************/
 
CREATE TABLE jogador(
    jogador_id INT NOT NULL AUTO_INCREMENT,
    cpf VARCHAR(14) UNIQUE,
    nome VARCHAR(255) NOT NULL,
    sobrenome VARCHAR(255) NOT NULL,
    apelido VARCHAR(255),
    sexo CHAR,
    qtd_vitorias INT DEFAULT 0,
    qtd_derrotas INT DEFAULT 0,
    PRIMARY KEY(jogador_id),
    CHECK (sexo IN ('M', 'F'))
);
    
ALTER TABLE jogador AUTO_INCREMENT = 0;

CREATE TABLE torneio(
    torneio_id INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(255) NOT NULL,
    dt_inicio DATE NOT NULL,
    dt_fim DATE NOT NULL,
    qtd_participantes INT NOT NULL,
    qtd_vagas INT NOT NULL,
    premio VARCHAR(255) DEFAULT 'Sem premiação',
    id_vencedor INT,
    PRIMARY KEY(torneio_id),
    FOREIGN KEY (id_vencedor) REFERENCES jogador (jogador_id)
);
  
ALTER TABLE torneio AUTO_INCREMENT = 0;

CREATE TABLE personagem(
    personagem_id INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(255) NOT NULL,
    PRIMARY KEY(personagem_id)
);

CREATE TABLE partida(
    partida_id INT NOT NULL AUTO_INCREMENT,
    id_jogador1 INT NOT NULL,
    id_jogador2 INT NOT NULL,
    id_torneio INT NOT NULL,
    round varchar(255) NOT NULL,
    id_vencedor INT,
    PRIMARY KEY(partida_id),
    FOREIGN KEY(id_jogador1) REFERENCES jogador(jogador_id),
    FOREIGN KEY(id_jogador2) REFERENCES jogador(jogador_id),
    FOREIGN KEY(id_vencedor) REFERENCES jogador(jogador_id),
    FOREIGN KEY(id_torneio) REFERENCES torneio(torneio_id)
);

alter table partida change id_jogador1 id_jogador1 int;
alter table partida change id_jogador2 id_jogador2 int;
    
CREATE TABLE torneio_perso_jogador(
    id_torneio INT NOT NULL,
    id_jogador INT NOT NULL,
    id_personagem INT NOT NULL,
    PRIMARY KEY(id_torneio,id_jogador),
    FOREIGN KEY(id_torneio) REFERENCES torneio(torneio_id),
    FOREIGN KEY(id_jogador) REFERENCES jogador(jogador_id),
    FOREIGN KEY(id_personagem) REFERENCES personagem(personagem_id)
);

/*********************************************
 *                                           *
 *          Criação dos triggers             *
 *                                           *
 *********************************************/

DELIMITER $$
CREATE TRIGGER after_partida_update
    AFTER UPDATE ON partida
    FOR EACH ROW
BEGIN
		UPDATE jogador  SET qtd_vitorias = qtd_vitorias + 1 WHERE jogador_id = NEW.id_vencedor;
    
		IF (NEW.id_vencedor = NEW.id_jogador1) THEN
			UPDATE jogador  SET qtd_derrotas = qtd_derrotas + 1 WHERE jogador_id = NEW.id_jogador2;
		ELSE
			UPDATE jogador  SET qtd_derrotas = qtd_derrotas + 1 WHERE jogador_id = NEW.id_jogador1;
		END IF;
END $$
DELIMITER ;




-- NAO SEI PQ ESSA DESGRACA NAO FUNCIONA
DELIMITER $$
CREATE TRIGGER after_partida_update_final
    AFTER UPDATE ON partida
    FOR EACH ROW
BEGIN
    IF (NEW.round = 'Final') THEN
        UPDATE torneio SET id_vencedor = NEW.id_vencedor 
        WHERE torneio_id = NEW.id_torneio;
    END IF;
END $$
DELIMITER ;

CREATE TRIGGER after_torneio_perso_jogador_insert
    AFTER INSERT ON torneio_perso_jogador
    FOR EACH ROW
    UPDATE torneio SET torneio.qtd_vagas = torneio.qtd_vagas - 1
    WHERE torneio.torneio_id = NEW.id_torneio;
    
 CREATE TRIGGER after_torneio_perso_jogador_delete
    AFTER DELETE ON torneio_perso_jogador
    FOR EACH ROW
    UPDATE torneio SET torneio.qtd_vagas = torneio.qtd_vagas + 1
    WHERE torneio.torneio_id = OLD.id_torneio; 

DELIMITER $$
CREATE TRIGGER after_torneio_update
	BEFORE UPDATE ON torneio
    FOR EACH ROW
BEGIN
	IF(NEW.qtd_participantes != OLD.qtd_participantes) THEN
		SET NEW.qtd_vagas = (OLD.qtd_vagas + NEW.qtd_participantes - OLD.qtd_participantes);
	END IF;
END $$
DELIMITER ;


/*********************************************
 *                                           *
 * Populando as tabelas com dados de exemplo *
 *                                           *
 *********************************************/

INSERT INTO torneio
    (nome, dt_inicio, dt_fim, qtd_participantes,qtd_vagas)
VALUES
    ('XVII Torneio Carioca de Street Fighter V', STR_TO_DATE('20-May-2018', '%d-%M-%Y'), STR_TO_DATE('27-May-2018', '%d-%M-%Y'), 32,32),
    ('III Aberto de Sanca', STR_TO_DATE('13-Feb-2018', '%d-%M-%Y'), STR_TO_DATE('16-Feb-2018', '%d-%M-%Y'), 16,16),
    ('Preparação Brasileiro 2018', STR_TO_DATE('04-Jan-2018', '%d-%M-%Y'), STR_TO_DATE('11-Jan-2018', '%d-%M-%Y'), 8,8),
    ('Copa Zica 2018', STR_TO_DATE('01-Apr-2018', '%d-%M-%Y'), STR_TO_DATE('01-May-2018', '%d-%M-%Y'), 8,8);

INSERT INTO personagem 
    (nome) 
VALUES
    ('Abigail'),
    ('Akuma'),
    ('Alex'),
    ('Balrog'),
    ('Birdie'),
    ('Blanka'),
    ('Cammy'),
    ('Chun-li'),
    ('Cody'),
    ('Dhalsim'),
    ('Ed'),
    ('F.A.N.G'),
    ('Falke'),
    ('G'),
    ('Guile'),
    ('Ibuki'),
    ('Juri'),
    ('Karin'),
    ('Ken'),
    ('Kolin'),
    ('Laura'),
    ('M. Bison'),
    ('Menat'),
    ('Mika'),
    ('Nash'),
    ('Necalli'),
    ('Rashid'),
    ('Ryu'),
    ('Sagat'),
    ('Sakura'),
    ('Urien'),
    ('Vega'),
    ('Zangief'),
    ('Zeku');
    
INSERT INTO jogador 
    (cpf, nome, sobrenome, apelido, sexo)
VALUES
    ('450.612.502-90', 'Diogo Gabriel', 'da Mota', 'Biscoito', 'M'),
    ('239.067.219-14', 'Raul', 'Costa', 'Portuga', 'M'),
    ('826.682.656-06', 'João', 'Peixoto', 'Pesca', 'M'),
    ('204.232.726-32', 'Karina', 'Kowalsky', 'Bitoca', 'F'),
    ('428.375.821-31', 'Yago', 'Martins', 'Papagaio', 'M'),
    ('504.880.305-10', 'Isabela', 'Cooper', 'GG', 'F'),
    ('273.103.410-66', 'Severino', 'Oliveira', 'Seva', 'M'),
    ('611.396.839-18', 'Juan', 'Rodrigues', 'Bisteca', 'M'),
    ('308.148.125-20', 'Carolina', 'Marques', 'Spam', 'F'),
    ('658.862.407-72', 'Anna', 'Freitas', 'Poste', 'F'),
    ('692.385.218-83', 'Elsa', 'Dias', 'Minibyte', 'F'),
    ('986.592.294-01', 'José', 'Cunha', 'Batoré', 'M'),
    ('308.216.644-09', 'João', 'Drummond', 'Dorito', 'M'),
    ('659.307.896-49', 'Márcio', 'Figueiredo', 'Hobbit', 'M'),
    ('912.966.613-93', 'Bruno', 'Ramos', 'Leitão', 'M'),
    ('773.580.234-04', 'Lucas', 'Viana', 'Ken', 'M'),
    ('819.319.450-04', 'Carlos', 'Rocha', 'Kamikaze', 'M'),
    ('158.013.295-28', 'Lucas', 'Carvalho', 'Tank', 'M'),
    ('423.352.316-69', 'Bruno', 'Lopes', 'Buda', 'M'),
    ('901.251.766-43', 'Manoel', 'Cardoso', 'Monstro', 'M'),
    ('039.066.123-68', 'Melissa', 'Almeida', 'Barbie', 'F'),
    ('221.932.432-04', 'Jéssica', 'da Paz', 'Bubu', 'F'),
    ('851.505.195-88', 'Emanuel', 'Botelho', 'Shrek', 'M'),
    ('509.188.096-81', 'Heitor', 'Teixeira', 'Rei', 'M'),
    ('433.204.523-80', 'Amadeu', 'Silva', 'Pesado', 'M'),
    ('222.644.086-00', 'Gabriel', 'Galvão', 'Bolinho', 'M'),
    ('565.698.436-21', 'Anderson', 'Neves', 'Chiclé', 'M'),
    ('625.662.598-60', 'Sarah', 'Rüdiger', 'Top', 'F'),
    ('939.216.625-75', 'Bruna', 'Baptista', 'Mosquito', 'F'),
    ('628.355.830-50', 'Carlos', 'Oliveira', 'Champ', 'M'),
    ('190.705.831-19', 'Jorge', 'Duarte', 'Zilla', 'M'),
    ('719.530.555-40', 'Júlia', 'Castro', 'Tata', 'F');

alter table partida modify partida_id int not null;
alter table partida drop primary key;
alter table partida add primary key(num_partida,id_torneio);
alter table partida change partida_id num_partida int not null;
