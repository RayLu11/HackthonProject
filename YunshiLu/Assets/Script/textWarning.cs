using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textWarning : MonoBehaviour
{
    public Text textManage;
    // Start is called before the first frame update
    void Start()
    {
        textManage.enabled = false;
    }

    public void whenClick(Text textManage)
    {
        textManage.enabled = true;
    }
}
