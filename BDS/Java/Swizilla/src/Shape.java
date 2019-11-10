class Point {
	public int x;
	public int y;

	public int getX() {
		return x;
	}

	public void setX(int x) {
		this.x = x;
	}

	public int getY() {
		return y;
	}

	public void setY(int y) {
		this.y = y;
	}

	public Point(int x, int y) {
		this.x = x;
		this.y = y;
	}

	public Point() {
		this(0, 0);
	}

}

interface Shape {
	double calculateArea();
}

class Rectangle implements Shape {
	public Point startPoint;
	public Point endPoint;

	public Rectangle(Point startPoint, Point endPoint) {
		this.startPoint = startPoint;
		this.endPoint = endPoint;
	}
	
	public Rectangle() {
		this(new Point(), new Point());
	}

	public double calculateArea() {
		return Math.abs(endPoint.x - startPoint.x) * Math.abs(endPoint.y - startPoint.y);
	}
}

class Circle implements Shape
{
	public Point centerPoint;
	public double radius;


	public Point getCenterPoint() {
		return centerPoint;
	}

	public void setCenterPoint(Point centerPoint) {
		this.centerPoint = centerPoint;
	}

	public double getRadius() {
		return radius;
	}

	public void setRadius(double radius) {
		this.radius = radius;
	}


	public Circle(Point centerPoint, double radius) {
		this.centerPoint = centerPoint;
		this.radius = radius;
	}

	public Circle() {
		this(new Point(), 0.0);
	}
	
	public double calculateArea() {
		return Math.PI * Math.pow(radius, 2);
	}

}

class ShapeCreator {
	public static Shape newShape(String name) {
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