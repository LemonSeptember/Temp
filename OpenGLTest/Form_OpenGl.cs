using SharpGL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OpenGLTest
{
    public partial class Form_OpenGl : Form
    {
        public Form_OpenGl()
        {
            InitializeComponent();
        }

        private OpenGL A_Gl;

        private void Form_OpenGl_Load(object sender, EventArgs e)
        {
            A_Gl = openGLControl1.OpenGL;
            InitDrawOpenGL(A_Gl, openGLControl1.Size);
            openGLControl1.OpenGLDraw += new RenderEventHandler(OpenGLControl1_OpenGLDraw);
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
            DrawImgae(A_Gl);
        }

        private void DrawImgae(OpenGL gl)
        {
            Color backgroundColor = Color.White;
            /******************  清空屏幕  ********************/
            gl.ClearColor(backgroundColor.R / 255f, backgroundColor.G / 255f, backgroundColor.B / 255f, backgroundColor.A);
            gl.EnableClientState(OpenGL.GL_VERTEX_ARRAY);
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT);

            {
                gl.LineWidth(3);
                Color color = Color.Red;
                gl.Color(color.R, color.G, color.B);
                gl.LineStipple(2, 0xFE18);
                gl.Enable(OpenGL.GL_LINE_STIPPLE);
                gl.Begin(OpenGL.GL_LINES);
                gl.Vertex(10, 10);
                gl.Vertex(50, 50);
                gl.End();
                gl.Disable(OpenGL.GL_LINE_STIPPLE);
            }
            {
                gl.PointSize(50);
                int centerX = 10;
                int centerY = 10;
                Color color = Color.Red;
                gl.Color(color.R, color.G, color.B);
                gl.Begin(OpenGL.GL_POINTS);
                gl.Vertex(centerX, centerY);
                gl.End();
            }
        }

    }
}
