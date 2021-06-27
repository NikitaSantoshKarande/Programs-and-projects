package com.doctor.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.doctor.model.MedicalService;

@Repository
public interface MedicalServiceRepository extends JpaRepository<MedicalService, Long>{

	
	

}
