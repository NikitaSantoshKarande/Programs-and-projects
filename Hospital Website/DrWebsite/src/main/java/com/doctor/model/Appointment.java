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
public class Appointment {

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Long id;
	private Long customerId;
	private String patientName = "";
	private String patientEmail = "";
	private String patientPhone = "";
	private String patientAge = "";
	private String couponId = "";
	private String paymentId = "";
	private Float appointmentAmount = 00F;
	private Float couponAmount = 00F;
	private Float totalAmount = 00F;
	private String paymentStatus = ""; // Paid, Unpaid
	@CreatedDate
	@Temporal(TemporalType.DATE)
	@DateTimeFormat(pattern = "yyyy-MM-dd")
	private Date paymentDate = new Date();
	@CreatedDate
	@Temporal(TemporalType.TIMESTAMP)
	@DateTimeFormat(pattern = "yyyy-MM-dd")
	private Date paymentDateTime = new Date();
	private String appointmentType = "";
	private String communicationLink = "";
	private String appointmentDescription = "";
	private String appointmentStatus = "";
	private String patientGender = "";
	private String patientImage = "";
	@CreatedDate
	@Temporal(TemporalType.DATE)
	@DateTimeFormat(pattern = "yyyy-MM-dd")
	private Date appointmentDate;
	@Temporal(TemporalType.TIME)
	@DateTimeFormat(pattern = "HH:mm")
	private Date appointmentTime;
	
	
	
	
	public Appointment() {
		super();
		// TODO Auto-generated constructor stub
	}


	public Appointment(Long id, Long customerId, String patientName, String patientEmail, String patientPhone,
			String patientAge, String couponId, String paymentId, Float appointmentAmount, Float couponAmount,
			Float totalAmount, String paymentStatus, Date paymentDate, Date paymentDateTime, String appointmentType,
			String communicationLink, String appointmentDescription, String appointmentStatus, String patientGender,
			String patientImage, Date appointmentDate, Date appointmentTime) {
		super();
		this.id = id;
		this.customerId = customerId;
		this.patientName = patientName;
		this.patientEmail = patientEmail;
		this.patientPhone = patientPhone;
		this.patientAge = patientAge;
		this.couponId = couponId;
		this.paymentId = paymentId;
		this.appointmentAmount = appointmentAmount;
		this.couponAmount = couponAmount;
		this.totalAmount = totalAmount;
		this.paymentStatus = paymentStatus;
		this.paymentDate = paymentDate;
		this.paymentDateTime = paymentDateTime;
		this.appointmentType = appointmentType;
		this.communicationLink = communicationLink;
		this.appointmentDescription = appointmentDescription;
		this.appointmentStatus = appointmentStatus;
		this.patientGender = patientGender;
		this.patientImage = patientImage;
		this.appointmentDate = appointmentDate;
		this.appointmentTime = appointmentTime;
	}


	public Long getId() {
		return id;
	}


	public Long getCustomerId() {
		return customerId;
	}


	public String getPatientName() {
		return patientName;
	}


	public String getPatientEmail() {
		return patientEmail;
	}


	public String getPatientPhone() {
		return patientPhone;
	}


	public String getPatientAge() {
		return patientAge;
	}


	public String getCouponId() {
		return couponId;
	}


	public String getPaymentId() {
		return paymentId;
	}


	public Float getAppointmentAmount() {
		return appointmentAmount;
	}


	public Float getCouponAmount() {
		return couponAmount;
	}


	public Float getTotalAmount() {
		return totalAmount;
	}


	public String getPaymentStatus() {
		return paymentStatus;
	}


	public Date getPaymentDate() {
		return paymentDate;
	}


	public Date getPaymentDateTime() {
		return paymentDateTime;
	}


	public String getAppointmentType() {
		return appointmentType;
	}


	public String getCommunicationLink() {
		return communicationLink;
	}


	public String getAppointmentDescription() {
		return appointmentDescription;
	}


	public String getAppointmentStatus() {
		return appointmentStatus;
	}


	public String getPatientGender() {
		return patientGender;
	}


	public String getPatientImage() {
		return patientImage;
	}


	public Date getAppointmentDate() {
		return appointmentDate;
	}


	public Date getAppointmentTime() {
		return appointmentTime;
	}


	public void setId(Long id) {
		this.id = id;
	}


	public void setCustomerId(Long customerId) {
		this.customerId = customerId;
	}


	public void setPatientName(String patientName) {
		this.patientName = patientName;
	}


	public void setPatientEmail(String patientEmail) {
		this.patientEmail = patientEmail;
	}


	public void setPatientPhone(String patientPhone) {
		this.patientPhone = patientPhone;
	}


	public void setPatientAge(String patientAge) {
		this.patientAge = patientAge;
	}


	public void setCouponId(String couponId) {
		this.couponId = couponId;
	}


	public void setPaymentId(String paymentId) {
		this.paymentId = paymentId;
	}


	public void setAppointmentAmount(Float appointmentAmount) {
		this.appointmentAmount = appointmentAmount;
	}


	public void setCouponAmount(Float couponAmount) {
		this.couponAmount = couponAmount;
	}


	public void setTotalAmount(Float totalAmount) {
		this.totalAmount = totalAmount;
	}


	public void setPaymentStatus(String paymentStatus) {
		this.paymentStatus = paymentStatus;
	}


	public void setPaymentDate(Date paymentDate) {
		this.paymentDate = paymentDate;
	}


	public void setPaymentDateTime(Date paymentDateTime) {
		this.paymentDateTime = paymentDateTime;
	}


	public void setAppointmentType(String appointmentType) {
		this.appointmentType = appointmentType;
	}


	public void setCommunicationLink(String communicationLink) {
		this.communicationLink = communicationLink;
	}


	public void setAppointmentDescription(String appointmentDescription) {
		this.appointmentDescription = appointmentDescription;
	}


	public void setAppointmentStatus(String appointmentStatus) {
		this.appointmentStatus = appointmentStatus;
	}


	public void setPatientGender(String patientGender) {
		this.patientGender = patientGender;
	}


	public void setPatientImage(String patientImage) {
		this.patientImage = patientImage;
	}


	public void setAppointmentDate(Date appointmentDate) {
		this.appointmentDate = appointmentDate;
	}


	public void setAppointmentTime(Date appointmentTime) {
		this.appointmentTime = appointmentTime;
	}


	@Override
	public String toString() {
		return "Appointment [id=" + id + ", customerId=" + customerId + ", patientName=" + patientName
				+ ", patientEmail=" + patientEmail + ", patientPhone=" + patientPhone + ", patientAge=" + patientAge
				+ ", couponId=" + couponId + ", paymentId=" + paymentId + ", appointmentAmount=" + appointmentAmount
				+ ", couponAmount=" + couponAmount + ", totalAmount=" + totalAmount + ", paymentStatus=" + paymentStatus
				+ ", paymentDate=" + paymentDate + ", paymentDateTime=" + paymentDateTime + ", appointmentType="
				+ appointmentType + ", communicationLink=" + communicationLink + ", appointmentDescription="
				+ appointmentDescription + ", appointmentStatus=" + appointmentStatus + ", patientGender="
				+ patientGender + ", patientImage=" + patientImage + ", appointmentDate=" + appointmentDate
				+ ", appointmentTime=" + appointmentTime + "]";
	}
	
	
	

	

}
