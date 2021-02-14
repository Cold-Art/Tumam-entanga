using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] GameObject placeholderPrefab = default;
    [SerializeField] LayerMask tileMask = default;

    private bool isBuyingBasicTower;
    private GameObject placeholder;

    private void Update()
    {
        if (isBuyingBasicTower)
            SetPlaceHolder();
    }

    private void SetPlaceHolder()
    {
        //Instanciar placeholder si no existe
        if (placeholder == null)
            placeholder = Instantiate(placeholderPrefab, new Vector3(0f, 100f, 0f), Quaternion.identity);

        //Colocar el placeholder arriba de un tile
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        Debug.DrawRay(ray.origin, ray.direction * 100f, Color.red);

        if (Physics.Raycast(ray, out hit, 100f, tileMask))
        {
            placeholder.transform.position = hit.point;
        }
        else
        {
            placeholder.transform.position = new Vector3(0f, 100f, 0f);
        }
    }

    public void BuyBasicTower()
    {
        isBuyingBasicTower = true;
    }
}