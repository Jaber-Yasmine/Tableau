using System;
using System.Linq;


namespace TABLEAU
{
    public class TABLEAU
    {

        public int[] Initial(int lenth)
        {
            int[] array = new int[lenth];
            for (int i = 0; i < lenth; i++)
            {
                array[i] = i + 101;
            }

            return array;
        }


        public void Show(int[] array)
        {
            Console.WriteLine("Tableau : ");
            foreach (int j in array)
            {
                Console.WriteLine(j);
            }
        }


        public int[] InsertionArrayElement(int value, int[] array)
        {

            array = new System.Collections.Generic.List<int>(array) { value }.ToArray();

            Console.WriteLine("Tableau après ajout");

            Console.WriteLine("Tableau : ");
            foreach (int j in array)
            {
                Console.WriteLine(j);
            }

            return array;
        }


        public void TrierArrayElements(int nb, int k, int[] array)
        {
            for (int i = 0; i < nb - 1; i++)
            {
                // declaration du vecteur
                int[] vec = new int[nb];

                // recherche de la position du plus petit element
                int numcase = i;
                for (int j = i + 1; j < nb; j++)
                {
                    if (vec[j] < vec[numcase])
                    {
                        numcase = j;
                    }
                }
                //echange des 2 cases
                int sauv = vec[numcase];
                vec[numcase] = vec[i];
                vec[i] = sauv;

                // affichage du vecteur en cours de trie
                Console.WriteLine();
                for (k = 0; k < nb; k++)
                {
                    Console.Write(vec[k] + " ");
                }

            }

        }


        public int[] DeleteArrayElement(int index, int[] array)
        {

            int indexToRemove = index;
            array = array.Where((source, index) => index != indexToRemove - 1).ToArray();
            Console.WriteLine("Tableau après suppression");

            Console.WriteLine("Tableau : ");
            foreach (int j in array)
            {
                Console.WriteLine(j);
            }

            return array;
        }


        public int[] ModifierArrayElement(int index, int newValue, int[] array)
        {

            array[index - 1] = newValue;
            Console.WriteLine("Tableau : ");
            foreach (int j in array)
            {
                Console.WriteLine(j);
            }

            return array;
        }


        internal int[] TrierArrayElements(int singleTrieString, int[] array)
        {
            throw new NotImplementedException();
        }
    }
        
    class programm
        {
            public static void Main(string[] args, int[] array)
            {

                // saisie du nombre de cases du vectuer
                Console.Write("la longueur du tableau = ");
                int nb = int.Parse(Console.ReadLine());

                // declaration du vecteur
                int[] vec = new int[nb];

                //saisie du vecteur
                for (int k = 0; k < nb; k++)
                {
                    Console.Write("nombre n°" + k + " = ");
                    vec[k] = int.Parse(Console.ReadLine());
                    string? input = Console.ReadLine();
                }

                TABLEAU program = new TABLEAU(); // Création d'objet
                Console.Write("L'initialisation du tableau est terminée \n\n");



                do
                {

                    Console.Write("1) Afficher le tableau \n");
                    Console.Write("2) Inserer dans le tableau \n");
                    Console.Write("3) Trie les éléments du tableau \n");
                    Console.Write("4) supprimer l'élément du tableau \n");
                    Console.Write("5) Modifier l'élément de tableau \n");
                    Console.Write("6) Sortir \n\n");
                    string? switchInput = Console.ReadLine();
                    int switchInputString = Convert.ToInt32(switchInput);


                    if (switchInputString == 1)
                    {
                        program.Show(array);
                    }
                
                    else if (switchInputString == 2)
                    {
                        Console.Write("Entrez la valeur du nouvel élément du tableau : ");
                        string? singleAddInput = Console.ReadLine();
                        int singleAddString = Convert.ToInt32(singleAddInput);

                        array = program.InsertionArrayElement(singleAddString, array);

                    }

                    else if (switchInputString == 3)
                    {
                        Console.Write("Le tableau apres le trie ");
                        string? singletrierInput = Console.ReadLine();
                        int singleTrieString = Convert.ToInt32(singletrierInput);

                        array = program.TrierArrayElements(singleTrieString, array);
                    }

                    else if (switchInputString == 4)
                        {
                            Console.Write("Entrez l'index de l'élément du tableau : ");
                            string? singleDeleteInput = Console.ReadLine();
                            int singleDeleteString = Convert.ToInt32(singleDeleteInput);

                            array = program.DeleteArrayElement(singleDeleteString, array);

                        }

                    else if (switchInputString == 5)
                    {
                        Console.Write("Entrez l'index de l'élément du tableau : ");
                        string? singleUpdateInput = Console.ReadLine();
                        int singleUpdateString = Convert.ToInt32(singleUpdateInput);

                        Console.Write("Saisissez la nouvelle valeur de l'index : ");
                        string? singleUpdateNewValueInput = Console.ReadLine();
                        int singleUpdateNewValueString = Convert.ToInt32(singleUpdateNewValueInput);


                        array = program.ModifierArrayElement(singleUpdateString, singleUpdateNewValueString, array);
                    }
                    
                    else if (switchInputString == 6)
                    {
                        break;
                    }

                } while (true);
            }
        }

        
}
