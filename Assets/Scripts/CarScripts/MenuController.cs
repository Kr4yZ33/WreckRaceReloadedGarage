using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject menu;
    
    public void EnableMenu()
    {
        menu.SetActive(true);
    }

    public void DisableMenu()
    {
        menu.SetActive(false);
    }
}
