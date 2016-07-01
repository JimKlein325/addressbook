using Nancy;
using System.Collections.Generic;
using AddressBook.Objects;

namespace AddressBook
{
  using AddressBook.Objects;

  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        var contacts = Contact.GetAll();
        return View["index.cshtml", contacts];
      };

      Get["/contacts/new"] = _ => {
        return View["contact_form.cshtml"];
      };

      Post["/contacts/new"] = _ => {
        var address = new Address(
          Request.Form["street"],
          Request.Form["city"],
          Request.Form["state"],
          Request.Form["zip"]
        );
        var contact = new Contact(
          Request.Form["name"],
          Request.Form["phoneNumber"],
          address
        );
        Contact.Save(contact);
        return View["contact-created.cshtml", contact];
      };
      Get["/contacts/{id}"] = parameters => {
        Contact contact = Contact.Find(parameters.id);
        return View["contact-details.cshtml", contact];
      };
      Get["/contacts/deleteAll"] = _ => {
        var contacts = Contact.GetAll();
        return View["delete-contacts-form.cshtml", contacts];
      };

      Post["/contacts/deleteAll"] = _ => {
        Contact.DeleteAll();
        return View["contacts-deleted.cshtml"];
      };
    }
  }
}
