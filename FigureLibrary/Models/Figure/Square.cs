﻿using FigureLibrary.Models.Interfaces;

namespace FigureLibrary.Models.Figure;

public class Square : IFigure
{
    private Double A { get; init; }

    public Square(Double side)
    {
        if (side > 0)
        {
            this.A = side;
        }
        else { throw new ArgumentException("Argument must be greater than zero"); }
    }

    public Double GetArea()
        => Math.Pow(A, 2);
}
