using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000773 RID: 1907
public sealed class by8 : chf
{
	// Token: 0x06003056 RID: 12374 RVA: 0x00128284 File Offset: 0x00126484
	Texture2D chf.b()
	{
		chf chf = this.d;
		if (chf == null)
		{
			return null;
		}
		return chf.a();
	}

	// Token: 0x06003057 RID: 12375 RVA: 0x0012829C File Offset: 0x0012649C
	public chf acm(a2f A_0)
	{
		by8 by = new by8();
		chf chf = this.d;
		by.d = ((chf != null) ? chf.acm(A_0) : null);
		by.e = (A_0 as f6);
		f6 f = this.f;
		by.f = (((f != null) ? f.f5() : null) as f6);
		f6 f2 = this.g;
		by.g = (((f2 != null) ? f2.f5() : null) as f6);
		by.h = this.h;
		by.k = this.k;
		return by;
	}

	// Token: 0x06003058 RID: 12376 RVA: 0x00128338 File Offset: 0x00126538
	public a2f[] acn()
	{
		if (this.f == null && this.g == null)
		{
			return null;
		}
		return new a2f[]
		{
			this.f,
			this.g
		};
	}

	// Token: 0x06003059 RID: 12377 RVA: 0x00128370 File Offset: 0x00126570
	void chf.a(cp9 A_0, Rectangle A_1, Rectangle A_2, Color A_3, float A_4, Vector2 A_5, SpriteEffects A_6, float A_7, byte A_8, Vector2 A_9)
	{
		if (this.i == null && this.m != null)
		{
			this.i = this.m.i;
		}
		if (this.i != null)
		{
			Rectangle value = new Rectangle(0, 0, by8.a.c, by8.a.d);
			A_0.b().w8(this.i, this.n, new Rectangle?(value), A_3, A_4, A_5, A_6, A_7, A_8, A_9);
			if (this.k)
			{
				this.acq();
			}
			return;
		}
		chf chf = this.d;
		if (chf != null)
		{
			chf.avw(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9);
		}
		if (this.f != null && this.f.d != null)
		{
			this.f.d.avw(A_0, this.f.m, this.f.c, A_3, A_4, A_5, A_6, A_7, A_8, A_9);
		}
		if (this.g != null && this.g.d != null)
		{
			this.g.d.avw(A_0, this.g.m, this.g.c, A_3, A_4, A_5, A_6, A_7, A_8, A_9);
		}
	}

	// Token: 0x0600305A RID: 12378 RVA: 0x001284D4 File Offset: 0x001266D4
	void chf.a(cp9 A_0, a2f A_1, bkx A_2)
	{
		f6 f = A_1 as f6;
		bool flag = false;
		if (this.i == null && this.m != null)
		{
			this.i = this.m.i;
		}
		if (this.i == null)
		{
			flag = true;
			this.i = this.a(A_0);
			this.h = Point.Zero;
			if (this.f != null && f != null)
			{
				this.h = d05.a(this.f.m.Location, f.m.Location, true);
			}
		}
		else if (this.i.IsContentLost)
		{
			flag = true;
		}
		if (flag)
		{
			RenderTarget2D renderTarget2D = null;
			RenderTargetBinding[] renderTargets = A_0.c.GetRenderTargets();
			if (renderTargets.Length != 0)
			{
				renderTarget2D = (renderTargets[0].RenderTarget as RenderTarget2D);
			}
			A_0.a();
			Effect resource = A_0.a.GetResource<Effect>("Shaders\\LayeredCharacter", new double?((double)-1));
			if (resource != null)
			{
				A_0.c.SetRenderTarget(this.i);
				A_0.c.Clear(Color.Transparent);
				A_0.b().w3(SpriteSortMode.Immediate, BlendState.AlphaBlend, SamplerState.PointClamp, DepthStencilState.Default, RasterizerState.CullNone, resource);
				if (this.e != null)
				{
					e4m e4m = this.d as e4m;
					if (e4m != null)
					{
						string a_ = e4m.b.Replace("##base", "##depth");
						Texture2D value = A_0.a.us(a_, null);
						EffectParameter effectParameter = resource.Parameters["DepthTexture"];
						if (effectParameter != null)
						{
							effectParameter.SetValue(value);
						}
						A_0.b().w7(this.d.a(), by8.c, new Rectangle?(this.e.c), Color.White, 0f, this.e.j, 1f, SpriteEffects.None, 0f);
					}
				}
				if (this.f != null)
				{
					e4m e4m2 = this.f.d as e4m;
					if (e4m2 != null)
					{
						string a_2 = e4m2.b.Replace("##base", "##depth");
						Texture2D value2 = A_0.a.us(a_2, null);
						EffectParameter effectParameter2 = resource.Parameters["DepthTexture"];
						if (effectParameter2 != null)
						{
							effectParameter2.SetValue(value2);
						}
						A_0.b().w7(e4m2.a, by8.c, new Rectangle?(this.f.c), Color.White, 0f, this.f.j, 1f, SpriteEffects.None, 0f);
					}
				}
				if (this.g != null)
				{
					e4m e4m3 = this.g.d as e4m;
					if (e4m3 != null)
					{
						string a_3 = e4m3.b.Replace("##base", "##depth");
						Texture2D value3 = A_0.a.us(a_3, null);
						EffectParameter effectParameter3 = resource.Parameters["DepthTexture"];
						if (effectParameter3 != null)
						{
							effectParameter3.SetValue(value3);
						}
						A_0.b().w7(e4m3.a, by8.c, new Rectangle?(this.g.c), Color.White, 0f, this.g.j, 1f, SpriteEffects.None, 0f);
					}
				}
				A_0.b().an();
				A_0.c.SetRenderTarget(null);
				A_0.c.Textures[1] = null;
			}
			if (renderTarget2D != null)
			{
				A_0.c.SetRenderTarget(renderTarget2D);
			}
			a7m a7m = A_2 as a7m;
			if (a7m != null)
			{
				Rectangle scissorRectangle = A_0.c.ScissorRectangle;
				RasterizerState rasterizerState = new RasterizerState();
				rasterizerState.ScissorTestEnable = true;
				A_0.c.ScissorRectangle = scissorRectangle;
				a7m.iu(A_0, SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.PointClamp, DepthStencilState.Default, rasterizerState);
				return;
			}
			A_0.a(null);
		}
	}

	// Token: 0x0600305B RID: 12379 RVA: 0x001288F0 File Offset: 0x00126AF0
	public void aco(Vector2 A_0, float A_1, esj A_2)
	{
		if (A_1 == 1f)
		{
			int width = (int)((float)by8.a.c * this.e.l.X);
			int height = (int)((float)by8.a.d * this.e.l.Y);
			this.n = new Rectangle((int)(A_0.X + (float)A_2.c - (by8.c.X + (float)A_2.c) * this.e.l.X), (int)(A_0.Y + (float)A_2.d - (by8.c.Y + (float)A_2.d) * this.e.l.Y), width, height);
			return;
		}
		float num = this.e.l.X * A_1;
		float num2 = this.e.l.Y * A_1;
		int width2 = (int)((float)by8.a.c * num);
		int height2 = (int)((float)by8.a.d * num2);
		this.n = new Rectangle((int)(A_0.X + (float)A_2.c * A_1 - (by8.c.X + (float)A_2.c) * num), (int)(A_0.Y + (float)A_2.d * A_1 - (by8.c.Y + (float)A_2.d) * num2), width2, height2);
	}

	// Token: 0x0600305C RID: 12380 RVA: 0x00128A5C File Offset: 0x00126C5C
	public void acp(Vector2 A_0)
	{
		f6 f = this.f;
		if (f != null)
		{
			f.a(A_0);
		}
		f6 f2 = this.g;
		if (f2 == null)
		{
			return;
		}
		f2.a(A_0);
	}

	// Token: 0x0600305D RID: 12381 RVA: 0x00128A8C File Offset: 0x00126C8C
	private RenderTarget2D a(cp9 A_0)
	{
		RenderTarget2D renderTarget2D;
		do
		{
			renderTarget2D = null;
			if (by8.l.Count > 0)
			{
				renderTarget2D = by8.l[by8.l.Count - 1];
				by8.l.RemoveAt(by8.l.Count - 1);
			}
			if (renderTarget2D != null && renderTarget2D.IsDisposed)
			{
				renderTarget2D = null;
			}
			if (renderTarget2D != null)
			{
				return renderTarget2D;
			}
		}
		while (by8.l.Count > 0);
		renderTarget2D = new RenderTarget2D(A_0.c, by8.a.c, by8.a.d, false, SurfaceFormat.Color, DepthFormat.Depth24);
		return renderTarget2D;
	}

	// Token: 0x0600305E RID: 12382 RVA: 0x00128B24 File Offset: 0x00126D24
	public void acq()
	{
		if (!this.j)
		{
			if (this.i != null && !this.i.IsDisposed)
			{
				by8.l.Add(this.i);
			}
			this.i = null;
		}
	}

	// Token: 0x0600305F RID: 12383 RVA: 0x00128B64 File Offset: 0x00126D64
	public void a()
	{
		this.k = true;
	}

	// Token: 0x04001A81 RID: 6785
	public static readonly esj a = new esj(512, 512);

	// Token: 0x04001A82 RID: 6786
	public static readonly Point b = new Point(128, 128);

	// Token: 0x04001A83 RID: 6787
	public static readonly Vector2 c = new Vector2(256f, 256f);

	// Token: 0x04001A84 RID: 6788
	public chf d;

	// Token: 0x04001A85 RID: 6789
	public f6 e;

	// Token: 0x04001A86 RID: 6790
	public f6 f;

	// Token: 0x04001A87 RID: 6791
	public f6 g;

	// Token: 0x04001A88 RID: 6792
	public Point h;

	// Token: 0x04001A89 RID: 6793
	public RenderTarget2D i;

	// Token: 0x04001A8A RID: 6794
	public bool j;

	// Token: 0x04001A8B RID: 6795
	public bool k;

	// Token: 0x04001A8C RID: 6796
	private static List<RenderTarget2D> l = new List<RenderTarget2D>();

	// Token: 0x04001A8D RID: 6797
	public by8 m;

	// Token: 0x04001A8E RID: 6798
	private Rectangle n;
}
