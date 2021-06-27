package com.doctor.configuration;

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;

import javax.servlet.ServletOutputStream;
import javax.servlet.http.HttpServletResponse;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
public class ImageReadController {

	String uploadMedicalServiceDirectory = System.getProperty("user.dir") + "/uploads/medical-service/";

	
	@RequestMapping("/uploads/medical-service/{serviceImage}")
	public String getMedicalServiceImage(@PathVariable("serviceImage") String serviceImage,
			HttpServletResponse response) {
		try {
			byte b[] = Files.readAllBytes(Paths.get(uploadMedicalServiceDirectory + serviceImage));
			response.setContentLength(b.length);
			response.setContentType("image/jpg");
			ServletOutputStream os = response.getOutputStream();
			os.write(b);
			os.flush();
		} catch (IOException e) {
			e.printStackTrace();
		}
		return null;
	}



}
