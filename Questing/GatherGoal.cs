using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatherGoal : Goal
{

    public string ItemID { get; set; }

    public GatherGoal(Quest quest, string itemID, string description, bool completed, int currAmount, int reqAmount)
    {
        this.Quest = quest;
        this.ItemID = itemID;
        this.Description = description;
        this.Completed = completed;
        this.CurrAmount = currAmount;
        this.ReqAmount = reqAmount;
    }

    public override void Init()
    {
        base.Init();
        UIEventHandler.OnItemAdded += ItemGathered;
    }

    void ItemGathered(Item item)
    {
        if(item.ObjectSlug == this.ItemID)
        {
            this.CurrAmount++;
            Eval();
        }
    }
}
