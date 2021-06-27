package com.doctor.model;

import java.util.Date;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Temporal;
import javax.persistence.TemporalType;

import org.springframework.format.annotation.DateTimeFormat;



@Entity
public class Coupon {
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Long id;
	private String couponName="";
	@Temporal(TemporalType.DATE)
	@DateTimeFormat(pattern = "yyyy-MM-dd")
	private Date startDate;
	@Temporal(TemporalType.DATE)
	@DateTimeFormat(pattern = "yyyy-MM-dd")
	private Date endDate;
	private String couponStatus = "Active"; //Active, Inactive
	private Float maxPrice = (float) 0;
	private Float couponPrice = (float) 0;
	private String couponCode = "";
	@Temporal(TemporalType.TIMESTAMP)
	@DateTimeFormat(pattern = "yyyy-MM-dd")
	private Date createdDate = new Date();
	
	
	
	public Coupon() {
		super();
		// TODO Auto-generated constructor stub
	}

	


	public Coupon(Long id, String couponName, Date startDate, Date endDate, String couponStatus, Float maxPrice,
			Float couponPrice, String couponCode, Date createdDate) {
		super();
		this.id = id;
		this.couponName = couponName;
		this.startDate = startDate;
		this.endDate = endDate;
		this.couponStatus = couponStatus;
		this.maxPrice = maxPrice;
		this.couponPrice = couponPrice;
		this.couponCode = couponCode;
		this.createdDate = createdDate;
	}




	public Long getId() {
		return id;
	}



	public String getCouponName() {
		return couponName;
	}



	public Date getStartDate() {
		return startDate;
	}



	public Date getEndDate() {
		return endDate;
	}



	public String getCouponStatus() {
		return couponStatus;
	}



	public Float getMaxPrice() {
		return maxPrice;
	}



	public Float getCouponPrice() {
		return couponPrice;
	}



	public Date getCreatedDate() {
		return createdDate;
	}



	public void setId(Long id) {
		this.id = id;
	}



	public void setCouponName(String couponName) {
		this.couponName = couponName;
	}



	public void setStartDate(Date startDate) {
		this.startDate = startDate;
	}



	public void setEndDate(Date endDate) {
		this.endDate = endDate;
	}



	public void setCouponStatus(String couponStatus) {
		this.couponStatus = couponStatus;
	}



	public void setMaxPrice(Float maxPrice) {
		this.maxPrice = maxPrice;
	}



	public void setCouponPrice(Float couponPrice) {
		this.couponPrice = couponPrice;
	}



	public void setCreatedDate(Date createdDate) {
		this.createdDate = createdDate;
	}



	public String getCouponCode() {
		return couponCode;
	}



	public void setCouponCode(String couponCode) {
		this.couponCode = couponCode;
	}




	@Override
	public String toString() {
		return "Coupon [id=" + id + ", couponName=" + couponName + ", startDate=" + startDate + ", endDate=" + endDate
				+ ", couponStatus=" + couponStatus + ", maxPrice=" + maxPrice + ", couponPrice=" + couponPrice
				+ ", couponCode=" + couponCode + ", createdDate=" + createdDate + "]";
	}


	
}
