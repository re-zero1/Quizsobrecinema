create Database db_Quizcinema

create table tb_Players(
	id_Player int identity primary key,
	nome varchar(100) not null
)
-- selecionar toda tabela jogador
select * from tb_Players
-- selecionar toda tabela perguntas
select * from tb_perguntas

-- insere nomes na tabela jogador
insert into tb_Jogador(nome) values('Amanda')
insert into tb_Jogador(nome) values('Fernanda')
-- cria a tabela perguntas
create table tb_perguntas(
id_Pergunta int identity primary key,
pergunta varchar(max),
resposta_correta varchar (max),
data datetime default getdate()
)
--inserindo a pergunta 
insert into tb_perguntas(pergunta, resposta_correta) values('Qual cidade ocorreu teremoto','toquio')
--deleta o id do numero 12
delete from tb_Jogador where id = 12
insert into tb_Jogador(nome) values ('ramon')
--deleta os dados da tabela
delete from tb_Jogador
delete from tb_perguntas
--apaga os dados da tabela
truncate table tb_players
truncate table tb_perguntas
--acrescenta coluna na tabela
ALTER TABLE tb_Perguntas ADD id_jogador int  ;
--exclui a coluna da tabela
ALTER TABLE tb_Players ADD Email varchar (40);
ALTER TABLE tb_Perguntas ADD pontos int ;
ALTER TABLE tb_Perguntas drop  Email;
ALTER TABLE tb_Players DROP COLUMN Email ; 
