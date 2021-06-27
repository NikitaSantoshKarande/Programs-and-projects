package com.doctor.adminController;

import java.io.File;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.List;

import javax.servlet.ServletOutputStream;
import javax.servlet.http.HttpServletResponse;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.multipart.MultipartFile;

import com.doctor.model.MedicalService;
import com.doctor.service.MedicalServiceService;

@RestController
public class MedicalServiceController {
	
	@Autowired
	private MedicalServiceService medicalServiceService;
	
	String uploadMedicalServiceDirectory = System.getProperty("user.dir") + "/uploads/medical-service/";
	
	@GetMapping(path = "/get-medical-services-list", produces = "application/json")
	public List<MedicalService> getMedicalServicesList(){
		return medicalServiceService.getMedicalServiceList();
	}
	
	@PostMapping(path = "/get-medical-service-by-id", produces = "application/json")
	public MedicalService getMedicalServiceById(Long id){
		return medicalServiceService.getMedicalServiceById(id);
	}
	
	@DeleteMapping(path = "/delete-medical-service-by-id", produces = "application/json")
	public void deleteMedicalServiceById(Long id){
		 medicalServiceService.deleteMedicalServiceById(id);
	}
	
	
	@PostMapping(path = "/create-medical-service", consumes = { "multipart/form-data" }, produces = "application/json")
	public MedicalService createMedical(MedicalService medicalService, BindingResult bindingResult,
			@RequestParam("serviceImage") MultipartFile serviceImage) {

			
			File f = new File(uploadMedicalServiceDirectory);
			if (!f.exists()) {
				f.mkdirs();
			}
			
			
			if (!serviceImage.isEmpty()) {
				String dateName = new SimpleDateFormat("yyyyMMddHHmm").format(new Date());
				String originalFileName = dateName + "-"
						+ serviceImage.getOriginalFilename().replace(" ", "-").toLowerCase();
				Path fileNameAndPath = Paths.get(uploadMedicalServiceDirectory, originalFileName);
				try {
					Files.write(fileNameAndPath, serviceImage.getBytes());
				} catch (IOException e) {
					e.printStackTrace();
				}
				medicalService.setServiceImage(originalFileName);
				
			}
			else
			{
				medicalService.setServiceImage("");
			}
			
			return medicalServiceService.saveMedicalService(medicalService);
			
	}

	
	
	@PutMapping(path = "/update-medical-service", consumes = { "multipart/form-data" }, produces = "application/json")
	public MedicalService updateMedicalService(MedicalService medicalService, BindingResult bindingResult,
			@RequestParam("serviceImage") MultipartFile serviceImage) {

			
			File f = new File(uploadMedicalServiceDirectory);
			if (!f.exists()) {
				f.mkdirs();
			}
			
			
			if (!serviceImage.isEmpty()) {
				String dateName = new SimpleDateFormat("yyyyMMddHHmm").format(new Date());
				String originalFileName = dateName + "-"
						+ serviceImage.getOriginalFilename().replace(" ", "-").toLowerCase();
				Path fileNameAndPath = Paths.get(uploadMedicalServiceDirectory, originalFileName);
				try {
					Files.write(fileNameAndPath, serviceImage.getBytes());
				} catch (IOException e) {
					e.printStackTrace();
				}
				medicalService.setServiceImage(originalFileName);
				
			}
			else
			{
				Long id = medicalService.getId();
				MedicalService medicalService1 = medicalServiceService.getMedicalServiceById(id);
				medicalService.setServiceImage(medicalService1.getServiceImage());
				
			}
			
			return medicalServiceService.saveMedicalService(medicalService);
			
	}
	

}
