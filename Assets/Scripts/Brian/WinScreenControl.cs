using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScreenControl : MonoBehaviour
{
    [SerializeField] UIManager UIManage;
    [SerializeField] GameObject player1WinScreen;
    [SerializeField] GameObject player2WinScreen;
    // Update is called once per frame
    void Update()
    {
        if (UIManage.wonPlayer == 1)
        {
            player1WinScreen.SetActive(true);
        }
        else
        {
            player2WinScreen.SetActive(true);
        }
    }
}
