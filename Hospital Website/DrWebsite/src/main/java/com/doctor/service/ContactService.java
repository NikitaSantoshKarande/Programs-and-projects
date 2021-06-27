package com.doctor.service;

import java.util.Date;
import java.util.List;

import javax.transaction.Transactional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.doctor.model.Contact;
import com.doctor.repository.ContactRepository;

@Service
@Transactional
public class ContactService {
	
	@Autowired
	private ContactRepository contactRepository;
	
	public List<Contact> getContactList(){
		return contactRepository.findAll();
	}
	
	public Contact getContactById(Long id){
		return contactRepository.findContactById(id);
	}
	
	public void deleteContactById(Long id) {
		contactRepository.deleteById(id);
	}

	public Contact saveContact(Contact contact) {
		return contactRepository.save(contact);
	}
	
	public Contact updateContact(Contact contact) {
		return contactRepository.save(contact);
	}
	
	public Long getContactByDate(Date date)
	{
		return contactRepository.getCountByContactDate(date);
	}
	
	public Long getTotalContact()
	{
		return contactRepository.getCount();
	}
}
