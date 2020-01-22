using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCFactory : MonoBehaviour
{
    public INPC getNPC(NPCType type)
    {
        switch (type)
        {
            case NPCType.Beggar:
                INPC beggar = new Beggar();
                return beggar;
            case NPCType.Farmer:
                INPC farmer = new Farmer();
                return farmer;
            case NPCType.Shopowner:
                INPC shopowner = new ShopOwner();
                return shopowner;
            case NPCType.QuestGiver:
                INPC questgiver = new QuestGiver();
                return questgiver;
        }
        return null;
    }
}
