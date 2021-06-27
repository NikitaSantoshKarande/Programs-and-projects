package com.doctor.repository;

import java.util.Date;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.stereotype.Repository;

import com.doctor.model.Callback;

@Repository
public interface CallbackRepository extends JpaRepository<Callback, Long>{

	@Query(value = "SELECT COUNT(*) FROM Callback WHERE callbackDate=:date")
	Long getCountByCallbackDate(Date date);
	
	@Query(value = "SELECT COUNT(*) FROM Callback")
	Long getCount();
	
}
