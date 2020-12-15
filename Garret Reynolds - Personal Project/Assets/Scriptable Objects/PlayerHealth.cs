using UnityEngine;

[CreateAssetMenu]

public class PlayerHealth : ScriptableObject
{
    
    public float value;

    public void UpdateValue(float number)
    {
        value += number;
        Debug.Log(value);
    }
}
