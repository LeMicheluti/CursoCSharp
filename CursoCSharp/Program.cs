﻿using CursoCSharp.Api;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.Excecoes;
using CursoCSharp.Fundamentos;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.OO;
using CursoCSharp.TopicosAvancados;
using System;
using System.Collections.Generic;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentários.Executar},
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstanstes.Executar},
                {"Inferências - Fundamentos", Inferencia.Executar},
                {"Interpolção - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},

                //Estruturas de Controle
                {"Estrutura IF - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura IF/Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura IF/Else/If - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura ForEach - Estruturas de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},

                //Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Get Set - Classes e Métodos", GetSet.Executar},
                {"Props - Classes e Métodos", Props.Executar},
                {"Readonly - Classes e Métodos", Readonly.Executar},
                {"Enum - Classes e Métodos", ExemploEnum.Executar},
                {"Struct - Classes e Métodos", ExemploStruct.Executar},
                {"Struct Vs Classe - Classes e Métodos", StructVsClasse.Executar},
                {"Valor Vs Referência - Classes e Métodos", ValorVsReferencia.Executar},
                {"Parâmetros Por Referência - Classes e Métodos", ParametrosPorReferencia.Executar},
                {"Parâmetro com Valor Padrão - Classes e Métodos", ParametroPadrao.Executar},

                // Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"Array List - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},

                // OO
                {"Herança - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},
                
                
                // Métodos & Funções
                {"Exemplo Lambda - Métodos & Funções", ExemploLambda.Executar},
                {"Lambdas Como Delegates - Métodos & Funções", LambdasDelegate.Executar},
                {"Usando Delegates - Métodos & Funções", UsandoDelegate.Executar},
                {"Delegates Como Função Anônima - Métodos & Funções", DelegateFuncAnonima.Executar},
                {"Delegates Como Parâmetros - Métodos & Funções", DelegatesComoParametros.Executar},
                {"Métodos de Extensão - Métodos & Funções", MetodosDeExtensao.Executar},

                // Exceções
                {"Primeira Exceção - Exceções", PrimeiraExcecao.Executar},
                {"Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar},

                // Api
                {"Primeiro Arquivo - Usando Api", PrimeiroArquivo.Executar},
                {"Lendos Arquivos - Usando Api", LendoArquivos.Executar},
                {"Exemplo FileInfo - Usando Api", ExemploFileInfo.Executar},
                {"Diretórios - Usando Api", Diretorios.Executar},
                {"Exemplo DirectoryInfo - Usando Api", ExemploDirectoryInfo.Executar},
                {"Exemplo Path - Usando Api", ExemploPath.Executar},
                {"Exemplo DateTime - Usando Api", ExemploDateTime.Executar},
                {"Exemplo TimeSpan - Usando Api", ExemploTimeSpan.Executar},

                // Tópicos Avançados
                {"LINQ #01 - Tópicos Avançados", LINQ1.Executar},
                {"LINQ #02 - Tópicos Avançados", LINQ2.Executar},
                {"Nullables - Tópicos Avançados", Nullables.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}