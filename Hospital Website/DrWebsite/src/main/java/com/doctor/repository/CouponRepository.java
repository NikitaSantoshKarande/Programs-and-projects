package com.doctor.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.doctor.model.Coupon;

@Repository
public interface CouponRepository extends JpaRepository<Coupon, Long>{

	Coupon findCouponById(Long id);

	Coupon findCouponByCouponCode(String couponCode);

	Boolean existsByCouponCode(String couponCode);
}
