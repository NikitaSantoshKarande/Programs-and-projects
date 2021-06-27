package com.doctor.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.doctor.model.User;

@Repository
public interface UserRepository extends JpaRepository<User, Long>{

	User findByEmailAndPassword(String email,String password);
	
	Boolean existsByEmail(String email);
	
}
