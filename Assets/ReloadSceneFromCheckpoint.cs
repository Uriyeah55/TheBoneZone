using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;  


public class ReloadSceneFromCheckpoint : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler
{
    int highScore;
    public GameObject arm,armRetry;

    // Start is called before the first frame update
    void Start()
    {
         highScore = PlayerPrefs.GetInt("HighScore", 0); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReloadSavedScene(){
        Debug.Log("clicat boto realod amb current highscore" + highScore);
      switch (highScore)
        {
        case 0:
            SceneManager.LoadScene("tutorial");
            break;
        case 1:
            SceneManager.LoadScene("level1");
            break;
        case 2:
            SceneManager.LoadScene("level2");
            break;
        case 3:
            SceneManager.LoadScene("level3");
            break;
        case 4:
            SceneManager.LoadScene("level4Bridge");
            break;
        case 5:
            SceneManager.LoadScene("level5Inverted");
            break;
        default:
      
            break;
        }

    }
        public void OnPointerEnter(PointerEventData eventData)
    {
        arm.SetActive(false);
        armRetry.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        arm.SetActive(false);
        armRetry.SetActive(false);
    }
}
