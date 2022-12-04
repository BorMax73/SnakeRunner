using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodScript : MonoBehaviour
{
    [SerializeField]
    private int _foodValue;

    [SerializeField]
    private ParticleSystem particleSystem;
    
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
            var particle = Instantiate(particleSystem, transform.position, Quaternion.identity);
            Destroy(particle.gameObject, 1.0f);
            Destroy(transform.parent.gameObject, 0.1f);
            Destroy(this.gameObject);
        }
    }
    public int GetFoodValue()
    {
        return _foodValue;
    }
    public void OnDestroy()
    {
        
        Debug.Log("Food Destroyed");
        
    }
}
