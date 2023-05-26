USE master;

-- Fecha todas as conexões ativas com o banco de dados
ALTER DATABASE NomeBancoDados
SET SINGLE_USER
WITH ROLLBACK IMMEDIATE;

-- Restaura o banco de dados usando um backup anterior
RESTORE DATABASE NomeBancoDados
FROM DISK = ''
WITH REPLACE;

-- Reabre o banco de dados para conexões
ALTER DATABASE NomeBancoDados
SET MULTI_USER;
Certifique-se de substituir "NomeBancoDados" pelo nome do seu banco de dados e "CaminhoBackup.bak" pelo caminho do arquivo de backup apropriado.

Essa consulta fecha todas as conexões ativas com o banco de dados, restaura o banco de dados usando o backup fornecido e, em seguida, reabre o banco de dados para conexões novamente.

Lembre-se de que essa é uma consulta geral e pode ser necessário fazer ajustes para atender aos seus requisitos específicos ou considerar outras opções e parâmetros de restauração disponíveis.






