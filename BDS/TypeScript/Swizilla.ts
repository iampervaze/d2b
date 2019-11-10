
import { Billing } from './Billing';
import { DOW } from './DOW';
import { KeyCode } from './KeyCode';
import { Account, AccountType } from './Account';
import { ChangeCase, Case } from './ChangeCase';
import { Customer, CustomerDiscount } from './Customer';
import { Circle, Point, Rectangle, ShapeCreator } from './Shape';

function main() {
    // Value replace switch (fixed)
    console.log(DOW.dayOfWeek(1))

    // Value replace switch (dynamic over time)
    console.log(KeyCode.getKeyMap(38));

    // Value Action switch
    console.log(ChangeCase.convert(Case.Pascal, ["Numeric", "Value"]));

    // Value Action if-else ladder
    console.log(Billing.calculateTariff(274));

    // // Varied condition if-else ladder
    console.log()
    let brendan = new Customer("Brendan Eich", new Date(2017, 7, 7), new Date(2017, 10, 5), new Date(1961, 7, 4));
    console.log(brendan);
    console.log(CustomerDiscount.calculateDiscount(brendan) * 100 + "%");

    // Multiple switch-case statements
    let dmr = new Account(AccountType.SavingsAccount, 1, "Dennis M. Ritchie", 1000);
    console.log(dmr);
    dmr.withdraw(500);
    console.log(dmr);
    dmr.deposit(10000);
    console.log(dmr);

    // Dynamically creating object of a type
    let circle: Circle = <Circle>(ShapeCreator.newShape("circle"));
    circle.centerPoint = new Point(10, 10);
    circle.radius = 10;
    console.log(circle.calculateArea());

    let rectangle = <Rectangle>(ShapeCreator.newShape("rectangle"));
    rectangle.startPoint = new Point(10, 10);
    rectangle.endPoint = new Point(20, 20);
    console.log(rectangle.calculateArea());
}

main();