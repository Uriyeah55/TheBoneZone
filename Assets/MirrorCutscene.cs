using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MirrorCutscene : MonoBehaviour {
  public GameObject audioSDash, audioLaugh,audioHit;
  public GameObject mirror, skelet, panelVoice, panelSkeleton;
  // Start is called before the first frame update
  void Start() {
    //Invoke("textVoice", 3f);

   // Invoke("mirrorAnim", 8.5f);
   // Invoke("dialegSkeleton", 12f);
   // Invoke("playDash", 12f);
   // Invoke("playLaugh", 9f);

   // Invoke("skeletPunch", 13.5f);
  }

  // Update is called once per frame
  void Update() {}
  public void mirrorAnim() {
    mirror.GetComponent<Animator>().SetTrigger("triggerAnim");
  }
  public void skeletPunch() {
    skelet.SetActive(true);
    //Invoke("tpGameOver", 2f);
    panelVoice.SetActive(false);
    panelSkeleton.SetActive(false);
  }
  public void tpGameOver() { SceneManager.LoadScene("end"); }
  public void textVoice() { panelVoice.SetActive(true); }
  public void playLaugh() { audioLaugh.SetActive(true); }
  public void dialegSkeleton() {
    panelVoice.SetActive(false);
    panelSkeleton.SetActive(true);
  }
  public void playDash() { audioSDash.SetActive(true); }
  public void playHit() { audioHit.SetActive(true); }

  public void showVoiceText() { panelVoice.SetActive(true); }
  public void hideVoiceText() { panelVoice.SetActive(false); }

  public void showSkeletonWelcome() { panelSkeleton.SetActive(true); }
  public void hideSkeletonWelcome() { panelSkeleton.SetActive(false); }


  public void playEvilLaugh() { audioLaugh.SetActive(true); }
  public void callEndScene() {  SceneManager.LoadScene("end"); }

}
