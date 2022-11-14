# Banco de Dados SQL Server

Um banco de dados é uma coleção organizada de informações (ou dados) estruturadas, normalmente armazenadas eletronicamente em um sistema de computador.

## Tipos de banco de dados

`Banco de Dados Relacional` => Tipo mais usado atualmente, armazenando dados estruturados, sendo organizados em tabelas, com colunas e linhas, que se relacionam entre si.
Exemplos:
- SQL Server
- Oracle DataBase
- MySql
- PostgreeSQL

`Banco de Dados Não Relacional` => Banco de dados onde os dados não são armazenados em tabela e sim armazenados de maneira não estruturadas ou semi-estruturadas. 
Exemplo:
- MongoDB

Existem vários tipos: document databases, key-value databases, wide-comumn stores e graph databases.

## DBMS

`Database Management System:` É um software utilizado para acessar, manipular e monitorar um sistema de banco de dados.

## A linguagem SQL

**SQL (Structured Query Language):** É a linguagem de banco de dados usada para consulta e manipulação de dados.

`Comandos a utilizar dentro do SQL`
- DDL - Data Definition Language (Create; Drop; Alter; Truncate)
- DCL - Data ol Language (Grant; Revoke)
- DML - Data Manipulation Language (Insert; Update; Delete)
- TCL - Transaction Control Language (Commit; Rollback; Save Point)
- DQL - Data Query Language (Select)

`Database: é uma coleção de *dados estruturados*, agrupados de forma concisa. É composto de tabelas, procedures, views, etc.

## Selecionando dados de uma tabela usando o `SELECT`

```sql
SELECT * FROM Clientes
```
**Ordenando a listagem de uma tabela**
```sql
SELECT * FROM Clientes
ORDER BY Nome
```
**Ordenando a listagem de uma tabela por ordem DECRESCENTE**
```sql
SELECT * FROM Clientes
ORDER BY Sobrenome DESC
```
**Ordenando a listagem de uma tabela por dois campos**
```sql
SELECT * FROM Clientes
ORDER BY Nome, Sobrenome
```
**Selecionando colunas específicas**
```sql
SELECT Nome, Sobrenome, Email FROM clientes
```
**Filtrando a consulta com a query `WHERE`**
```sql
SELECT * FROM Clientes
WHERE Nome = 'Adam'
ORDER BY Nome, Sobrenome
```
```sql
SELECT * FROM Clientes
WHERE AceitaComunicados = 1
ORDER BY Nome, Sobrenome
```
**Usando a query `AND`**
```sql
SELECT * FROM Clientes
WHERE Nome = 'Adam' AND Sobrenome = 'Reynolds'
ORDER BY Nome, Sobrenome
```
**Usando a query `OR`**
```sql 
SELECT * FROM Clientes
WHERE Nome = 'Adam' OR Sobrenome = 'Reynolds'
ORDER BY Nome, Sobrenome
```
**Usando a query `LIKE`**
```sql
SELECT * FROM Clientes
WHERE Nome LIKE 'G%'
ORDER BY Nome, Sobrenome
```
*Usando o `%` após a letra, estou filtrando todos os clientes que começam com a letra `G`*
```sql
SELECT * FROM Clientes
WHERE Nome LIKE '%g%'
ORDER BY Nome, Sobrenome
```
*Buscando todos os clientes que contém a letra `G` no nome*

## Inserindo valores na tabela
*Obs: Neste método abaixo, podemos escolher qual coluna passar primeiro*
```sql
INSERT INTO Clientes (Nome, Sobrenome, Email, AceitaComunicados, DataCadastro)
VALUES('Carlos', 'Botelho', 'carloshenrique.cont@gmail.com', 1, GETDATE())
```
*O método `GETDATE()` pega a data corrente do cadastro*

## Inserindo valores na ordem da tabela
```sql
INSERT INTO Clientes VALUES ('Henrique', 'Botelho', 'email@gmail.com', 1, GETDATE())
```
## Usando o `UPDATE`
```sql
UPDATE Clientes
SET Email = 'emailatualizado@email.com'
WHERE id = 'Henrique'
```
```sql
UPDATE Clientes
SET Email = 'emailatualizado@email.com',
    AceitaComunicados = 0
WHERE id = 1499
```
**EXTRAMAMENTE INPORTANTE FAZER O UPDATE COM O `WHERE`**
*OBS: Se não fizer o UPDATE com o WHERE, poderá alterar dados que não deseja e não terá como voltar a traz*

Para testar aterações, utiize o `BEGIN TRAN` e o `ROLLBACK`
```sql
--Execute o Begin tran primeiro para entrar em ambiente de teste
BEGIN TRAN 

-- Faça a alteração desejada
UPDATE Clientes
SET Email = 'emailatualizado@email.com',
	AceitaComunicados = 0,
	Sobrenome = 'Botelho'

-- Consulte a alteração
SELECT * FROM Clientes

-- Use o Rollback para voltar ao estado sem alteração
ROLLBACK
```

## Deletando dados da tabela usando o `DELETE`
```sql
DELETE Clientes
WHERE Id = 1004
```

## Tipos de dados

**Tipos mais comuns** - `String`
- Char(n) *String com caracteres fixos (5 carcteres e colocar 2 ele completa*
- varchar(n) *Sgrint com até 8 mil caracteres. (n) valor máximo*

**Outros tipos menos utilizados** - `String`
- varchar(max)
- text
- nchar
- nvarchar(max)
- binary(n)
- varbinary
- varbinary(max)
- image *Não recomendado guardar imagens no banco de dados*

**Tipos mais comuns** - `Numéricos`
- bit *tipo boleano*
- int
- decimal(p,s)

**Outros tipos menos utilizados** - `Numéricos`
- tinyint
- smallint
- bigint
- numeric(p,s)
- smallmoney
- money
- float(n)
- real

**Tipos de** `Time` e `Data Types`
- datetime
- datetime2 - *Recomendado*
- smaldatetime
- date
- time
- datetimeoffset
- timestamp

## Criando uma tabela
```sql
CREATE TABLE Produtos(
    -- O tipo IDENTITY vai se autoincrementar.
	Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Nome varchar(255) NOT NULL,
	Cor varchar(50) NULL,
	Preco decimal(13,2) NOT NULL,
	Tamanho varchar(5)NULL,
	Genero char(1)NULL
    -- Podemos especificar que um campo é NULL ou simplesmente omitir essa informação que dá no mesmo.
)
```
## Built-in Functions
`Built-in Functions` são funções pré-existentes que auxiliam na manipulação de dados, como por exemplo, contar, somar, média, etc.

## Contando linhas usando o `COUNT`
```sql
SELECT COUNT (*) FROM Produtos
```
## Contando valores específicos
```sql
SELECT COUNT (*) QuantidadeProdutos FROM Produtos
```

```sql
SELECT COUNT (*) QuantidadeProdutosTamanhoM FROM Produtos WHERE Tamanho = 'M'
```

## Somando valores com o `SUM`
```sql
SELECT SUM(Preco) PrecoTotal FROM Produtos
```
```sql
SELECT SUM(Preco) PrecoTotalProdutosTamanhoM FROM Produtos WHERE Tamanho = 'M'
```
## Selecionando maior valor com `MAX`
```sql
SELECT MAX (Preco) ProdutoMaisCaro FROM Produtos
```
```sql
SELECT MAX (Preco) ProdutoMaisCaroTamanhoM FROM Produtos WHERE Tamanho = 'M'
```

## Selecionando menor valor com `MIN`
```sql
SELECT MIN (Preco) ProdutoMaisBarato FROM Produtos
```
```sql
SELECT MIN (Preco) ProdutoMaisBaratoTamanhoM FROM Produtos WHERE Tamanho = 'M'
```

## Concatenando colunas com o `SELECT` e o `FROM`
*Obs: os tipos de dados devem ser os mesmos*
```sql
SELECT Nome + ', Cor: ' + Cor + ' - ' + Genero NomeProduto
FROM Produtos
```

## Usando tratamento de `UPPER` e o `LOWER`
```sql
SELECT Nome + ', Cor: ' + Cor + ' - ' + Genero NomeProdutoCompleto,
	   UPPER(Nome) Nome, 
	   LOWER(Cor) Cor
FROM Produtos
```

## Adicionando uma coluna na tabela usando o `ALTER TABLE`
```sql
ALTER TABLE Produtos
ADD DataCadastro DATETIME2
```
## Deletando uma coluna com o `DROP`
```sql
ALTER TABLE Produtos
DROP COLUMN DataCadastro
```
## Formatando a hora com o `FORMAT`
```sql
SELECT Nome + ', Cor: ' + Cor + ' - ' + Genero NomeProdutoCompleto,
	   UPPER(Nome) Nome, 
	   LOWER(Cor) Cor,
	   FORMAT(DataCadastro, 'dd-MM-yyyy' + ' HH:mm') Data
FROM Produtos
```

## Executando uma consulta retornando a quantidade de itens do critério
```sql
SELECT 
	Tamanho,
	COUNT(*) Quantidade
FROM Produtos
WHERE Tamanho <> ''
GROUP BY Tamanho
```

## Criando uma tabela, colocando chave primaria com `PRIMARY KEY` e chave secundária com `FOREIGN KEY`
```sql
CREATE TABLE Enderecos(
	Id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	IdCliente int NULL,
	Rua varchar(255) NULL, 
	Bairro varchar(255) NULL,
	Cidade varchar(255) NULL,
	Estado char(2) NULL,

	CONSTRAINT FK_Endereco_Clientes FOREIGN KEY (IdCliente)
	REFERENCES Clientes(id)

)
```
## Inserindo valores na tabela Endereços e consultando com chave primária e secundária
```sql
INSERT INTO Enderecos VALUES (4, 'Rua Teste', 'Bairro Teste', 'Cidade Teste', 'SP')

SELECT * FROM Clientes WHERE Id = 4
SELECT * FROM Enderecos WHERE IdCliente = 4
```

## Selecionando dados de várias tabelas usando o `INNER JOIN`
```sql
SELECT * FROM Clientes
INNER JOIN Enderecos ON Clientes.Id = Enderecos.IdCliente
WHERE Clientes.Id = 4
```
Refinando a Consulta 
```sql
SELECT 
	Clientes.Nome,
	Clientes.Sobrenome,
	Clientes.Email,
	Enderecos.Rua,
	Enderecos.Bairro,
	Enderecos.Cidade,
	Enderecos.Estado
FROM 
	Clientes
INNER JOIN Enderecos ON Clientes.Id = Enderecos.IdCliente
WHERE Clientes.Id = 4
```
## Criando um `Alias` das tabelas
```sql
SELECT 
	C.Nome,
	C.Sobrenome,
	C.Email,
	E.Rua,
	E.Bairro,
	E.Cidade,
	E.Estado
FROM 
	Clientes C
INNER JOIN Enderecos E ON C.Id = E.IdCliente
WHERE C.Id = 4
```
*Obs: Existem vários `JOIN`s, pesquisar mais*

<br>

# Constraints

`Constaints são regars que devem ser seguidas para permitir uma inserção em uma tabela. Exemplos:

- `NOT NULL` - Não permite valor nulo
- `UNIQUE` - Valor único em toda a tabela
- `CHECK` - Garante uma determinada condição
- `DEFAULT` - Valor padrão para inserção
- `PRIMARY KEY` - É uma combinação de `NOT NULL` e `UNIQUE`
- `FOREIGN KEY` - Garante que um   gistro exista em outra tabela
  
### Para obter detalhes de uma coluna da tabela, selecione o nome da coluna na consulta e aperte `ALT+F1`

## Adicionando uma constraint `UNIQUE`
```sql
ALTER TABLE Produtos
ADD UNIQUE (Nome)
```
## Adicionando uma constraint com `CHECK`
```sql
ALTER TABLE Produtos
ADD CONSTRAINT CHK_ColunaGenero CHECK (Genero = 'U' OR Genero = 'M' OR Genero = 'F')
```
## Adicionando uma constraint `DEFOULT`
```sql
ALTER TABLE Produtos
ADD DEFOULT GETDATE() FOR DataCadastro
```

# STORE PROCEDURES
`Store procedures` são códigos SQL que você pode **salvar** diretamente no banco da dados, permitindo assim aproveitar um script comumente usado.

## Criando uma `PROCEDURE`
```sql
CREATE PROCEDURE InserirNovoProduto
@Nome varchar(255), 
@Cor varchar(50),
@Preco decimal,
@Tamanho varchar(5),
@Genero char(1)

AS 

INSERT INTO Produtos(Nome, Cor, Preco, Tamanho, Genero)
VALUES (@Nome, @Cor, @Preco, @Tamanho, @Genero)
```
*Obs: Para consultar se criou realmente procure:* <br>
`Databases>ExemploDB>Programmability>Store Procedures>dbo.InserirNovoProduto`

## Chamando uma `PROCEDURE`
```sql
EXEC InserirNovoProduto 
'NOVO PRODUTO PROCEDURE',
'COLORIDO',
50,
'G',
'U'
```

**OU**

```sql
EXEC InserirNovoProduto 
@Nome = 'NOVO PRODUTO PROCEDURE',
@Cor = 'COLORIDO',
@Preco = 50,
@Tamanho = 'G',
@Genero = 'U'
```

## Criando e consultando produtos por tamanho com uma `PROCEDURE`
```sql
CREATE PROCEDURE ObterProdutosPorTamanho
@TamanhoProduto VARCHAR(5)

AS

SELECT * FROM Produtos WHERE Tamanho = @TamanhoProduto
```
```sql
EXEC ObterProdutosPorTamanho 'G'
```

## Criando `PROCEDURES` sem parâmetros
```sql
CREATE PROCEDURE ObterTodosOsProdutos
AS
SELECT * FROM Produtos
```
```sql
EXEC ObterTodosOsProdutos
```

# FUNCTIONS
`Functions` são códigos SQL que você pode salvar diretamente no banco de dados, semelhante a uma `PROCEDURE`, mas com usos específicos e limitações, como por exemplo, devem sempre ter um retorno e aceita apenas parâmetros de entrada.

## Criando uma `FUNCTION` para query com desconto
```sql
SELECT
	Nome, 
	Preco, 
	dbo.CalcularDesconto(Preco,50) PrecoComDesconto
FROM Produtos WHERE Tamanho = 'M'
```
`FUNCTION`
```sql
CREATE FUNCTION CalcularDesconto(@Preco DECIMAL(13,2), @Porcentagem INT)
-- o RETURNS neste caso é o tipo de retorno que esperamos
RETURNS DECIMAL(13,2) 

BEGIN
	-- Este RETURN é o que esperamos que retorna
	RETURN @Preco - @Preco / 100 * @Porcentagem
END
```
