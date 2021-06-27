package com.doctor.configuration;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.time.LocalDate;
import java.time.LocalTime;
import java.time.format.DateTimeFormatter;
import java.time.temporal.ChronoUnit;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import java.util.Random;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

import org.json.JSONObject;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.mail.SimpleMailMessage;
import org.springframework.mail.javamail.JavaMailSender;

import com.razorpay.Order;
import com.razorpay.RazorpayClient;
import com.razorpay.RazorpayException;

public class BaseConfiguration {

	@Autowired
	private JavaMailSender javaMailSender;



	protected void sendEmail(String to, String subject, String message) {

		SimpleMailMessage msg = new SimpleMailMessage();
		msg.setFrom("mahesh.aayanshgerminate@gmail.com");
		msg.setTo(to);
		msg.setSubject(subject);
		msg.setText(message);

		javaMailSender.send(msg);

	}

	public Date getCurrentDate() throws ParseException {
		LocalDate localDate = LocalDate.now();
		DateTimeFormatter dateFormatter = DateTimeFormatter.ofPattern("yyyy-MM-dd");
		String formattedDate = localDate.format(dateFormatter);
		Date currentDate = new SimpleDateFormat("yyyy-MM-dd").parse(formattedDate);
		return currentDate;
	}

	public Date convertStringToDateFormat(String dateFormat) throws ParseException {
		Date formattedDate = new SimpleDateFormat("yyyy-MM-dd").parse(dateFormat);
		return formattedDate;
	}

	public Date convertStringToTimeFormat(String timeFormat) throws ParseException {
		Date formattedTime = new SimpleDateFormat("HH:mm").parse(timeFormat);
		return formattedTime;
	}

	public Date getCurrentTime() throws ParseException {
		LocalTime localTime = LocalTime.now();
		DateTimeFormatter dateFormatter = DateTimeFormatter.ofPattern("HH:mm");
		String formattedTime = localTime.format(dateFormatter);
		Date currentTime = new SimpleDateFormat("HH:mm").parse(formattedTime);
		return currentTime;
	}

	public Date getPastOneMonthDate() throws ParseException {
		LocalDate currentDate = LocalDate.now();
		LocalDate pastDate = currentDate.minusMonths(1);
		DateTimeFormatter dateFormatter = DateTimeFormatter.ofPattern("yyyy-MM-dd");
		String formattedDate = pastDate.format(dateFormatter);
		Date pastOneMonthDate = new SimpleDateFormat("yyyy-MM-dd").parse(formattedDate);
		return pastOneMonthDate;
	}

	public Date getPastTwoMonthDate() throws ParseException {
		LocalDate currentDate = LocalDate.now();
		LocalDate pastDate = currentDate.minusMonths(2);
		DateTimeFormatter dateFormatter = DateTimeFormatter.ofPattern("yyyy-MM-dd");
		String formattedDate = pastDate.format(dateFormatter);
		Date pastOneMonthDate = new SimpleDateFormat("yyyy-MM-dd").parse(formattedDate);
		return pastOneMonthDate;
	}

	public Date getPastThreeMonthDate() throws ParseException {
		LocalDate currentDate = LocalDate.now();
		LocalDate pastDate = currentDate.minusMonths(3);
		DateTimeFormatter dateFormatter = DateTimeFormatter.ofPattern("yyyy-MM-dd");
		String formattedDate = pastDate.format(dateFormatter);
		Date pastOneMonthDate = new SimpleDateFormat("yyyy-MM-dd").parse(formattedDate);
		return pastOneMonthDate;
	}

	public Date getDateAfterFiveDays() throws ParseException {
		LocalDate currentDate = LocalDate.now();
		LocalDate afterFiveDaysDate = currentDate.plusDays(5);
		DateTimeFormatter dateFormatter = DateTimeFormatter.ofPattern("yyyy-MM-dd");
		String formattedDate = afterFiveDaysDate.format(dateFormatter);
		Date afterFiveDayDate = new SimpleDateFormat("yyyy-MM-dd").parse(formattedDate);
		return afterFiveDayDate;
	}

	public Date getDateAfterTwoDays() throws ParseException {
		LocalDate currentDate = LocalDate.now();
		LocalDate afterFiveDaysDate = currentDate.plusDays(2);
		DateTimeFormatter dateFormatter = DateTimeFormatter.ofPattern("yyyy-MM-dd");
		String formattedDate = afterFiveDaysDate.format(dateFormatter);
		Date afterFiveDayDate = new SimpleDateFormat("yyyy-MM-dd").parse(formattedDate);
		return afterFiveDayDate;
	}

	public Date getDateAfterOneDays() throws ParseException {
		LocalDate currentDate = LocalDate.now();
		LocalDate afterFiveDaysDate = currentDate.plusDays(1);
		DateTimeFormatter dateFormatter = DateTimeFormatter.ofPattern("yyyy-MM-dd");
		String formattedDate = afterFiveDaysDate.format(dateFormatter);
		Date afterFiveDayDate = new SimpleDateFormat("yyyy-MM-dd").parse(formattedDate);
		return afterFiveDayDate;
	}

	

	public Long generateFourDigitOtp() {
		String values = "123456789";
		Random rndm_method = new Random();
		char[] obj = new char[4];
		for (int i = 0; i < 4; i++) {
			obj[i] = values.charAt(rndm_method.nextInt(values.length()));
		}
		String data = new String(obj);
		long otp = Long.parseLong(data);
		return otp;
	}

	public Long generateSixDigitOtp() {
		String values = "0123456789";
		Random rndm_method = new Random();
		char[] obj = new char[6];
		for (int i = 0; i < 6; i++) {
			obj[i] = values.charAt(rndm_method.nextInt(values.length()));
		}
		String data = new String(obj);
		long otp = Long.parseLong(data);
		return otp;
	}



	public String getPaymentId(String orderCode, Float amount) throws RazorpayException {
		RazorpayClient razorpay = new RazorpayClient("rzp_live_0NoVzbVRnK4EUy", "pTDiO15DRJaIQRMXQvGdLTYf");
		
//		 RazorpayClient razorpay = new RazorpayClient("rzp_test_BJhpLshlVxMi9A",
				// "Vg5mds21Rn538O6RR7yLhLIQ");
		JSONObject orderRequest = new JSONObject();
		String balanceAmount = String.format("%.02f", amount);
		Float newAmount=Float.parseFloat(balanceAmount);
		

		orderRequest.put("amount", (newAmount * 100));
		// amount in the smallest currency
		orderRequest.put("currency", "INR");
		orderRequest.put("receipt", orderCode);
		Order order1 = razorpay.Orders.create(orderRequest);

		JSONObject obj1 = new JSONObject(order1.toString());

		String paymentId = obj1.getString("id");
		return paymentId;

	}

	public List<Date> getDateListBetweenFiestDateAndLastDate(String firstDate, String lastDate) throws ParseException {
		List<Date> dateList = new ArrayList<Date>();

		DateTimeFormatter formatter = DateTimeFormatter.ofPattern("yyyy-MM-dd");

		LocalDate startDate = LocalDate.parse(firstDate, formatter);
		LocalDate endDate = LocalDate.parse(lastDate, formatter);

		long numOfDaysBetween = ChronoUnit.DAYS.between(startDate, endDate);
		List<LocalDate> weekDateList = IntStream.iterate(0, i -> i + 1).limit(numOfDaysBetween + 1)
				.mapToObj(i -> startDate.plusDays(i)).collect(Collectors.toList());

		for (LocalDate weekDate : weekDateList) {

			DateTimeFormatter dateFormatter = DateTimeFormatter.ofPattern("yyyy-MM-dd");
			String formattedString = weekDate.format(dateFormatter);
			Date reportDate = convertStringToDateFormat(formattedString);
			dateList.add(reportDate);

		}
		return dateList;
	}


	public String sendSms(String phoneNumber, String mymessage) {
		try {
			// Construct data
			String apiKey = "apikey=" + "YTBhZmU1MDAxMTU0NDMwZjc2ZmQyNGJjMDRiODU0NGE=";
			String message = "&message=" + mymessage;

			String sender = "&sender=" + "ONEDSS";
			String numbers = "&numbers=" + phoneNumber;

			// Send data
			HttpURLConnection conn = (HttpURLConnection) new URL("https://api.textlocal.in/send/?").openConnection();
			String data = apiKey + numbers + message + sender;
			conn.setDoOutput(true);
			conn.setRequestMethod("POST");
			conn.setRequestProperty("Content-Length", Integer.toString(data.length()));
			conn.getOutputStream().write(data.getBytes("UTF-8"));
			final BufferedReader rd = new BufferedReader(new InputStreamReader(conn.getInputStream()));
			final StringBuffer stringBuffer = new StringBuffer();
			String line;

			while ((line = rd.readLine()) != null) {
				stringBuffer.append(line);
				System.out.println(line);
			}
			rd.close();

			return stringBuffer.toString();
		} catch (Exception e) {
			System.out.println("Error SMS " + e);
			return "Error " + e;
		}
	}

	public String getDateInString(Date date) {
		String pattern = "dd-MMM-yyyy";

		// Create an instance of SimpleDateFormat used for formatting
		// the string representation of date according to the chosen pattern
		java.text.DateFormat df = new SimpleDateFormat(pattern);

		// Get the today date using Calendar object.
		// Date today = Calendar.getInstance().getTime();
		// Using DateFormat format method we can create a string
		// representation of a date with the defined format.
		String todayAsString = df.format(date);

		// Print the result!
		return todayAsString;
	}

	
	public String getTimeInString(Date time) {
		String pattern = "HH:mm a";

		// Create an instance of SimpleDateFormat used for formatting
		// the string representation of date according to the chosen pattern
		java.text.DateFormat df = new SimpleDateFormat(pattern);

		// Get the today date using Calendar object.
		// Date today = Calendar.getInstance().getTime();
		// Using DateFormat format method we can create a string
		// representation of a date with the defined format.
		String todayAsString = df.format(time);

		// Print the result!
		return todayAsString;
	}
	
}
