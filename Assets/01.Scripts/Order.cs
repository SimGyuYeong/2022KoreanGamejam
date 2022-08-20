using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order : MonoBehaviour
{
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
        order *= 10;

        Renderer renderer = GetComponent<Renderer>();
        renderer.sortingLayerName = _sortingLayerName;
        renderer.sortingOrder = order;
    }
}
