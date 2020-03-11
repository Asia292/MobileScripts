using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUIDetails : MonoBehaviour
{
    Item item;
    Button selectedItemButton, itemInteractButton;
    Text itemNameText, itemDescriptionText, itemInteractButtonText;

    void Start()
    {
        itemNameText = transform.FindChild("Item_Name").GetComponent<Text>();
        itemDescriptionText = transfrom.FindChild("Item_Desciption").GetComponent<Text>();
        itemInteractButton = transform.FindChild("Button").GetComponent<Button>();
        itemInteractButtonText = itemInteractButton.transfrom.FindChild("Text").GetComponent<Text>();
    }

    public void SetItem(Item item, Button selectedButton)
    {
        itemInteractButton.onClick.RemoveAllListeners();

        this.item = item;
        selectedItemButton = selectedItemButton;
        itemNameText.text = item.ItemName;
        itemDescriptionText.text = item.Description;
        itemInteractButtonText.text = item.ActionName;

        itemInteractButton.onClick.AddListener(OnItemInteract);
    }

    public void OnItemInteract()
    {
        if (item.ItemType == Item.ItemTypes.Tool)
        {
            InventoryController.Instance.EquipItem(item);
            Destroy(selectedItemButton.gameObject);
        }
        else if (item.ItemType == item.ItemTypes.Quest)
        {

        }
    }
}
