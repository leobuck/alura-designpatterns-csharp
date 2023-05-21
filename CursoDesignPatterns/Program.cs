﻿using CursoDesignPatterns;

Imposto iss = new ISS();
Imposto icms = new ICMS();
Imposto iccc = new ICCC();

Orcamento orcamento = new Orcamento(500);

CalculadorDeImpostos calculador = new CalculadorDeImpostos();

calculador.RealizaCalculo(orcamento, icms);
calculador.RealizaCalculo(orcamento, iss);
calculador.RealizaCalculo(orcamento, iccc);

Investimento conservador = new Conservador();
Investimento moderado = new Moderado();
Investimento arrojado = new Moderado();

ContaBancaria conta = new ContaBancaria(500);

RealizadorDeInvestimentos realizador = new RealizadorDeInvestimentos();

realizador.RealizaCalculo(conta, conservador);
realizador.RealizaCalculo(conta, moderado);
realizador.RealizaCalculo(conta, arrojado);

Console.ReadKey();