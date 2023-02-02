using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIPlayerMoveSpeed : MonoBehaviour
{

    [SerializeField] private Rigidbody rb;

    private TextMeshProUGUI TextMeshProUGUI;

    private void Awake()
    {
        TextMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI.text = "Speed: " + rb.velocity.magnitude;
    }
}
