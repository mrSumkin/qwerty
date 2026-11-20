using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TimelapseVertigo.Common.Settings;

// Token: 0x0200201E RID: 8222
public class apw : ec9, evy
{
	// Token: 0x0600C290 RID: 49808 RVA: 0x00435DE4 File Offset: 0x00433FE4
	public string g()
	{
		return this.d;
	}

	// Token: 0x0600C291 RID: 49809 RVA: 0x00435DEC File Offset: 0x00433FEC
	public void a(string A_0)
	{
		this.d = A_0;
		this.e();
	}

	// Token: 0x0600C292 RID: 49810 RVA: 0x00435DFC File Offset: 0x00433FFC
	public string j()
	{
		return this.e;
	}

	// Token: 0x0600C293 RID: 49811 RVA: 0x00435E04 File Offset: 0x00434004
	public void b(string A_0)
	{
		this.e = A_0;
		this.e();
	}

	// Token: 0x0600C294 RID: 49812 RVA: 0x00435E14 File Offset: 0x00434014
	public bd8 l()
	{
		return this.f;
	}

	// Token: 0x0600C295 RID: 49813 RVA: 0x00435E1C File Offset: 0x0043401C
	public bool k()
	{
		return this.g;
	}

	// Token: 0x0600C296 RID: 49814 RVA: 0x00435E24 File Offset: 0x00434024
	public void a(bool A_0)
	{
		this.g = A_0;
		this.e();
	}

	// Token: 0x0600C297 RID: 49815 RVA: 0x00435E34 File Offset: 0x00434034
	public override bool et()
	{
		return base.IsMousedOver || (this.c != null && this.c.IsMousedOver);
	}

	// Token: 0x0600C298 RID: 49816 RVA: 0x00435E5C File Offset: 0x0043405C
	public Color h()
	{
		return this.c.Color;
	}

	// Token: 0x0600C299 RID: 49817 RVA: 0x00435E6C File Offset: 0x0043406C
	public void b(Color A_0)
	{
		this.c.Color = A_0;
	}

	// Token: 0x0600C29A RID: 49818 RVA: 0x00435E7C File Offset: 0x0043407C
	public Color i()
	{
		return this.b.Color;
	}

	// Token: 0x0600C29B RID: 49819 RVA: 0x00435E8C File Offset: 0x0043408C
	public void a(Color A_0)
	{
		this.b.Color = A_0;
	}

	// Token: 0x0600C29C RID: 49820 RVA: 0x00435E9C File Offset: 0x0043409C
	public override string es()
	{
		if (this.n != null)
		{
			return this.n();
		}
		return base.CursorName;
	}

	// Token: 0x0600C29D RID: 49821 RVA: 0x00435EBC File Offset: 0x004340BC
	public apw(bd8 A_0)
	{
		wj wj = wj.a();
		this.f = A_0;
		if (wj.d == UiSize.Classic)
		{
			this.h = bo1.x;
			this.k = bo1.w;
		}
		else
		{
			this.h = wj.f;
			this.i = wj.bc;
			this.j = new esj?(wj.bd);
			this.k = wj.f;
			this.l = wj.be;
			this.m = new esj?(wj.bf);
			this.a = wj.i;
		}
		if (this.f == bd8.a)
		{
			base.Size = new esj(50 + 2 * this.a, 50 + 2 * this.a);
		}
		else if (this.f == bd8.b)
		{
			base.Size = new esj(100 + 2 * this.a, 100 + 2 * this.a);
		}
		else
		{
			base.Size = new esj(200 + 2 * this.a, 200 + 2 * this.a);
		}
		this.f();
	}

	// Token: 0x0600C29E RID: 49822 RVA: 0x00436008 File Offset: 0x00434208
	public string eu()
	{
		if (this.n != null)
		{
			return this.n();
		}
		return base.CursorName;
	}

	// Token: 0x0600C29F RID: 49823 RVA: 0x00436028 File Offset: 0x00434228
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.e();
	}

	// Token: 0x0600C2A0 RID: 49824 RVA: 0x0043603C File Offset: 0x0043423C
	private void f()
	{
		this.b = new bg1();
		this.b.IsPrivateComponent = true;
		this.b.a = true;
		this.aox(this.b);
		this.c = new bg1();
		this.c.IsPrivateComponent = true;
		this.c.a = true;
		this.aox(this.c);
		this.e();
	}

	// Token: 0x0600C2A1 RID: 49825 RVA: 0x004360B0 File Offset: 0x004342B0
	private new void e()
	{
		if (this.g)
		{
			if (this.f == bd8.a || base.Size.c < 110)
			{
				this.c = this.h;
				this.e = this.i;
				this.d = this.j;
			}
			else
			{
				this.c = this.k;
				this.e = this.l;
				this.d = this.m;
			}
		}
		else
		{
			this.c = null;
		}
		if (this.b != null)
		{
			this.b.Location = new Point(this.a, this.a);
			this.b.Size = new esj(Math.Max(0, base.Size.c - 2 * this.a), Math.Max(0, base.Size.d - 2 * this.a));
			if (this.e != null)
			{
				this.b.c = new Func<Texture2D>(this.d);
			}
			else
			{
				this.b.c = null;
			}
		}
		if (this.c != null)
		{
			this.c.Location = new Point(this.a, this.a);
			this.c.Size = new esj(Math.Max(0, base.Size.c - 2 * this.a), Math.Max(0, base.Size.d - 2 * this.a));
			if (this.d != null)
			{
				if (this.f == bd8.c)
				{
					this.c.c = new Func<Texture2D>(this.c);
					return;
				}
				if (this.f == bd8.b)
				{
					this.c.c = new Func<Texture2D>(this.b);
					return;
				}
				this.c.c = new Func<Texture2D>(this.a);
				return;
			}
			else
			{
				this.c.c = null;
			}
		}
	}

	// Token: 0x0600C2A2 RID: 49826 RVA: 0x004362C0 File Offset: 0x004344C0
	[CompilerGenerated]
	private new Texture2D d()
	{
		return d37.a(this.e, base.Size.c > 110);
	}

	// Token: 0x0600C2A3 RID: 49827 RVA: 0x004362DC File Offset: 0x004344DC
	[CompilerGenerated]
	private new Texture2D c()
	{
		return d37.d(this.d);
	}

	// Token: 0x0600C2A4 RID: 49828 RVA: 0x004362EC File Offset: 0x004344EC
	[CompilerGenerated]
	private Texture2D b()
	{
		return d37.c(this.d);
	}

	// Token: 0x0600C2A5 RID: 49829 RVA: 0x004362FC File Offset: 0x004344FC
	[CompilerGenerated]
	private Texture2D a()
	{
		return d37.b(this.d);
	}

	// Token: 0x04004677 RID: 18039
	private new int a = 5;

	// Token: 0x04004678 RID: 18040
	private new bg1 b;

	// Token: 0x04004679 RID: 18041
	private new bg1 c;

	// Token: 0x0400467A RID: 18042
	private new string d;

	// Token: 0x0400467B RID: 18043
	private new string e;

	// Token: 0x0400467C RID: 18044
	private new bd8 f = bd8.b;

	// Token: 0x0400467D RID: 18045
	private new bool g = true;

	// Token: 0x0400467E RID: 18046
	private string h;

	// Token: 0x0400467F RID: 18047
	private Point i;

	// Token: 0x04004680 RID: 18048
	private new esj? j;

	// Token: 0x04004681 RID: 18049
	private new string k;

	// Token: 0x04004682 RID: 18050
	private new Point l;

	// Token: 0x04004683 RID: 18051
	private new esj? m;

	// Token: 0x04004684 RID: 18052
	public Func<string> n;
}
