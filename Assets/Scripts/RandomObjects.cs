using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjects : MonoBehaviour
{
    public GameObject[] _obstacles = default;

    private void Start() 
    {
        SpawnRandom();    
    }

    private void SpawnRandom()
    {
        int last = 0;                   
         for (int i = 0; i < 10; i++)
         {
             int num = Random.Range(0, 10);
            while (num == last)                        
                 num = Random.Range(0, 10);  
                 StartCoroutine(Wait());       
             _obstacles[num].SetActive(true);
             last = num;
         }
    }

    IEnumerator Wait() 
    {
        yield return new WaitForSeconds(2f);
    }
}
