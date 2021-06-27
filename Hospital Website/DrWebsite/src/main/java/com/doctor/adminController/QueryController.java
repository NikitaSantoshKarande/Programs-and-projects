package com.doctor.adminController;

import java.util.List;

import javax.servlet.http.HttpSession;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;

import com.doctor.model.Query;
import com.doctor.service.QueryService;

@Controller
public class QueryController {

	@Autowired
	private QueryService queryService;

	@RequestMapping(path = "/get-query-list", method = RequestMethod.GET)
	@ResponseBody
	public List<Query> getQueryList() {
		return queryService.getQueryList();
	}

	@RequestMapping(path = "/get-query-by-id", method = RequestMethod.POST)
	@ResponseBody
	public Query getQueryById(Long id) {
		return queryService.getQueryById(id);
	}

	@RequestMapping(path = "/delete-query-by-id", method = RequestMethod.DELETE)
	@ResponseBody
	public void deleteQueryById(Long id) {
		queryService.deleteQueryById(id);
	}

	@RequestMapping(path = "/create-query", method = RequestMethod.POST)
	public String createQuery(Query query,HttpSession session) {

		Long customerId = (long)session.getAttribute("id");
		query.setCustomerId(customerId);
	    queryService.saveQuery(query);
	    
	    return "redirect:/";
	}

	@RequestMapping(path = "/update-query",  method = RequestMethod.PUT)
	@ResponseBody
	public Query updateQuery(Query query,HttpSession session) {
		
		Query query1 = queryService.getQueryById(query.getId());
		query.setCustomerQuery(query1.getCustomerQuery());;
		query.setQueryDate(query1.getQueryDate());
		query.setAnswerDate(query.getQueryDate());
		query.setCustomerId((long)session.getAttribute("id"));
		
		return queryService.updateQuery(query);

	}

}
