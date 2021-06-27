package com.doctor.service;

import java.util.List;

import javax.transaction.Transactional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.doctor.model.User;
import com.doctor.repository.UserRepository;

@Service
@Transactional
public class UserService {
	
	@Autowired
	private UserRepository userRepository;
	
	public List<User> getUserList(){
		return userRepository.findAll();
	}
	
	public Boolean isExistsByEmail(String email){
		return userRepository.existsByEmail(email);
	}
	
	public User getUserById(Long id){
		return userRepository.findById(id).get();
	}
	
	public User validateUser(String email,String password){
		return userRepository.findByEmailAndPassword(email,password);
	}
	
	
	public void deleteUserById(Long id) {
		userRepository.deleteById(id);
	}

	public User saveUser(User user) {
		return userRepository.save(user);
	}
	
	public User updateUser(User user) {
		return userRepository.save(user);
	}

	
	
}
