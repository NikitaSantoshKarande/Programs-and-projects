package com.doctor.adminController;

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.text.ParseException;
import java.util.Date;
import java.util.List;

import javax.servlet.ServletOutputStream;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.jpa.repository.Query;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

import com.doctor.configuration.BaseConfiguration;
import com.doctor.model.Admin;
import com.doctor.service.AdminService;
import com.doctor.service.CallbackService;
import com.doctor.service.ContactService;
import com.doctor.service.QueryService;


@Controller
@RequestMapping("/admin")
public class DoctorApplicationController extends BaseConfiguration{
	
	@Autowired 
	private AdminService adminService;
	
	@Autowired 
	private CallbackService callBackService;
	
	@Autowired 
	private QueryService queryService;
	
	@Autowired 
	private ContactService contactService;

	
	@RequestMapping("/sign-in")
	public String admin() {
		return "admin/sign-in";
	}
	
	@RequestMapping("/dashboard")
	public String dashboard(Model model, HttpSession session) throws ParseException {
		if (session.getAttribute("sign-in-user") != null) {
			
			Date today = getCurrentDate();
			
			Long todaysCallBack = callBackService.getCallBackCountByDate(today);
			model.addAttribute("todaysCallBack",todaysCallBack);
		
			Long totalCallBack = callBackService.getCallBackCount();
			model.addAttribute("totalCallBack",totalCallBack);	
			
			Long todaysQuery = queryService.getQueryCountByDate(today);
			model.addAttribute("todaysQuery",todaysQuery);
			
			Long totalQuery = queryService.getTotalQuery();
			model.addAttribute("totalQuery",totalQuery);	
			
			Long todaysContact = contactService.getContactByDate(today);
			model.addAttribute("todaysContact",todaysContact);
			
			Long totalContact = contactService.getTotalContact();
			model.addAttribute("totalContact",totalContact);	
			
			
			return "admin/index";
		}
		return "redirect:/admin/sign-in";

	}

	@RequestMapping("/logout")
	public String logout(HttpSession session) {
		session.setAttribute("sign-in-user", null);

		session.invalidate();
		return "redirect:/admin/sign-in";

	}

	@RequestMapping("/super-admin-sign-in")
	public String doSignIn(RedirectAttributes redireAttributes, HttpServletRequest request, HttpSession session,
			@RequestParam("email") String email, @RequestParam("password") String password) {
		Admin user = adminService.validateAdmin(email, password);
		if (user != null) {
			if(user.getStatus().equals("Active"))
			{
			session.setAttribute("sign-in-user", user.getName());
			session.setAttribute("sign-in-userId", user.getId());
			session.setAttribute("sign-in-userEmail", user.getEmail());
			session.setAttribute("admin-id", user.getId());
			
			Long id = user.getId();
			Admin admin = adminService.getById(id);
			session.setAttribute("profileImage1", admin.getProfileImage());
			
			return "redirect:/admin/dashboard";
			}
			else
			{
				redireAttributes.addFlashAttribute("message", "Account Inactive");
				return "redirect:/admin/sign-in";	
			}
		}
			
		redireAttributes.addFlashAttribute("message", "Invalid Credintials");
		return "redirect:/admin/sign-in";
	}
	
	
	@RequestMapping("/manage-medical-service")
	public String manageMedicalService(Model model, HttpSession session) {
		if (session.getAttribute("sign-in-user") != null) {
			return "admin/manage-medical-service";
		}
		return "redirect:/admin/sign-in";

	}
	
	
	@RequestMapping("/manage-procedure")
	public String manageProcedure(Model model, HttpSession session) {
		if (session.getAttribute("sign-in-user") != null) {
			return "admin/manage-procedure";
		}
		return "redirect:/admin/sign-in";

	}
	
	@RequestMapping("/manage-appointment")
	public String manageAppointment(Model model, HttpSession session) {
		if (session.getAttribute("sign-in-user") != null) {
			return "admin/manage-appointment";
		}
		return "redirect:/admin/sign-in";

	}
	
	@RequestMapping("/manage-contact")
	public String manageContact(Model model, HttpSession session) {
		if (session.getAttribute("sign-in-user") != null) {
			return "admin/manage-contact";
		}
		return "redirect:/admin/sign-in";

	}
	
	
	@RequestMapping("/manage-query")
	public String manageQuery(Model model, HttpSession session) {
		if (session.getAttribute("sign-in-user") != null) {
			return "admin/manage-query";
		}
		return "redirect:/admin/sign-in";

	}
	
	@RequestMapping("/manage-user")
	public String manageUser(Model model, HttpSession session) {
		if (session.getAttribute("sign-in-user") != null) {
			return "admin/manage-user";
		}
		return "redirect:/admin/sign-in";

	}
	
	@RequestMapping("/manage-callback")
	public String manageCallback(Model model, HttpSession session) {
		if (session.getAttribute("sign-in-user") != null) {
			return "admin/manage-callback";
		}
		return "redirect:/admin/sign-in";

	}
	
	
	@RequestMapping("/manage-coupon")
	public String manageCoupon(Model model, HttpSession session) {
		if (session.getAttribute("sign-in-user") != null) {
			return "admin/manage-coupan";
		}
		return "redirect:/admin/sign-in";

	}
	
	
}
