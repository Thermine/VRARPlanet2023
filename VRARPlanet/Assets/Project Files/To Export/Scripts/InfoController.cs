using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoController : MonoBehaviour
{

    
    [SerializeField]
    private GameObject _partic;

    [SerializeField]
    private GameObject _light;

    public void Right()
    {
        _partic.SetActive(true);
        _light.SetActive(true);
        
    }


}
