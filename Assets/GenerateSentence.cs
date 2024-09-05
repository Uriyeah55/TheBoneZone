using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GenerateSentence : MonoBehaviour
{
    public List<string> sentences= new List<string>();
    public TMP_Text textGO;
    // Start is called before the first frame update
    void Start()
    {
                int randomNum = Random.Range(0, sentences.Count);
                textGO.text=sentences[randomNum];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
