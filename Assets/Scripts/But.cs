using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Experimental.UIElements;

public class But : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   public void promeniText() {
        TextMeshPro[] niz = GameObject.FindObjectsOfType<TextMeshPro>();
        InputField f = GameObject.FindObjectOfType<InputField>();

       /* for (int i = 0; i < niz.Length; i+=3)
        {
            if (niz[i].text == "")
            {
                
                niz[i].SetText(f[0].text);
                niz[i+1].SetText(f[1].text);
                niz[i+2].SetText(f[2].text);
                break;
            }
        }
        */
       foreach(var i in niz) {
            if (i.text == "")
            {   

                i.SetText(f.text);
                break;
            }
            

        }
        
    }
}
