using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpGL;
using SharpGL.WinForms;
using nsSpline; // Расчет и отрисовка сплайна

namespace DemoSpline
{
    public partial class FormMain : Form
    {
        short[] VerGrid; // массив (x,y)-вершин для отрисовки сетки
        int CentrX = 0; //  X-координата центра области рисования
        int CentrY = 0; //  Y-координата центра области рисования
        float ScaleXY = 1; // коэффициент масштабирования по OX и OY
        float ShiftX = 0;  // сдвиг по OX
        double ShiftY = 0;  // сдвиг по OY
        int GridStep = 100; // шаг сетки в пикселях
        bool LineVisible = true; // видимость направляющих
        ushort LineStipple = 0xFFFF; // шаблон для направляющих
        int LineWidth = 2; // толщина (в пикселях) направляющих
        int PointSize = 5; // размер (в пикселях) контрольных точек
        int PointSelect = -1; // выделение черным цветом выбранной контрольной точки
        Color PointColor = Color.FromName("Red"); // цвет контрольных точек
        Color GraphColor = Color.FromName("Blue"); // цвет графика сплайна
        Color LineColor = Color.FromName("Gray"); // цвет направляющих
        cSpline Spline; // класс для расчета и отрисовки сплайна
        bool flag = true;

        public FormMain()
        {
            InitializeComponent();
            buttonVertexAll.Text = Spline.vertex.Count.ToString();
            comboBoxLine.SelectedIndex = 2;
            numericUpDownGraph.Value = LineWidth;
            radioButtonSmoothOn1_CheckedChanged(FormMain.ActiveForm, null);
            comboBoxGrid.SelectedIndex = 2;

            toolStripStatusLabelVerOpengl.Text = GL.OpenGLVersion.ToString().Replace('_', '.') + "  ";
            toolStripStatusLabelVerSharpgl.Text = GL.ProductName + " " + GL.ProductVersion + "  ";
        }

        private void GL_OpenGLInitialized(object sender, EventArgs e) // Инициализация библиотеки
        {
            OpenGL gl = GL.OpenGL;
            int W = GL.Width;
            int H = GL.Height;

            gl.Disable(OpenGL.GL_DEPTH_TEST);

            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.LoadIdentity();
            gl.Ortho(0, W, 0, H, -1, 1);
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
            gl.LoadIdentity();

            CentrX = W / 2;
            CentrY = H / 2;

            short w = (short)W;
            short h = (short)H;
            short cx = (short)CentrX;
            short cy = (short)CentrY;
            short step = (short)GridStep;
            int len = (w + h) / step + 2;
            VerGrid = new short[len * 4];
            VerGrid[0] = cx; VerGrid[1] = 0; VerGrid[2] = cx; VerGrid[3] = h;
            VerGrid[4] = 0; VerGrid[5] = cy; VerGrid[6] = w; VerGrid[7] = cy;
            int pos = 8;
            for (short x = (short)(cx + step); x < w; x += step) { VerGrid[pos++] = x; VerGrid[pos++] = 0; VerGrid[pos++] = x; VerGrid[pos++] = h; }
            for (short x = (short)(cx - step); x > 0; x -= step) { VerGrid[pos++] = x; VerGrid[pos++] = 0; VerGrid[pos++] = x; VerGrid[pos++] = h; }
            for (short y = (short)(cy + step); y < h; y += step) { VerGrid[pos++] = 0; VerGrid[pos++] = y; VerGrid[pos++] = w; VerGrid[pos++] = y; }
            for (short y = (short)(cy - step); y > 0; y -= step) { VerGrid[pos++] = 0; VerGrid[pos++] = y; VerGrid[pos++] = w; VerGrid[pos++] = y; }
            if (flag)
            {
                flag = false;
                Spline = new cSpline(gl);
            }
        }

        private void GL_OpenGLDraw(object sender, RenderEventArgs args)  // Функция Display, вызывается по таймеру (RenderTrigger = TimerBased )
        {
            OpenGL gl = GL.OpenGL;
            gl.ClearColor(1f, 1f, 1f, 1f);
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT);
            gl.LoadIdentity();

            /* Отрисовка сетки */
            gl.Color(0.9,0.9,0.9);
            gl.LineWidth(1);
            gl.EnableClientState(OpenGL.GL_VERTEX_ARRAY);
             gl.VertexPointer(2, 0, VerGrid);
             gl.DrawArrays(OpenGL.GL_LINES, 0, VerGrid.Count()/2);
            gl.DisableClientState(OpenGL.GL_VERTEX_ARRAY);
            gl.PointSize(10);
            gl.Begin(OpenGL.GL_POINTS);
             gl.Vertex(CentrX, CentrY);
            gl.End();
            int[] xy=new int[4];
            xy[0] = 0;
            xy[1] = 0;
            xy[2] = GL.Width;
            xy[3] = 0;

            /* Смена системы координат (сдвиг и масштабирование) */
            gl.Translate(ShiftX, ShiftY, 0f);
            if (ScaleXY != 1)
            {
                gl.Translate(CentrX, CentrY, 0f);
                gl.Scale(1, ScaleXY, 1f);
                gl.Translate(-CentrX, -CentrY, 0f);
            }
            gl.Color(0.0, 0.0, 0.0);
            gl.EnableClientState(OpenGL.GL_VERTEX_ARRAY);
            gl.VertexPointer(2, 0, xy);
            gl.DrawArrays(OpenGL.GL_LINES, 0, 2);
            gl.DisableClientState(OpenGL.GL_VERTEX_ARRAY);
            gl.LineStipple(1, 0xFFFF);
            gl.LineWidth(LineWidth);
            gl.Color(GraphColor.R, GraphColor.G, GraphColor.B);
            Spline.Draw(GL.Width);
            /* Отрисовка направляющих */
            gl.EnableClientState(OpenGL.GL_VERTEX_ARRAY);
             gl.VertexPointer(2, 0, Spline.only_vertex);
             if (LineVisible)
             {
                gl.LineWidth(1);
                gl.Enable(OpenGL.GL_LINE_STIPPLE);
                 gl.LineStipple(1, LineStipple);
                 gl.Color(LineColor.R, LineColor.G, LineColor.B);
                 gl.DrawArrays(OpenGL.GL_LINE_STRIP, 0, Spline.only_vertex.Count()/2);
                gl.Disable(OpenGL.GL_LINE_STIPPLE);
             }
            gl.DisableClientState(OpenGL.GL_VERTEX_ARRAY);
            /* Отрисовка контрольных точек */
            gl.EnableClientState(OpenGL.GL_VERTEX_ARRAY);
             gl.Color(PointColor.R, PointColor.G, PointColor.B);
             gl.PointSize(PointSize);
             gl.DrawArrays(OpenGL.GL_POINTS, 0, Spline.only_vertex.Count() / 2);
             if (PointSelect != -1)
             {
                gl.Color(0, 0, 0);
                gl.DrawArrays(OpenGL.GL_POINTS, PointSelect, 1);
             }
            gl.DisableClientState(OpenGL.GL_VERTEX_ARRAY);
            gl.Finish();
        }


        private void GL_Resized(object sender, EventArgs e)
        {
            GL_OpenGLInitialized(sender, e);
        }

        private void GL_MouseClick(object sender, MouseEventArgs e)
        {
            if (ShiftX != 0 || ShiftY != 0 || ScaleXY != 1)
            {
                MessageBox.Show(" Восстановлена исходная \n система координат", "Внимаение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                buttonNaviReset_Click(sender, e);
                return;
            }

            int w = GL.Width;
            int h = GL.Height;
            int x = e.Location.X;
            int y = e.Location.Y;
            if(!Spline.search(new Points((double)x, (double)(h - y))))
                 Spline.add_point(new Points((double)x, (double)(h - y) ));
            else MessageBox.Show("Невозможно поставить еще одну узел в данную точку", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            buttonVertexAll.Text = Spline.vertex.Count().ToString();
            checkBoxVertex_CheckedChanged(sender, e);
        }

        private void buttonVertexSingle_Click(object sender, EventArgs e)
        {
            int pos = -1;
            if(dataGridViewVertex.CurrentRow != null) pos= dataGridViewVertex.CurrentRow.Index;
            if (pos < 0) { MessageBox.Show(" Выбирите вершину для удаления", "Внимаение", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            Spline.remove(pos);
            if (Spline.vertex.Count != 0)
            Spline.calc();
            if (pos-1 == Spline.vertex.Count) pos--;
            
            buttonVertexAll.Text = Spline.vertex.Count.ToString();
            checkBoxVertex_CheckedChanged(sender, e);

            PointSelect = pos;
            if(pos>=0&&Spline.flag) dataGridViewVertex.CurrentCell = dataGridViewVertex.Rows[pos].Cells[0];
        }

        private void buttonVertexAll_Click(object sender, EventArgs e)
        {
            Spline.vertex.Clear();
            dataGridViewVertex.Rows.Clear();
            checkBoxVertex_CheckedChanged(sender, e);
            buttonVertexAll.Text = Spline.vertex.Count.ToString();

            PointSelect = -1;
        }

        private void checkBoxVertex_CheckedChanged(object sender, EventArgs e)
        {
            if(Spline.vertex.Count!=0)
            Spline.sort();

            dataGridViewVertex.Rows.Clear();
            for (int i = 0; i < Spline.vertex.Count; i++)
            {
                dataGridViewVertex.Rows.Add();
                dataGridViewVertex[0, i].Value = (i + 1).ToString();
                dataGridViewVertex[1, i].Value = Spline.vertex[i].first.x.ToString("G");
                dataGridViewVertex[2, i].Value = Spline.vertex[i].first.y.ToString("G");
            }
            if (Spline.vertex.Count > 0)
            {
                dataGridViewVertex.Rows.Add();
                dataGridViewVertex[0, Spline.vertex.Count].Value = (Spline.vertex.Count + 1).ToString();
                dataGridViewVertex[1, Spline.vertex.Count].Value = Spline.vertex[Spline.vertex.Count - 1].second.x.ToString("G");
                dataGridViewVertex[2, Spline.vertex.Count].Value = Spline.vertex[Spline.vertex.Count - 1].second.y.ToString("G");
            }
            if (Spline.vertex.Count == 0&&Spline.flag)
            {
                dataGridViewVertex.Rows.Add();
                dataGridViewVertex[0, Spline.vertex.Count].Value = (Spline.vertex.Count + 1).ToString();
                dataGridViewVertex[1, Spline.vertex.Count].Value = Spline.prev.x.ToString("G");
                dataGridViewVertex[2, Spline.vertex.Count].Value = Spline.prev.y.ToString("G");
            }
            if (Spline.vertex.Count > 0) dataGridViewVertex.CurrentCell = dataGridViewVertex.Rows[Spline.vertex.Count].Cells[0];
            PointSelect = Spline.vertex.Count;
        }

        private void buttonNavi12_Click(object sender, EventArgs e)
        {
            ScaleXY /= 2f;
            if (ScaleXY > 1) toolStripStatusLabelScaleXYv.Text = ScaleXY.ToString() + ":1";
            else if (ScaleXY < 1) toolStripStatusLabelScaleXYv.Text = "1:" + (1 / ScaleXY).ToString();
                 else toolStripStatusLabelScaleXYv.Text = "1:1";
        }

        private void buttonNavi21_Click(object sender, EventArgs e)
        {
            ScaleXY *= 2f;
            ScaleXY *= 2f;
            buttonNavi12_Click(sender, e);
        }

        private void buttonNaviReset_Click(object sender, EventArgs e)
        {
            ScaleXY = 1f;
            ShiftX = 0f;
            ShiftY = 0f;
        }

        private void buttonNaviRight_Click(object sender, EventArgs e)
        {
            ShiftX += GridStep;
            ShiftX += GridStep;
            buttonNaviLeft_Click(sender, e);
        }

        private void buttonNaviUp_Click(object sender, EventArgs e)
        {
            ShiftY += GridStep;
            ShiftX += GridStep;
            buttonNaviLeft_Click(sender, e);
        }

        private void buttonNaviLeft_Click(object sender, EventArgs e)
        {
            ShiftX -= GridStep;
            toolStripStatusLabelShiftXv.Text = ShiftX.ToString();
            toolStripStatusLabelShiftYv.Text = ShiftY.ToString();
        }

        private void buttonNaviDown_Click(object sender, EventArgs e)
        {
            ShiftY -= GridStep;
            ShiftX += GridStep;
            buttonNaviLeft_Click(sender, e);
        }

         private void numericUpDownGraph_ValueChanged(object sender, EventArgs e)
        {
            LineWidth = (int)numericUpDownGraph.Value;
        }

        private void buttonGraph_Click(object sender, EventArgs e)
        {
            colorDialogMain.Color = GraphColor;
            colorDialogMain.ShowDialog();
            GraphColor = colorDialogMain.Color;
        }

        private void numericUpDownPoint_ValueChanged(object sender, EventArgs e)
        {
            PointSize = (int)numericUpDownPoint.Value;
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            colorDialogMain.Color = PointColor;
            colorDialogMain.ShowDialog();
            PointColor = colorDialogMain.Color;
        }

        private void radioButtonSmoothOn2_CheckedChanged(object sender, EventArgs e)
        {
            OpenGL gl = GL.OpenGL;
            gl.Enable(OpenGL.GL_POINT_SMOOTH);
            gl.Enable(OpenGL.GL_LINE_SMOOTH);
        }

        private void radioButtonSmoothOn1_CheckedChanged(object sender, EventArgs e)
        {
            OpenGL gl = GL.OpenGL;
            gl.Enable(OpenGL.GL_POINT_SMOOTH);
            gl.Disable(OpenGL.GL_LINE_SMOOTH);
        }

        private void radioButtonSmoothOff_CheckedChanged(object sender, EventArgs e)
        {
            OpenGL gl = GL.OpenGL;
            gl.Disable(OpenGL.GL_POINT_SMOOTH);
            gl.Disable(OpenGL.GL_LINE_SMOOTH);
        }

         private void checkBoxLine_CheckedChanged(object sender, EventArgs e)
        {
            LineVisible = checkBoxLine.Checked;
        }

        private void comboBoxLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxLine.SelectedIndex)
            {
                case 0: LineStipple = 0xFFFF; break;
                case 1: LineStipple = 0x0101; break;
                case 2: LineStipple = 0x00F0; break;
                case 3: LineStipple = 0x1C47; break;
            }
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            colorDialogMain.Color = LineColor;
            colorDialogMain.ShowDialog();
            LineColor = colorDialogMain.Color;
        }

        private void GL_MouseMove(object sender, MouseEventArgs e)
        {
            int w = GL.Width;
            int h = GL.Height;

            int x = e.Location.X;
            int y = h - e.Location.Y;

            toolStripStatusLabelPosXv.Text = x.ToString();
            toolStripStatusLabelPosYv.Text = y.ToString();
        }

        private void comboBoxGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridStep = int.Parse((comboBoxGrid.Text));
            GL_OpenGLInitialized(sender, e);
        }

        private void dataGridViewVertex_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridViewVertex.CurrentRow == null) PointSelect = -1;
            else PointSelect = dataGridViewVertex.CurrentRow.Index;
        }

        private void toolStripStatusLabelVerOpengl_Click(object sender, EventArgs e)
        {
            FormVersion.ActiveForm.Activate();
            FormVersion Forma = new FormVersion();
            OpenGL gl = GL.OpenGL;
            string s = "OpenGL version: \n" + gl.GetString(OpenGL.GL_VERSION) + "\n\n"
                     + "Vendor: \n" + gl.GetString(OpenGL.GL_VENDOR) + "\n\n"
                     + "Renderer: \n" + gl.GetString(OpenGL.GL_RENDERER) + "\n\n"
                     + "Extensions: \n" + gl.GetString(OpenGL.GL_EXTENSIONS);
            Forma.SetText = s;
            Forma.ShowDialog();
        }

        private void toolStripStatusLabelAbout_Click(object sender, EventArgs e)
        {
            AboutBox.ActiveForm.Activate();
            AboutBox Forma = new AboutBox();
            Forma.ShowDialog();
        }

        private void toolStripStatusLabelVerSharpgl_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://sharpgl.codeplex.com");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Spline.flag_dif = !Spline.flag_dif;
            //if (Spline.flag_dif)
            //MessageBox.Show("Чтобы увидеть интеграл, нужно уменьшить масштаб", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
