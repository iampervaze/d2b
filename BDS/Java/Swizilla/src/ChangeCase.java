
public class ChangeCase {

	public enum Case {
		Lower, Upper, Pascal
	};

	public static String convert(Case cas, String[] words) {
		String outstring = "";
		switch (cas) {
		case Lower: // lowercase
			for (int i = 0; i < words.length; i++)
				outstring += words[i].toLowerCase();
			break;

		case Upper: // UPPERCASE
			for (int i = 0; i < words.length; i++)
				outstring += words[i].toUpperCase();
			break;

		case Pascal: // PascalCase
			for (int i = 0; i < words.length; i++) {
				outstring += words[i].substring(0, 1).toUpperCase();
				outstring += words[i].substring(1).toLowerCase();
			}
			break;
		}
		return outstring;
	}
}
