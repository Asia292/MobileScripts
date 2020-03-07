using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal
{
    public Quest Quest { get; set; }
    public string Description { get; set; }
    public bool Completed { get; set; }
    public int CurrAmount { get; set; }
    public int ReqAmount { get; set; }

    public virtual void Init()
    {

    }

    public void Eval()
    {
        if (CurrAmount >= ReqAmount)
        {
            Complete();
        }
    }

    public void Complete()
    {
        Quest.CheckGoals();

        Completed = true;
    }
}
