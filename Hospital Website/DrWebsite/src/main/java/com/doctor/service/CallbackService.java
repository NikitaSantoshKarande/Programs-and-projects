package com.doctor.service;

import java.util.Date;
import java.util.List;

import javax.transaction.Transactional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.doctor.model.Callback;
import com.doctor.repository.CallbackRepository;

@Service
@Transactional
public class CallbackService {
	
	@Autowired
	private CallbackRepository callbackRepository;
	
	public List<Callback> getCallbackList(){
		return callbackRepository.findAll();
	}
	
	public Callback getCallbackById(Long id){
		return callbackRepository.findById(id).get();
	}
	
	public void deleteCallbackById(Long id) {
		callbackRepository.deleteById(id);
	}

	public Callback saveCallback(Callback callback) {
		return callbackRepository.save(callback);
	}
	
	public Callback updateCallback(Callback callback) {
		return callbackRepository.save(callback);
	}
	
	public Long getCallBackCountByDate(Date date) {
		return callbackRepository.getCountByCallbackDate(date);
	}
	
	public Long getCallBackCount() {
		return callbackRepository.getCount();
	}
	
	
}
