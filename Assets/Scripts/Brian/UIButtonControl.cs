using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIButtonControl : MonoBehaviour
{
    [SerializeField] UIManager UIManage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Restart()
    {
        //SceneManager.LoadScene(); RELOAD SCENE
    }
    public void StartGame()
    {
        UIManage.start = false;
        UIManage.pausedGame = false;
    }
}
