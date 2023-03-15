// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal valida tema sugu (m/f)
//rakendus küsib kasutajal sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi] / "Welcome, Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please, sellect your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //Console.ReadLine(); - loeb konsoolist maha andmeid string (sõne) formaadis

Console.WriteLine("Please, enter yout last name:");
string userLastName = Console.ReadLine();

if (userGender == 'm') //== - võrdub    //'' - reserveeritud charidele  //"" - reserveeritud sõnadele (string)
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!"); //kui selle koodi Console.WriteLine("Welcome, Mr.!"); töö on valmis saanud siis kõik andmed vahemälust kustutakse maha
}   
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}

