# Mencari Kalimat Di Dalam Tanda Kurung Menggunakan C#
Merupakan contoh program dari cara mengambil nilai `(` `text` `)` di dalam tanda kurung menggunaka method `IndexOf()`, dan `LastIndexOf`. Untuk dokumentasi tentang cara penggunaan method tersebut bisa mengunjungi link berikut :
- [IndexOf()](https://learn.microsoft.com/en-us/dotnet/api/system.string.indexof?view=net-8.0)
- [LastIndexOf()](https://learn.microsoft.com/en-us/dotnet/api/system.string.lastindexof?view=net-8.0)

## Studi Kasus
### Case 1

string case = "Chatbot ini termasuk ke dalam Large Language Model `(LLM)`, yaitu program komputer yang dapat mengenali, meringkas, menerjemahkan, memprediksi, dan menghasilkan teks"

```
output: 
- LLM
```

### Case 2

string case = "Chatbot ini termasuk ke dalam Large Language Model `(LLM)`, yaitu program komputer yang dapat `(mengenali)`, `(meringkas)`, `(menerjemahkan)`, `(memprediksi)`, dan `(menghasilkan teks)`"

```
output: 
- LLM
- mengenali
- meringkas
- menerjemahkan
- memprediksi
- menghasilkan teks
```

### Case 2

string case = "Chatbot ini termasuk ke dalam Large Language Model `(LLM)`, yaitu `(program komputer yang dapat (1) mengenali, (2) meringkas, (3) menerjemahkan, (4) memprediksi, dan (5) menghasilkan teks)`"

```
Output: 
- LLM
- program komputer yang dapat (1) mengenali, (2) meringkas, (3) menerjemahkan, (4) memprediksi, dan (5) menghasilkan teks
- 1
- 2
- 3
- 4
- 5
```
