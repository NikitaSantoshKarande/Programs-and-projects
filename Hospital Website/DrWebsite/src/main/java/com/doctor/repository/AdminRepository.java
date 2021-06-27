package com.doctor.repository;

import java.util.Optional;

import org.springframework.data.jpa.repository.JpaRepository;

import com.doctor.model.Admin;

public interface AdminRepository extends JpaRepository<Admin, Long> {
	
	Admin findByEmailAndPassword(String email,String password);

	Optional<Admin> findById(Long id);
	
	Admin findByEmail(String email);
	
	Boolean existsByEmailAndPassword(String email,String password);
}
