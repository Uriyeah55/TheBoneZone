using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewAudioManager : MonoBehaviour
{
    public bool itsSinging=false;
    public GameObject singSprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          if (Input.GetKeyDown(KeyCode.R))
        {
            itsSinging=true;
            singSprite.SetActive(true);
            GetComponent<AudioSource>().Play();
        }
              if (Input.GetKeyUp(KeyCode.R))
        {
            itsSinging=false;
            singSprite.SetActive(false);
            GetComponent<AudioSource>().Stop();

        }
    }
}
