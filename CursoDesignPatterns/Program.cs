﻿using CursoDesignPatterns;

Imposto iss = new ISS();
Imposto icms = new ICMS();

Orcamento orcamento = new Orcamento(500);

CalculadorDeImpostos calculador = new CalculadorDeImpostos();

calculador.RealizaCalculo(orcamento, icms);
calculador.RealizaCalculo(orcamento, iss);

Console.ReadKey();