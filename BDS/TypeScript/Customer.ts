class DateDiff {

    static inDays(d1: Date, d2: Date): number {
        var t2 = d2.getTime();
        var t1 = d1.getTime();

        return (t2 - t1) / (24 * 3600 * 1000);
    }

    static inWeeks(d1: Date, d2: Date): number {
        let t2 = d2.getTime();
        let t1 = d1.getTime();

        return (t2 - t1) / (24 * 3600 * 1000 * 7);
    }

    static inMonths(d1: Date, d2: Date): number {
        let d1Y = d1.getFullYear();
        let d2Y = d2.getFullYear();
        let d1M = d1.getMonth();
        let d2M = d2.getMonth();

        return (d2M + 12 * d2Y) - (d1M + 12 * d1Y);
    }

    static inYears(d1: Date, d2: Date): number {
        return d2.getFullYear() - d1.getFullYear();
    }
}

export class Customer {
    constructor(public customerName: string, public customerSince: Date, public dateOfLastPurchase: Date, public birthday: Date) {
        this.customerName = customerName;
        this.customerSince = customerSince;
        this.dateOfLastPurchase = dateOfLastPurchase;
        this.birthday = birthday;
    }

    toString() {
        return
        "{" +
            "Name: " + this.customerName + ", " +
            "Since: " + this.customerSince + ", " +
            "Last Purchase: " + this.dateOfLastPurchase + ", " +
            "Birthday " + this.birthday +
            "}";
    }
}

export class CustomerDiscount {
    static calculateDiscount(customer: Customer) {
        // If Long term customer (more than 10 years)
        if (DateDiff.inYears(new Date(), customer.customerSince) > 10)
            return 0.20;

        // Happy Birthday
        if (new Date().getDate() == customer.birthday.getDate() && new Date().getMonth() == customer.birthday.getMonth())
            return .15;

        // If last purchase in 30 days
        if (DateDiff.inMonths(new Date(), customer.dateOfLastPurchase) < 30)
            return .08;
        return 0;
    }
}
