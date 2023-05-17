using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] UIManager UIManage;
    [SerializeField] GameObject startScreen;
    [SerializeField] GameObject finishScreen;
    [SerializeField] GameObject pauseScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (UIManage.start)
        {
            startScreen.SetActive(true);
            pauseScreen.SetActive(false);
            finishScreen.SetActive(false);
        }
        else if (UIManage.finished)
        {
            finishScreen.SetActive(true);
            pauseScreen.SetActive(false);
            startScreen.SetActive(false);
        }
        else
        {
            pauseScreen.SetActive(true);
            startScreen.SetActive(false);
            finishScreen.SetActive(false);
        }

    }
}
