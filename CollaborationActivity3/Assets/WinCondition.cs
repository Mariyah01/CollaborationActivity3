using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TextMeshProUGUI;
    
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(PlayerWin());
    }
    
    IEnumerator PlayerWin()
    {
        TextMeshProUGUI.enabled = true;
        TextMeshProUGUI.text = "Thank you for not burning!";
        yield return new WaitForSeconds(2f);
        TextMeshProUGUI.enabled = false;
        SceneManager.LoadScene(0);
    }
}
