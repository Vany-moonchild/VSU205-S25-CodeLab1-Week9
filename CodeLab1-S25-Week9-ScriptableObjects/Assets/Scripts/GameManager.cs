using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public LocationScriptableObject currentLocation;
    public TextMeshProUGUI title;
    public TextMeshProUGUI description;
    
    public Button northButt;
    public Button eastButt;
    public Button southButt;
    public Button westButt;
    
    public Image image;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // UpdateLocation();
        currentLocation.UpdateUI(this);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void MoveDirection(int dir)
    {
        switch (dir)
        {
            //scriptable objects are persistant - it will remember where you were.
            case 0:
                //set our norths southern location to the current location
                    // currentLocation.north.south = currentLocation;
                //move our current location to be the location north of here
                currentLocation = currentLocation.north;
                break;
            case 1:
                currentLocation = currentLocation.east;
                break;
            case 2:
                currentLocation = currentLocation.south;
                break;
            case 3:
                currentLocation = currentLocation.west;
                break;
            default:
                Debug.Log("The location: " + dir + " is not implemented.");
                break;
            
        }
        
        currentLocation.UpdateUI(this);
        
        // if (dir == 0) //0 is north
        // {
        //     currentLocation = currentLocation.north;
        //     currentLocation.UpdateUI(this);
        // }
    }

    // public void UpdateLocation()
    // {
    //     title.text = currentLocation.locationName;
    //     description.text = currentLocation.locationDesc;
    // }
    
}
