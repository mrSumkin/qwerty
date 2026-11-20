using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TimelapseVertigo.Materialization.Batching;

// Token: 0x0200077C RID: 1916
public struct b04 : ISpriteBatchVertex<dyj>, IVertexType
{
	// Token: 0x0600308C RID: 12428 RVA: 0x0012BA14 File Offset: 0x00129C14
	public VertexDeclaration get_VertexDeclaration()
	{
		return b04.a;
	}

	// Token: 0x0600308E RID: 12430 RVA: 0x0012BA94 File Offset: 0x00129C94
	public VertexDeclaration ac3()
	{
		return b04.a;
	}

	// Token: 0x0600308F RID: 12431 RVA: 0x0012BA9C File Offset: 0x00129C9C
	public void ac4(float A_0, float A_1, float A_2, float A_3, Color A_4, ref dyj A_5)
	{
		this.b.X = A_0;
		this.b.Y = A_1;
		this.c.X = A_2;
		this.c.Y = A_3;
		this.d = A_4;
		this.f = A_5.b;
		this.e = A_5.c;
	}

	// Token: 0x04001AA2 RID: 6818
	public static readonly VertexDeclaration a = new VertexDeclaration(new VertexElement[]
	{
		new VertexElement(0, VertexElementFormat.Vector3, VertexElementUsage.Position, 0),
		new VertexElement(12, VertexElementFormat.Vector2, VertexElementUsage.TextureCoordinate, 0),
		new VertexElement(20, VertexElementFormat.Color, VertexElementUsage.Color, 0),
		new VertexElement(24, VertexElementFormat.Vector2, VertexElementUsage.Normal, 0),
		new VertexElement(32, VertexElementFormat.Byte4, VertexElementUsage.BlendIndices, 0)
	});

	// Token: 0x04001AA3 RID: 6819
	public Vector3 b;

	// Token: 0x04001AA4 RID: 6820
	public Vector2 c;

	// Token: 0x04001AA5 RID: 6821
	public Color d;

	// Token: 0x04001AA6 RID: 6822
	public Vector2 e;

	// Token: 0x04001AA7 RID: 6823
	public byte f;

	// Token: 0x04001AA8 RID: 6824
	public byte g;

	// Token: 0x04001AA9 RID: 6825
	public byte h;

	// Token: 0x04001AAA RID: 6826
	public byte i;
}
