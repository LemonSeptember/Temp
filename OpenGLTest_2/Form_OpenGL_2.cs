using SharpGL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OpenGLTest_2
{
    public partial class Form_OpenGL_2 : Form
    {
        private int centerX = 0;
        private int centerY = 0;


        public Form_OpenGL_2()
        {
            InitializeComponent();
        }

        private void Form_OpenGL_2_Load(object sender, EventArgs e)
        {
            centerX = 10;
            centerY = 10;

            this.openGLControl1.OpenGLDraw += new SharpGL.RenderEventHandler(this.OpenGLControl1_OpenGLDraw);
            //this.openGLControl1.Paint += OpenGLControl1_Paint;

        }

        private void OpenGLControl1_Paint(object sender, PaintEventArgs e)
        {
            DrawImgae(openGLControl1.OpenGL);
        }

        private void InitDrawOpenGL(OpenGL gl, Size panelSize)
        {
            //设置显示视图
            gl.Viewport(0, 0, panelSize.Width, panelSize.Height);
            //设置透视矩阵
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            //重置矩阵
            gl.LoadIdentity();
            //设置 3d 显示区间
            gl.Frustum(0, panelSize.Width, 0, panelSize.Height, 3f, 7f);
            //设置 模型矩阵
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
            //重置矩阵
            gl.LoadIdentity();
            //设置相机位置
            gl.LookAt(0f, 0f, 3f, 0f, 0f, 0f, 0f, 1f, 0f);
        }

        private void OpenGLControl1_OpenGLDraw(object sender, RenderEventArgs args)
        {
            DrawImgae((sender as OpenGLControl).OpenGL);

            //OpenGL gl = openGLControl1.OpenGL;
            //gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT | OpenGL.GL_STENCIL_BUFFER_BIT);

            //gl.LoadIdentity();
            //gl.Rotate(rotation, 0.0f, 1.0f, 0.0f);
            //gl.Begin(OpenGL.GL_TRIANGLES);
        }

        private void DrawImgae(OpenGL gl)
        {
            Color backgroundColor = Color.Pink;
            /******************  清空屏幕  ********************/
            //gl.ClearColor(backgroundColor.R, backgroundColor.G, backgroundColor.B, backgroundColor.A);
            gl.ClearColor(backgroundColor.R / 255f, backgroundColor.G / 255f, backgroundColor.B / 255f, backgroundColor.A);
            gl.EnableClientState(OpenGL.GL_VERTEX_ARRAY);
            //gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT);
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT | OpenGL.GL_STENCIL_BUFFER_BIT);

            centerX++;
            if (centerX > openGLControl1.Width)
            {
                centerX = 10;
            }
            centerY++;
            if (centerY > openGLControl1.Height)
            {
                centerY = 10;
            }

            int x = centerX;
            int y = openGLControl1.Height - centerY;

            //{
            //    gl.PointSize(50f);
            //    Color color = Color.Red;
            //    gl.Color(color.R, color.G, color.B);
            //    gl.Begin(OpenGL.GL_POINTS);
            //    gl.Vertex(x, y);
            //    gl.End();
            //}

            //{
            //    gl.LineWidth(3);
            //    Color color = Color.Blue;
            //    gl.Color(color.R, color.G, color.B);
            //    gl.LineStipple(2, 0b1111111000011000);
            //    gl.Enable(OpenGL.GL_LINE_STIPPLE);
            //    gl.Begin(OpenGL.GL_LINES);
            //    gl.Vertex(10, 10);
            //    gl.Vertex(x, y);
            //    gl.End();
            //    gl.Disable(OpenGL.GL_LINE_STIPPLE);
            //}

            //{
            //    int x1 = 300;
            //    int x2 = 350;
            //    int y1 = 300;
            //    int y2 = 350;
            //    Color color = Color.Green;
            //    gl.Color(color.R, color.G, color.B);
            //    gl.Begin(OpenGL.GL_POLYGON);
            //    gl.Vertex(x1, y1);
            //    gl.Vertex(x1, y2);
            //    gl.Vertex(x2, y2);
            //    gl.Vertex(x2, y1);
            //    gl.End();
            //}
            {

                float Pi = 3.1415926536f;
                float R = 0.5f;
                int n = 1000;
                Color color = Color.White;
                //gl.PointSize(1f);
                gl.Color(color.R, color.G, color.B);
                gl.Begin(OpenGL.GL_POINTS);
                for (int i = 0; i < n; i++)
                {
                    gl.Vertex(R * Math.Cos(2 * Pi / n * i), R * Math.Sin(2 * Pi / n * i));
                }
                gl.End();
            }
        }

        private void openGLControl1_OpenGLInitialized(object sender, EventArgs e)
        {
            InitDrawOpenGL(openGLControl1.OpenGL, openGLControl1.Size);
        }

        private void openGLControl1_Resized(object sender, EventArgs e)
        {
            InitDrawOpenGL(openGLControl1.OpenGL, openGLControl1.Size);
        }

        private void openGLControl1_Load(object sender, EventArgs e)
        {

        }

        private void mTimer_Tick(object sender, EventArgs e)
        {
            openGLControl1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mTimer.Enabled = !mTimer.Enabled;
            button1.Text = mTimer.Enabled.ToString();
        }
    }
}
