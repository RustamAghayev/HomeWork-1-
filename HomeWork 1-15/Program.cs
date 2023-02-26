#region task 1
//int a = int.Parse(Console.ReadLine());
//int countlog = (int)Math.Log10(a) + 1;

//if (countlog == 4)
//{
//    int result = (40000 + a) * 10 + 2;

//    Console.WriteLine(result);
//}
//else
//{
//    Console.WriteLine("eded 4 reqemli deyil");
//}
#endregion
#region task 1 (v2)
//int a = int.Parse(Console.ReadLine());
//int countlog = (int)Math.Log10(a) + 1;
//if (a >= 10000 && a <= 99999)
//{
//    //int result = (40000 + a) * 10 + 2;
//    string s = $"4{a}2";
//    int result = int.Parse(s);

//    Console.WriteLine(result);
//}
//else
//{
//    Console.WriteLine(" daxil edilen eded 5 reqemli deyil");
//}
#endregion
#region task 2
//l1:
//Console.WriteLine("3 reqemli ededi daxil edin:  ");
//string eded = (Console.ReadLine());


//if (!int.TryParse(eded, out int num1))
//{
//    goto l1;
//}
//if (num1 >= 100 && num1 <= 999)
//{
//    int num2 = num1 * 1000 + num1;
//    Console.WriteLine(num2);
//}
#endregion
#region task 3
//5 reqemli eded verilib. Bu ededin evvel  18 % sonra ise 3 % tap.
//l1:
//Console.WriteLine("5 reqemli ededi daxil edin");
//string eded = (Console.ReadLine());

//if (!int.TryParse(eded, out int num1))
//{
//    goto l1;
//}


//if (num1 >= 10000 && num1 <= 99999)
//{
//    double num2 = num1 * 18 / 100;
//    double num3 = num2 * 3 / 100;
//    Console.WriteLine($"Netice:    {num3}");
//}
//else
//{
//    Console.WriteLine("5 reqemli deyil!!!");
//}
#endregion
#region task 4
//3 reqemli eded verilib. Bu ededin axirina 7 artir. Sonra cavabin 7% tap;
//l1:
//Console.WriteLine("3 reqemli eded daxil edin:  ");
//string eded = Console.ReadLine();

//if (!int.TryParse(eded, out int num1))
//{
//    goto l1;
//}
//if (num1 >= 100 && num1 <= 999)
//{
//    double num2 = num1 * 10 + 7;
//    double num3 = num2 * 7 / 100;
//    Console.WriteLine($"Netice: {num3}");
//}
//else
//{
//    Console.WriteLine("3 reqemli eded daxil edin");
//}
#endregion
#region task 5
//l1:
//Console.WriteLine("4 reqemli eded daxil edin:  ");
//string eded = Console.ReadLine();

//if (!int.TryParse(eded, out int num1))
//{
//    goto l1;
//}
//int numLong = (int)Math.Log10(num1) + 1;

//if (numLong == 4)
//{
//    double num2 = (40000 + num1) * 100 + 44;
//    double num3 = num2 * 44 / 100;
//    Console.WriteLine(num3);
//}
//else
//{
//    Console.WriteLine("4 reqemli eded daxil etmedin");
//}
#endregion
#region task 6
//l1:
//Console.WriteLine("4 reqemli eded daxil edin:  ");
//string eded = Console.ReadLine();

//if (!int.TryParse(eded, out int num1))
//{
//    goto l1;
//}
//int numLong = (int)Math.Log10(num1) + 1;

//if (numLong == 4)
//{
//    double num2 = num1 * 20  / 100;
//    double num3 = num2 * 10 / 100;
//    double num4 = (double)Math.Pow(num3, 2);
//    Console.WriteLine(num4);
//}
//else
//{
//    Console.WriteLine("4 reqemli eded daxil etmedin");
//}
#endregion
#region task 7
//l1:
//Console.WriteLine("5 reqemli eded daxil edin:  ");
//string eded1 = Console.ReadLine();

//if (!int.TryParse(eded1, out int num1))
//{
//    goto l1;
//}
//int numLong1 = (int)Math.Log10(num1) + 1;

//if (numLong1 != 5)
//{
//    goto l1;
//}



//l2:
//Console.WriteLine("5 reqemli diger eded daxil edin:  ");
//string eded2 = Console.ReadLine();

//if (!int.TryParse(eded2, out int num2))
//{
//    goto l2;
//}
//int numLong2 = (int)Math.Log10(num2) + 1;

//if (numLong2 != 5)
//{

//    goto l2;
//}

//int num3 = num1 + num2;

//int numlong3 = (int)Math.Log10(num3) + 1;
//int num4 = (int)Math.Pow(10, numlong3);

//int num5 = (num4 * 5 + num3) * 10 + 5;
//double num6 = num5 * 5 / 100;
//Console.WriteLine(num6);

#endregion
#region task 8


//l1:
//Console.WriteLine("4 reqemli eded daxil edin:  ");
//string eded1 = Console.ReadLine();

//if (!int.TryParse(eded1, out int num1))
//{
//    goto l1;
//}
//int numLong1 = (int)Math.Log10(num1) + 1;

//if (numLong1 != 4)
//{
//    goto l1;
//}
//l2:
//Console.WriteLine("7 reqemli diger eded daxil edin:  ");
//string eded2 = Console.ReadLine();

//if (!int.TryParse(eded2, out int num2))
//{
//    goto l2;
//}
//int numLong2 = (int)Math.Log10(num2) + 1;

//if (numLong2 != 7)
//{

//    goto l2;
//}
//double num3 = num1 * 4 / 100;
//double num4 = num2 * 9 / 100;
//double num5 = (num4 + num3) * 10 / 100;
//Console.WriteLine(num5);
#endregion
#region task 9


//l1:
//Console.WriteLine("6 reqemli eded daxil edin:  ");
//string eded1 = Console.ReadLine();

//if (!int.TryParse(eded1, out int num1))
//{
//    goto l1;
//}
//int numLong1 = (int)Math.Log10(num1) + 1;

//if (numLong1 != 6)
//{
//    goto l1;
//}

//l2:
//Console.WriteLine("6 reqemli diger eded daxil edin:  ");
//string eded2 = Console.ReadLine();

//if (!int.TryParse(eded2, out int num2))
//{
//    goto l2;
//}
//int numLong2 = (int)Math.Log10(num2) + 1;

//if (numLong2 != 6)
//{

//    goto l2;
//}



//l3:
//Console.WriteLine("6 reqemli diger diger eded daxil edin:  ");
//string eded3 = Console.ReadLine();

//if (!int.TryParse(eded3, out int num3))
//{
//    goto l3;
//}
//int numLong3 = (int)Math.Log10(num3) + 1;

//if (numLong3 != 6)
//{

//    goto l3;
//}

//double result = num1 * 10 / 100;
//double result1 = num2 * 10 / 100;
//double result2 = num3 * 10 / 100;

//double result4 = result + result1 + result2;

//double result5 = result4 * 10 / 100;
//Console.WriteLine(result5);

#endregion
#region task 10
//l1:
//Console.WriteLine("4 reqemli 1ci eded daxil edin:  ");
//string eded1 = Console.ReadLine();

//if (!int.TryParse(eded1, out int num1))
//{
//    goto l1;
//}
//int numLong1 = (int)Math.Log10(num1) + 1;

//if (numLong1 != 4)
//{
//    goto l1;
//}
//l2:
//Console.WriteLine("4 reqemli 2ci eded daxil edin:  ");
//string eded2 = Console.ReadLine();

//if (!int.TryParse(eded2, out int num2))
//{
//    goto l2;
//}
//int numLong2 = (int)Math.Log10(num2) + 1;

//if (numLong2 != 4)
//{

//    goto l2;
//}

//l3:
//Console.WriteLine("4 reqemli 3cu eded daxil edin:  ");
//string eded3 = Console.ReadLine();

//if (!int.TryParse(eded3, out int num3))
//{
//    goto l3;
//}
//int numLong3 = (int)Math.Log10(num3) + 1;

//if (numLong3 != 4)
//{

//    goto l3;
//}

//double result1 = num1 * 1 / 100;
//double result2 = num2 * 2 / 100;
//double result3 = num3 * 3 / 100;
//double result4 = num3 * 7 / 100;

//double result = (result1 - result2 - result3) + result4;

//Console.WriteLine($"# reqemin faizlerinen toplanan netice {result}");

#endregion
#region task 11
//l1:
//Console.WriteLine("5 reqemli 1ci eded daxil edin:  ");
//string eded1 = Console.ReadLine();

//if (!int.TryParse(eded1, out int num1))
//{
//    goto l1;
//}
//int numLong1 = (int)Math.Log10(num1) + 1;

//if (numLong1 != 5)
//{
//    goto l1;
//}
//l2:
//Console.WriteLine("5 reqemli 2ci eded daxil edin:  ");
//string eded2 = Console.ReadLine();

//if (!int.TryParse(eded2, out int num2))
//{
//    goto l2;
//}
//int numLong2 = (int)Math.Log10(num2) + 1;

//if (numLong2 != 5)
//{

//    goto l2;
//}

//l3:
//Console.WriteLine("5 reqemli 3cu eded daxil edin:  ");
//string eded3 = Console.ReadLine();

//if (!int.TryParse(eded3, out int num3))
//{
//    goto l3;
//}
//int numLong3 = (int)Math.Log10(num3) + 1;

//if (numLong3 != 5)
//{

//    goto l3;
//}

//l4:
//Console.WriteLine("5 reqemli 4cu eded daxil edin:  ");
//string eded4 = Console.ReadLine();

//if (!int.TryParse(eded4, out int num4))
//{
//    goto l4;
//}
//int numLong4 = (int)Math.Log10(num4) + 1;

//if (numLong3 != 5)
//{

//    goto l4;
//}

//double result1 = num1 + num3;
//double result2 = num2 + num4;

//double result3 = result1 * result2;

//double result4 = result3 - num3 * 3 / 100;

//Console.WriteLine(result4);

/*
  4 dene 5 reqemli eded verilib. Her I ededin ustune III ededi gel . II ededin usutune IV eeddi gel. 
    Sonra cavablari vur birbirine. Alinan neticeden III ededin 3%-ni cix.
 */
#endregion
#region task 12
//l1:
//Console.WriteLine("6 reqemli 1ci eded daxil edin:  ");
//string eded1 = Console.ReadLine();

//if (!int.TryParse(eded1, out int num1))
//{
//    goto l1;
//}
//int numLong1 = (int)Math.Log10(num1) + 1;

//if (numLong1 != 6)
//{
//    goto l1;
//}
//l2:
//Console.WriteLine("6 reqemli 2ci eded daxil edin:  ");
//string eded2 = Console.ReadLine();

//if (!int.TryParse(eded2, out int num2))
//{
//    goto l2;
//}
//int numLong2 = (int)Math.Log10(num2) + 1;

//if (numLong2 != 6)
//{

//    goto l2;
//}

//l3:
//Console.WriteLine("6 reqemli 3cu eded daxil edin:  ");
//string eded3 = Console.ReadLine();

//if (!int.TryParse(eded3, out int num3))
//{
//    goto l3;
//}
//int numLong3 = (int)Math.Log10(num3) + 1;

//if (numLong3 != 6)
//{

//    goto l3;
//}

//l4:
//Console.WriteLine("6 reqemli 4cu eded daxil edin:  ");
//string eded4 = Console.ReadLine();

//if (!int.TryParse(eded4, out int num4))
//{
//    goto l4;
//}
//int numLong4 = (int)Math.Log10(num4) + 1;

//if (numLong3 != 6)
//{

//    goto l4;
//}

//double result1 = num1 * 10 / 100 * 15 / 100;
//double result2 = num2 * 10 / 100 * 15 / 100;
//double result3 = num3 * 10 / 100 * 15 / 100;
//double result4 = num4 * 10 / 100 * 15 / 100;

//double result5 = result1 * result2;
//double result6 = result3 * result4;

//double result7 = result5 * result6;

//double result8 = result7 * 10 / 100 * 11 / 100;

//Console.WriteLine(result8);



/*
4 dene 6 reqemli eded verilib. Ededlerin hamisinin 10 faizini tap ve topla. Sonra hamisinin
15 faizini tap ve topla. 
Sonra yekunda alinanlar iki cavabi vur biri birine. Alinan neticenin evvel 10% tap sonra ise
hemin cavabin 11% tap.
 */
#endregion
#region task 13
//l1:
//Console.WriteLine("5 reqemli 1ci eded daxil edin:  ");
//string eded1 = Console.ReadLine();

//if (!int.TryParse(eded1, out int num1))
//{
//    goto l1;
//}
//int numLong1 = (int)Math.Log10(num1) + 1;

//if (numLong1 != 5)
//{
//    goto l1;
//}
//l2:
//Console.WriteLine("5 reqemli 2ci eded daxil edin:  ");
//string eded2 = Console.ReadLine();


//if (!int.TryParse(eded2, out int num2))
//{
//    goto l2;
//}
//int numLong2 = (int)Math.Log10(num2) + 1;

//if (numLong2 != 5)
//{

//    goto l2;
//}

//l3:
//Console.WriteLine("5 reqemli 3cu eded daxil edin:  ");
//string eded3 = Console.ReadLine();

//if (!int.TryParse(eded3, out int num3))
//{
//    goto l3;
//}
//int numLong3 = (int)Math.Log10(num3) + 1;

//if (numLong3 != 5)
//{

//    goto l3;
//}


//l4:
//Console.WriteLine("3 reqemli 4cu eded daxil edin:  ");
//string eded4 = Console.ReadLine();

//if (!int.TryParse(eded4, out int num4))
//{
//    goto l4;
//}
//int numLong4 = (int)Math.Log10(num4) + 1;

//if (numLong4 != 3)
//{

//    goto l4;
//}

//l5:
//Console.WriteLine("3 reqemli 5cu eded daxil edin:  ");
//string eded5 = Console.ReadLine();

//if (!int.TryParse(eded5, out int num5))
//{
//    goto l5;
//}
//int numLong5 = (int)Math.Log10(num5) + 1;

//if (numLong5 != 3)
//{

//    goto l5;
//}

//double result = num1 * 5 / 100;
//double result1 = num2 * 5 / 100;
//double result2 = num3 * 5 / 100;

//double resultvur = result * result1 * result2;

//double result3=num4 * 3 / 100;
//double result4=num5 * 3 / 100;

//double resulttopla = result3 + result4;

//double result6 = resultvur * 10 / 100;
//double result7 = resulttopla * 10 / 100;

//double result8 = result6 + result7;

//Console.WriteLine(result8);

/*
    5 dene eded verilib. Bunlardan 3 denesi 5 reqemli. 2 denesi ise 3 reqemlidir.
    5 reqemli ededlerin 5% tap ,neticeleri vur bir birine. 
    Sonra 3 reqemli ededlerin 3% tap ,neticeleri topla. Sonra yekunda alinan
    iki cavalarin her birinin 10%-ni tapib topla.
 */
#endregion
#region task 14
//l1:
//Console.WriteLine("6 reqemli 1ci eded daxil edin:  ");
//string eded1 = Console.ReadLine();

//if (!int.TryParse(eded1, out int num1))
//{
//    goto l1;
//}
//int numLong1 = (int)Math.Log10(num1) + 1;

//if (numLong1 != 6)
//{
//    goto l1;
//}
//l2:
//Console.WriteLine("6 reqemli 2ci eded daxil edin:  ");
//string eded2 = Console.ReadLine();


//if (!int.TryParse(eded2, out int num2))
//{
//    goto l2;
//}
//int numLong2 = (int)Math.Log10(num2) + 1;

//if (numLong2 != 6)
//{

//    goto l2;
//}

//l3:
//Console.WriteLine("6 reqemli 3cu eded daxil edin:  ");
//string eded3 = Console.ReadLine();

//if (!int.TryParse(eded3, out int num3))
//{
//    goto l3;
//}
//int numLong3 = (int)Math.Log10(num3) + 1;

//if (numLong3 != 6)
//{

//    goto l3;
//}


//l4:
//Console.WriteLine("6 reqemli 4cu eded daxil edin:  ");
//string eded4 = Console.ReadLine();

//if (!int.TryParse(eded4, out int num4))
//{
//    goto l4;
//}
//int numLong4 = (int)Math.Log10(num4) + 1;

//if (numLong4 != 6)
//{

//    goto l4;
//}

//l5:
//Console.WriteLine("6 reqemli 5cu eded daxil edin:  ");
//string eded5 = Console.ReadLine();

//if (!int.TryParse(eded5, out int num5))
//{
//    goto l5;
//}
//int numLong5 = (int)Math.Log10(num5) + 1;

//if (numLong5 != 6)
//{

//    goto l5;
//}


//l6:
//Console.WriteLine("6 reqemli 6cu eded daxil edin:  ");
//string eded6 = Console.ReadLine();

//if (!int.TryParse(eded6, out int num6))
//{
//    goto l6;
//}
//int numLong6 = (int)Math.Log10(num6) + 1;

//if (numLong6 != 6)
//{

//    goto l6;
//}

//long result1 = num1 + num2 + num3 + num4 + num5 + num6;

//long result2 = num1 * 1000000 + num2;

//long result3 = result1 - result2;

//long result4 = result3 * 10 / 100;

//long result5 = result4 + num5 + num6;

//long result6 = result5 * 11 / 100;

//Console.WriteLine(result6);





//long result2 = num1 * 1000000 + num3;
//long result3 = result1 - result2;
//long result4 = result3;
//long result5 = result4 * 10 / 100;
//long result6 = result5+ num5 + num6;
//long result7 = result6 * 11 / 100;

//Console.WriteLine(result7);



/*
    6 dene 6 reqemli eded verilib. Evvel hamisini topla . Sonra I ve III ededi bir birine yapishdir
    ve bir eded al.  
    I neticeden II neticeni cix. Alinan cavabin 10% tap. Neticenin uzerine V ve VI ededleri gel.
    Yekunda alinan cavabin 11% tap.*/

#endregion
#region task 15

//l1:
//Console.WriteLine("3 reqemli 1ci eded daxil edin:  ");
//string eded1 = Console.ReadLine();

//if (!int.TryParse(eded1, out int num1))
//{
//    goto l1;
//}
//int numLong1 = (int)Math.Log10(num1) + 1;

//if (numLong1 != 3)
//{
//    goto l1;
//}
//l2:
//Console.WriteLine("3 reqemli 2ci eded daxil edin:  ");
//string eded2 = Console.ReadLine();


//if (!int.TryParse(eded2, out int num2))
//{
//    goto l2;
//}
//int numLong2 = (int)Math.Log10(num2) + 1;

//if (numLong2 != 3)
//{

//    goto l2;
//}

//l3:
//Console.WriteLine("4 reqemli 3cu eded daxil edin:  ");
//string eded3 = Console.ReadLine();

//if (!int.TryParse(eded3, out int num3))
//{
//    goto l3;
//}
//int numLong3 = (int)Math.Log10(num3) + 1;

//if (numLong3 != 4)
//{

//    goto l3;
//}


//l4:
//Console.WriteLine("4 reqemli 4cu eded daxil edin:  ");
//string eded4 = Console.ReadLine();

//if (!int.TryParse(eded4, out int num4))
//{
//    goto l4;
//}
//int numLong4 = (int)Math.Log10(num4) + 1;

//if (numLong4 != 4)
//{

//    goto l4;
//}

//l5:
//Console.WriteLine("5 reqemli 5ci eded daxil edin:  ");
//string eded5 = Console.ReadLine();

//if (!int.TryParse(eded5, out int num5))
//{
//    goto l5;
//}
//int numLong5 = (int)Math.Log10(num5) + 1;

//if (numLong5 != 5)
//{

//    goto l5;
//}


//l6:
//Console.WriteLine("5 reqemli 6ci eded daxil edin:  ");
//string eded6 = Console.ReadLine();

//if (!int.TryParse(eded6, out int num6))
//{
//    goto l6;
//}
//int numLong6 = (int)Math.Log10(num6) + 1;

//if (numLong6 != 5)
//{

//    goto l6;
//}


//l7:
//Console.WriteLine("6 reqemli 7ci eded daxil edin:  ");
//string eded7 = Console.ReadLine();

//if (!int.TryParse(eded7, out int num7))
//{
//    goto l7;
//}
//int numLong7 = (int)Math.Log10(num7) + 1;

//if (numLong7 != 6)
//{

//    goto l7;
//}

//double result1 = num1 + num2;
//double result2 = num3 * num4;
//double result3 = result1 + result2 * 10 + 2 / 10;
//double result4 = num5 + num6;
//double result5 = result3 + result4;
//double result6 = num1 * num2 * 10 + 1;
//double result7 = result5 - result6;
//double result8 = num1 + num2 + num3 + num4;
//double result9 = result7+num7;
//double result10 = result7 - result8;

//double result11 = result10 * 18 / 100 * 3 / 100 * 1 / 100;

//double result12 = result11 + num5 + num6;

//Console.WriteLine(result12);




/*
 * 7 dene eded verilib.Bunlardan 2 denesi 3 reqemlidir. 2 denesi 4 reqemlidir. 2 denesi 5 reqemlidir.1 denesi ise
 * 6 reqemlidir.
    3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
    Sonra neticenin axirina 7 reqemini artir. Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
    Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
    Sonra alinan cavabin ustune gel 6 reqemli ededi.
    Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
    Sonra alinan cavabin 18% -ni sonra 3%-ni sonra 1% tap.
    Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.
 */
#endregion