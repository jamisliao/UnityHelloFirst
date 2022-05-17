using System;
using Models;
using Newtonsoft.Json;
using UnityEngine;

namespace Jamis.SDK.HelloFirst.Scripts
{
    public class HelloFirst : MonoBehaviour
    {
        void Start()
        {
            Debug.Log("Hello First.");
            
            var product = new Product
                          {
                              Name = "Macbook",
                              Price = 2999.99m,
                              ID = Guid.NewGuid()
                          };
            var jsonStr = JsonConvert.SerializeObject(product);
            Debug.Log(jsonStr);
        }
    }
}