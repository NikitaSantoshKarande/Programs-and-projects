package com.doctor.adminController;

import java.io.File;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.multipart.MultipartFile;

import com.doctor.model.Coupon;
import com.doctor.model.MedicalService;
import com.doctor.response.DoctorJsonResponse;
import com.doctor.service.CouponService;

@RestController
public class CouponController {

	@Autowired
	private CouponService couponService;
	
	String uploadCouponServiceDirectory = System.getProperty("user.dir") + "/uploads/coupon/";

	@GetMapping(path = "/get-coupon-list", produces = "application/json")
	public List<Coupon> getCouponList() {
		return couponService.getCouponList();
	}
		
	@PostMapping(path = "/get-coupon-amount", produces = "application/json")
	public DoctorJsonResponse getCouponAmount(String coupanCode) {
		
		DoctorJsonResponse json = new DoctorJsonResponse();
		
		Coupon coupon = couponService.getCouponByCoupanCode(coupanCode);
		if(coupon != null)
		{
			 json.setData(coupon.getCouponPrice().toString());
		     json.setStatus("true");
		     return json;
		}
		else
		{
			json.setMessage("Invalid Coupon");
		    json.setStatus("false");
		     return json;
		}
			
	}

	@PostMapping(path = "/get-coupon-by-id", produces = "application/json")
	public Coupon getCouponById(Long id) {
		return couponService.getCouponById(id);
	}

	@DeleteMapping(path = "/delete-coupon-by-id", produces = "application/json")
	public void deleteCouponById(Long id) {
		couponService.deleteCouponById(id);
	}
	
	@PostMapping(path = "/create-coupon", produces = "application/json")
	public DoctorJsonResponse createCoupon(Coupon coupon) {
		
		DoctorJsonResponse json = new DoctorJsonResponse();
		boolean isExist = couponService.existsByCouponCode(coupon.getCouponCode());
		if(!isExist)
		{
			 couponService.saveCoupon(coupon);
			 json.setMessage("Coupon Added");
			 json.setStatus("true");
		}
		else
		{
			 json.setMessage("Coupon with this code already exist");
			 json.setStatus("false");
		}
		return json;
	}
	
	@PutMapping(path = "/update-coupon", produces = "application/json")
	public Coupon updateCoupon(Coupon coupon) {
		return couponService.saveCoupon(coupon);
	}

//	@PostMapping(path = "/create-coupon",consumes = { "multipart/form-data" },  produces = "application/json")
//	public Coupon createCoupon(Coupon coupon, BindingResult bindingResult,
//			@RequestParam("coupanImage") MultipartFile coupanImage) {
//
//			
//			File f = new File(uploadCouponServiceDirectory);
//			if (!f.exists()) {
//				f.mkdirs();
//			}
//			
//			
//			if (!coupanImage.isEmpty()) {
//				String dateName = new SimpleDateFormat("yyyyMMddHHmm").format(new Date());
//				String originalFileName = dateName + "-"
//						+ coupanImage.getOriginalFilename().replace(" ", "-").toLowerCase();
//				Path fileNameAndPath = Paths.get(uploadCouponServiceDirectory, originalFileName);
//				try {
//					Files.write(fileNameAndPath, coupanImage.getBytes());
//				} catch (IOException e) {
//					e.printStackTrace();
//				}
//				coupon.setCoupanImage(originalFileName);
//				
//			}
//			else
//			{
//				coupon.setCoupanImage("");
//			}
//			
//			return couponService.saveCoupon(coupon);
//
//	}
//	
//	@PutMapping(path = "/update-coupon",consumes = { "multipart/form-data" }, produces = "application/json")
//	public Coupon updateCoupon(Coupon coupon, BindingResult bindingResult,
//			@RequestParam("coupanImage") MultipartFile coupanImage) {
//
//			
//			File f = new File(uploadCouponServiceDirectory);
//			if (!f.exists()) {
//				f.mkdirs();
//			}
//			
//			
//			if (!coupanImage.isEmpty()) {
//				String dateName = new SimpleDateFormat("yyyyMMddHHmm").format(new Date());
//				String originalFileName = dateName + "-"
//						+ coupanImage.getOriginalFilename().replace(" ", "-").toLowerCase();
//				Path fileNameAndPath = Paths.get(uploadCouponServiceDirectory, originalFileName);
//				try {
//					Files.write(fileNameAndPath, coupanImage.getBytes());
//				} catch (IOException e) {
//					e.printStackTrace();
//				}
//				coupon.setCoupanImage(originalFileName);
//				
//			}
//			else
//			{
//				Coupon coupon1 = couponService.getCouponById(coupon.getId());
//				coupon.setCoupanImage(coupon1.getCoupanImage());
//			}
//			
//			return couponService.saveCoupon(coupon);
//
//	}


}
