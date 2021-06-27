package com.doctor.adminController;

import java.util.List;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpSession;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

import com.doctor.model.Admin;
import com.doctor.model.User;
import com.doctor.response.DoctorJsonResponse;
import com.doctor.service.UserService;

@Controller
public class UserController {

	@Autowired
	private UserService userService;



	@RequestMapping(path = "/user-registration",  method = RequestMethod.POST)	
	@ResponseBody
	public DoctorJsonResponse userRegistration(User user,RedirectAttributes redireAttributes) {
		
		DoctorJsonResponse json = new DoctorJsonResponse();
		
		Boolean isExist = userService.isExistsByEmail(user.getEmail());
		if(!isExist)
		{
			userService.saveUser(user);
			json.setMessage("Registration Successful");
			json.setStatus("true");
		}
		else
		{			
			json.setMessage("Email id already exist");
			json.setStatus("false");
		}
		
		return json;
	}

	@RequestMapping(path = "/user-sign-in" , method = RequestMethod.POST)
	public String doSignIn(RedirectAttributes redireAttributes, HttpServletRequest request, HttpSession session,
			@RequestParam("email") String email, @RequestParam("password") String password) {
		
		User user = userService.validateUser(email, password);
			if (user != null) {
				if(user.getStatus().equals("Active"))
				{
					session.setAttribute("name", user.getName());
					session.setAttribute("id", user.getId());
					session.setAttribute("email", user.getEmail());
					session.setAttribute("image", user.getProfileImage());
				
					return "redirect:/";
				}
				else
				{
					redireAttributes.addFlashAttribute("error", "Account Inactive");
					return "redirect:/login";	
				}
		}
		
		redireAttributes.addFlashAttribute("error", "Invalid Credintials");
		return "redirect:/login";
			
	}
	
	
	@RequestMapping("/logout")	
	public String logout(HttpSession session) {
		  	session.setAttribute("name", null);
			session.setAttribute("id", null);
			session.setAttribute("email", null);
			session.setAttribute("image", null);
		return "redirect:/";
	}

	@RequestMapping(path = "/fetch-all-user-list",  method = RequestMethod.POST)	
	@ResponseBody
	public List<User> fetchUserList() {
		
	   return userService.getUserList();
	}

	@RequestMapping(path = "/update-user",  method = RequestMethod.POST)	
	@ResponseBody
	public DoctorJsonResponse updateUser(User user,RedirectAttributes redireAttributes) {
		
		DoctorJsonResponse json = new DoctorJsonResponse();
		
		User user1 = userService.getUserById(user.getId());
		user1.setStatus(user.getStatus());
		userService.updateUser(user1);
		
		json.setMessage("User Updated");
		return json;
	}
	
	@RequestMapping(path = "/get-user-by-id",  method = RequestMethod.GET)	
	@ResponseBody
	public User getUser(Long id,RedirectAttributes redireAttributes) {
		
		return userService.getUserById(id);
		
	}
}
