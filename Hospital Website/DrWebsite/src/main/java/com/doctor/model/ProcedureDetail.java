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
public class ProcedureDetail {

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Long id;
	private String procedureTitle = "";
	private String procedureImage = "";
	private String procedureDescription = "";
	private String procedureStatus = "Active";
	@CreatedDate
	@Temporal(TemporalType.TIMESTAMP)
	@DateTimeFormat(pattern = "yyyy-MM-dd")
	private Date updatedDate = new Date();
	
	
	
	public ProcedureDetail() {
		super();
		// TODO Auto-generated constructor stub
	}



	public ProcedureDetail(Long id, String procedureTitle, String procedureImage, String procedureDescription,
			String procedureStatus, Date updatedDate) {
		super();
		this.id = id;
		this.procedureTitle = procedureTitle;
		this.procedureImage = procedureImage;
		this.procedureDescription = procedureDescription;
		this.procedureStatus = procedureStatus;
		this.updatedDate = updatedDate;
	}



	public Long getId() {
		return id;
	}



	public String getProcedureTitle() {
		return procedureTitle;
	}



	public String getProcedureImage() {
		return procedureImage;
	}



	public String getProcedureDescription() {
		return procedureDescription;
	}



	public String getProcedureStatus() {
		return procedureStatus;
	}



	public Date getUpdatedDate() {
		return updatedDate;
	}



	public void setId(Long id) {
		this.id = id;
	}



	public void setProcedureTitle(String procedureTitle) {
		this.procedureTitle = procedureTitle;
	}



	public void setProcedureImage(String procedureImage) {
		this.procedureImage = procedureImage;
	}



	public void setProcedureDescription(String procedureDescription) {
		this.procedureDescription = procedureDescription;
	}



	public void setProcedureStatus(String procedureStatus) {
		this.procedureStatus = procedureStatus;
	}



	public void setUpdatedDate(Date updatedDate) {
		this.updatedDate = updatedDate;
	}

	

}
