using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;  
using UnityEngine.SceneManagement;

public class loadMainMenu : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject arm;
    public GameObject armRetry;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadMenu()
    {
        SceneManager.LoadScene("mainMenu");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        arm.SetActive(true);
        armRetry.SetActive(false);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        arm.SetActive(false);
        armRetry.SetActive(false);
    }
}
