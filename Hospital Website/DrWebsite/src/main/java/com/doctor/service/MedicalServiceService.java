package com.doctor.service;

import java.util.List;

import javax.transaction.Transactional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.doctor.model.MedicalService;
import com.doctor.repository.MedicalServiceRepository;

@Service
@Transactional
public class MedicalServiceService {
	
	@Autowired
	private MedicalServiceRepository medicalServiceRepository;
	
	public List<MedicalService> getMedicalServiceList(){
		return medicalServiceRepository.findAll();
	}
	
	public MedicalService getMedicalServiceById(Long id){
		return medicalServiceRepository.findById(id).get();
	}
	
	public void deleteMedicalServiceById(Long id) {
		 medicalServiceRepository.deleteById(id);
	}

	public MedicalService saveMedicalService(MedicalService medicalService) {
		return medicalServiceRepository.save(medicalService);
	}
	
	public MedicalService updateMedicalService(MedicalService medicalService) {
		return medicalServiceRepository.save(medicalService);
	}
	
	
}
