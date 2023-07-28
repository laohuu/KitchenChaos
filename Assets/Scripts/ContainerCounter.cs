using System;
using UnityEngine;

public class ContainerCounter : BaseCounter
{
    public event EventHandler OnPlayerGrabbedObject;

    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public override void Interact(Player player)
    {
        if (player.HasKitchenObject()) return;
        // Player is not carrying anything
        KitchenObject.SpawnKitchenObject(kitchenObjectSO, player);
        OnPlayerGrabbedObject?.Invoke(this, EventArgs.Empty);
    }
}