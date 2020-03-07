using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleQuest : Quest
{
    // Start is called before the first frame update
    void Start()
    {
        QuestName = "Test Quest";
        Description = "Testing gather quest";

        Goals.Add(new GatherGoal(this, "item", "Gather X", false, 0, 2));

        Goals.ForEach(g => g.Init());
    }

}
