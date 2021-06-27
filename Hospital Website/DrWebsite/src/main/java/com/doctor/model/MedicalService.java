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

public class MedicalService {

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Long id;
	private String serviceTitle = "";
	private String serviceImage = "";
	private String serviceDescription = "";
	private String serviceStatus = "Active";
	@CreatedDate
	@Temporal(TemporalType.TIMESTAMP)
	@DateTimeFormat(pattern = "yyyy-MM-dd")
	private Date updatedDate = new Date();
	
	
	

	public MedicalService() {
		super();
		// TODO Auto-generated constructor stub
	}

	public MedicalService(Long id, String serviceTitle, String serviceImage, String serviceDescription,
			String serviceStatus, Date updatedDate) {
		super();
		this.id = id;
		this.serviceTitle = serviceTitle;
		this.serviceImage = serviceImage;
		this.serviceDescription = serviceDescription;
		this.serviceStatus = serviceStatus;
		this.updatedDate = updatedDate;
	}

	public Long getId() {
		return id;
	}

	public String getServiceTitle() {
		return serviceTitle;
	}

	public String getServiceImage() {
		return serviceImage;
	}

	public String getServiceDescription() {
		return serviceDescription;
	}

	public String getServiceStatus() {
		return serviceStatus;
	}

	public Date getUpdatedDate() {
		return updatedDate;
	}

	public void setId(Long id) {
		this.id = id;
	}

	public void setServiceTitle(String serviceTitle) {
		this.serviceTitle = serviceTitle;
	}

	public void setServiceImage(String serviceImage) {
		this.serviceImage = serviceImage;
	}

	public void setServiceDescription(String serviceDescription) {
		this.serviceDescription = serviceDescription;
	}

	public void setServiceStatus(String serviceStatus) {
		this.serviceStatus = serviceStatus;
	}

	public void setUpdatedDate(Date updatedDate) {
		this.updatedDate = updatedDate;
	}

	@Override
	public String toString() {
		return "MedicalService [id=" + id + ", serviceTitle=" + serviceTitle + ", serviceImage=" + serviceImage
				+ ", serviceDescription=" + serviceDescription + ", serviceStatus=" + serviceStatus + ", updatedDate="
				+ updatedDate + "]";
	}


}
