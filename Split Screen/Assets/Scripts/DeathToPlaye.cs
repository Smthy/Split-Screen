using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathToPlaye : MonoBehaviour
{
    public void Start()
    {
        Time.timeScale = 1f;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Time.timeScale = 1f;
            Destroy(gameObject);
        }
    }

}
