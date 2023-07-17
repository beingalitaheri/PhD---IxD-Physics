using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUI : MonoBehaviour
{
    [Header("( Choose Mode : )")]
    public bool _OpenHandUI,_OpenMainMenu;
    bool _Open;
    //
    public GameObject _HandMenu;
    //
    public void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "FingerTip") 
        {
            if (_Open) 
            {
                _Open = false;
                if (_OpenHandUI)
                {
                    _HandMenu.SetActive(false);
                }
                else if ( _OpenMainMenu )
                {
                    MainUI MUI = FindObjectOfType<MainUI>();
                    MUI.CloseUI();
                }
                 GetComponent<ButtonClick>()._ButtonClicked();
            }
            else 
            {
                _Open = true;
                if (_OpenHandUI)
                {
                    _HandMenu.SetActive(true);
                }
                else if (_OpenMainMenu)
                {
                    MainUI MUI = FindObjectOfType<MainUI>();
                    MUI.OpenUI();
                }
                GetComponent<ButtonClick>()._ButtonClicked();

            }
        }
    }
    //
}
