using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    public GameObject helppanel;
    public GameObject mainpanel;
    public GameObject optionspanel;
    public void HelpGo()
    {
        helppanel.SetActive(true);
        mainpanel.SetActive(false);
        optionspanel.SetActive(false);

    }
    public void Back()
    {
        helppanel.SetActive(false);
        mainpanel.SetActive(true);
        optionspanel.SetActive(false);
    }
    public void Options()
    {
        optionspanel.SetActive(true);
        helppanel.SetActive(false);
        mainpanel.SetActive(false);
    }
}
