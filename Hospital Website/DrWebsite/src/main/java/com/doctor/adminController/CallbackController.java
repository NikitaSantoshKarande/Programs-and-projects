package com.doctor.adminController;

import java.util.Date;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RestController;

import com.doctor.configuration.BaseConfiguration;
import com.doctor.model.Callback;
import com.doctor.service.CallbackService;

@RestController
public class CallbackController extends BaseConfiguration{

	@Autowired
	private CallbackService callbackService;

	@GetMapping(path = "/get-callback-list", produces = "application/json")
	public List<Callback> getCallbacksList() {
		return callbackService.getCallbackList();
	}

	@PostMapping(path = "/get-callback-by-id", produces = "application/json")
	public Callback getCallbackById(Long id) {
		return callbackService.getCallbackById(id);
	}

	@DeleteMapping(path = "/delete-callback-by-id", produces = "application/json")
	public void deleteCallbackById(Long id) {
		callbackService.deleteCallbackById(id);
	}

	@PostMapping(path = "/create-callback", produces = "application/json")
	public Callback createCallback(Callback callback) {
	
		return callbackService.saveCallback(callback);
	}

	
	@PutMapping(path = "/update-callback", produces = "application/json")
	public Callback updateCallback(Callback callback) {
		
		Callback callback1 =  callbackService.getCallbackById(callback.getId());
		callback1.setStatus(callback.getStatus());
		callback1.setUpdatedDate(callback.getUpdatedDate());
		return callbackService.saveCallback(callback1);

	}

}
