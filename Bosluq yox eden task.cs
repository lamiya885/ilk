namespace bosluqlari_yox_eden_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
             string name=Console.ReadLine();
            DeleteSpace(name);
            
        }
        static void DeleteSpace(string word ) 
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != ' ')
                {
                    
                   
                }
                else
                {
                i++;

                }
                Console.Write(word[i]);

            }
           
        }
    }
}
