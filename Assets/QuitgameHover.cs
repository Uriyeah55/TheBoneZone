using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;  


public class QuitgameHover : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler
{
    public GameObject handPlay,handQuit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
            public void OnPointerEnter(PointerEventData eventData)
    {
        handPlay.SetActive(false);
        handQuit.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        handQuit.SetActive(false);
        handPlay.SetActive(false);
    }
        public void quitapp(){
        Application.Quit();
    }
}
