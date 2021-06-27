package com.doctor.adminController;

import java.io.File;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.multipart.MultipartFile;

import com.doctor.model.Appointment;
import com.doctor.service.AppointmentService;

@RestController
public class AppointmentController {
	
	@Autowired
	private AppointmentService appointmentService;
	
	String uploadAppointmentDirectory = System.getProperty("user.dir") + "/uploads/appointment-patient-image/";
	
	@GetMapping(path = "/get-appointment-list", produces = "application/json")
	public List<Appointment> getAppointmentsList(){
		return appointmentService.getAppointmentList();
	}
	
	@PostMapping(path = "/get-appointment-by-id", produces = "application/json")
	public Appointment getAppointmentById(Long id){
		return appointmentService.getAppointmentById(id);
	}
	
	@DeleteMapping(path = "/delete-appointment-by-id", produces = "application/json")
	public void deleteAppointmentById(Long id){
		appointmentService.deleteAppointmentById(id);
	}
	
	
	@PostMapping(path = "/create-appointment", consumes = { "multipart/form-data" }, produces = "application/json")
	public Appointment createAppintment(Appointment appointment, BindingResult bindingResult,
			@RequestParam("patientImage") MultipartFile patientImage) {

			
			File f = new File(uploadAppointmentDirectory);
			if (!f.exists()) {
				f.mkdirs();
			}
			
			
			if (!patientImage.isEmpty()) {
				String dateName = new SimpleDateFormat("yyyyMMddHHmm").format(new Date());
				String originalFileName = dateName + "-"
						+ patientImage.getOriginalFilename().replace(" ", "-").toLowerCase();
				Path fileNameAndPath = Paths.get(uploadAppointmentDirectory, originalFileName);
				try {
					Files.write(fileNameAndPath, patientImage.getBytes());
				} catch (IOException e) {
					e.printStackTrace();
				}
				appointment.setPatientImage(originalFileName);
				
			}
			else
			{
				appointment.setPatientImage("");
			}
			
			return appointmentService.saveAppointment(appointment);
			
	}

	
	
	@PutMapping(path = "/update-appointment", consumes = { "multipart/form-data" }, produces = "application/json")
	public Appointment updateAppointment(Appointment appointment, BindingResult bindingResult,
			@RequestParam("patientImage") MultipartFile patientImage) {

			
			File f = new File(uploadAppointmentDirectory);
			if (!f.exists()) {
				f.mkdirs();
			}
			
			
			if (!patientImage.isEmpty()) {
				String dateName = new SimpleDateFormat("yyyyMMddHHmm").format(new Date());
				String originalFileName = dateName + "-"
						+ patientImage.getOriginalFilename().replace(" ", "-").toLowerCase();
				Path fileNameAndPath = Paths.get(uploadAppointmentDirectory, originalFileName);
				try {
					Files.write(fileNameAndPath, patientImage.getBytes());
				} catch (IOException e) {
					e.printStackTrace();
				}
				appointment.setPatientImage(originalFileName);
				
			}
			else
			{
				Long id = appointment.getId();
				Appointment appointment1 = appointmentService.getAppointmentById(id);
				appointment.setPatientImage(appointment1.getPatientImage());
				
			}
			
			return appointmentService.saveAppointment(appointment);
			
	}
	

}
