public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    
    public Address()
    {

    }
    public Address(string streetAddress,string city,string state,string country)
    {
        _streetAddress=streetAddress;
        _city=city;
        _state=state;
        _country=country;
    }
    public void SetStreetAddress(string streetAddress)
    {
        _streetAddress=streetAddress;
    }
    public void SetCity(string city)
    {
        _city=city; 
    }
    public void SetState(string state)
    {
        _state=state;
    }
    public void SetCountry(string country)
    {
        _country=country;
    }
    public string GetStreetAddress()
    {
        return _streetAddress;
    }
    public string GetCity()
    {
        return _city;
    }
    public string GetState()
    {
        return _state;
    }
    public string GetCountry()
    {
        return _country;
    }

    public string GetDisplayText()
    {
        string DisplayText;
        DisplayText=$"{_streetAddress},{_city},{_state},{_country}" ;  
        return DisplayText;
    }

    public bool USAOrNot()
    {
        bool USA;
        if (_country.ToLower() == "usa")
        {
            USA=true;
        }
        else
        {
            USA=false;
        }
        return USA;
    }
}