# Tipo Valor & Referencia

**Links úteis:**
- [Stack Overflow [Site]](https://pt.stackoverflow.com/)
- [Reference Types [Docs]](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/reference-types)
- [C# Span [Docs]](https://docs.microsoft.com/en-us/dotnet/api/system.span-1?view=net-5.0)
- [C# Ref [Docs]](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref)
- [C# Type System[Docs]](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/#the-common-type-system)

O que são e como se comportam: 
- Value Type
- Reference Type

Boas práticas na criação de Classes, struct

Utilização e comparação:
- Ref
- Ref Struct

Funcionamento básico:
- Garbage Collector

## Desafio de Código:

Leia quatro valores inteiros **A, B, C e D**.<br />
A seguir, calcule e mostre a **diferença** do produto de **A e B** pelo produto de **C e D**.

<i>Fórmula:</i> **DIFERENCA = (A * B - C * D)**.

**Entrada**:
O arquivo de entrada contém 4 valores inteiros.

**Saída**:
Imprima a mensagem DIFERENCA com todas as letras maiúsculas, com um espaço em branco antes e depois da igualdade.

Entrada | Saida
:----: | :----:
5 6 7 8 | DIFERENCA = -26
0 0 7 8 | DIFERENCA = -56

<div align="center">
  
**Resolução**<br />
<img src="https://github.com/JefersonTaiyou/TipoValorReferencia/blob/main/img-desafio/Desafio1-GFT.PNG" alt="Desafio 1 GTF"></img>
</div>

-------------------------------

Leia 2 valores inteiros **(A e B)**. <br />
O programa deve mostrar uma mensagem **"Sao Multiplos"** ou **"Nao sao Multiplos"**, indicando se os valores lidos são múltiplos entre si.

**Entrada**:
A entrada contém **valores inteiros**.

**Saída**:
A saída deve conter uma das mensagens conforme descrito acima.

Entrada | Saida
:----: | :----:
6 24 | Sao Multiplos
6 25 | Nao sao Multiplos

<div align="center">
  
**Resolução**<br />
<img src="https://github.com/JefersonTaiyou/TipoValorReferencia/blob/main/img-desafio/Desafio2-GFT.PNG" alt="Desafio 2 GTF"></img>
</div>

-------------------------------

Leia o **código** de uma peça 1, o **número** de peças 1, o **valor unitário** de cada peça 1.<br />
Leia o **código** de uma peça 2, o **número** de peças 2 e o **valor unitário** de cada peça 2.<br />
Após, **calcule e mostre o valor** a ser pago.

**Entrada**:
O arquivo de entrada contém duas linhas de dados.<br />
Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.

**Saída**:
A saída deverá ser uma mensagem, lembrando de deixar um espaço após os dois pontos e um espaço após o "R$".<br />
O valor deverá ser apresentado com 2 casas após o ponto.<br />

**Exemplo**
Entrada | Saida
:----: | :----:
12 1 5.30   / 16 2 5.10 | VALOR A PAGAR: R$ 15.50
13 2 15.30  / 161 4 5.20 | VALOR A PAGAR: R$ 51.40

<div align="center">
  
**Resolução**<br />
<img src="https://github.com/JefersonTaiyou/TipoValorReferencia/blob/main/img-desafio/Desafio3-GFT.PNG" alt="Desafio 3 GTF"></img>
</div>

-------------------------------
