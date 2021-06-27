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

import com.doctor.model.MedicalService;
import com.doctor.model.ProcedureDetail;
import com.doctor.service.ProcedureDetailService;

@RestController
public class ProcedureDetailController {

	@Autowired
	private ProcedureDetailService procedureDetailService;
	
	String uploadProcedureDirectory = System.getProperty("user.dir") + "/uploads/procedure/";

	@GetMapping(path = "/get-procedure-detail-list", produces = "application/json")
	public List<ProcedureDetail> getProcedureDetailsList() {
		return procedureDetailService.getProcedureDetailList();
	}

	@PostMapping(path = "/get-procedure-detail-by-id", produces = "application/json")
	public ProcedureDetail getProcedureDetailById(Long id) {
		return procedureDetailService.getProcedureDetailById(id);
	}

	@DeleteMapping(path = "/delete-procedure-detail-by-id", produces = "application/json")
	public void deleteProcedureDetailById(Long id) {
		procedureDetailService.deleteProcedureDetailById(id);
	}

	@PostMapping(path = "/create-procedure", consumes = { "multipart/form-data" }, produces = "application/json")
	public ProcedureDetail createProcedureDetail(ProcedureDetail procedureDetail, BindingResult bindingResult,
			@RequestParam("procedureImage") MultipartFile procedureImage) {

			
			File f = new File(uploadProcedureDirectory);
			if (!f.exists()) {
				f.mkdirs();
			}
			
			
			if (!procedureImage.isEmpty()) {
				String dateName = new SimpleDateFormat("yyyyMMddHHmm").format(new Date());
				String originalFileName = dateName + "-"
						+ procedureImage.getOriginalFilename().replace(" ", "-").toLowerCase();
				Path fileNameAndPath = Paths.get(uploadProcedureDirectory, originalFileName);
				try {
					Files.write(fileNameAndPath, procedureImage.getBytes());
				} catch (IOException e) {
					e.printStackTrace();
				}
				procedureDetail.setProcedureImage(originalFileName);
				
			}
			else
			{
				procedureDetail.setProcedureImage("");
			}
			
			return procedureDetailService.saveProcedureDetail(procedureDetail);
			
	}

	
	
	@PutMapping(path = "/update-procedure", consumes = { "multipart/form-data" }, produces = "application/json")
	public ProcedureDetail updateProcedureDetail(ProcedureDetail procedureDetail, BindingResult bindingResult,
			@RequestParam("procedureImage") MultipartFile procedureImage) {

			
			File f = new File(uploadProcedureDirectory);
			if (!f.exists()) {
				f.mkdirs();
			}
			
			
			if (!procedureImage.isEmpty()) {
				String dateName = new SimpleDateFormat("yyyyMMddHHmm").format(new Date());
				String originalFileName = dateName + "-"
						+ procedureImage.getOriginalFilename().replace(" ", "-").toLowerCase();
				Path fileNameAndPath = Paths.get(uploadProcedureDirectory, originalFileName);
				try {
					Files.write(fileNameAndPath, procedureImage.getBytes());
				} catch (IOException e) {
					e.printStackTrace();
				}
				procedureDetail.setProcedureImage(originalFileName);
				
			}
			else
			{
				Long id = procedureDetail.getId();
				ProcedureDetail procedureDetail1 = procedureDetailService.getProcedureDetailById(id);
				procedureDetail.setProcedureImage(procedureDetail1.getProcedureImage());
				
			}
			
			return procedureDetailService.saveProcedureDetail(procedureDetail);
			
	}
	

}
