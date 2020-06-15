using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COMA : MonoBehaviour
{
    public GameObject TitleMenu;
    public GameObject Options;
    // Start is called before the first frame update
    void Start()
    {
        TitleMenu.SetActive(true);
        Options.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void CallOptions()    {        Invoke("CallOptions2", 0.2f);
        //TitleMenu.SetActive(false);
        //Options.SetActive(true);
    }    public void CallOptions2()    {
        //  invoke(CallOptions2, 0.2f);
        TitleMenu.SetActive(false);        Options.SetActive(true);    }    public void CallTitleMenu()    {        Invoke("CallTitleMenu2", 0.2f);
        //  TitleMenu.SetActive(true);
        //Options.SetActive(false);
        Debug.Log("koko");    }    public void CallTitleMenu2()    {
        //Invoke("CallTitleMenu", 0.2f);
        TitleMenu.SetActive(true);        Options.SetActive(false);        Debug.Log("koko");    }
}
