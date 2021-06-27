package com.doctor.repository;

import java.util.Date;
import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.doctor.model.Query;

@Repository
public interface QueryRepository extends JpaRepository<Query, Long>{

	List<Query> findAllByCustomerId(Long customerId);
	
	@org.springframework.data.jpa.repository.Query(value = "SELECT COUNT(*) FROM Query WHERE queryDate=:date")
	Long getCountByQueryDate(Date date);
	
	@org.springframework.data.jpa.repository.Query(value = "SELECT COUNT(*) FROM Query")
	Long getCount();
	
}
