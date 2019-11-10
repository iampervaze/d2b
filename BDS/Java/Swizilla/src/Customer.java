import java.time.LocalDate;
import java.time.Period;
import java.util.Date;

class Customer {

	private String customerName;
	public LocalDate customerSince;
	public LocalDate dateOfLastPurchase;
	public LocalDate birthday;

	public String getCustomerName() {
		return customerName;
	}

	private void setCustomerName(String customerName) {
		this.customerName = customerName;
	}

	public LocalDate getCustomerSince() {
		return customerSince;
	}

	private void setCustomerSince(LocalDate customerSince) {
		this.customerSince = customerSince;
	}

	public LocalDate getDateOfLastPurchase() {
		return dateOfLastPurchase;
	}

	private void setDateOfLastPurchase(LocalDate dateOfLastPurchase) {
		this.dateOfLastPurchase = dateOfLastPurchase;
	}

	public LocalDate getBirthday() {
		return birthday;
	}

	private void setBirthday(LocalDate birthday) {
		this.birthday = birthday;
	}


	public Customer(String customerName, LocalDate customerSince, LocalDate dateOfLastPurchase, LocalDate birthday) {
		this.customerName = customerName;
		this.customerSince = customerSince;
		this.dateOfLastPurchase = dateOfLastPurchase;
		this.birthday = birthday;
	}

	@Override
	public String toString()
        {
            return 
                "{" +
                "Name: " + customerName + ", " +
                "Since: " + customerSince + ", " +
                "Last Purchase: " + dateOfLastPurchase+ ", " +
                "Birthday " + birthday +
                "}";
        }
}

class CustomerDiscount {
	public static double calculateDiscount(Customer customer) {
		// If Longterm customer (more than 10 years)
		Period years = Period.between(LocalDate.now(), customer.customerSince);
		if (years.getYears() > 10)
			return 0.20;

		// Happy Birthday
		if ((LocalDate.now().getDayOfMonth() == customer.birthday.getDayOfMonth()) && (LocalDate.now().getMonth() == customer.birthday.getMonth()))
			return .15;

		// If last purchase in 30 days
		Period days = Period.between(LocalDate.now(), customer.dateOfLastPurchase);
		if (days.getDays() < 30)
			return .08;
		return 0;
	}
}