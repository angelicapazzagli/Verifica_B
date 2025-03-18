Random r = new Random();
void stampa_matrice(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write("[ " + mat[i, j] + " ]");
        }
        Console.WriteLine();
    }
}
//ESERCIZIO A
void popola_temperature(int[,] mat)
{
    for(int i = 0; i < mat.GetLength(0); i++)
    {
        for(int j = 0; j < mat.GetLength(1); j++)
        {
            if(i == 0)
            {
                mat[i, j] = r.Next(-10, 36);
            }
            else if(j == 1)
            {
                mat[i, j] = 0;
            }
        }
    }
    stampa_matrice(mat);
}
//ESERCIZIO B
void media_progressiva(int[,] mat)
{
    int somma = 0, n = 0;
    for(int i =  0; i < mat.GetLength(0); i++)
    {
        for(int j = 0; j < mat.GetLength(1); j++)
        {
            if(i == 1) 
            { 
                for(int k = 0; k <= j; k++)
                {
                    somma += mat[0, k];
                    n++;
                }
                mat[i, j] = somma / n;
            }
            somma = 0;
            n = 0;
        }
    }
    stampa_matrice(mat);
}
int temperatura_massima(int[,] mat)
{
    int temp_max = 0, temp;
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            if(i == 1)
            {
                temp = mat[i, j];
                if(temp > temp_max)
                {
                    temp_max = temp;
                }
            }
        }
    }
    return temp_max;
}
//ESERCIZIO C
string completa(ref string caratteri)
{
    string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    for (int i = 0; i < alfabeto.Length; i++) 
    {
        if (caratteri.Contains(alfabeto[i]))
        {
            
        }
        else
        {
            caratteri += alfabeto[i];
        }
    }
    return caratteri;
}
//ESERCIZIO D
bool verifica(string sequenza)
{
    string cifre = "1234567890";
    for(int i = 0; i < cifre.Length; i++)
    {
        int numero_cifre = 0;
        for(int j = 0; j < sequenza.Length; j++)
        {
            if (cifre[i] == sequenza[j])
            {
                numero_cifre++;
            }
        }
        if (numero_cifre > 1)
        {
            return false;
        }
    }
    return true;
}
int[,] mat = new int[2, 12];
//ESERCIZIO A
popola_temperature(mat);
//ESERCIZIO B
media_progressiva(mat);
Console.WriteLine("Temperatura massima registrata: " + temperatura_massima(mat));
//ESERCIZIO C
string caratteri = "ILMATNOHRBC";
Console.WriteLine(completa(ref caratteri));
//ESERCIZIO D
string sequenza = "123456789";
Console.WriteLine(verifica(sequenza));
