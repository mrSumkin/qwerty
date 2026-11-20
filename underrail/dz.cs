using System;
using Microsoft.Xna.Framework;

// Token: 0x02001FEE RID: 8174
public class dz : euz, evy
{
	// Token: 0x0600C04C RID: 49228 RVA: 0x0042A2D4 File Offset: 0x004284D4
	public string c()
	{
		return this.c;
	}

	// Token: 0x0600C04D RID: 49229 RVA: 0x0042A2DC File Offset: 0x004284DC
	public void a(string A_0)
	{
		this.c = A_0;
		this.a();
	}

	// Token: 0x0600C04E RID: 49230 RVA: 0x0042A2EC File Offset: 0x004284EC
	public Color d()
	{
		return this.a.Color;
	}

	// Token: 0x0600C04F RID: 49231 RVA: 0x0042A2FC File Offset: 0x004284FC
	public void a(Color A_0)
	{
		this.a.Color = A_0;
	}

	// Token: 0x0600C050 RID: 49232 RVA: 0x0042A30C File Offset: 0x0042850C
	public override string es()
	{
		if (this.h != null)
		{
			return this.h();
		}
		return base.CursorName;
	}

	// Token: 0x0600C051 RID: 49233 RVA: 0x0042A32C File Offset: 0x0042852C
	public override bool et()
	{
		return base.IsMousedOver || (this.a != null && this.a.IsMousedOver) || (this.b != null && this.b.IsMousedOver);
	}

	// Token: 0x0600C052 RID: 49234 RVA: 0x0042A37C File Offset: 0x0042857C
	static dz()
	{
		dz.i[0].b = 39;
		dz.i[0].a = "_s";
		dz.i[0].c = 10;
		dz.i[0].d = 2;
		dz.i[1].b = 79;
		dz.i[1].a = "";
		dz.i[1].c = 12;
		dz.i[1].d = 2;
		dz.i[2].b = 79;
		dz.i[2].a = "";
		dz.i[2].c = 12;
		dz.i[2].d = 2;
		dz.j = new dz.a[3];
		dz.j[0].b = 39;
		dz.j[0].a = "_s";
		dz.j[0].c = 10;
		dz.j[0].d = 2;
		dz.j[1].b = 75;
		dz.j[1].a = "_h2";
		dz.j[1].c = 12;
		dz.j[1].d = 3;
		dz.j[2].b = 150;
		dz.j[2].a = "_h1";
		dz.j[2].c = 24;
		dz.j[2].d = 4;
	}

	// Token: 0x0600C053 RID: 49235 RVA: 0x0042A560 File Offset: 0x00428760
	public dz(bd8 A_0)
	{
		this.d = A_0;
		dz.a[] array;
		if (wj.a().c())
		{
			array = dz.i;
		}
		else
		{
			array = dz.j;
		}
		ref dz.a ptr = ref array[(int)A_0];
		base.Size = new esj(ptr.b, ptr.b);
		this.e = ptr.a;
		this.f = new esj(ptr.c, ptr.b);
		this.g = new esj(ptr.b, ptr.b);
		this.b();
	}

	// Token: 0x0600C054 RID: 49236 RVA: 0x0042A600 File Offset: 0x00428800
	private void b()
	{
		this.a = new bg1();
		this.a.IsPrivateComponent = true;
		this.aox(this.a);
		this.b = new bg1();
		this.b.IsPrivateComponent = true;
		this.aox(this.b);
		this.a();
	}

	// Token: 0x0600C055 RID: 49237 RVA: 0x0042A65C File Offset: 0x0042885C
	private void a()
	{
		if (this.a != null)
		{
			this.a.Size = base.Size;
			if (this.c != null)
			{
				this.a.b = "Portraits\\Vehicles\\" + this.c + this.e;
			}
			else
			{
				this.a.b = null;
			}
			if (this.b != null)
			{
				this.b.Size = this.a.Size;
				this.b.b = bo1.az + this.e;
				this.b.d = new Rectangle?(new Rectangle(this.f.c * 6, 0, this.g.c, this.g.d));
			}
		}
	}

	// Token: 0x0600C056 RID: 49238 RVA: 0x0042A738 File Offset: 0x00428938
	public string eu()
	{
		if (this.h != null)
		{
			return this.h();
		}
		return base.CursorName;
	}

	// Token: 0x0600C057 RID: 49239 RVA: 0x0042A758 File Offset: 0x00428958
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.a();
	}

	// Token: 0x04004574 RID: 17780
	private new bg1 a;

	// Token: 0x04004575 RID: 17781
	private new bg1 b;

	// Token: 0x04004576 RID: 17782
	private new string c;

	// Token: 0x04004577 RID: 17783
	private new bd8 d = bd8.b;

	// Token: 0x04004578 RID: 17784
	private new string e;

	// Token: 0x04004579 RID: 17785
	private new esj f;

	// Token: 0x0400457A RID: 17786
	private new esj g;

	// Token: 0x0400457B RID: 17787
	public Func<string> h;

	// Token: 0x0400457C RID: 17788
	public static readonly dz.a[] i = new dz.a[3];

	// Token: 0x0400457D RID: 17789
	public new static readonly dz.a[] j;

	// Token: 0x02001FEF RID: 8175
	public new struct a
	{
		// Token: 0x0400457E RID: 17790
		public string a;

		// Token: 0x0400457F RID: 17791
		public int b;

		// Token: 0x04004580 RID: 17792
		public int c;

		// Token: 0x04004581 RID: 17793
		public int d;
	}
}
