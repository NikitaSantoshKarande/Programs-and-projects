package com.doctor.websiteController;
import java.util.ArrayList;
import java.util.List;

import javax.servlet.http.HttpSession;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

import com.doctor.model.Coupon;
import com.doctor.model.MedicalService;
import com.doctor.model.ProcedureDetail;
import com.doctor.model.Query;
import com.doctor.service.CouponService;
import com.doctor.service.MedicalServiceService;
import com.doctor.service.ProcedureDetailService;
import com.doctor.service.QueryService;

@Controller
public class DoctorWebsiteController {
	
	@Autowired 
	private MedicalServiceService medicalServiceService;
	
	@Autowired 
	private ProcedureDetailService procedureDetailService;
	
	@Autowired 
	private CouponService couponService;
	
	@Autowired 
	private QueryService queryService;
	
		
	@RequestMapping("/")
	public String home(Model model,HttpSession session) {
		
		List<MedicalService> medicalServiceList = medicalServiceService.getMedicalServiceList();	
		List<MedicalService> medicalServiceList1 = new ArrayList<MedicalService>();	
		
		System.out.println("medicalServiceList.size() = "+medicalServiceList.size());
		int medicalServiceListLength = medicalServiceList.size();
		int cnt = 0;
		if(medicalServiceListLength > 2)
		{
			medicalServiceListLength = 2;
		}
		for(MedicalService medicalService : medicalServiceList)
		{
			medicalServiceList1.add(medicalService);
			if(cnt == medicalServiceListLength)
			{
				break;
			}
			cnt++;
		}
		cnt = 0;
		model.addAttribute("medicalServiceList" , medicalServiceList1);
		
		
		
		List<ProcedureDetail> procedureList = procedureDetailService.getProcedureDetailList();		
		List<ProcedureDetail> procedureList1 = new ArrayList<ProcedureDetail>();	
		
		System.out.println("procedureList.size() = "+procedureList.size());
		int ProcedureDetailListLength = procedureList.size();
		if(ProcedureDetailListLength > 2)
		{
			ProcedureDetailListLength = 2;
		}
		for(ProcedureDetail procedureDetail : procedureList)
		{
			procedureList1.add(procedureDetail);
			if(cnt == ProcedureDetailListLength)
			{
				break;
			}
			cnt++;
		}
		cnt = 0;
		model.addAttribute("procedureList" , procedureList1);
	
		
		List<Coupon> couponList = couponService.getCouponList();		
		List<Coupon> couponList1 = new ArrayList<Coupon>();	
		
		System.out.println("couponList.size() = "+couponList.size());
		int CouponListLength = couponList.size();
		if(CouponListLength > 2)
		{
			CouponListLength = 2;
		}
		for(Coupon coupon : couponList)
		{
			couponList1.add(coupon);
			if(cnt == CouponListLength)
			{
				break;
			}
			cnt++;
		}
		cnt = 0;
		model.addAttribute("couponList" , couponList1);
		
		
		if(session.getAttribute("id") != null)
		{
			Long customerId = (long)session.getAttribute("id");
			List<Query> queryList = queryService.getQueryListByCustomerId(customerId);		
			model.addAttribute("queryList" , queryList);
		}
		
		return "website/index";
	}

	@RequestMapping("/contact")
	public String contact(Model model) {
		
		return "website/contact";
	}
	
	@RequestMapping("/procedures")
	public String procedures(Model model) {
		
		List<ProcedureDetail> procedureList = procedureDetailService.getProcedureDetailList();	
		model.addAttribute("procedureList" , procedureList);
	
		
		return "website/procedures";
	}
	
	@RequestMapping("/medical-service")
	public String medicalServices(Model model) {
		
		List<MedicalService> medicalServiceList = medicalServiceService.getMedicalServiceList();	
		model.addAttribute("medicalServiceList" , medicalServiceList);
		
		return "website/medical-services";
	}
	
	@RequestMapping("/coupons")
	public String coupons(Model model) {
		List<Coupon> couponList = couponService.getCouponList();
		model.addAttribute("couponList" , couponList);
		
		return "website/coupons";
	}
	
	@RequestMapping("/login")
	public String userLogin(Model model) {
		
		return "website/sign-in";
	}
	
	@RequestMapping("/appointment")
	public String appointment(Model model,HttpSession session,RedirectAttributes redireAttributes) {
		
		String name = (String) session.getAttribute("name");
		
		if(name != null)
		{
			return "website/appointment";
		}
		else
		{
			redireAttributes.addFlashAttribute("error","Please login to book an appointment");
			return "redirect:/login";
		}
		
	}

}
