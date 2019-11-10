class Point {

    constructor(x, y) {
        this.x = x == undefined ? 0 : x;
        this.y = y == undefined ? 0 : y;
    }


}

class Shape {
    calculateArea() { }
}

class Rectangle extends Shape {

    constructor(startPoint, endPoint) {
        super();
        this.startPoint = startPoint == undefined ? new Point() : startPoint;
        this.endPoint = endPoint == undefined ? new Point() : endPoint;
    }

    calculateArea() {
        return Math.abs(this.endPoint.x - this.startPoint.x) * Math.abs(this.endPoint.y - this.startPoint.y);
    }
}

class Circle extends Shape {


    constructor(centerPoint, radius) {
        super();
        this.centerPoint = centerPoint == undefined ? new Point() : centerPoint;
        this.radius = radius == undefined ? 0 : radius;
    }

    calculateArea() {
        return Math.PI * Math.pow(this.radius, 2);
    }

}

class ShapeCreator {
    static newShape(name) {
        switch (name.toLowerCase()) {
            case "rectangle":
            case "rect":
                return new Rectangle();

            case "circle":
            case "circ":
                return new Circle();
        }
        return null;
    }
}

module.exports = {
    Point,
    Shape,
    Circle,
    Rectangle,
    ShapeCreator
}