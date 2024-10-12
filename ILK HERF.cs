namespace ConsoleApp2
{
    internal class program
    {
        static void main(string[] args)
        {
            string soz = Console.ReadLine() ;
            FirstLatter( ref soz);
        }
        static void FirstLatter(ref string word) 
        {
           
            for (int i = 0; i < word.Length; i++)
            { 
                 if (word[i] == ' ' && word[i+1]!=' ')
                {
                   Console.WriteLine(word[i+1]);

                }
                else  
                {
                    i++;
                }
            }
            Console.WriteLine(word[i + 1]);

        }       
        

    }
}
