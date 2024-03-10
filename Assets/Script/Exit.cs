using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    [SerializeField] GameObject QuitPanel;
    public void QuitGame()
    {
        Application.Quit();
    }

    public void OpenAreYouSure()
    {
        QuitPanel.SetActive(true);
    }

    public void CloseAreYouSure()
    {
        QuitPanel.SetActive(false);
    }
}
