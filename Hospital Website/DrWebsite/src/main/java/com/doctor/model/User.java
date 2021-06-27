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

//Offer % amount

@Entity
public class User {

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Long id;
	private String name = "";
	private String phone = "";
	private String email = "";
	private Long otp;
	private String password = "";
	private String profileImage = "";
	private String status = "Active"; // Inactive, Active
	@CreatedDate
	@Temporal(TemporalType.TIMESTAMP)
	@DateTimeFormat(pattern = "yyyy-MM-dd")
	private Date registrationDate = new Date();
	
	
	
	public User() {
		super();
		// TODO Auto-generated constructor stub
	}


	public User(Long id, String name, String phone, String email, String password, String status,
			Date registrationDate) {
		super();
		this.id = id;
		this.name = name;
		this.phone = phone;
		this.email = email;
		this.password = password;
		this.status = status;
		this.registrationDate = registrationDate;
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


	public Long getOtp() {
		return otp;
	}


	public String getPassword() {
		return password;
	}


	public String getProfileImage() {
		return profileImage;
	}


	public String getStatus() {
		return status;
	}


	public Date getRegistrationDate() {
		return registrationDate;
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


	public void setOtp(Long otp) {
		this.otp = otp;
	}


	public void setPassword(String password) {
		this.password = password;
	}


	public void setProfileImage(String profileImage) {
		this.profileImage = profileImage;
	}


	public void setStatus(String status) {
		this.status = status;
	}


	public void setRegistrationDate(Date registrationDate) {
		this.registrationDate = registrationDate;
	}


	@Override
	public String toString() {
		return "User [id=" + id + ", name=" + name + ", phone=" + phone + ", email=" + email + ", otp=" + otp
				+ ", password=" + password + ", profileImage=" + profileImage + ", status=" + status
				+ ", registrationDate=" + registrationDate + "]";
	}

	
}
