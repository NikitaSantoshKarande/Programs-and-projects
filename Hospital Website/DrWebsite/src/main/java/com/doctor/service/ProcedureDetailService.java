package com.doctor.service;

import java.util.List;

import javax.transaction.Transactional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.doctor.model.ProcedureDetail;
import com.doctor.repository.ProcedureDetailRepository;

@Service
@Transactional
public class ProcedureDetailService {
	
	@Autowired
	private ProcedureDetailRepository procedureDetailRepository;
	
	public List<ProcedureDetail> getProcedureDetailList(){
		return procedureDetailRepository.findAll();
	}
	
	public ProcedureDetail getProcedureDetailById(Long id){
		return procedureDetailRepository.findProcedureDetailById(id);
	}
	
	public void deleteProcedureDetailById(Long id) {
		procedureDetailRepository.deleteById(id);
	}

	public ProcedureDetail saveProcedureDetail(ProcedureDetail ProcedureDetail) {
		return procedureDetailRepository.save(ProcedureDetail);
	}
	
	public ProcedureDetail updateProcedureDetail(ProcedureDetail ProcedureDetail) {
		return procedureDetailRepository.save(ProcedureDetail);
	}
	
	
}
