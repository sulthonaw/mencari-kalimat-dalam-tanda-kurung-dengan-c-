using System.Runtime.InteropServices;
using FindLetter;

namespace FindLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string case3 = "Chatbot ini termasuk ke dalam Large Language Model (LLM), yaitu (program komputer yang dapat (1) mengenali, (2) meringkas, (3) menerjemahkan, (4) memprediksi, dan (5) menghasilkan teks)";
            FindLetter(case3);
        }

        // problem solving CASE 3 
        static void FindLetter(string text)
        {

            // mencari index tata letak ['(', ')']
            int open = text.IndexOf('(');
            int close = text.IndexOf(')');

            // operasi untuk menghilangkan tanda buka kurung '(' 
            open += 1;

            // menentukan panjang kalimat dari tanda buka kurung '(' hingga tutup kurung ')'
            int length = close - open;

            // menampilkan kata (LLM) dan memotong string
            Console.WriteLine($"- {text.Substring(open, length)}");

            // mencari index tata letak ['(', ')']
            open = text.IndexOf('(', close += 1);
            close = text.LastIndexOf(')');
            open += 1;
            length = close - open;
            string LongText = text.Substring(open, length);

            // menampilkan kalimat dalam kurung yang panjang
            Console.WriteLine($"- {LongText}");

            // perulangan untuk menampilkan nomor didalam tanda kurung yang berisi kalimat panjang
            while (true)
            {
                open = LongText.IndexOf('(');
                if (open == -1) break;

                open += 1;
                close = LongText.IndexOf(')');
                length = close - open;
                Console.WriteLine($"- {LongText.Substring(open, length)}");
                LongText = LongText.Substring(close + 1);
            }
        }
    }
}
