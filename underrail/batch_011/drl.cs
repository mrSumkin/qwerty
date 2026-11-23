using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TimelapseVertigo.Materialization.Batching;

// Token: 0x0200077B RID: 1915
public sealed class drl : UrGenericSpriteBatchBase<b04, dyj>, ob
{
	// Token: 0x06003082 RID: 12418 RVA: 0x0012B6CC File Offset: 0x001298CC
	public drl(GraphicsDevice A_0, int A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003083 RID: 12419 RVA: 0x0012B6D8 File Offset: 0x001298D8
	public void w3(SpriteSortMode A_0, BlendState A_1, SamplerState A_2, DepthStencilState A_3, RasterizerState A_4, Effect A_5 = null)
	{
		this.q = A_1;
		this.r = A_4;
		this.s = new SamplerState[]
		{
			A_2
		};
		this.a(A_5);
	}

	// Token: 0x06003084 RID: 12420 RVA: 0x0012B704 File Offset: 0x00129904
	public void w4(Texture2D A_0, Vector2 A_1, Color A_2)
	{
		base.a(A_0, null, null, null, null, null, null, null, A_1, null, A_2, 0f, Vector2.Zero, Vector2.One, SpriteEffects.None, dyj.a);
	}

	// Token: 0x06003085 RID: 12421 RVA: 0x0012B740 File Offset: 0x00129940
	public void xa(Texture2D A_0, Rectangle A_1, Color A_2)
	{
		Vector2 a_ = new Vector2((float)A_1.X, (float)A_1.Y);
		Vector2 one;
		if (A_0 == null)
		{
			one = Vector2.One;
		}
		else
		{
			one = new Vector2(Convert.ToSingle(A_1.Width) / (float)A_0.Width, Convert.ToSingle(A_1.Height) / (float)A_0.Height);
		}
		base.a(A_0, null, null, null, null, null, null, null, a_, null, A_2, 0f, Vector2.Zero, one, SpriteEffects.None, dyj.a);
	}

	// Token: 0x06003086 RID: 12422 RVA: 0x0012B7CC File Offset: 0x001299CC
	public void w5(Texture2D A_0, Vector2 A_1, Rectangle? A_2, Color A_3)
	{
		base.a(A_0, null, null, null, null, null, null, null, A_1, A_2, A_3, 0f, Vector2.Zero, Vector2.One, SpriteEffects.None, dyj.a);
	}

	// Token: 0x06003087 RID: 12423 RVA: 0x0012B800 File Offset: 0x00129A00
	public void w6(Texture2D A_0, Rectangle A_1, Rectangle? A_2, Color A_3)
	{
		Vector2 a_ = new Vector2((float)A_1.X, (float)A_1.Y);
		Vector2 one;
		if (A_2 != null)
		{
			one = new Vector2(Convert.ToSingle(A_1.Width) / (float)A_2.Value.Width, Convert.ToSingle(A_1.Height) / (float)A_2.Value.Height);
		}
		else if (A_0 != null)
		{
			one = new Vector2(Convert.ToSingle(A_1.Width) / (float)A_0.Width, Convert.ToSingle(A_1.Height) / (float)A_0.Height);
		}
		else
		{
			one = Vector2.One;
		}
		base.a(A_0, null, null, null, null, null, null, null, a_, A_2, A_3, 0f, Vector2.Zero, one, SpriteEffects.None, dyj.a);
	}

	// Token: 0x06003088 RID: 12424 RVA: 0x0012B8D0 File Offset: 0x00129AD0
	public void w7(Texture2D A_0, Vector2 A_1, Rectangle? A_2, Color A_3, float A_4, Vector2 A_5, float A_6, SpriteEffects A_7, float A_8)
	{
		base.a(A_0, null, null, null, null, null, null, null, A_1, A_2, A_3, A_4, A_5, new Vector2(A_6, A_6), A_7, dyj.a);
	}

	// Token: 0x06003089 RID: 12425 RVA: 0x0012B904 File Offset: 0x00129B04
	public void w8(Texture2D A_0, Rectangle A_1, Rectangle? A_2, Color A_3, float A_4, Vector2 A_5, SpriteEffects A_6, float A_7, byte A_8, Vector2 A_9)
	{
		Vector2 a_ = new Vector2((float)A_1.X, (float)A_1.Y);
		Vector2 one;
		if (A_2 != null)
		{
			one = new Vector2(Convert.ToSingle(A_1.Width) / (float)A_2.Value.Width, Convert.ToSingle(A_1.Height) / (float)A_2.Value.Height);
		}
		else if (A_0 != null)
		{
			one = new Vector2(Convert.ToSingle(A_1.Width) / (float)A_0.Width, Convert.ToSingle(A_1.Height) / (float)A_0.Height);
		}
		else
		{
			one = Vector2.One;
		}
		dyj a_2 = new dyj
		{
			b = A_8,
			c = A_9
		};
		base.a(A_0, null, null, null, null, null, null, null, a_, A_2, A_3, A_4, A_5, one, A_6, a_2);
	}

	// Token: 0x0600308A RID: 12426 RVA: 0x0012B9E4 File Offset: 0x00129BE4
	public void w9(Texture2D A_0, Vector2 A_1, Rectangle? A_2, Color A_3, float A_4, Vector2 A_5, Vector2 A_6, SpriteEffects A_7, float A_8)
	{
		base.a(A_0, null, null, null, null, null, null, null, A_1, A_2, A_3, A_4, A_5, A_6, A_7, dyj.a);
	}

	// Token: 0x0600308B RID: 12427 RVA: 0x0012BA10 File Offset: 0x00129C10
	public void xb(SpriteFont A_0, string A_1, Vector2 A_2, Color A_3)
	{
	}
}
