package com.doctor.service;

import java.util.Date;
import java.util.List;

import javax.transaction.Transactional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.doctor.model.Query;
import com.doctor.repository.QueryRepository;

@Service
@Transactional
public class QueryService {
	
	@Autowired
	private QueryRepository queryRepository;
	
	public List<Query> getQueryList(){
		return queryRepository.findAll();
	}
	
	public List<Query> getQueryListByCustomerId(Long customerId){
		return queryRepository.findAllByCustomerId(customerId);
	}
	
	public Query getQueryById(Long id){
		return queryRepository.findById(id).get();
	}
	
	public void deleteQueryById(Long id) {
		queryRepository.deleteById(id);
	}

	public Query saveQuery(Query query) {
		return queryRepository.save(query);
	}
	
	public Query updateQuery(Query query) {
		return queryRepository.save(query);
	}
	
	public Long getQueryCountByDate(Date date) {
		return queryRepository.getCountByQueryDate(date);
	}
	
	public Long getTotalQuery() {
		return queryRepository.getCount();
	}
	
	
}
