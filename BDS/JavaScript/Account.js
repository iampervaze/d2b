AccountType = {
    SavingsAccount: 0, CurrentAccount: 1
}

function Account(accountType, accountNumber, holdersName, balance) {

    this.accountType = accountType;
    this.accountNumber = accountNumber;
    this.holdersName = holdersName;
    this.balance = balance;

}

Account.prototype.toString = function () {
    return "{" + "Account Type: " + this.accountType + ", " + "Account Number: " + this.accountNumber + ", "
        + "Holder's Name: " + this.holdersName + ", " + "Balance: " + this.balance + "}";

}

Account.prototype.withdraw = function (amount) {
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

Account.prototype.deposit = function (amount) {
    switch (this.accountType) {
        case AccountType.SavingsAccount:
        case AccountType.CurrentAccount:
            // Add the amount to balance
            this.balance += amount;
            break;
    }
    return this.balance;
}


module.exports = {
    Account,
    AccountType
}