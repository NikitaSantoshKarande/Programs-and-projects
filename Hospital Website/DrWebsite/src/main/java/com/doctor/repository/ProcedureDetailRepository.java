package com.doctor.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.doctor.model.ProcedureDetail;

@Repository
public interface ProcedureDetailRepository extends JpaRepository<ProcedureDetail, Long>{

	ProcedureDetail findProcedureDetailById(Long id);

	
}
