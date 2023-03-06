using System.Runtime.InteropServices;
using FindLetter;

namespace FindLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string case2 = "Chatbot ini termasuk ke dalam Large Language Model (LLM), yaitu program komputer yang dapat (mengenali), (meringkas), (menerjemahkan), (memprediksi), dan (menghasilkan teks)";
            FindLetter(case2);
        }


        // problem solving CASE 2
        static void FindLetter(string text)
        {
            while (true)
            {
                // mencari index '('
                int open = text.IndexOf('(');

                // perulangan akan berhenti jika tanda '(' sudah tidak ada pada kalimat
                if (open == -1) break;

                // operasi untuk menghilangkan tanda buka kurung '(' 
                open += 1;

                // mencari index '('
                int close = text.IndexOf(')');

                // menentukan panjang kalimat dari tanda buka kurung '(' hingga tutup kurung ')'
                int length = close - open;

                // menampilkan ke console
                Console.WriteLine($"- {text.Substring(open, length)}");

                // menghilangkan teks sebelum ')' agar tanda '(' sebelumnya tidak terkesekusi lagi
                text = text.Substring(close + 1);
            }
        }
    }
}
