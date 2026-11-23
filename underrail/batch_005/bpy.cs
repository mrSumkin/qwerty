using System;
using System.Linq;
using Microsoft.Xna.Framework;

// Token: 0x02001890 RID: 6288
public abstract class bpy : btm
{
	// Token: 0x06008568 RID: 34152
	protected abstract byte aju();

	// Token: 0x06008569 RID: 34153 RVA: 0x003764BC File Offset: 0x003746BC
	public float a()
	{
		return this.c;
	}

	// Token: 0x0600856A RID: 34154 RVA: 0x003764C4 File Offset: 0x003746C4
	public void a(float A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600856B RID: 34155 RVA: 0x003764D0 File Offset: 0x003746D0
	public bool b()
	{
		return this.d;
	}

	// Token: 0x0600856C RID: 34156 RVA: 0x003764D8 File Offset: 0x003746D8
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600856D RID: 34157 RVA: 0x003764E4 File Offset: 0x003746E4
	protected override bool b4(e6d A_0)
	{
		bcm serviceOrThrow = bpo.GetServiceOrThrow<bcm>();
		this.b = A_0.a().TotalGameTime;
		if (serviceOrThrow.aau() == null)
		{
			return true;
		}
		this.a = Enumerable.FirstOrDefault<d0p>(Enumerable.OfType<d0p>(serviceOrThrow.aau().Controls));
		if (this.a == null)
		{
			this.a = new d0p(false);
			serviceOrThrow.aau().aox(this.a);
		}
		this.a.Color = new Color(0, 0, 0, (int)this.aju());
		return false;
	}

	// Token: 0x0600856E RID: 34158 RVA: 0x00376574 File Offset: 0x00374774
	protected override bool aen(e6d A_0)
	{
		int a_ = Math.Max(1, (int)((A_0.a().TotalGameTime.TotalMilliseconds - this.b.TotalMilliseconds) * (double)this.a()));
		int num = this.ajv((int)this.a.Color.A, a_);
		if (this.ajw(num))
		{
			if (this.d)
			{
				this.a.Parent.g(this.a);
			}
			return true;
		}
		this.a.Color = new Color((int)this.a.Color.R, (int)this.a.Color.G, (int)this.a.Color.B, (int)((byte)num));
		this.b = A_0.a().TotalGameTime;
		return false;
	}

	// Token: 0x0600856F RID: 34159
	protected abstract int ajv(int A_0, int A_1);

	// Token: 0x06008570 RID: 34160
	protected abstract bool ajw(int A_0);

	// Token: 0x06008571 RID: 34161 RVA: 0x00376658 File Offset: 0x00374858
	protected bpy() : base(null)
	{
	}

	// Token: 0x0400331D RID: 13085
	private d0p a;

	// Token: 0x0400331E RID: 13086
	private TimeSpan b;

	// Token: 0x0400331F RID: 13087
	private float c = 0.5f;

	// Token: 0x04003320 RID: 13088
	private new bool d = true;
}
