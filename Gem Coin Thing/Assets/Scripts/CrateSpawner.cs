using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateSpawner : MonoBehaviour
{
    public GameObject cratePrefab;

    public int amountOfCratesToSpawn;
    //What the fuck Justin how could you do this, I trusted you, you were like a brother to me. You have betrayed my trust and lost my loyalty simultaniously. I hope you feel regret, but I doubt a lowlife such as yourself could feel such things

    private void Start()
    {
      for(int i = 0; i < amountOfCratesToSpawn; i++)
      {
         Instantiate(cratePrefab, transform.localPosition, Quaternion.identity, this.transform);
      }
    }
    
}
