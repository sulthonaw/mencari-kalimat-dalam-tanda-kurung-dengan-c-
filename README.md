# mencari-kalimat-dalam-tanda-kurung-dengan-c#
Program untuk mencari kata atau kalimat dalam tanda kurung menggunakan c# dengan contoh 3 studi kasus

## Case 1
String = "Chatbot ini termasuk ke dalam Large Language Model (LLM), yaitu program komputer yang dapat mengenali, meringkas, menerjemahkan, memprediksi, dan menghasilkan teks"

output: LLM

## Case 2
String = "Chatbot ini termasuk ke dalam Large Language Model (LLM), yaitu program komputer yang dapat (mengenali), (meringkas), (menerjemahkan), (memprediksi), dan (menghasilkan teks)"

output: 
- LLM, 
- mengenali
- meringkas
- menerjemahkan
- memprediksi
- menghasilkan teks

## Case 3 
String = "Chatbot ini termasuk ke dalam Large Language Model (LLM), yaitu (program komputer yang dapat (1) mengenali, (2) meringkas, (3) menerjemahkan, (4) memprediksi, dan (5) menghasilkan teks)"

Output: 
- LLM
- program komputer yang dapat (1) mengenali, (2) meringkas, (3) menerjemahkan, (4) memprediksi, dan (5) menghasilkan teks
- 1
- 2
- 3
- 4
- 5
