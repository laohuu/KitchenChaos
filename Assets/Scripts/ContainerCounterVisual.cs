using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerCounterVisual : MonoBehaviour
{
    private const string OPEN_CLOSE = "OpenClose";

    [SerializeField] private ContainerCounter container;
    private Animator animator;
    private static readonly int OpenClose = Animator.StringToHash(OPEN_CLOSE);

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        container.OnPlayerGrabbedObject += OnPlayerGrabbedObject;
    }

    private void OnPlayerGrabbedObject(object sender, EventArgs e)
    {
        animator.SetTrigger(OpenClose);
    }
}