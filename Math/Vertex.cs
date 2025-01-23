using System.Numerics;

namespace ProjectTerra.Framework.Math;

public struct Vertex {
    public Vector3 Position;
    public Vector3 Color;
    public Vector2 TexCoord;

    public Vertex(Vector3 position, Vector3 color, Vector2 texCoord) {
        Position = position;
        Color = color;
        TexCoord = texCoord;
    }

    public static int Size => sizeof(float) * 8;
}