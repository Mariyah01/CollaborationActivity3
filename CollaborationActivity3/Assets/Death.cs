using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI TextMeshProUGUI;
    
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(FellIntoLava());
        StartCoroutine(Waitfor());
    }

    IEnumerator FellIntoLava()
    {
        TextMeshProUGUI.enabled = true;
        TextMeshProUGUI.text = "YOU DIED!";
        yield return new WaitForSeconds(1f);
        TextMeshProUGUI.enabled = false;
    }
    
    IEnumerator Waitfor()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
