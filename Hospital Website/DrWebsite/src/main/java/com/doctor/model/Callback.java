package com.doctor.model;

import java.util.Date;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Temporal;
import javax.persistence.TemporalType;

import org.springframework.data.annotation.CreatedDate;
import org.springframework.format.annotation.DateTimeFormat;


@Entity
public class Callback {

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Long id;
	private String name = "";
	private String phone = "";
	private String email = "";
	private String message = "";
	private String status = "Pending"; // Pending, Accept, Reject
	@Temporal(TemporalType.DATE)
	@DateTimeFormat(pattern = "yyyy-MM-dd")
	private Date callbackDate = new Date();
	
	@Temporal(TemporalType.DATE)
	@DateTimeFormat(pattern = "yyyy-MM-dd")
	private Date updatedDate;
	
	

	public Callback() {
		super();
		// TODO Auto-generated constructor stub
	}



	public Callback(Long id, String name, String phone, String email, String message, String status, Date callbackDate,
			Date updatedDate) {
		super();
		this.id = id;
		this.name = name;
		this.phone = phone;
		this.email = email;
		this.message = message;
		this.status = status;
		this.callbackDate = callbackDate;
		this.updatedDate = updatedDate;
	}



	public Long getId() {
		return id;
	}



	public String getName() {
		return name;
	}



	public String getPhone() {
		return phone;
	}



	public String getEmail() {
		return email;
	}



	public String getMessage() {
		return message;
	}



	public String getStatus() {
		return status;
	}



	public Date getCallbackDate() {
		return callbackDate;
	}



	public Date getUpdatedDate() {
		return updatedDate;
	}



	public void setId(Long id) {
		this.id = id;
	}



	public void setName(String name) {
		this.name = name;
	}



	public void setPhone(String phone) {
		this.phone = phone;
	}



	public void setEmail(String email) {
		this.email = email;
	}



	public void setMessage(String message) {
		this.message = message;
	}



	public void setStatus(String status) {
		this.status = status;
	}



	public void setCallbackDate(Date callbackDate) {
		this.callbackDate = callbackDate;
	}



	public void setUpdatedDate(Date updatedDate) {
		this.updatedDate = updatedDate;
	}

	
}
