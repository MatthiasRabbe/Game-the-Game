﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControler : MonoBehaviour
{
    [SerializeField]
    private string panelName;

    public GameObject panel;
    public KeyCode interactKey;

    private void OnGUI()
    {
        panelName = panel.name;
    }

  




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(interactKey))
        {
            if (panel.activeSelf)
            {
                panel.SetActive(false);
               
            }
            else
            {
                panel.SetActive(true);
               
            }

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Close(this.panel);
        }
    }
    public void Close(GameObject panelToClose)
    {
        panelToClose.SetActive(false);
    }


}
