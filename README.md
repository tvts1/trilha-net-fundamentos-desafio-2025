# trilha-net-fundamentos-desafio-2025
<hr>
🚗 Parking System - .NET Console App

Este projeto foi desenvolvido como parte do processo "Se aprofunde no desenvolvimento back-end com .NET", promovido pela Avanade.

O sistema simula a gestão de um estacionamento, permitindo cadastrar carros, validar placas e gerenciar veículos estacionados.

Além de reforçar conceitos fundamentais de C# e .NET, o projeto também reflete práticas importantes de arquitetura de software, boas práticas de programação e uma visão de como IA e nuvem podem ser integradas em soluções modernas e escaláveis.
<hr>
Objetivos do Projeto

Exercitar conceitos de Programação Orientada a Objetos (POO).

Aplicar separação de responsabilidades (entidades, serviços e camada de apresentação).

Utilizar validações com expressões regulares.

Criar um fluxo de interação simples com o usuário via Console Application.

Demonstrar boas práticas para desenvolvimento back-end com .NET.
<hr>
🛠 Tecnologias Utilizadas

C# 12 / .NET 8.0

Regex para validação de placas

Coleções (List<T>) para gerenciamento de dados em memória
<hr>
📚 Estrutura do Projeto

Models/Car.cs → Entidade Car, responsável pela validação da placa.

Parking.cs → Classe que gerencia a lista de carros estacionados.

Program.cs → Interface de console que interage com o usuário.

Fluxo de responsabilidades:

Usuário (Menu) → Parking (Gerencia carros) → Car (Valida e garante consistência)
<hr>
🚀 Como Executar

Clone o repositório:

git clone https://github.com/seu-usuario/parking-system.git
cd parking-system


Compile e execute o projeto:

dotnet run


Siga as instruções no console para cadastrar e gerenciar carros.
<hr>
💡 Exemplos de Uso

Adicionar um carro válido:
Digite a placa: ABC-1234
Carro adicionado.

Tentar adicionar um carro inválido:
Digite a placa: ABC1234
Erro: Placa inválida! Formato correto: ABC-1234.

<hr>
