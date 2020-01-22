using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public NPCFactory m_Factory;

    private INPC m_Farmer;
    private INPC m_Beggar;
    private INPC m_ShopOwner;
    private INPC m_QuestGiver;

    public void SpawnVillagers()
    {
        m_Beggar = m_Factory.getNPC(NPCType.Beggar);
        m_Farmer = m_Factory.getNPC(NPCType.Farmer);
        m_ShopOwner = m_Factory.getNPC(NPCType.Shopowner);
        m_QuestGiver = m_Factory.getNPC(NPCType.QuestGiver);

        m_Beggar.Speak();
        m_Farmer.Speak();
        m_ShopOwner.Speak();
        m_QuestGiver.Speak();
    }
}
