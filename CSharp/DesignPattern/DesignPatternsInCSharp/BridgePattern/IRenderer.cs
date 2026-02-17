using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.BridgePattern
{
    public interface IRenderer
    {
        void Render(string shapeName);
    }

    public class OpenGLRenderer : IRenderer
    {
        public void Render(string shapeName)
        {
            Console.WriteLine($"Rendering {shapeName} using OpenGL");
        }
    }

    public class DirectXRenderer : IRenderer
    {
        public void Render(string shapeName)
        {
            Console.WriteLine($"Rendering {shapeName} using DirectX");
        }
    }
}
