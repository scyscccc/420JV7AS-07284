using UnityEngine;
using UnityEngine.UI;

public class InventoryView : MonoBehaviour
{
    private Text textComponent;

    void Awake()
    {
        textComponent = GetComponent<Text>();
    }

    void Update()
    {
        textComponent.text = Inventory.GetInstance().GetItemNames();
    }
}
