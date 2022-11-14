# Anotações em C#

## Instanciando uma Classe
`Pessoa pessoa1 = new Pessoa();` 
- Dizendo ao sistema que a classe pessoa foi construída. Instanciamos a classe por dar um nome de uma variável para a classe.  

## Função
`public void Apresentar()` 
- Metodo ou função é uma ação que uma pessoa pode realizar. O () indica que é um Método e podemos dar um argumento para esse método também.  

`public void Apresentar(string @class)`
- o C# não permite o uso de palavras *reservadas*, porém com o uso do @ você diz a ele que entende que é uma palavra reservada, mas quer usar mesmo assim. Dessa forma o C# não confunde as palavras, porém não é recomendado fazê-lo.  


## Convenções do C#
 - Os Cases são padrões de escrita do código C#  
 - Temos os padrões: camelCase; PascalCase; snake_case e o spinal_case  
 - No C# os mais usados são o camelCase e o PascalCase  
 - Nome de classe, propriedade e método deve sempre ser a primeira letra de cada palavra em maiúsculo, ex: PessoaFisica  
 - Todo nome de variável vai ser a primeira palavra em minusculo e a segunda em diante em maiúsculo pessoaFisicaRepresentacao  
 - Evitar abreviações

## Nome da Classe

- Por convenção, é obrigatório que o nome do arquivo seja o mesmo que o nome da classe.

## Tipos de Dados

- int = Inteiro  
- double = duas casas decimais.. mas ignora o zero a direita, por exemplo 1.80 escreve 1.8  
- string = texto

## Variável 
- A variável tem um tipo de um nome e pode ser alterada quantas vezes quiser


## Escopo
Escopo é um pedaço de bloco que você vai realizar seus códigos.    
<br>
<br> 


# ALGUNS COMANDOS

- Sempre que for trabalhar com data usará do **`DateTime`** 
- `DateTime dataAtual = DateTime.Now;` - Retorna a data atual do computador
- `DateTime dataAtual = DateTime.Now.AddDays(5);` - Adiciona 5 dias a data atual do computador
- `Console.WriteLine(dataAtual.ToString("dd.MM.yyyy"))` - Converte a data para nosso padrão
- `int a = Convert.ToInt32("5");` ToInt32 é um método que converte string para inteiro e esta conversão é chamada de **Cast** ou **Casting**
- `int a = int.Parse("5");`-  o *int.Parse* faz a mesma função de **Cast** ou **Casting**
  > *o **_.Parse_** não aceita nulo, já o **_.ToInt32_** converte o nulo para zero*
-  Realizando a conversão de modo seguro
```csharp
string a = "15-";
//int b = 0;
int.TryParse(a, out int b);

Console.WriteLine(b);
Console.WriteLine("Conversão realizada com sucesso!"); 
``` 
## Fazendo a verificação de estoque com **if** ou **else**
```csharp
int quantidadeEmEstoque = 4;
int quantidadeCompra = 10;

if (quantidadeEmEstoque >= quantidadeCompra)
{
    Console.WriteLine("Venda realizada! ");
} else {
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
}
```
### Outra forma de fazer a verificação
```csharp
int quantidadeEmEstoque = 4;
int quantidadeCompra = 10;
bool possivelVenda - quantidadeEmEstoque >+ quantidadeCompra; //esta variável faz a verificação de estoque

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade Compra: {quantidadeCompra}");
Console.WriteLine($" É possível realizar a venda? {possivelVenda}");

if (possivelVenda)
{
    Console.WriteLine("Venda realizada! ");
} else {
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
}
```
- Usando **if** ou **else if**
- o operador **&&** é igual a *and*
- o operador **==** é comparativo de igualdade
```c#
int quantidadeEmEstoque = 3;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra >0 && quantidadeEmEstoque >+ quantidadeCompra; //esta variável faz a verificação de estoque

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade Compra: {quantidadeCompra}");
Console.WriteLine($" É possível realizar a venda? {possivelVenda}");

if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválidada!");
}
else if (possivelVenda) 
{
    Console.WriteLine("Venda realizada! ");
} 
else 
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
}
```
## Usando **ou** no C#
*Verificar por que esse código deu erro no else, postado no room do bootcamp*
O uso do ***ou*** no C# é descrito por um *pipe* duplo **||**
```c#
if (letra == "a"|| 
     letra == "e"|| 
     letra == "i"|| 
     letra == "o"|| 
     letra == "u");
 {
     Console.WriteLine("É uma vogal");
 }
 else //deu algum erro que preciso corrigir
 {
     Console.WriteLine("Não é vogal");
}
```
```c#
using ExemploFundamentos.Models; //usando a classe criada

bool maiorDeIdade = false;
bool autorizacao = true;

if (maiorDeIdade || autorizacao) // o if sempre avalia se o bool é true, se for false, vai para else
{
    Console.WriteLine("Entrada Liberada");
}
else 
{
    Console.WriteLine("Entrada não Liberada");
}
```

## Usando casos no C#
```c#
Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    default:
        Console.WriteLine("Não é uma vogal");
        break;

}
```
## Executando o operador condicional "e" ou "and" = **&&**

```c#
bool possuiPresencaMinima = true;
double media = 7.5;

if(possuiPresencaMinima && media >= 7)
{
    Console.WriteLine("Aprovado!");
}
else 
{
    Console.WriteLine("Reprovado!");
}
```

## Executando o operador condicional "OU" ou "OR" = **||**

```c#
bool possuiPresencaMinima = true;
double media = 7.5;

if(possuiPresencaMinima || media >= 7)
{
    Console.WriteLine("Aprovado!");
}
else 
{
    Console.WriteLine("Reprovado!");
}
```

## Uso de condição de Negação "NOT" representado por "!"

```c#
bool choveu = true;
bool estaTarde = true;

if(!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar");
}
else
{
    Console.WriteLine("Vou pedalar outro dia");
}
```

- Método é um pedaço de Código que vai fazer alguma ação
- Quando o *WriteLine* é aberto com o sinal de dollár "$" e é declarado uma variável dentro de chaves "{}", então se pega o valor da varivável no tipo texto, ex:
```c#
Console.WriteLine($"{x} + {y} = {x + y}");
```

## Criando uma classe Calculadora
```c#
 public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        
```

- A classe Math acima tem várias operações matemáticas já criadas.

## Calculando a Potência `Math.Pow`
```c#
public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }
```
## Calculando o `Math.Sin`
```c#
public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}º = {Math.Round (seno,4)}");
        }
```
## Calculando o Cosseno `Math.Cos`
```c#
public void Cosseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double cosseno = Math.Cos(radiano);
            Console.WriteLine($"Cosseno de {angulo}º = {Math.Round(cosseno, 4)}");
        }
```
## Calculando a Tangênte `Math.Tan`
```c#
 public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}º = {Math.Round(tangente,4)}");
        }
```
*O argumento `{Math.Round(variavel,4)}` limita o resultado a apenas 4 dígitos em vez de várias casas decimais*

## Calculando a Raiz Quadrada `Math.Sqrt`
```c#
 public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x); //squareroot = raiz quadrada
            Console.WriteLine($"A Raiz quadrada de {x} = {Math.Round(raiz, 2)}");
        }
```

## Utilizando o laço de repetição **for**
```c#
int numero = 5;

for(int contador = 0; contador <= 5; contador++)
    { 
        Console.WriteLine($"{numero} x {contador} = {numero * contador}");
        
    }
```
## Utilizando o laço de repetição **while** *enquanto*
*Cuidado para não entrar num loop infinito*
```c#
int numero = 5;
int contador = 0;


while(contador <= 10) //enquanto
{
    Console.WriteLine($"{contador + 1}º Execução: {numero} x {contador} = {numero * contador}");
    contador++;
    
} 
```

## Utilizando o laço de repetição **do while**
```c#
int soma = 0, numero = 0;


do //do executa o código independente da condição
{
    Console.WriteLine("Digite um número (0 para parar)");
    numero = Convert.ToInt32(Console.ReadLine());
    soma += numero; // o "+=" é o mesmo que fazer (soma = soma + número)

} while(numero != 0);

Console.WriteLine($"Total da soma dos número digitados é: {soma}");
```
## Para debugar o `Console.ReadLine()`, tem que alterar o lauch.json (.vscode->lauch.json) o ítem `"console": "internalConsole",`para `"console": "integratedTerminal",`
```c#
"console": "integratedTerminal",
```

## Fazendo um menu interativo com **while** e **switch case**
```c#
string opcao;

while(true)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de Cliente");
            break;
        case "2":
            Console.WriteLine("Buscar Cliente");
            break;
        case "3":
            Console.WriteLine("Apagar Cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            Environment.Exit(0); //sair do programa
            break;

        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
}
```

## Refatorando o menu

```c#
string opcao;
bool exibirMenu = true;

while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de Cliente");
            break;
        case "2":
            Console.WriteLine("Buscar Cliente");
            break;
        case "3":
            Console.WriteLine("Apagar Cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            //Environment.Exit(0); //sair do programa
            exibirMenu = false; //passa o valor falso para a variável condicional do while
            break;

        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
}
Console.WriteLine("O Programa se encerrou");
```

### `vscode-solution-explorer` para instalar uma solução para projetos

## Percorrendo o Array com o `FOR`
```c#
 int[] arrayInteiros = new int [4];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;

for(int contador = 0; contador < arrayInteiros.Length; contador++)
{
     Console.WriteLine($"Posição número {contador} - {arrayInteiros[contador]}");
}
```
## Percorrendo o Array com `FOREACH`
```c#
Console.WriteLine("Percorrendo o Array com o FOREACH");

int contadorForeach = 0;
foreach(int valor in arrayInteiros) //foreach significa "para cada"
{
    Console.WriteLine($"Posição nº {contadorForeach} - {valor}");
    contadorForeach++;
}
```

## Dobrando a capacidade do Array com `Array.Resize()`
`Array.Resize(ref arrayInteiros, arrayInteiros.Length *2);`
```c#
 int[] arrayInteiros = new int [4];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;


Array.Resize(ref arrayInteiros, arrayInteiros.Length *2);


Console.WriteLine("Percorrendo o array com o FOR");

for(int contador = 0; contador < arrayInteiros.Length; contador++)
{
     Console.WriteLine($"Posição número {contador} - {arrayInteiros[contador]}");
}
```
## Para fazer um comentário, usa-se o seguinte:

```c#
// para um comentário simples de uma linha
/* Para comentários de
   várias linhas*/
/// Para comentários com <sumary>
///
///</sumary>
```
<br> 
<br>

# MODULO II

## Propriedades de classes
- As propriedades possuem ods métodos `get` e `set`
  
```c# 
public string Nome { get; set; }
``` 
<br>
- Quando se faz um `get` você recebe um valor, quando faz o `set` você atribui um valor a propriedade.

## Encapsulamento
<br>

**Encapsulamento** é você proteger seus campos (atributos) de modificação externa a não ser que ela passe por validacão de propriedades ou de métodos

## Validando se o nome é diferente de zero
```c#
public string Nome 
        { 
            get
            {
                return _nome.ToUpper(); //retornar o nome em maiúsculo
            }


            set
            {
                if (value == "") //value é o argumento que está recebendo o nome
                {
                    /*
                        Excessão que nosso código gerou
                        Excessão para seu código e esperar que alguém trate essa excessão
                    */
                    throw new ArgumentException("O nome não pode ser vazio");                                      
                }

                 _nome = value;
            }
        } //isso é uma propriedade
```
## Simplificando o retorno do `get` - Conhecido como Body Expressions

```c#
private string _nome; 

        public string Nome 
        { 
            //Body Expressions
            get => _nome.ToUpper(); //retornar o nome em maiúsculo
            
            set
            {
                if (value == "") //value é o argumento que está recebendo o nome
                {
                    /*
                        Excessão que nosso código gerou
                        Excessão para seu código e esperar que alguém trate essa excessão
                    */
                    throw new ArgumentException("O nome não pode ser vazio");                                      
                }

                 _nome = value;
            }
        } //isso é uma propriedade
```
## Métodos
Métodos é um bloco de código que contém uma série de instruções

## Criando uma classe Curso e adicionano aluno na Classe Pessoa
```c#
public class Curso
    {
        public string Nome { get; set; }

        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno (Pessoa aluno) //void não retorna, significa "vazio"
        {
            Alunos.Add(aluno);
        }
    }
```

## O que são Construtores?
- Instanciar um classe e colocar valores padrões no momento da instanciação.
- O Construtor deve estar bem abaixo do nome da `Classe`, ou seja, o primeiro código.
- O Constutor tem que ter o mesmo nome da `Classe`
- O Contrutor não tem nenhum tipo de `return`

```c#
 public class Pessoa
    {
        //Isto é um constutor
        public Pessoa() 
        {
            
        }
```
## Solicitando atribuições na hora de instanciar a `Classe`
```c#
public Pessoa(string nome, string sobrenome)
        {

        }
```
**Exemplo de código com valores já atribuídos na instanciação**
```c#
//Substitui 6 linhas de código por apenas 2
Pessoa p1 = new Pessoa(Console.ReadLine(), Console.ReadLine());
// p1.Nome = "Carlos";
// p1.Sobrenome = "Botelho";

Pessoa p2 = new Pessoa("Carlos Henrique", "Botelho");
// p2.Nome = "Carlos Henrique";
// p2.Sobrenome = "Botelho";
```

## Concatenação e Interpolação de Strings
<hr>

### Concatenação de `String`

```c#
string texto = "Nº " + count + " - " + Alunos[count].NomeCompleto; 
```

### Interpolação de `String`
```c#
string texto = $"Nº {count} - {Alunos[count].NomeCompleto}"; 
```

## Formatando moeda em Real
**C** significa *Currence* (Moeda)
```c#
decimal valorMonetario = 82.40M;
//Quando coloco na interpolação de String o ":", significa que quero formatar essa String
Console.WriteLine($"{valorMonetario:C}");
```
## Alterando a localização do Sistema
```c#
using System.Globalization; //importando biblioteca de globalização

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
```

## Alterando a formatação de Cultura com o Sistema travado
```c#
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
```
## Imprimindo em porcentagem
```c#
double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P"));
```

## Formando números
```c#
long numero = 17981061979;
Console.WriteLine(numero.ToString("(##) #####-####"));
```

## Formatanto `DateTipe`
```c#
DateTime data = DateTime.Now;
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm:ss"));
```
Data Curta `data.ToShortDateString()`
```c#
Console.WriteLine(data.ToShortDateString());
```
Exibindo somente a hora `data.ToShortTimeString()`
```c#
Console.WriteLine(data.ToShortTimeString());
```
Convertendo String para Data `DateTime.Parse("26/09/2022 16:00")`
```c#
DateTime data = DateTime.Parse("26/09/2022 16:00");
Console.WriteLine(data);
```

## Convertendo uma `string` em data com o método `TryParseExact`
```c#
//O método abaixo vai tentar converter uma data que pode não ser válida para uma data válida
DateTime.TryParseExact(dataString, //recebe a data
                       "yyyy-MM-dd HH:mm", //recebe o formado
                       CultureInfo.InvariantCulture, //Não depende de uma cultura específica (localização)
                       DateTimeStyles.None, //sem estilo de data (Localização)
                       out DateTime data); //retorna a data

Console.WriteLine(data);
```
<br>

# Excessões

## Uso do `try` e do `catch`

`try` - Significa `tente`. Tente executar esse código, porém com cautela
`catch` - Significa `pegar/obter`. Obtem o valor do erro do código e atribui a variável `ex`

```c#
try //Significa TENTE
{
    //Cada linha do arquivo vai ser um array
    string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

    //Usando o foreach para ler cada linha e escrever
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }

} catch(Exception ex) //PEGAR/OBTER - Pega o valor da excessão e atribuir a variável EX
{
    Console.WriteLine($"Ocorreu uma excessão genérica.{ex.Message}");
}
```
## Tratamentos `try` e `catch` específico
*Obs: Os tratamento de exceção `try` e `catch` somente devem ser usado para acesso externo do programa, pois podem afetar a legibilidade do código e também a performace do software*

```c#
try //Significa TENTE
{
    //Cada linha do arquivo vai ser um array
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    //Usando o foreach para ler cada linha e escrever
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }

} 
catch(FileNotFoundException ex) //PEGAR/OBTER - Pega o valor da excessão e atribui a variável EX
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado.{ex.Message}");
}

catch(DirectoryNotFoundException ex) //PEGAR/OBTER - Pega o valor da excessão e atribui a variável EX
{
    Console.WriteLine($"Caminho da pasta não encontrado.{ex.Message}");
}

catch(Exception ex) //PEGAR/OBTER - Pega o valor da excessão e atribui a variável EX
{
    Console.WriteLine($"Ocorreu uma excessão genérica.{ex.Message}");
}
```
## Usando o bloco `finally` independente de erro ou sucesso
```c#
try //Significa TENTE
{
    //Cada linha do arquivo vai ser um array
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    //Usando o foreach para ler cada linha e escrever
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }

} 
catch(FileNotFoundException ex) //PEGAR/OBTER - Pega o valor da excessão e atribui a variável EX
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado.{ex.Message}");
}

catch(DirectoryNotFoundException ex) //PEGAR/OBTER - Pega o valor da excessão e atribui a variável EX
{
    Console.WriteLine($"Caminho da pasta não encontrado.{ex.Message}");
}

catch(Exception ex) //PEGAR/OBTER - Pega o valor da excessão e atribui a variável EX
{
    Console.WriteLine($"Ocorreu uma excessão genérica.{ex.Message}");
} 

//O finally serve para executar um bloco de código sempre que chegar no final da execução, independente de ter acontecido uma exceção ou não
finally
{
    Console.WriteLine("Chegou até aqui");
}
```
## O tratamento `throw`
O `throw` joga para o metodo acima procurando o bloco `catch`
```c#
throw new Exception("Ocorreu uma excessão.");
```

## Criando e listando fila com `Queue`
`FIFO - First In, First Out`
```c#
Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}"); //sempre vai remover o primeiro elemento
fila.Enqueue(10);

foreach (int item in fila)
{
    Console.WriteLine(item);
}


Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}"); //sempre vai remover o primeiro elemento

foreach (int item in fila)
{
    Console.WriteLine(item);
}
```
## Criando e listando pilhas com `Stack`
`LAST IN, FIRST OUT`
```c#
Stack<int> pilha = new Stack<int>();

// LIFO - LAST IN, FIRST OUT
// O método Push insere elementos no topo da pilha
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

try
{


    foreach (int item in pilha)
    {
        Console.WriteLine(item);
    }

    // O método .Pop remove elementos do topo da pilha
    Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

    pilha.Push(20);

    foreach (int item in pilha)
    {
        Console.WriteLine(item);
    }
}catch(IOException ex)
{
    Console.WriteLine($"Ocorreu um erro específico: {ex.Message}");
}
```
## Usando o a Classe `Dictionary`
*A chave não pode ser duplicada.*
```c#
// Garante que o primeiro elemento(chave), seja único
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("MG", "Minas Gerais");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("SC", "Santa Catarina");
estados.Add("BA", "Bahia");

//foreach(KeyValuePair<string, string> item in estados)
foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
```
## Removendo e alterando VALORES (Chaves não podem ser alteradas) do `Dictionary`
```c#
// Removendo chaves e valores
estados.Remove("BA");

// Alterando os valores (NÃO É POSSÍVEL ALTERAR A CHAVE)
estados["SP"] = "São Paulo - Valor Alterado";
```
## Verificando se existem valores cadastrados no `Dictionary`
```c#
string chave = "MG";
Console.WriteLine("Verificando o elemento: ");

if(estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor Existente: {chave}");
}
else
{
    Console.WriteLine($"Valor não existe. É seguro adicionar a chave {chave}");
}
```
## Obtendo VALORES do `Dictionary`
```c#
// Obtendo Valores do Dictionary
Console.WriteLine(estados["SP"]);
```
<br>

# Tuplas
## Tuplas fornece sintaxe concisa para agrupar vários elementos de dados em uma estrutura de dados leve.
Uma tupla não é uma coleção, mas pode ter dentro de si uma coleção e ser de diferentes tipos. Com uma tupla eu consigo retornar diversos valores de diferentes tipos em uma mesma variável, muito útil quando quiser representar um dado que pode ter variação de diferentes tipos de retorno.

## Declarando a variável `Tupla`
```c#
(int, string, string, decimal) tupla = (1, "Carlos Henrique", "Botelho", 1.79M);

// Quando declara a tupla, cada dado vai ser um item desta tupla
Console.WriteLine($"ID: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"Altura: {tupla.Item4}");
```
## Mais dois exemplos de como criar uma `Tupla`
*Note que nestes exemplos, não é possível criar o nome do item da tupla, ficando somente `Item1`, `Item2`...*
```c#
// Outro exemplo de como criar uma Tupla
ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Carlos Henrique", "Botelho", 1.79M);
Console.WriteLine(outroExemploTupla.Item1);
Console.WriteLine(outroExemploTupla.Item2);
Console.WriteLine(outroExemploTupla.Item3);
Console.WriteLine(outroExemploTupla.Item4);

// Mais um exemplo de como criar uma Tupla
var outroExemploTuplaCreate = Tuple.Create(1, "Carlos Henrique", "Botelho", 1.79M);
Console.WriteLine(outroExemploTuplaCreate.Item1);
Console.WriteLine(outroExemploTuplaCreate.Item2);
Console.WriteLine(outroExemploTuplaCreate.Item3);
Console.WriteLine(outroExemploTuplaCreate.Item4);
```
## Criando uma `Tupla` em uma classe
```c#
 public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
        {
            try
            {
                // O método ReadAllLines, lê as linhas de um arquivo e armazena em um array
                string[] linhas = File.ReadAllLines(caminho); 
                // Retornando o sucesso em uma Tupla
                return (true, linhas, linhas.Count());
            }
            catch(Exception)
            {
                // Caso não dê sucesso, retorna também em uma Tupla
                return (false, new string[0], 0);
            }

        }
```
## Instanciando uma `Tupla` declarada em uma classe
```c#
LeituraArquivo arquivo = new LeituraArquivo();

// Criando a variável Tupla
var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if(sucesso)
{
    Console.WriteLine("Quantidade linhas do arquivo: " + quantidadeLinhas);
    foreach(string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}
```
## Descartando uma informação em uma `Tupla` com o `_`
```c#
var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
```
## Usando o Método `Descontruct`

**Na Classe**
```c#
public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }
```
**Na Instância**
```c#
Pessoa p1 = new Pessoa("Carlos", "Botelho");

(string nome, string sobrenome) = p1;

Console.WriteLine($"{nome} {sobrenome}");
```

## Descobrindo se um número é par usando o `if` e `else`
```c#
int numero = 20;

if(numero % 2 == 0)
{
    Console.WriteLine($"O número {numero} é par");
}
else
{
    Console.WriteLine($"O númeor {numero} é ímpar");
}
```
## Usando o `if ternario`
```c#
// If Ternário
ehPar = numero % 2 == 0;
// O IF Ternário funciona quando temos DUAS OPÇÕES.
/* 
    (ehPar ? "par" : "ímpar") - Retorna duas strings, se verdadeiro ou falso
    o parenteses é somente por conta da concatenação da string
*/
Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));
```

## Pacotes
- Um pacote é um conjuto de códigos úteis, que possibilita o compartilhamento e o reuso do código.
- Um dos fundamentos da orientação a objetos é fazer o reuso do código, não repetir o código.
- Um pacote é um pequeno projeto no C# que pode ser utilizados em outros sistemas
- o `Nuget` é um **gerenciador de pacotes**, que permite desenvolvedores compartilharem códigos e bibliotecas
- Quando cria um pacote, deve subir ele para o `Nuget`

## Serialização e Desserialização 
- O processo de serializar consiste em transformar objetos em um fluxo de bytes para seu armazenamento ou transmissão.
- A serialização é o processo de converter um objeto em um fluxo de bytes para armazenar o objeto ou transmiti-lo para a memória, um banco de dados ou um arquivo. Sua finalidade principal é salvar o estado de um objeto para recriá-lo quando necessário. O processo inverso é chamado desserialização.
- `Json` - JavaScript Notation Object. É um formato que segue a sintaxe do JavaScript

```c#
using ExemploExplorando.Models;
using System.Globalization;
using Models;
using Newtonsoft.Json;

DateTime dataAtual = DateTime.Now;

// Criando uma lista de vendas
List<Venda> listaVendas = new List<Venda>();
// Passando parâmetros pelo constructor
Venda v1 = new Venda(1, "Material de Escritório", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);
// Adicionando vendas na lista
listaVendas.Add(v1);
listaVendas.Add(v2);

// Usando o Json para serializar o objeto
string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
// Escrevendo o arquivo.json da serialização
File.WriteAllText("Arquivos/vendas.json", serializado);
Console.WriteLine(serializado);
```
## Deserialização do `Json`
```c#
using System.Globalization;
using Models;
using Newtonsoft.Json;

// Criando uma string para ler o arquivo Json
string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// Criando uma lista para receber a lista que está no arquivo Json
List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// Listando todos os arquivos da lista
foreach(Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}" +
                      $" Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}"); // Convertendo a data
}
```

## Ajustando os atributos do `Json` para a convenção do C#
- Arquivo `Json`
```json
[
  {
    "Id": 1,
    "Nome_Produto": "Material de Escritório",
    "Preco": 25.00,
    "DataVenda": "2022-10-04T17:48:00.4394191-03:00"
  },
  {
    "Id": 2,
    "Nome_Produto": "Licença de Software",
    "Preco": 110.00,
    "DataVenda": "2022-10-04T17:48:00.4394191-03:00"
  }
]
```
- Ajuste (Dentro da Classe)
```c#
[JsonProperty("Nome_Produto")]
public string Produto { get; set; }
```
## Valores nulos em propriedades
```c#
// o "?" significa que alem de aceitar os valores padrões (true or false), vai acertar o nulo.
bool? desejaReceberEmail = null;

// o If pega a variável e verifica se tem valor diferente de nulo e o valor é verdadeiro
if(desejaReceberEmail.HasValue && desejaReceberEmail.Value)
{
    Console.WriteLine("O usuário optou por receber e-mail");
}
else
{
    Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail");
}
```
Um valor `null` pode ser usado por exemplo em um desconto, visto que alguns produtos tem desconto e outros não.

## Tipos anônimos
Os tipos anônimos fornecem um modo conveniente de encapsular propriedades somente de leitura
É semelhante a `tupla` onde pode representar vários tipos de valores e não precisa declarar o tipo, porém é um método somente `get` (leitura)
```c#
var tipoAnonimo = new { Nome = "Carlos", Sobrenome = "Botelho", Altura = 1.80 };

Console.WriteLine("Nome: " + tipoAnonimo.Nome);
Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
Console.WriteLine("Altura: " + tipoAnonimo.Altura);
```
## Usando o tipo anonimo para selecionar produtos específicos do `json`

Muito usado para criar listas e buscar dados do BD onde não quer buscar todos os dados

```c#
// Criando uma string para ler o arquivo Json
string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// Criando uma lista para receber a lista que está no arquivo Json
List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// Usando o tipo anonimo para criar uma lista e selecionar atributos específicos do json
// o Select serve para selecinar um novo tipo de dado. 
// O x representa um elemento da lista
// o new é do tipo anonimo, onde obtem o produto e o preço
var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

foreach(var venda in listaAnonimo)
{
    Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
}
```
## Variável `Dynimic` permite alterar o tipo da variável em tempo de excução
```c#

// Variável Dinamica que permite que eu altere o valor de acordo com a necessidade
dynamic variavelDinamica = "Carlos";

// o Método GetType pega o tipo da variável declarada
Console.WriteLine($"Tipo da variável {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

variavelDinamica = 1234;
Console.WriteLine($"Tipo da variável {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

variavelDinamica = true;
Console.WriteLine($"Tipo da variável {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

variavelDinamica = 15.5M;
Console.WriteLine($"Tipo da variável {variavelDinamica.GetType()}, Valor: {variavelDinamica}");
```
## Criando uma classe genérica com um `array`
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    // Letra T no array representa TIPO
    public class MeuArray<T>
    {
        private static int capacidade = 10;
        private int contador = 0;
        private T[] array = new T[capacidade];

        public void AdicionarElementoArray(T elemento)
        {
            if(contador + 1 < 11)
            {
                array[contador] = elemento;
            }
            contador++;
        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
        
    }
}
```
## Instanciando a classe genérica com `array`
```c#
// Classe genérica com tipo inteiro
MeuArray<int> arrayInteiro = new MeuArray<int>();
arrayInteiro.AdicionarElementoArray(30);
Console.WriteLine(arrayInteiro[0]);

// Classe genérica com tipo string
MeuArray<string> arrayString = new MeuArray<string>();
arrayString.AdicionarElementoArray("Carlos");
Console.WriteLine(arrayString[0]);

```
Se tem os sinais `<>` então é uma classe genérica onde terá que passar o tipo de dado

## Métodos de extensão
Os métodos de extensão permitem que você "Adicione" tipos existentes sem criar um novo tipo derivado, recompilar ou, caso contrário, modificar o original.

Criando uma extensão para calcular se o número é par ou ímpar
*Classe*
```c#
public static class IntExtensions
    {
         // Quando coloco o this int significa que estou usando o próprio valor onde estou chamando
        public static bool EhPar(this int numero)
        {
            return numero % 2 == 0;
        }
    }
```
*Chamando o método*
```c#
int numero = 15;
bool par = false;

// If ternário
par = numero.EhPar();

string mensagem = $"O número {numero} é {(par ? "par" : "ímpar")}";
Console.WriteLine(mensagem);
```
<br>
<br>
<br>
<hr>

# O que é POO?

## Classo vs Objeto

***Classe*** é uma representação de algo no mundo real e ***Objeto*** é uma implementação dessa classe.

## Tipos de paradigmas da programação

Um *paradigma* é um modelo de técnicas, estruturas e formas de solucionar um problema
<br>

Uma *linguagem de programação* implementa um ou mais **paradigmas**

**Temos vários paradigmas de programação**
- Programação orientada a objetos (POO)
- Programação estruturada
- Programação imperativa
- Programação procedural
- Programação orientada a eventos
- Programação lógica
- ... e várias outras

## Pilares da Programação Orientada a Objetos
<br>

### Abstração

É o conceito de abstrair um objeto do mundo real para um *contexto específico*, considerando apenas os *atributos importantes*.

### Encapsulamento

O **encapsulamento** serve para proteger uma classe e definir limites para alterações em suas propriedades. Serve para ocultar seu comportamento e expor somente o necesário.

## Herança

A herança nos permite reutilizar atributos, métodos e comportamenteos de uma classe em outras classes. Serve para agrupar objetos que são do mesmo tipo, porém com características diferentes.

## Polimorfismo

Significa "Muitas Formas". Com o polimorfismo podemos *sobrescrever métodos* das classes filhas para que se *comporte de maneira diferente* e ter sua própria implementação.

**Para poder usar o `polimorfismo` em um método, é necessário usar o `virtual` na classe PAI**
```csharp
public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
        }    
```
**Polimorfismo na classe Aluno**
```csharp
public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}. Tenho {Idade} anos e sou um aluno nota {Nota}");
        }
```
**Polimorfismo na classe Professor**
```csharp
public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e sou professor. Tenho {Idade} anos, e tenho o salário de R$ {Salario}");
        }
```
*Nota: Observe que ambos são o método* `Apresentar()`*, porém, com funções diferentes*

### Polimorfismo 
- Em tempo de Complicação (Overload/Early Biding)
Métodos com nomes iguais e tipos de retornos iguais, porém com número de parametros diferentes.

- Em tempo de execução (Override/Late Binding)
Esse depende de herança para realiza-lo (exemplo acima)

## Classes Abstratas e de Interfaces

### Classe Abstrata

Uma classe abstrata tem como objetivo ser exclusivamente um modelo para ser herdado, portanto não pode ser instanciada. Pode implementar métodos ou deixá-los a cargo de quem herdar.

**Criando uma classe abstrata**
```csharp
public abstract class Conta
    {
        // protected é protegido contra alterações externas
        protected decimal saldo;

        // Método sem implementação { }
        public abstract void Creditar(decimal valor);
        
        public void ExibirSaldo()
        {
            Console.WriteLine("O seu saldo é: " + saldo);
        }   
    }
```
**Herdando a classe abstrada e implementando o método abstrato**
```csharp
public class Corrente : Conta
    {
        // Implementando o método Creditar
        public override void Creditar(decimal valor)
        {
            saldo += valor;
        }
    }
```
*Obs: O `protected` é protegido contra alterações externas, porém as **classes filhas conseguem alterar**. O `private` também é protegido contra alterações externas, porém **somente a classe mãe** pode fazer alterações.*

## Construtor por herança

**Criando um construtor na classe `mãe`**
```csharp
public Pessoa(string nome)
        {
            Nome = nome;
        }
```
**Criando um `Construtor por Herança` nas classes filhas**
```csharp
 public Aluno(string nome) : base(nome)
        {
            
        }
```
```csharp
public Professor(string nome) : base(nome)
        {
            
        }
```
*Se a classe `Aluno` e a classe `Professor` são filhos da classe `Pessoa` e a classe exige nome, as classes filhas também devem exigir nome*

Para não se precisar exigir o nome, é necessário passar um construtor vazio em todas as classes.
```csharp
// Classe mãe
public Pessoa()
        {
            
        }
```
```csharp
// Classe filha
public Aluno()
        {
            
        }
```
```csharp
// Classe filha
 public Professor()
        {
            
        }
```
## Classe selada
Tem como objetivo impedir que outras classes façam uma herança dela, ou seja, nenhuma classe pode ser sua derivada.
Quando colocamos a palavra `sealed`, impedimos que outras classes herdam dela
```csharp
public sealed class Professor : Pessoa
    {

    }
```
**Selando um método da classe `Professor`**
```csharp
 public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e sou professor. Tenho {Idade} anos, e tenho o salário de R$ {Salario}");
        }
```

## Classe Object
A classe `System.Object` é a mãe de todas as classes na hierarquia do .NET

Todas as classes derivam, direta ou indiretamente da classe `Object`, e ela tem como objetivo prover serviços de baixo nível para suas classes filhas

## Interfaces

Uma interface é um contrato que pode ser implementado por uma classe.
É como se fosse uma classe abstrata, podendo definir métodos abstratos para serem implementados.
Assim como uma classe abstrata, uma interface não pode ser instanciada
<br>
<br>
<hr>

# INTRODUÇÃO A APIs

## O QUE É UMA API?
Uma API (Application Programming Interface) é uma forma de comunicação entre computadores ou programas de computadores. Em outras palavras, é um software que fornece informações para outro software.

Para executar uma 'API' pelo terminal, digite:
```csharp
dotnet watch run
```
## Controller

Uma `Controller` nada mais é do que uma classe que vai agrupar suas requisições HTTP e disponibilizar seus `endpoints`

*Criando uma* `Controller`
```csharp
namespace ModuloAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    //Herdando da classe ControllerBase
    public class UsuarioController : ControllerBase
    {
        // O HttpGet não precisa ter o mesmo nome que o método
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            return Ok(obj);
        }
    }
}
```

# Entity Framework e CRUD

O EF é um framework ORM (Object-Relational Mapping) criado para facilitar a integração com o banco de dados, mapeando tabelas e gerando comandos SQL de forma automática

## CRUD

- `C` - Create (*insert*)
- `R` - Read (*select*)
- `U` - Update (*update*)
- `D` - Delete (*delete*)

## Instalando a ferramenta do Entity Framework

*Necessário instalar apenas uma vez na máquina*
```csharp
dotnet tool install --global dotnet-ef
```

*Necessário instalar em todo projeto*

## Instalando o pacote do Entity Framework
```csharp
dotnet add package Microsoft.EntityFrameworkCore.Design
```

## Instalando o pacote do SqlServer
```csharp
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

## Criando a conexão com o banco de dados
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ModuloAPI.Context
{
    // Herdando da classe DbContext
    public class AgendaContext : DbContext
    {
        // Criando a conexão com o banco de dados e passando para a classe herdada
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }
    }
}
```

## Modificando `ConectionStrings` no `appsettings.Development.json`
```json
/* ARQUIVOS JSON NÃO PERMITEM ANOTAÇÕES
    Estas anotações não funcionam em ambiente de execução
*/
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  // Criando a conexão
  "ConnectionStrings": {
        // Serve=localhost\\sqlexpress - Instanciando o Servidor do Banco de Dados
        // Initial Catalog=Agenda - Banco de Dados que vai trabalhar, se não houver, ele cria
        // Integrated Security=true - Usando autenticação do windows para logar, mas se tiver usuário e senha, setar aqui
        "ConexaoPadrao": "Serve=localhost\\sqlexpress;Initial Catalog=Agenda;Integrated Security=true"
  }
}
```

## Configurando o `Program.cs`

```csharp
using ModuloAPI.Context;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
/*
    CONFIGURANDO A CONEXÃO COM O BANCO DE DADOS

    Estamos adicionando um DbContext do tipo AgendaContext e passando algumas opções:
    AgendaContext usa o Sql Server. 
    builder.configuration - Pegando a configuração do `appsettings.json`
    GetConnectionString - Pega a chave da conexão string e o nome da conexão (ConexãoPadrão)
*/
builder.Services.AddDbContext<AgendaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
```
## Chamando a ferramenta Entity Frameworks e atualizando o Banco de Dados
```
dotnet-ef migrations add CriacaoTabelaContato
```