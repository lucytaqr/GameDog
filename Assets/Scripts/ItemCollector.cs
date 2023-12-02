using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollection : MonoBehaviour
{

    public int cherries = 0;
    public GameObject Finish;
    public GameObject FinishText;

    [SerializeField] private TMP_Text cherriesText;

    [SerializeField] private AudioSource collectionSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            cherries--;
            cherriesText.text = "Score : " + cherries;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (cherries != 0)
        {
            Finish.SetActive(false);
            FinishText.SetActive(false);
        }
        else
        {
            Finish.SetActive(true);
            FinishText.SetActive(true);
        }
    }
}
