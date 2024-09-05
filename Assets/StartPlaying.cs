using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;  



public class StartPlaying : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
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
        public void loadTutorial()
    {
        SceneManager.LoadScene("tutorial");
    }
        public void OnPointerEnter(PointerEventData eventData)
    {
        handPlay.SetActive(true);
        handQuit.SetActive(false);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        handQuit.SetActive(false);
        handPlay.SetActive(false);
    }
}
