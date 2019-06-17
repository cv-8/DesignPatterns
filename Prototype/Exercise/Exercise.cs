using System;

  namespace Coding.Exercise
  {
    public class Point
    {
      public int X, Y;
    }

    public class Line
    {
      public Point Start, End;

      public Line DeepCopy()
      {
          Line NewLine = new Line();
		  Point NewStart = new Point();
		  Point NewEnd = new Point();
		  
		  NewStart.X = Start.X;
		  NewStart.Y = Start.Y;
		  NewEnd.X = End.X;
		  NewEnd.Y = End.Y;
		  
		  NewLine.Start = NewStart;
		  NewLine.End = NewEnd;
		  
		  return NewLine;
      }
    }
  }
