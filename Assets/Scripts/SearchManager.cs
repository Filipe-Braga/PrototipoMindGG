using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchManager : MonoBehaviour
{
 public MonoBehaviour scriptParaAtivar; 

    public void AtivarScript()
    {
        if (scriptParaAtivar != null)
        {
            scriptParaAtivar.enabled = true; 
        }
    }

}
