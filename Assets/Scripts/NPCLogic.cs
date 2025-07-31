using UnityEngine;

public class NPCLogic : MonoBehaviour
{
    // Variable of the npc speed
    public float nPCSpeed;
    private bool isGameActive;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isGameActive = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // Every frame the NPC go forward with a special speed
        transform.Translate(Vector3.forward * nPCSpeed * Time.deltaTime);
    }
}
