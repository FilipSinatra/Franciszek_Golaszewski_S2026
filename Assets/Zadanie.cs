using System.Collections;
using System.Collections.Generic;
using System.Data;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Zadanie : MonoBehaviour
{
    // Start is called before the first frame update


    List<int> dane = new List<int> { 1, 3, 3, 1, 2, 2, 3, 1, 3, 2 };
    List<int> jedynki = new List<int>();
    List<int> dwojki = new List<int>();
    List<int> trojki = new List<int>();


    void Start()
    {
        foreach (int i in dane)
        {   
            if (i == 1)
            {
                jedynki.Add(i);
                
            }
            else if (i == 2)
            {
                dwojki.Add(i);

            }
            else if (i == 3)
            {
                trojki.Add(i);


            }

            
        }

        dane.Clear();

        Debug.Log("Jedyneczki: " + jedynki.Count);
        Debug.Log("Dwojeczki: " + dwojki.Count);
        Debug.Log("Trojeczki: " + trojki.Count);
        Debug.Log("Dane: " + dane.Count);
    }
    
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
