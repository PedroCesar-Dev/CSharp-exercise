//Primeira

//Console.WriteLine("Calculadora de terreno retangular\n");
//int i = 0;
//while (i == 0)
//{
//    Console.WriteLine("Digite o valor do primeiro comprimento.");
//    double comp1 = Convert.ToDouble(Console.ReadLine());
//    Console.WriteLine("Digite o valor do segundo comprimento.");
//    double comp2 = Convert.ToDouble(Console.ReadLine());

//    if (comp1 <= 0 || comp2 <= 0)
//    {
//        Console.WriteLine("Um dos valores está invalido, por favor digite novamente.");
//    }
//    else
//    {
//        Console.WriteLine($"O terreno tem {comp1 * comp2} metros quadrados.");
//        break;
//    }
//}

//Segunda

//Console.WriteLine("Calculadora para ferraduras\n");
//int ferraduras = 4;
//Console.WriteLine("Digite a quantidade de cavalos possuidos: ");
//int cavalos = Convert.ToUInt16(Console.ReadLine());

//Console.WriteLine($"A quantidade de ferraduras necessarias é: {ferraduras * cavalos}");

//Terceira

//Console.WriteLine("Calculadora de dias vividos\n");
//Console.WriteLine("Digite seu primeiro nome:");
//string nome = Console.ReadLine().ToUpper();
//Console.WriteLine("\nDigite sua idade em anos: ");
//int idade = Convert.ToUInt16(Console.ReadLine());

//Console.WriteLine($"{nome} sua idade em dias é {idade * 365}");

//Quarta
//Console.WriteLine("Digite o valor do litro de gasolina: ");
//double gas = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Digite quantos reais deseja colocar de gasolina: ");
//double valor = Convert.ToDouble(Console.ReadLine());
//double valorTotal = valor / gas;

//Console.WriteLine($"Foram comprados {valorTotal:0.00}L de gasolina");

//Quinta

//Console.WriteLine("Fábrica de camisetas");

//int p, m, g;
//p = 10;
//m = 12;
//g = 15;

//Console.WriteLine("Digite quantas camisas P deseja comprar: ");
//double camisasPCompradas = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Digite quantas camisas M deseja comprar: ");
//double camisasMCompradas = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Digite quantas camisas G deseja comprar: ");
//double camisasGCompradas = Convert.ToDouble(Console.ReadLine());

//double total = (camisasPCompradas * p) + (camisasMCompradas * m) + (camisasGCompradas * g);

//Console.WriteLine($"O valor total é: {total}");

//Sexta

//double aumento, imposto, salario, salarioAtualizado, salarioAtualizadoComImposto;

//aumento = 0.15;
//imposto = 0.08;

//Console.WriteLine("Digite o salario inicial: ");
//salario = Convert.ToDouble(Console.ReadLine());
//salarioAtualizado = salario + (salario * aumento);
//salarioAtualizadoComImposto = salarioAtualizado - (salarioAtualizado * imposto);
//Console.WriteLine($"O salario inicial é: {salario}\n O salario com aumento é: {salarioAtualizado}\n O salario final é: {salarioAtualizadoComImposto}");

//Setima
//double raio, altura, pi, volume;
//pi = 3.14;

//Console.WriteLine("Digite o raio da caixa d'água(Em metros): ");
//raio = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Digite a altura da caixa d'água(Em metros): ");
//altura = Convert.ToDouble(Console.ReadLine());
//raio = Math.Pow(raio, 2);
//volume = pi * raio * altura;
//Console.WriteLine($"O volume da caixa d'água é de {volume}L");

//Nona

//double m, cm, mm, km;

//cm = 100;
//mm = 1000;
//km = 1000;

//Console.WriteLine("Digite um valor em metros: ");
//m = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"O valor {m:0.00}M é equivalente a:\n{m * cm:0.00}Cm\n{m * mm:0.00}Mm\n{m / km:0.00}Km");

//Decima
//int qntLata, qntG600, qntG2L;
//double lata, garrafa600, garrafa2L;
//lata = 350;
//garrafa600 = 600;
//garrafa2L = 2000;

//Console.WriteLine("Digite quantas lata(s) de 350ml deseja comprar: ");
//qntLata = Convert.ToInt16(Console.ReadLine());

//Console.WriteLine("Digite quantas garrafa(s) de 600ml deseja comprar: ");
//qntG600 = Convert.ToInt16(Console.ReadLine());

//Console.WriteLine("Digite quantas garrafa(s) de 2L deseja comprar: ");
//qntG2L = Convert.ToInt16(Console.ReadLine());
//Console.WriteLine($"A quantidade de litros comprada é {((qntLata * lata) + (qntG600 * garrafa600) + (qntG2L * garrafa2L)) / 1000:0.00}L");



///////////////////////////////////////////////////SEGUNDA PARTE////////////////////////////////////////////////////////////////



//Aplicando logica em JS - C
//Primeira

//double[] numeros; 
//Console.WriteLine("Digite 10 números separados por espaço: ");
//numeros = Console.ReadLine().Split().Select(double.Parse).ToArray();
//Console.WriteLine($"A soma dos numeros é {numeros.Sum()}");


//Segunda

//string nome;
//double nota1, nota2, media;

//Console.WriteLine("Digite o nome do aluno: ");
//nome = Console.ReadLine();

//Console.WriteLine("Digite a primeira nota: ");
//nota1 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Digite a segunda nota: ");
//nota2 = Convert.ToDouble(Console.ReadLine());

//media =  (nota1 + nota2) / 2;
//if (media >= 6) 
//{
//    Console.WriteLine($"Aluno: {nome}\nMedia: {media}\nSituação: Aprovado");
//}
//else 
//{
//    Console.WriteLine($"Aluno: {nome}\nMedia: {media}\nSituação: reprovado");
//}

//Terceira
//double salario, salarioAumentado;

//Console.WriteLine("Digite o salario para calcular o aumento (Apenas números): ");
//salario = Convert.ToDouble(Console.ReadLine());

//if (salario <= 1500)
//{
//    salarioAumentado = salario + (salario * 0.5);
//    Console.WriteLine($"O salário atualizado é R${salarioAumentado:0.00}");
//}
//else if(salario > 1500 && salario <= 4300)
//{
//    salarioAumentado = salario + (salario * 0.4);
//    Console.WriteLine($"O salário atualizado é R${salarioAumentado:0.00}");
//}
//else
//{
//    salarioAumentado = salario + (salario * 0.3);
//    Console.WriteLine($"O salário atualizado é R${salarioAumentado:0.00}");
//}

//Quarta
//int idade;
//Console.WriteLine("Digite a idade do nadador: ");
//idade = Convert.ToInt16(Console.ReadLine());
//if (idade >= 5 && idade <= 7)
//{
//    Console.WriteLine("Categoria: Ifantil A");
//}
//else if (idade >= 8 && idade <= 10)
//{
//    Console.WriteLine("Categoria: Ifantil B");
//}
//else if (idade >= 11 && idade <= 13)
//{
//    Console.WriteLine("Categoria: Juvenil A");
//}
//else if (idade >= 14 && idade <= 17)
//{
//    Console.WriteLine("Categoria: Juvenil A");
//}
//else if (idade >= 18)
//{
//    Console.WriteLine("Categoria: Adulto");
//}

//Sexta
//double nota1, nota2, media;

//Console.WriteLine("Digite a primeira nota: ");
//nota1 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Digite a segunda nota: ");
//nota2 = Convert.ToDouble(Console.ReadLine());

//media = (nota1 + nota2) / 2;
//if (media >= 7)
//{
//    Console.WriteLine($"Media: {media}\nSituação: Aprovado\nCertificado: Recebe certificado");
//}
//else
//{
//    Console.WriteLine($"Media: {media}\nSituação: reprovado\nCertificado: Não recebe");
//}

//Setima
//double a, b, c, resultado;
//double delta, xl, xll, raizq;

//Console.WriteLine("Calculadora da fórmula de Bhaskara");
//Console.WriteLine("Digite o valor de A:");
//a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Digite o valor de B:");
//b = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Digite o valor de C:");
//c = Convert.ToDouble(Console.ReadLine());

//delta = (b * b) * (-4) * a * c;

//xl = ((-b) + Math.Sqrt(delta)) / 2 * a;
//xll = ((-b) - Math.Sqrt(delta)) / 2 * a;
//Console.WriteLine($"O resultado de x1 é {xl}");
//Console.WriteLine($"O resultado de x2 é {xll}");

//Oitava
//string genero;
//double altura, peso, imc;

//Console.WriteLine("IMC");
//Console.WriteLine("Digite a sua altura em metros: ");
//altura = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Digite o seu genero (M/F): ");
//genero = Console.ReadLine();
//genero = genero.Substring(0, 1);
//Console.WriteLine("Digite o peso em kg:");
//peso = Convert.ToDouble(Console.ReadLine());

//imc = peso /(Math.Pow(altura,2));

//if (genero == "m" || genero == "M") 
//{
//    if (imc < 20.7)
//    {
//        Console.WriteLine("Abaixo do peso");
//    }
//    else if (imc >= 20.7 && imc <= 26.4)
//    {
//        Console.WriteLine("Peso ideal");
//    }
//    else if (imc >= 26.5 && imc <= 27.8)
//    {
//        Console.WriteLine("Pouco acima do peso");
//    }
//    else if (imc >= 27.9 && imc <= 31.1)
//    {
//        Console.WriteLine("Acima do peso");
//    }
//    else if (imc >= 31.2)
//    {
//        Console.WriteLine("Obesidade");
//    }
//}
//else if (genero == "f" || genero == "F")
//{
//    if (imc < 19.1)
//    {
//        Console.WriteLine("Abaixo do peso");
//    }
//    else if (imc >= 19.1 && imc <= 25.8)
//    {
//        Console.WriteLine("Peso ideal");
//    }
//    else if (imc >= 25.9 && imc <= 27.3)
//    {
//        Console.WriteLine("Pouco acima do peso");
//    }
//    else if (imc >= 27.4 && imc <= 32.3)
//    {
//        Console.WriteLine("Acima do peso");
//    }
//    else if (imc >= 32.4)
//    {
//        Console.WriteLine("Obesidade");
//    }
//}


//Aplicando logica em JS - A
//Primeira
//Console.WriteLine("Digite o ano de nascimento: ");
//DateTime idadeAno = DateTime.Parse(Console.ReadLine());

//var data = DateTime.Today;
//var idade = data.Year - idadeAno.Year;
//Console.WriteLine($"Você tem {idade}anos");

//Segunda
//double p, r, volume;
//p = 3.14;
//Console.WriteLine("Digite o raio da esfera para calcular o volume");
//r = Convert.ToDouble(Console.ReadLine());

//volume = 4 / (3 * p * (Math.Pow(r,3)));
//Console.WriteLine($"O volume da esfera é {volume}cm cubicos");

//Terceira
//double x, y;
//Console.WriteLine("Digite o primeiro numero: ");
//x = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Digite o primeiro numero: ");
//y = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"A soma de {x} e {y} é igual a: {x + y} ");
//Console.WriteLine($"A subração de {x} e {y} é igual a: {x - y} ");
//Console.WriteLine($"A multiplicação de {x} e {y} é igual a: {x * y} ");
//Console.WriteLine($"A divisão de {x} e {y} é igual a: {x / y} ");

//Quarta
//double numero;
//Console.WriteLine("Digite o numero: ");
//numero = Convert.ToDouble(Console.ReadLine());

//if (numero > 0)
//{
//    Console.WriteLine("O numero é positivo");
//}
//else if (numero < 0)
//{
//    Console.WriteLine("O numero é negativo");
//}
//else
//{
//    Console.WriteLine("O numero é zero");
//}

//Quinta
//double usd, rate;
//Console.WriteLine("Conversor de USD para BRL");
//Console.WriteLine("Digite a quantide de dólares possuidos: ");
//usd = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Digite a cotação do dolar(Apenas numeros)");
//rate = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine($"A quantidade de reais possuida é {usd * rate}R$");