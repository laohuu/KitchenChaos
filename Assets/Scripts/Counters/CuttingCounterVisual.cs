using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingCounterVisual : MonoBehaviour
{
    private const string CUT = "Cut";

    [SerializeField] private CuttingCounter cuttingCounter;
    private Animator animator;
    private static readonly int Cut = Animator.StringToHash(CUT);

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        cuttingCounter.OnCut += CuttingCounterOnCut;
    }

    private void CuttingCounterOnCut(object sender, EventArgs e)
    {
        animator.SetTrigger(Cut);
    }
}