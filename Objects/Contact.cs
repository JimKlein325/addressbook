public class Contact
{
	private string _name;
	private string _phoneNumber;
	private Address _address;
	private int _id;
	private static List<Contact> _contacts = new List<Contact> { };
	public Contact(string name, string phoneNumber, Address address)
	{
		_name = name;
		_phoneNumber = phoneNumber;
		_address = address;

		_id = _contacts.Count;
	}
	public void SetName(string newName)
	{
		_name = newName;
	}
	public string GetName()
	{
		return _name;
	}
	public void SetPhoneNumber(string newPhoneNumber)
	{
		_name = newPhoneNumber;
	}
	public string GetPhoneNumber()
	{
		return _phoneNumber;
	}
	public void SetAddress(Address newAddress)
	{
		_address = newAddress;
	}
	public Address GetAddress()
	{
		return _address;
	}
	public static List<Contact> GetAll()
	{
		return _contacts;
	}
	public static void Save(Contact contact)
	{
		_contacts.Add(contact);
	}
	public static void DeleteAll()
	{
		_contacts.Clear();
  }
}
