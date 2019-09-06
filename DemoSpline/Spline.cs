using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL;

namespace nsSpline
{
    public class Points
    {
        public double x; //argument
        public double y; //y=f(x)
        public static bool operator >(Points a, Points b) { return a.x > b.x; }
        public static bool operator <(Points a, Points b) { return a.x < b.x; }
        public static bool operator ==(Points a, Points b) { return a.x == b.x; }
        public static bool operator !=(Points a, Points b) { return a.x != b.x; }
        public Points(double x, double y) { this.x = x; this.y = y; }
    }

    public class Lagrange
    {
        public Points first;
        public Points second;
        double h;
        double a;
        double b;
        double c;

        public void calc_koef()
        {
            this.h = second.x - first.x;
            double dif = (second.y - first.y) / h;
            this.a = 0;
            this.b = dif;
            this.c = first.y - dif * first.x;
        }

        public void calc_koef_all(Lagrange prev)
        {
            this.h = second.x - first.x;
            double dif = (second.y - first.y) / h;
            double beta = 2 * prev.a * first.x + prev.b;
            this.a = dif / h - beta / h;
            this.b = beta - 2 * a * first.x;
            this.c = first.y - beta * first.x + a * first.x * first.x;
        }

        public void add_point(Points a, Points b, bool type, Lagrange prev)
        {
            if (a > b) { this.second = a; this.first = b; }
            else { this.second = b; this.first = a; }

            if (type) calc_koef();
            else calc_koef_all(prev);

        }
        public Lagrange(Points a, Points b)
        {
            if (a > b) { this.second = a; this.first = b; }
            else { this.second = b; this.first = a; }
            calc_koef();
        }
        public double get_func(double x)
        {
            return a * x * x + b * x + c;
        }
        public double get_derivative(double x)
        {
            return a * 2 * x + b;
        }
        public Lagrange()
        { }
    }
    public class cSpline
    {
        public OpenGL gl;
        public List<Lagrange> vertex;
        public bool flag = false;
        public Points prev;
        public double func_value;
        public double[] func_spline_value;
        public double[] integral_spline_value;
        public bool flag_dif = false;
        public double[] only_vertex;
        public Lagrange prev1;
        public bool search(Points a)
        {
            if (vertex.Count == 0 && flag)
            {
                if (prev == a)
                { return true; }
                else
                { return false; }
            }
            if (vertex.Count != 0)
            {
                if (vertex[0].first == a) return true;
            }

            foreach (Lagrange b in vertex)
            {
                if (a == b.second) return true;
                if (a == b.first) return true;
            }
            return false;
        }
        public void add_point(Points a)
        {
            if (vertex.Count() == 0)
            {
                if (flag) { vertex.Add(new Lagrange(prev, a)); flag = false; }
                else { prev = a; flag = true; }
            }
            else
            {
                Lagrange b = new Lagrange();
                b.add_point(vertex[vertex.Count() - 1].second, a, false, vertex[vertex.Count() - 1]);
                vertex.Add(b);
            }
        }
        public void remove(int index)
        {
            if (index == 0 && vertex.Count == 1)
            {
                prev = vertex[index].second;
                vertex.Remove(vertex[index]);
                flag = true; return;
            }
            if (index == 1 && vertex.Count == 1)
            {
                prev = vertex[index - 1].first;
                vertex.Remove(vertex[index - 1]);
                flag = true; return;
            }
            if (index == 0 && vertex.Count == 0)
            {
                flag = false; return;
            }
            if (index == 0)
            {
                vertex.Remove(vertex[index]);
                return;
            }
            if (index == vertex.Count)
            {
                vertex.Remove(vertex[index - 1]); return;
            }
            if (index == 1 && vertex.Count == 2)
            {
                vertex[0].second = vertex[1].second;
                vertex.Remove(vertex[1]); return;
            }
            if (index == vertex.Count - 1)
            {
                vertex[index - 2].second = vertex[index - 1].second;
                vertex.Remove(vertex[index - 1]); return;
            }
            vertex[index - 1].second = vertex[index + 1].first;
            vertex.Remove(vertex[index]);

        }
        public void calc()
        {
            vertex[0].calc_koef();
            for (int i = 1; i < vertex.Count; i++)
                vertex[i].calc_koef_all(vertex[i - 1]);
        }

        public cSpline(OpenGL _gl)  // Констуктор
        {
            vertex = new List<Lagrange>();
            gl = _gl;
        }
        public bool get_func(double x)
        {
            foreach (Lagrange a in vertex)
            {
                if (a.first.x < x && a.second.x >= x)
                {
                    this.func_value = a.get_func(x); return true;
                }
            }
            return false;
        }
        public void sort()
        {
            Points u = vertex[vertex.Count() - 1].second;
            double max = 0;
            for (int k = 0; k < vertex.Count(); k++)
            {
                if (max < vertex[k].second.x) { max = vertex[k].second.x; u = vertex[k].second; }
            }
            bool inv = true;
            while (inv)
            {
                inv = false;
                for (int i = 1; i < vertex.Count; i++)
                {
                    int j = i - 1;
                    if (vertex[j].first > vertex[i].first)
                    {
                        Lagrange tmp = vertex[j]; vertex[j] = vertex[i]; vertex[i] = tmp;
                        inv = true;
                    }
                }
            }
            vertex[vertex.Count - 1].second = u;
            for (int i = 1; i < vertex.Count; i++)
            {
                vertex[i - 1].second = vertex[i].first;
            }
            calc();

        }
        public void Draw(int w)
        {
            List<double> ax = new List<double>();
            List<double> ay = new List<double>();
            List<double> der_y = new List<double>();
            List<double> der_x = new List<double>();
            if (vertex.Count > 0) prev1 = vertex[0];
            for (double i = 0; i < w; i += 0.1)
            {
                if (get_func((double)i))
                {
                    ay.Add(this.func_value);
                    ax.Add((double)i);
                }
            }
            if (vertex.Count > 0)
            {
                double y = 0, y1 = 0, y0 = 0;
                foreach (Lagrange a in vertex)
                {
                    int steps = 1000;
                    double h = (a.second.x - a.first.x) / steps;
                    double x = a.first.x;
                    y1 = a.get_derivative(x);
                    for (int i = 0; i < steps; i++)
                    {
                        x += h;
                        y = -y1 + y0 + a.get_derivative(x);
                        der_y.Add(y);
                        der_x.Add(x);
                    }
                    y0 = y;
                }
            }

            only_vertex = new double[vertex.Count * 2 + 2];
            for (int i = 0; i < vertex.Count * 2; i += 2)
            {
                only_vertex[i] = vertex[i / 2].first.x;
                only_vertex[i + 1] = vertex[i / 2].first.y;
            }
            if (vertex.Count != 0)
            {
                only_vertex[vertex.Count * 2] = vertex[vertex.Count - 1].second.x;
                only_vertex[vertex.Count * 2 + 1] = vertex[vertex.Count - 1].second.y;
            }
            else
            {
                if (flag)
                {
                    only_vertex[0] = prev.x;
                    only_vertex[1] = prev.y;
                }
            }
            func_spline_value = new double[ay.Count * 2];
            integral_spline_value = new double[der_x.Count * 2];
            for (int i = 0; i < der_x.Count * 2; i += 2)
            {
                integral_spline_value[i] = der_x[i / 2];
                integral_spline_value[i + 1] = der_y[i / 2];
            }
            for (int i = 0; i < ay.Count * 2; i += 2)
            {
                func_spline_value[i] = ax[i / 2];
                func_spline_value[i + 1] = ay[i / 2];
            }
            gl.EnableClientState(OpenGL.GL_VERTEX_ARRAY);
            gl.VertexPointer(2, 0, func_spline_value);
            {
                gl.LineWidth(1);
                gl.Enable(OpenGL.GL_LINE_STIPPLE);
                gl.DrawArrays(OpenGL.GL_LINE_STRIP, 0, ay.Count);
                gl.Disable(OpenGL.GL_LINE_STIPPLE);
            }
            gl.DisableClientState(OpenGL.GL_VERTEX_ARRAY);
            if (flag_dif)
            {
                gl.EnableClientState(OpenGL.GL_VERTEX_ARRAY);
                gl.VertexPointer(2, 0, integral_spline_value);
                {
                    gl.LineWidth(1);
                    gl.Enable(OpenGL.GL_LINE_STIPPLE);
                    gl.DrawArrays(OpenGL.GL_LINE_STRIP, 0, der_y.Count);
                    gl.Disable(OpenGL.GL_LINE_STIPPLE);
                }
                gl.DisableClientState(OpenGL.GL_VERTEX_ARRAY);
            }
        }
    }
}
