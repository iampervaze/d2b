export enum AccountType {
    SavingsAccount, CurrentAccount
}

export class Account {
    private accountType: AccountType;
    private accountNumber: number;
    private holdersName: string;
    private balance: number;


    constructor(accountType: AccountType, accountNumber: number, holdersName: string, balance: number) {

        this.accountType = accountType;
        this.accountNumber = accountNumber;
        this.holdersName = holdersName;
        this.balance = balance;

    }

    toString(): string {
        return "{" + "Account Type: " + this.accountType + ", " + "Account Number: " + this.accountNumber + ", "
            + "Holder's Name: " + this.holdersName + ", " + "Balance: " + this.balance + "}";

    }

    withdraw(amount: number): number {
        switch (this.accountType) {
            case AccountType.SavingsAccount:
                // SavingsAccount needs to maintain minimum balance
                if (this.balance - amount < 500)
                    throw new Error("Insufficient Balance Exception");
                this.balance -= amount;
                break;

            case AccountType.CurrentAccount:
                // CurrentAccount can be 0 balance, but check amount
                if (this.balance - amount < 0)
                    throw new Error("Insufficient Balance Exception");
                this.balance -= amount;
                break;
        }
        return this.balance;
    }

    deposit(amount) {
        switch (this.accountType) {
            case AccountType.SavingsAccount:
            case AccountType.CurrentAccount:
                // Add the amount to balance
                this.balance += amount;
                break;
        }
        return this.balance;
    }
}
