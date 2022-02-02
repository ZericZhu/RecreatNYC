using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ClassDemo : MonoBehaviour
{
    [SerializeField]
    private TMP_Text This_Text;

    void Start()
    {
        This_Text = this.GetComponent<TMP_Text>();
        This_Text.text = "22222";
    }


    void Update()
    {
        
    }
}
