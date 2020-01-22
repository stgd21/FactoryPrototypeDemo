using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class factoryClient : MonoBehaviour
{
    public NPCSpawner m_SpawnerNPC;
    public static int count = 0;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            m_SpawnerNPC.SpawnVillagers();
            count++;
        }
            
    }
}
