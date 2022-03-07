

using ProgramacionIntermedia;
//primera parte

Console.WriteLine("...Primera Parte...");
int randomNumber = new Random().Next(0, 1000);

Console.WriteLine(randomNumber.ToString());
Console.WriteLine(randomNumber>500?"Greater than 500":"Less than 500");

Console.WriteLine("\n\n...Segunda Parte...");
//segunda parte
try
{
    int? variableNull = null;
    Console.WriteLine(variableNull != null ? "Valor valido" : throw new ExcepcionPersonal("entrando a la exepcion"));
}
catch(ExcepcionPersonal)
{
    Console.WriteLine("pase a la excepcion");
}


Console.WriteLine("\n\n...Tercera Parte...");
//tercera parte 

var anonima = new { Name = "Gerardo", age = 27 };
Console.WriteLine(anonima.Name);
Console.WriteLine(anonima.age);

//dynamic variableDinamica = new { valor = 2012 };
dynamic variableDinamica = 2012;
Console.WriteLine(variableDinamica);

variableDinamica = "holi";
Console.WriteLine(variableDinamica);

var anonima2 = new { Name = "Gerardo", Age = 27, Sex = 'M' };
variableDinamica = anonima2;
Console.WriteLine("Nombre: " + anonima2.Name + " Edad: " + anonima2.Age + " Sexo: " + (anonima2.Sex.Equals('M')?"Masculino":"Femenino"));

Console.WriteLine("\n\n...Cuarta Parte...");
//cuarta parte

Map<AccesoriosPc> accesorio = new Map<AccesoriosPc>();

accesorio[0] = new AccesoriosPc("Teclado", 10);
accesorio[1] = new AccesoriosPc("Mouse", 15);
accesorio[2] = new AccesoriosPc("Monitor", 5);

AccesoriosPc a = accesorio["Teclado"];
AccesoriosPc b = accesorio[1];
//AccesoriosPc c = accesorio["perro"];

a.MosttrarAccesorio();
b.MosttrarAccesorio();
//c.MosttrarAccesorio();

Console.WriteLine("\n\n...Quinta Parte...");
//Quinta parte
accesorio.GetFirstElement();

Console.WriteLine("\n\n...Sexta Parte...");
//Sexta parte

string validacion = "Hola1234789";

validacion.regexValidation();
