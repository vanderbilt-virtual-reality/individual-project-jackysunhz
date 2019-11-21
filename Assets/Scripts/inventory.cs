using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    private const int MAX_ITEM_COUNT = 4;
    [SerializeField] private Transform player;
    private Vector3 posOffset;
    private GameObject[] itemList = new GameObject[MAX_ITEM_COUNT];
    [SerializeField] private Transform[] Slots;
    private int curItemCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        posOffset = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + posOffset;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obtainable")
        {
            AddItem(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Obtainable")
        {
            RemoveItem(other.gameObject);
        }
    }

    private void AddItem(GameObject item)
    {
        if(curItemCount >= MAX_ITEM_COUNT)
        {
            Debug.Log("Inventory Full!");
            return;
        }

        item.GetComponent<Rigidbody>().isKinematic = true;
        item.transform.SetParent(transform);
        item.transform.position = Slots[curItemCount].position;
        item.transform.localScale = new Vector3(2,2,2);
        curItemCount++;
    }

    private void RemoveItem(GameObject item)
    {
        item.transform.parent = null;
        item.transform.localScale = new Vector3(.2f,.2f,.2f);
        item.transform.position += new Vector3(0, 2, 0);
        item.GetComponent<Rigidbody>().isKinematic = false;
        curItemCount--;
    }
}
