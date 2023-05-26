USE master;

-- Fecha todas as conex�es ativas com o banco de dados
ALTER DATABASE NomeBancoDados
SET SINGLE_USER
WITH ROLLBACK IMMEDIATE;

-- Restaura o banco de dados usando um backup anterior
RESTORE DATABASE NomeBancoDados
FROM DISK = ''
WITH REPLACE;

-- Reabre o banco de dados para conex�es
ALTER DATABASE NomeBancoDados
SET MULTI_USER;
Certifique-se de substituir "NomeBancoDados" pelo nome do seu banco de dados e "CaminhoBackup.bak" pelo caminho do arquivo de backup apropriado.

Essa consulta fecha todas as conex�es ativas com o banco de dados, restaura o banco de dados usando o backup fornecido e, em seguida, reabre o banco de dados para conex�es novamente.

Lembre-se de que essa � uma consulta geral e pode ser necess�rio fazer ajustes para atender aos seus requisitos espec�ficos ou considerar outras op��es e par�metros de restaura��o dispon�veis.






