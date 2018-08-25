using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuAnimationDirector : MonoBehaviour {
    public Text contentSectionTitle;
    public GameObject contentSectionContent;

    public GameObject singleplayerContentPrefab;
    public string singleplayerContentTitle;

    public GameObject settingsContentPrefab;
    public string settingsContentTitle;

    private Animator mainMenuAnimator;

    // Use this for initialization
    void Start () {
        mainMenuAnimator = gameObject.GetComponent<Animator>();
	}

    private void SwitchToContent(GameObject prefab, string contentTitle)
    {
        contentSectionTitle.text = contentTitle;
        GameObject.Instantiate(prefab, contentSectionContent.transform, false);
    }
	
	public void HideMainMenu()
    {
        mainMenuAnimator.SetTrigger("Hide");
    }

    public void ShowMainMenu()
    {
        mainMenuAnimator.SetTrigger("Show");
    }

    public void ShowSingleplayer()
    {
        HideMainMenu();
        mainMenuAnimator.SetTrigger("Singleplayer");
    }

    public void ShowSettings()
    {
        HideMainMenu();
        mainMenuAnimator.SetTrigger("Settings");
    }

    public void SwitchToSingleplayer()
    {
        SwitchToContent(singleplayerContentPrefab, singleplayerContentTitle);
        ShowSingleplayer();
    }

    public void SwitchToSettings()
    {
        SwitchToContent(settingsContentPrefab, settingsContentTitle);
        ShowSettings();
    }
}
