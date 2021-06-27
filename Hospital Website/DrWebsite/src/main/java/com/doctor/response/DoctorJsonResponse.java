package com.doctor.response;



public class DoctorJsonResponse {
	private String message;
	private String status;
	private String data;
	
	
	public DoctorJsonResponse() {
		super();
		// TODO Auto-generated constructor stub
	}


	public DoctorJsonResponse(String message, String status, String data) {
		super();
		this.message = message;
		this.status = status;
		this.data = data;
	}


	public String getMessage() {
		return message;
	}


	public String getStatus() {
		return status;
	}


	public String getData() {
		return data;
	}


	public void setMessage(String message) {
		this.message = message;
	}


	public void setStatus(String status) {
		this.status = status;
	}


	public void setData(String data) {
		this.data = data;
	}


	@Override
	public String toString() {
		return "DoctorResponse [message=" + message + ", status=" + status + ", data=" + data + "]";
	}
	
	
	
	
}
