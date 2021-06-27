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
public class Query {
	
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Long id;
	private Long customerId;
	private String customerQuery="";
	private String queryAnswer="";
	private String status="Pending"; //Pending, Accept, Answer, Reject
	@Temporal(TemporalType.DATE)
	@DateTimeFormat(pattern = "yyyy-MM-dd")
	private Date queryDate= new Date();
	
	@Temporal(TemporalType.DATE)
	@DateTimeFormat(pattern = "yyyy-MM-dd")
	private Date answerDate;
	
	public Query(Long id, Long customerId, String customerQuery, String queryAnswer, String status, Date queryDate,
			Date answerDate) {
		super();
		this.id = id;
		this.customerId = customerId;
		this.customerQuery = customerQuery;
		this.queryAnswer = queryAnswer;
		this.status = status;
		this.queryDate = queryDate;
		this.answerDate = answerDate;
	}

	public Query() {
		super();
		// TODO Auto-generated constructor stub
	}

	public Long getId() {
		return id;
	}

	public Long getCustomerId() {
		return customerId;
	}

	public String getCustomerQuery() {
		return customerQuery;
	}

	public String getQueryAnswer() {
		return queryAnswer;
	}

	public String getStatus() {
		return status;
	}

	public Date getQueryDate() {
		return queryDate;
	}

	public Date getAnswerDate() {
		return answerDate;
	}

	public void setId(Long id) {
		this.id = id;
	}

	public void setCustomerId(Long customerId) {
		this.customerId = customerId;
	}

	public void setCustomerQuery(String customerQuery) {
		this.customerQuery = customerQuery;
	}

	public void setQueryAnswer(String queryAnswer) {
		this.queryAnswer = queryAnswer;
	}

	public void setStatus(String status) {
		this.status = status;
	}

	public void setQueryDate(Date queryDate) {
		this.queryDate = queryDate;
	}

	public void setAnswerDate(Date answerDate) {
		this.answerDate = answerDate;
	}
	
	
	
	
	
	

}
