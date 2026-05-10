## Aluno : Lucas Alves Oliveira - RA: 326129404.
Curso : Ciência da Computação

# RachaAí - Blazor Dashboard

Projeto desenvolvido para a disciplina de Interação Humano Computador e UX no Centro Universitário UNA.

## Sobre o Projeto

Dashboard de finanças coletivas feito em C# com Blazor (.NET 10), baseado nos wireframes criados no Miro.

## Implementação Blazor

O wireframe do Miro foi dividido em três partes principais. O Grupo.cs é o modelo de dados que representa cada grupo de gastos. O GrupoCard.razor é o componente que exibe as informações de cada grupo na tela. O Dashboard.razor é a página principal que junta tudo.

A hierarquia visual do Miro foi aplicada usando o Grid do Bootstrap com row e col, deixando os cards de resumo no topo e a lista de grupos logo abaixo, igual ao que foi desenhado no wireframe.

As cores seguem a ideia de deixar claro para o usuário a situação financeira: verde quando ele tem crédito e vermelho quando ele deve.

## Dificuldade Técnica

O maior desafio foi entender como passar o objeto Grupo como parâmetro para o componente GrupoCard usando o [Parameter] e configurar os @using corretamente para que o modelo Grupo fosse reconhecido em todos os arquivos do projeto.

## Tecnologias

C# com .NET 10, Blazor Web App e Bootstrap 5.
