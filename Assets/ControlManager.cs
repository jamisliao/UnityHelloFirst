using System;
using System.Collections;
using System.Collections.Generic;
using Models;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.UI;

public class ControlManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _hwBtn;
    
    [SerializeField]
    private GameObject _jsonBtn;
    
    [SerializeField] 
    private InputField _inputField;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void JsonBtnClick()
    {
        var tmp = new Product
                  {
                      Name = "Mac book",
                      Price = 2999.99m,
                      ID = Guid.NewGuid()
                  };
        
        var jsonStr = JsonConvert.SerializeObject(tmp);
        _inputField.text = jsonStr;
        
    }
    
    public void HwBtnClick()
    {
        Debug.Log("Hello World.");
    }
}
