void matriz()
{
    String[] nombre = new String[]
    {
        "Anderson","Brandon","Yeimi","Fatima","Vivian"
    };
    int[,] notas = { {51,80}, { 96,76 }, { 61, 0,} };
    int notaMasAlta = notas[0, 0];
    String nombreNotaMasAlta = nombre[0];
    for (int i = 0; i < notas.GetLength(0); i++)
    {
        for (int j = 0; j < notas.GetLength(1); j++)
        {
            if (notas[i, j] > notaMasAlta)
            {
                notaMasAlta = notas[i, j];
                nombreNotaMasAlta = nombre[i];
            }
        }
    }

    Console.WriteLine("La nota más alta es: " + notaMasAlta + ", y pertenece a: " + nombreNotaMasAlta);
}
matriz();