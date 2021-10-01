using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUI : MonoBehaviour
{
    [SerializeField] private Text Healthtext;
 
    
    public void UpdateUI(float lives) {
        Healthtext.text = "Player Lives " + lives.ToString();
    }
}
