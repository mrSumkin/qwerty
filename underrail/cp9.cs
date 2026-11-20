using System;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200011D RID: 285
public sealed class cp9
{
	// Token: 0x060006E5 RID: 1765 RVA: 0x0001C804 File Offset: 0x0001AA04
	public ob b()
	{
		return this.g ?? this.f;
	}

	// Token: 0x060006E6 RID: 1766 RVA: 0x0001C81C File Offset: 0x0001AA1C
	public cp9(GraphicsDevice A_0, SpriteBatch A_1, SpriteSortMode A_2, BlendState A_3)
	{
		this.c = A_0;
		this.b = A_1;
		this.d = A_2;
		this.e = A_3;
		this.f = new bc2(this.b);
	}

	// Token: 0x060006E7 RID: 1767 RVA: 0x0001C868 File Offset: 0x0001AA68
	public void a(RasterizerState A_0 = null)
	{
		this.g = null;
		this.b.Begin(this.d, this.e, SamplerState.PointClamp, null, A_0);
	}

	// Token: 0x060006E8 RID: 1768 RVA: 0x0001C890 File Offset: 0x0001AA90
	public void a()
	{
		if (this.g != null)
		{
			this.g.an();
			this.g = null;
			return;
		}
		this.b.End();
	}

	// Token: 0x060006E9 RID: 1769 RVA: 0x0001C8BC File Offset: 0x0001AABC
	public void a(ob A_0)
	{
		this.g = A_0;
	}

	// Token: 0x04000532 RID: 1330
	public cne a;

	// Token: 0x04000533 RID: 1331
	public SpriteBatch b;

	// Token: 0x04000534 RID: 1332
	public GraphicsDevice c;

	// Token: 0x04000535 RID: 1333
	public SpriteSortMode d;

	// Token: 0x04000536 RID: 1334
	public BlendState e;

	// Token: 0x04000537 RID: 1335
	public bc2 f;

	// Token: 0x04000538 RID: 1336
	public ob g;

	// Token: 0x04000539 RID: 1337
	public RasterizerState h = new RasterizerState();
}
