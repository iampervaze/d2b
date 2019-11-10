export class Point {
    constructor(public x: number = 0, public y: number = 0) {

    }

}

export interface Shape {
    calculateArea(): number;
}

export class Rectangle implements Shape {

    constructor(public startPoint: Point = new Point(), public endPoint: Point = new Point()) {
    }

    public calculateArea(): number {
        return Math.abs(this.endPoint.x - this.startPoint.x) * Math.abs(this.endPoint.y - this.startPoint.y);
    }
}

export class Circle implements Shape {
    constructor(public centerPoint: Point = new Point(), public radius: number = 0.0) {
    }



    public calculateArea(): number {
        return Math.PI * Math.pow(this.radius, 2);
    }

}

export class ShapeCreator {
    static newShape(name: string): Shape {
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