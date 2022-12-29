namespace EjercicioFinal;
class Program
{
    static void Main(string[] args)
    {
        int[]a= new int[100];
        int[]b= new int [50];
        
        Random r = new Random();
        for(int i = 0; i < 100; i++){ 
            a[i] = r.Next(10,200);
        }

        Console.WriteLine("Arreglo de 100 enteros: ");
        new Program().Imprimir(a,a.Length);

        for(int j = 0; j < 50; j++){
            b[j]=r.Next(10,200);
        }
        Console.WriteLine("\nArreglo de 50 enteros seleccionados al azar: ");
        new Program().Imprimir(b,b.Length);

        double porcentajeExito = (100)*((double)new Program().coincidencias(a,b)/(double)b.Length);
        double porcentajeFallida = (100)-(100)*((double)new Program().coincidencias(a,b)/(double)b.Length);
        Array.Sort(a);

        Console.WriteLine("\nNumero de busquedas con éxito: "+new Program().coincidencias(a,b));
        Console.WriteLine("Numero de busquedas fallidas: "+(50-(new Program().coincidencias(a,b))));
        Console.WriteLine("Porcentaje de busquedas con éxito: "+porcentajeExito+" %");
        Console.WriteLine("Porcentaje de busquedas fallidas: "+porcentajeFallida+" %");    
        Console.WriteLine("\nArreglo ordenado: ");
        new Program().Imprimir(a,a.Length);

    
    }

    int coincidencias (int[] arreglo1, int[] arreglo2){
        int contador=0;
        for (int i = 0; i < arreglo2.Length; i++){
            int posicionEncontrada = new Program().busquedaLineal(arreglo1,arreglo1.Length,arreglo2[i]);
            if(posicionEncontrada != -1){
                contador++;
            }    
        }
        return contador;
    }
    void Imprimir(int[]a, int n){
        for ( int i = 0; i < n; i++){
            Console.Write(a[i]+" ");
        }
    }

    int busquedaLineal (int[] A, int n, int clave){
        int i;
        for (i = 0; i < n; i++)
            if (A[i] == clave)
                return i;
        return -1;
    }
}
