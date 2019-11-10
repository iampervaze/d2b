class Account {
	public enum Type {
		SavingsAccount, CurrentAccount
	}

	private Type accountType;
	private int accountNumber;
	private String holdersName;
	private double balance;

	public Type getAccountType() {
		return accountType;
	}

	public void setAccountType(Type accountType) {
		this.accountType = accountType;
	}

	public int getAccountNumber() {
		return accountNumber;
	}

	public void setAccountNumber(int accountNumber) {
		this.accountNumber = accountNumber;
	}

	public String getHoldersName() {
		return holdersName;
	}

	public void setHoldersName(String holdersName) {
		this.holdersName = holdersName;
	}

	public double getBalance() {
		return balance;
	}

	public void setBalance(double balance) {
		this.balance = balance;
	}

	public Account(Type accountType, int accountNumber, String holdersName, double balance) {
		this.accountType = accountType;
		this.accountNumber = accountNumber;
		this.holdersName = holdersName;
		this.balance = balance;
	}

	@Override
	public String toString() {
		return "{" + "Account Type: " + accountType + ", " + "Account Number: " + accountNumber + ", "
				+ "Holder's Name: " + holdersName + ", " + "Balance: " + balance + "}";

	}

	public double withdraw(double amount) throws Exception {
		switch (accountType) {
		case SavingsAccount:
			// SavingsAccount needs to maintain minimum balance
			if (balance - amount < 500)
				throw new Exception("Insufficient Balance Exception");
			balance -= amount;
			break;

		case CurrentAccount:
			// CurrentAccount can be 0 balance, but check amount
			if (balance - amount < 0)
				throw new Exception("Insufficient Balance Exception");
			balance -= amount;
			break;
		}
		return balance;
	}

	public double deposit(double amount) {
		switch (accountType) {
		case SavingsAccount:
		case CurrentAccount:
			// Add the amount to balance
			balance += amount;
			break;
		}
		return balance;
	}
}
