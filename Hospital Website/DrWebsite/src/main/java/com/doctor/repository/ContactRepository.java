package com.doctor.repository;

import java.util.Date;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.stereotype.Repository;

import com.doctor.model.Contact;

@Repository
public interface ContactRepository extends JpaRepository<Contact, Long>{

	Contact findContactById(Long id);

	@Query(value = "SELECT COUNT(*) FROM Contact WHERE contactDate=:date")
	Long getCountByContactDate(Date date);
	
	@Query(value = "SELECT COUNT(*) FROM Contact")
	Long getCount();
}
