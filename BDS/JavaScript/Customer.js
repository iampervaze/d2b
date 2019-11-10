let DateDiff = {

    inDays: function (d1, d2) {
        var t2 = d2.getTime();
        var t1 = d1.getTime();

        return parseInt((t2 - t1) / (24 * 3600 * 1000));
    },

    inWeeks: function (d1, d2) {
        let t2 = d2.getTime();
        let t1 = d1.getTime();

        return parseInt((t2 - t1) / (24 * 3600 * 1000 * 7));
    },

    inMonths: function (d1, d2) {
        let d1Y = d1.getFullYear();
        let d2Y = d2.getFullYear();
        let d1M = d1.getMonth();
        let d2M = d2.getMonth();

        return (d2M + 12 * d2Y) - (d1M + 12 * d1Y);
    },

    inYears: function (d1, d2) {
        return d2.getFullYear() - d1.getFullYear();
    }
}

function Customer(customerName, customerSince, dateOfLastPurchase, birthday) {
    this.customerName = customerName;
    this.customerSince = customerSince;
    this.dateOfLastPurchase = dateOfLastPurchase;
    this.birthday = birthday;
}

Customer.prototype.toString = function () {
    return
    "{" +
        "Name: " + customerName + ", " +
        "Since: " + customerSince + ", " +
        "Last Purchase: " + dateOfLastPurchase + ", " +
        "Birthday " + birthday +
        "}";
}


function CustomerDiscount() { }
CustomerDiscount.calculateDiscount = function (customer) {
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

module.exports = {
    Customer,
    CustomerDiscount
}