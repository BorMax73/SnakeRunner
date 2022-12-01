using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodScript : MonoBehaviour
{
    [SerializeField]
    private int _foodValue;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
    }
    public void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Player"))
        {
            Debug.Log("Food");
            EventManager.OnFoodGet?.Invoke(_foodValue);
            Destroy(this.gameObject);
        }
    }
    public int GetFoodValue()
    {
        return _foodValue;
    }
}
