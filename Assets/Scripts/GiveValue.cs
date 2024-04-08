using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiveValue : MonoBehaviour
{
    [SerializeField] Text myText;

    public void Start()
    {
        string newText = StaticData.valueToKeep;
        myText.text = newText;
    }
}
