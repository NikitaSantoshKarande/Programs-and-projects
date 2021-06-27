package com.doctor.model;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;



@Entity
public class Admin {

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Long id;
	private String name;
	private String email;
	private String password;
	private Long otp;
	private String status = "Active";
	private String profileImage = "";
	
	
	
	
	public Admin() {
		super();
		// TODO Auto-generated constructor stub
	}


	public Admin(Long id, String name, String email, String password, Long otp, String status, String profileImage) {
		super();
		this.id = id;
		this.name = name;
		this.email = email;
		this.password = password;
		this.otp = otp;
		this.status = status;
		this.profileImage = profileImage;
	}


	public Long getId() {
		return id;
	}


	public String getName() {
		return name;
	}


	public String getEmail() {
		return email;
	}


	public String getPassword() {
		return password;
	}


	public Long getOtp() {
		return otp;
	}


	public String getStatus() {
		return status;
	}


	public String getProfileImage() {
		return profileImage;
	}


	public void setId(Long id) {
		this.id = id;
	}


	public void setName(String name) {
		this.name = name;
	}


	public void setEmail(String email) {
		this.email = email;
	}


	public void setPassword(String password) {
		this.password = password;
	}


	public void setOtp(Long otp) {
		this.otp = otp;
	}


	public void setStatus(String status) {
		this.status = status;
	}


	public void setProfileImage(String profileImage) {
		this.profileImage = profileImage;
	}


	@Override
	public String toString() {
		return "Admin [id=" + id + ", name=" + name + ", email=" + email + ", password=" + password + ", otp=" + otp
				+ ", status=" + status + ", profileImage=" + profileImage + "]";
	}
	
	

}
