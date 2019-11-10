public class Billing {
	public static double calculateTariff(int units) {
		/*
		 * Tariff Map First 100 units are at Rs. 1.35 Next 200 units are at Rs. 4.05
		 * Next 300 units are at Rs. 6.75 Beyond 500 units are at Rs. 8.05
		 */

		if (units <= 100)
			return (units * 1.35);

		if (units <= 300)
			return ((100 * 1.35) + ((units - 100) * 4.05));

		if (units <= 500)
			return ((100 * 1.35) + (200 * 4.05) + ((units - 300) * 6.75));

		return ((100 * 1.35) + (200 * 4.05) + (300 * 6.75) + ((units - 500) * 8.0));
    }
}
