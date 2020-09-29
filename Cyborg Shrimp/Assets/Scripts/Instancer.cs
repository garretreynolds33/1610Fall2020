using System.Collections;
using UnityEngine;

public class Instancer : MonoBehaviour
{
    public GameObject prefab;
    public float delay = 2f;
    
    IEnumerator Start()
    {
        while (true)
        {
            Instantiate(prefab);
            yield return new WaitForSeconds(delay);
        }
        
    }
}
