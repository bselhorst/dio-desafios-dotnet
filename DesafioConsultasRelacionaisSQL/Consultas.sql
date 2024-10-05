-- 1. Buscar o nome e ano dos filmes
-- De acordo com a imagem
SELECT Id, Nome, Ano FROM Filmes;
-- Solução correta conforme o pedido
SELECT Nome, Ano FROM Filmes;

-- 2. Buscar o nome e ano dos filmes, ordenados por odem crescente pelo ano 
-- De acordo com a imagem
SELECT * FROM Filmes ORDER BY Ano;
-- Solução correta conforme o pedido
SELECT Nome, Ano FROM Filmes ORDER BY Ano;

-- 3. Buscar pelo filme de volta para o futuro, trazendo o nome, ano e duração
-- De acordo com a imagem
SELECT * FROM Filmes WHERE Nome='De Volta para o futuro';
-- Solução correta conforme o pedido
SELECT Nome, Ano, Duracao FROM Filmes WHERE Nome='De Volta para o futuro';

-- 4. Buscar os filmes lançados em 1997
SELECT * FROM Filmes WHERE Ano=1997;

-- 5. Buscar os filmes lançados após o ano 2000
SELECT * FROM Filmes WHERE Ano>2000;

-- 6. Buscar os filmes com a duração maior que 100 e menor que 150, ordenando pela duração em ordem crescente
SELECT * FROM Filmes WHERE Duracao>100 AND Duracao<150 ORDER BY Duracao;

-- 7. Buscar a quantidade de filmes lançadas no ano, agrupando por ano, ordenando pela duração em ordem decrescente
SELECT Ano, Count(*) AS Quantidade FROM Filmes GROUP BY Ano ORDER BY Duracao DESC;

-- 8. Buscar os atores do gênero masculino, retornando o PrimeiroNome, UltimoNome
-- De acordo com a imagem
SELECT * FROM Atores WHERE Genero='M'
-- Solução correta conforme o pedido
SELECT PrimeiroNome, UltimoNome FROM Atores WHERE Genero='M'

-- 9. Buscar os Atores do gênero feminino, retornando o PrimeiroNome, UltimoNome e ordenando pelo PrimeiroNome
-- De acordo com a imagem
SELECT * FROM Atores WHERE Genero='F' ORDER BY PrimeiroNome
-- Solução correta conforme o pedido
SELECT PrimeiroNome, UltimoNome FROM Atores WHERE Genero='F' ORDER BY PrimeiroNome

-- 10. Buscar o nome do filme e o gênero
SELECT f.Nome AS Nome, g.Genero AS Genero FROM Filmes f 
INNER JOIN FilmesGenero fg ON f.Id = fg.IdFilme
INNER JOIN Generos g ON g.Id = fg.IdGenero 

-- 11. Buscar o nome do filme e o gênero do tipo "Mistério"
SELECT f.Nome AS Nome, g.Genero AS Genero FROM Filmes f 
INNER JOIN FilmesGenero fg ON f.Id = fg.IdFilme
INNER JOIN Generos g ON g.Id = fg.IdGenero 
WHERE g.Genero='Mistério'

-- 12. Buscar o nome do filme e os atores, trazendo o PrimeiroNome, UltimoNome e seu papel.
SELECT f.Nome AS Nome, a.PrimeiroNome AS PrimeiroNome, a.UltimoNome AS UltimoNome, ef.Papel AS Papel FROM Filmes f 
INNER JOIN ElencoFilme ef ON f.Id = ef.IdFilme
INNER JOIN Atores a ON a.Id = ef.IdAtor
