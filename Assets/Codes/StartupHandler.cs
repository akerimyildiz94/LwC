using LwC;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartupHandler : MonoBehaviour
{
    public static List<Word> Words = new List<Word>();
    // Start is called before the first frame update
    void Start()
    {
        Words.Add(new Word() { english = "car", turkish = "araba", level = 1, isUsed = false });
        Words.Add(new Word() { english = "apple", turkish = "elma", level = 1, isUsed = false });
        Words.Add(new Word() { english = "computer", turkish = "bilgisayar", level = 1, isUsed = false });
        Words.Add(new Word() { english = "pen", turkish = "kalem", level = 1, isUsed = false });
        Words.Add(new Word() { english = "paper", turkish = "kağıt", level = 1, isUsed = false });
        Words.Add(new Word() { english = "ruler", turkish = "silgi", level = 1, isUsed = false });
    }

    // Update is called once per frame
    void Update()
    {

    }
}
