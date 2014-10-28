using System.Collections.Generic;
using System.Drawing;

namespace FluentBuilderDemo
{
    public class PolyShapeBuilder<T> where T : IPolyShape, new()
    {
        private T _shape;

        #region Constructor

        public PolyShapeBuilder() : this(new T()) { }

        public PolyShapeBuilder(T shape)
        {
            _shape = shape;
        }

        #endregion

        #region Decorators

        public PolyShapeBuilder<T> SetX(int x)
        {
            _shape.X = x;
            return this;
        }

        public PolyShapeBuilder<T> SetY(int y)
        {
            _shape.Y = y;
            return this;
        }

        public PolyShapeBuilder<T> SetColor(int color)
        {
            _shape.Color = ColorTranslator.FromWin32(color);
            return this;
        }

        public PolyShapeBuilder<T> SetColor(Color color)
        {
            _shape.Color = color;
            return this;
        }

        public PolyShapeBuilder<T> SetColor(string color)
        {
            _shape.Color = ColorTranslator.FromHtml(color);
            return this;
        }

        public PolyShapeBuilder<T> SetFillColor(int color)
        {
            _shape.FillColor = ColorTranslator.FromWin32(color);
            return this;
        }

        public PolyShapeBuilder<T> SetFillColor(Color color)
        {
            _shape.FillColor = color;
            return this;
        }

        public PolyShapeBuilder<T> SetFillColor(string color)
        {
            _shape.FillColor = ColorTranslator.FromHtml(color);
            return this;
        }

        public PolyShapeBuilder<T> SetClosed(bool closed)
        {
            _shape.Closed = closed;
            return this;
        }

        public PolyShapeBuilder<T> AddVector(Vector vector)
        {
            if (_shape.Vectors == null)
                _shape.Vectors = new List<Vector>();
            _shape.Vectors.Add(vector);
            return this;
        }
        #endregion

        #region Builder

        public T Build()
        {
            return _shape;
        }

        #endregion

    }
}
