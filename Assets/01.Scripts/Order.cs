using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order : MonoBehaviour
{
    [SerializeField] private Renderer[] backRenderers;
    [SerializeField] private Renderer[] middleRenderers;
    [SerializeField] private string _sortingLayerName;
    public int originOrder;

    public void SetOriginOrder(int originOrder)
    {
        this.originOrder = originOrder;
        SetOrder(originOrder);
    }

    public void SetMostFrontOrder(bool isMostFront)
    {
        SetOrder(isMostFront ? 100 : originOrder);
    }


    public void SetOrder(int order)
    {
        int mulOrder = order * 10;

        foreach(var renderer in backRenderers)
        {
            renderer.sortingLayerName = _sortingLayerName;
            renderer.sortingOrder = mulOrder;
        }


        foreach (var renderer in middleRenderers)
        {
            renderer.sortingLayerName = _sortingLayerName;
            renderer.sortingOrder = mulOrder + 1;
        }
    }
}
