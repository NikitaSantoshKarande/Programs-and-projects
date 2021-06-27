package com.doctor.service;

import java.util.List;

import javax.transaction.Transactional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.doctor.model.Coupon;
import com.doctor.repository.CouponRepository;

@Service
@Transactional
public class CouponService {
	
	@Autowired
	private CouponRepository couponRepository;
	
	public List<Coupon> getCouponList(){
		return couponRepository.findAll();
	}
	
	public Coupon getCouponById(Long id){
		return couponRepository.findCouponById(id);
	}
	
	public Boolean existsByCouponCode(String couponCode){
		return couponRepository.existsByCouponCode(couponCode);
	}
	
	
	
	public Coupon getCouponByCoupanCode(String coupanCode){
		return couponRepository.findCouponByCouponCode(coupanCode);
	}
	
	public void deleteCouponById(Long id) {
		couponRepository.deleteById(id);
	}

	public Coupon saveCoupon(Coupon Coupon) {
		return couponRepository.save(Coupon);
	}
	
	public Coupon updateCoupon(Coupon Coupon) {
		return couponRepository.save(Coupon);
	}
	
	
}
