using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020004A7 RID: 1191
internal sealed class d51
{
	// Token: 0x06001E40 RID: 7744 RVA: 0x000A8664 File Offset: 0x000A6864
	internal d51(bph A_0, Vector2 A_1)
	{
		czh.a(A_0, "source");
		this.e = A_0;
		this.b = A_0.b;
		this.f = A_0.c;
		if (A_0.a != null)
		{
			this.d = A_0.a.a();
		}
		this.c = A_1;
	}

	// Token: 0x06001E41 RID: 7745 RVA: 0x000A86C4 File Offset: 0x000A68C4
	public void a(Point A_0, cp9 A_1, cne A_2, float A_3)
	{
		if (this.d == null || string.IsNullOrEmpty(this.d.a) || string.IsNullOrEmpty(this.b))
		{
			return;
		}
		SpriteFont resource = A_2.GetResource<SpriteFont>(this.d.a, null);
		Vector2 zero = Vector2.Zero;
		if (!string.IsNullOrEmpty(this.f))
		{
			float num = this.c.Y / 1.25f;
			zero = new Vector2((float)((int)(num * 1.5f)), (float)((int)(num * 0.25f)));
			apo service = bpo.GetService<apo>();
			if (service != null)
			{
				Rectangle a_ = new Rectangle(this.a.X + A_0.X, this.a.Y + A_0.Y, (int)this.c.Y, (int)this.c.Y);
				service.as3(this.f, A_1, a_, Color.White, 0, null);
			}
		}
		if (resource != null)
		{
			A_1.b().xb(resource, this.b, new Vector2((float)(A_0.X + this.a.X) + zero.X, (float)(A_0.Y + this.a.Y) + zero.Y), this.d.b * A_3);
		}
	}

	// Token: 0x06001E42 RID: 7746 RVA: 0x000A8834 File Offset: 0x000A6A34
	public bph a()
	{
		return this.e;
	}

	// Token: 0x04001352 RID: 4946
	public Point a;

	// Token: 0x04001353 RID: 4947
	public string b;

	// Token: 0x04001354 RID: 4948
	public Vector2 c;

	// Token: 0x04001355 RID: 4949
	public d22 d;

	// Token: 0x04001356 RID: 4950
	public bph e;

	// Token: 0x04001357 RID: 4951
	public string f;
}
