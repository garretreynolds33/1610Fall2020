using System;
using UnityEngine;
using UnityEngine.UI;

public class CollectCash : MonoBehaviour
{
    public IntData cashTotal;
    public Collectible collectibleObj;
    public Text txtObj;
    private SpriteRenderer renderer;

    private void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        renderer.sprite = collectibleObj.art;
        renderer.color = collectibleObj.artColor;
        txtObj.text = cashTotal.value.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        cashTotal.value += collectibleObj.cashValue;
        txtObj.text = cashTotal.value.ToString();
        gameObject.SetActive(false);
    }
}
