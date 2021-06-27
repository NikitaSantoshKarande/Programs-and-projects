package com.doctor.service;

import java.util.List;

import javax.transaction.Transactional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.doctor.model.Appointment;
import com.doctor.repository.AppointmentRepository;

@Service
@Transactional
public class AppointmentService {
	
	@Autowired
	private AppointmentRepository appointmentRepository;
	
	public List<Appointment> getAppointmentList(){
		return appointmentRepository.findAll();
	}
	
	public Appointment getAppointmentById(Long id){
		return appointmentRepository.findById(id).get();
	}
	
	public void deleteAppointmentById(Long id) {
		appointmentRepository.deleteById(id);
	}

	public Appointment saveAppointment(Appointment appointment) {
		return appointmentRepository.save(appointment);
	}
	
	public Appointment updateAppointment(Appointment appointment) {
		return appointmentRepository.save(appointment);
	}
	
	
}
