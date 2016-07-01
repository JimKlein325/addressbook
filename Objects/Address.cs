namespace AddressBook.Objects
{
  public class Address
  {
    private string _street;
    private string _city;
    private string _state;
    private string _zip;

    public Address(string street, string city, string state, string zip)
    {
      _street = street;
      _city = city;
      _state = state;
      _zip = zip;
    }
    public void SetStreet(string newStreet)
    {
      _street = newStreet;
    }
    public string GetStreet()
    {
      return _street;
    }
    public void SetCity(string newcity)
    {
      _city = newcity;
    }
    public string GetCity()
    {
      return this._city;
    }
    public void SetState(string newState)
    {
      _state = newState;
    }
    public string GetState()
    {
      return _state;
    }
    public void SetZip(string newZip)
    {
      _zip = newZip;
    }
    public string GetZip()
    {
      return _zip;
    }
  }
}
