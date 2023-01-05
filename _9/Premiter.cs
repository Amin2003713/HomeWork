public class Premiter
{
	public int Radius { get; set; }
	public int Rectangel { get; set; }
	public int Height { get; set; }

	private Premiter() { }

	public Premiter(int radius, int rectangel, int height)
	{
		Radius = radius;
		Rectangel = rectangel;
		Height = height;
	}

	public double SquarePremiter()
	{
		return Radius * 4;
	}

	public double Rectangale()
	{
		return (Radius + Rectangel) * 2;
	}

	public double Circle()
	{
		return (Radius) * Math.PI;
	}

	public double Trapezius()
	{
		return ((Radius * Rectangel) / 2) * Height;
	}
}