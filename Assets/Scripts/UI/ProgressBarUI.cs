using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBarUI : MonoBehaviour
{
    [SerializeField] private GameObject hasProgressGameObject;
    [SerializeField] private Image barImage;

    private IHasProgress iHasProgress;

    private void Start()
    {
        iHasProgress = hasProgressGameObject.GetComponent<IHasProgress>();
        iHasProgress.OnProgressChanged += CuttingCounterOnOnProgressChanged;
        barImage.fillAmount = 0f;
        Hide();
    }

    private void CuttingCounterOnOnProgressChanged(object sender, IHasProgress.OnProgressChangedEventArgs e)
    {
        barImage.fillAmount = e.progressNormalized;

        if (e.progressNormalized is <= 0f or >= 1f)
        {
            Hide();
        }
        else
        {
            Show();
        }
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}