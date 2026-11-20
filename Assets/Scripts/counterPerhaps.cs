using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class counterPerhaps : MonoBehaviour
{
   
    public TextMeshProUGUI countText;

    
    public int countNumber;
    private int countNumberTarget;
   
    // Start is called before the first frame update
    void Start()
    {
        countNumber = 0;
    }
// Update is called once per frame
    void Update()
    {   
    }
    public void Count()
    {
        countNumber++;

        countText.text = countNumber.ToString();
    }
 
}
