using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020001E5 RID: 485
public class a2f
{
	// Token: 0x06000E2D RID: 3629 RVA: 0x00039F64 File Offset: 0x00038164
	public virtual void f3(cp9 A_0, bkx A_1)
	{
		if (this.d != null)
		{
			this.d.avv(A_0, this, A_1);
			Vector2 a_ = default(Vector2);
			float val = 0f;
			bym bym = this.n;
			float? num;
			if (bym == null)
			{
				num = null;
			}
			else
			{
				b0b b0b = bym.b;
				num = ((b0b != null) ? new float?(b0b.ac) : null);
			}
			float? num2 = num;
			a_.X = Math.Max(val, num2.GetValueOrDefault(1f));
			float val2 = 0f;
			bym bym2 = this.n;
			float? num3;
			if (bym2 == null)
			{
				num3 = null;
			}
			else
			{
				b0b b0b2 = bym2.b;
				num3 = ((b0b2 != null) ? new float?(b0b2.ad) : null);
			}
			num2 = num3;
			a_.Y = Math.Max(val2, num2.GetValueOrDefault(1f));
			chf chf = this.d;
			Rectangle a_2 = this.m;
			Rectangle a_3 = this.c;
			Color value = this.e.Value;
			float a_4 = this.i;
			Vector2 zero = Vector2.Zero;
			SpriteEffects a_5 = this.k;
			float a_6 = 0f;
			bym bym3 = this.n;
			chf.avw(A_0, a_2, a_3, value, a_4, zero, a_5, a_6, (bym3 != null && bym3.f) ? 2 : 1, a_);
		}
	}

	// Token: 0x06000E2E RID: 3630 RVA: 0x0003A0AC File Offset: 0x000382AC
	public virtual void f4()
	{
	}

	// Token: 0x06000E2F RID: 3631 RVA: 0x0003A0B0 File Offset: 0x000382B0
	public virtual a2f f5()
	{
		a2f a2f = new a2f();
		this.f6(a2f);
		return a2f;
	}

	// Token: 0x06000E30 RID: 3632 RVA: 0x0003A0CC File Offset: 0x000382CC
	protected virtual void f6(a2f A_0)
	{
		A_0.a = this.a;
		A_0.b = this.b;
		A_0.c = this.c;
		A_0.d = this.d;
		A_0.e = this.e;
		A_0.h = this.h;
		A_0.i = this.i;
		A_0.j = this.j;
		A_0.k = this.k;
		A_0.l = this.l;
		A_0.m = this.m;
		A_0.o = this.o;
		A_0.p = this.p;
		A_0.q = this.q;
		A_0.t = this.t;
		chf chf = this.d;
		A_0.d = ((chf != null) ? chf.acm(A_0) : null);
	}

	// Token: 0x06000E31 RID: 3633 RVA: 0x0003A1AC File Offset: 0x000383AC
	public virtual void a(Vector2 A_0)
	{
		this.j += A_0;
		if (this.d != null)
		{
			this.d.acp(A_0);
		}
	}

	// Token: 0x06000E32 RID: 3634 RVA: 0x0003A1D8 File Offset: 0x000383D8
	public virtual void a()
	{
		if (this.d != null)
		{
			this.d.acq();
		}
	}

	// Token: 0x04000830 RID: 2096
	public string a;

	// Token: 0x04000831 RID: 2097
	public bool b = true;

	// Token: 0x04000832 RID: 2098
	public Rectangle c;

	// Token: 0x04000833 RID: 2099
	public chf d;

	// Token: 0x04000834 RID: 2100
	public Color? e;

	// Token: 0x04000835 RID: 2101
	public float f;

	// Token: 0x04000836 RID: 2102
	public float g = 1f;

	// Token: 0x04000837 RID: 2103
	public float? h;

	// Token: 0x04000838 RID: 2104
	public float i;

	// Token: 0x04000839 RID: 2105
	public Vector2 j;

	// Token: 0x0400083A RID: 2106
	public SpriteEffects k;

	// Token: 0x0400083B RID: 2107
	public Vector2 l = Vector2.One;

	// Token: 0x0400083C RID: 2108
	public Rectangle m;

	// Token: 0x0400083D RID: 2109
	public bym n;

	// Token: 0x0400083E RID: 2110
	public bool o;

	// Token: 0x0400083F RID: 2111
	public dm6 p;

	// Token: 0x04000840 RID: 2112
	public bool q;

	// Token: 0x04000841 RID: 2113
	public bool r;

	// Token: 0x04000842 RID: 2114
	public bool s;

	// Token: 0x04000843 RID: 2115
	public bool t;

	// Token: 0x04000844 RID: 2116
	public string u;

	// Token: 0x04000845 RID: 2117
	public Dictionary<string, object> v;

	// Token: 0x04000846 RID: 2118
	public bool w;
}
