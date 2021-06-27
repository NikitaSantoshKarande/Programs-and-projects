package com.doctor.adminController;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RestController;

import com.doctor.model.Contact;
import com.doctor.service.ContactService;

@RestController
public class ContactController {

	@Autowired
	private ContactService contactService;

	@GetMapping(path = "/get-contact-list", produces = "application/json")
	public List<Contact> getContactsList() {
		return contactService.getContactList();
	}

	@PostMapping(path = "/get-contact-by-id", produces = "application/json")
	public Contact getContactById(Long id) {
		return contactService.getContactById(id);
	}

	@DeleteMapping(path = "/delete-contact-by-id", produces = "application/json")
	public void deleteContactById(Long id) {
		contactService.deleteContactById(id);
	}

	@PostMapping(path = "/create-contact", produces = "application/json")
	public Contact createContact(Contact Contact) {
		return contactService.saveContact(Contact);
	}

	@PutMapping(path = "/update-contact", produces = "application/json")
	public Contact updateContact(Contact contact) {
		
		Contact contact1 = contactService.getContactById(contact.getId());
		contact1.setStatus(contact.getStatus());
		return contactService.saveContact(contact1);

	}

}
