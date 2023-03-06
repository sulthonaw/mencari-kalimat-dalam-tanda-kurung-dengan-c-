using System.Runtime.InteropServices;
using FindLetter;

namespace FindLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string case1 = "Chatbot ini termasuk ke dalam Large Language Model (LLM), yaitu program komputer yang dapat mengenali, meringkas, menerjemahkan, memprediksi, dan menghasilkan teks";
            FindLetter(case1);
        }



        // problem solving CASE 1
        static void FindLetter(string text)
        {
            // mencari index tata letak ['(', ')']
            int open = text.IndexOf('(');
            int close = text.IndexOf(')');

            // operasi untuk menghilangkan tanda buka kurung '(' 
            open += 1;

            // menentukan panjang kalimat dari tanda buka kurung '(' hingga tutup kurung ')'
            int length = close - open;

            // open adalah index awal; length adalah panjang dari index awal hingga karakter tutup kurung 
            Console.WriteLine($"- {text.Substring(open, length)}");   // output : - LLM
        }

    }
}
