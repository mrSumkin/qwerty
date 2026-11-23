using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02002043 RID: 8259
public sealed class bcd : au6
{
	// Token: 0x0600C3BF RID: 50111 RVA: 0x0043DFF4 File Offset: 0x0043C1F4
	public Type d()
	{
		return this.c;
	}

	// Token: 0x0600C3C0 RID: 50112 RVA: 0x0043DFFC File Offset: 0x0043C1FC
	public void a(Type A_0)
	{
		this.c = A_0;
		this.a();
	}

	// Token: 0x0600C3C1 RID: 50113 RVA: 0x0043E00C File Offset: 0x0043C20C
	public bcd()
	{
		this.c();
	}

	// Token: 0x0600C3C2 RID: 50114 RVA: 0x0043E020 File Offset: 0x0043C220
	private void c()
	{
		wj wj = wj.a();
		if (wj.c())
		{
			base.b(bo1.r);
		}
		else
		{
			base.b(wj.f);
			this.n = wj.b8;
			this.o = new esj?(wj.b9);
		}
		this.Focusable = false;
		this.a = new avo();
		if (wj.c())
		{
			this.a.a(egg.e);
		}
		else
		{
			this.a.a(wj.gh);
		}
		this.a.Location = new Point(10, 20);
		this.a.a(cab.a);
		this.a.a(ad4.a);
		this.a.IsPrivateComponent = true;
		this.b = new avo();
		this.b.a(egg.@as);
		this.b.Color = adi.a;
		this.b.Location = new Point(10, 130);
		this.b.a(cab.a);
		this.b.a(ad4.a);
		this.b.IsPrivateComponent = true;
		this.aox(this.a);
		this.aox(this.b);
		this.b();
		this.a();
	}

	// Token: 0x0600C3C3 RID: 50115 RVA: 0x0043E180 File Offset: 0x0043C380
	private void b()
	{
		if (this.a == null)
		{
			return;
		}
		wj wj = wj.a();
		if (wj.c())
		{
			this.a.Size = new esj(base.Size.c - 2 * this.b.Location.X, 120);
			this.b.Size = new esj(base.Size.c - 2 * this.b.Location.X, base.Size.d - base.Location.Y);
			return;
		}
		int num;
		int num2;
		int num3;
		this.a(out num, out num2, out num3);
		this.a.Location = new Point(wj.fv.c / 2, wj.fv.d);
		this.a.Size = new esj(base.Size.c - 2 * this.b.Location.X, num2 + 2);
		this.b.a(wj.gg);
		this.b.Location = new Point(this.a.Location.X, this.a.Location.Y + (int)(1.5f * (float)num2));
		this.b.Size = new esj(base.Size.c - 2 * this.b.Location.X, base.Size.d - base.Location.Y);
	}

	// Token: 0x0600C3C4 RID: 50116 RVA: 0x0043E318 File Offset: 0x0043C518
	private void a()
	{
		if (this.c == null)
		{
			this.a.Text = "Специализация";
			this.b.Text = qv.b("Specialization/GeneralInfo");
			return;
		}
		apq apq = ac8.a(this.c);
		if (apq != null)
		{
			this.a.Text = apq.e5();
			this.b.Text = qv.a("Specialization/" + apq.e4(), apq.e7());
			return;
		}
		this.a.Text = "";
		this.b.Text = "";
	}

	// Token: 0x0600C3C5 RID: 50117 RVA: 0x0043E3C8 File Offset: 0x0043C5C8
	private void a(out int A_0, out int A_1, out int A_2)
	{
		A_0 = 0;
		A_1 = 0;
		A_2 = 0;
		wj wj = wj.a();
		if (!wj.c())
		{
			base.b(wj.f);
			this.n = wj.b8;
			this.o = new esj?(wj.b9);
			cne serviceOrThrow = bpo.GetServiceOrThrow<cne>();
			try
			{
				A_0 = serviceOrThrow.GetResource<SpriteFont>(wj.gg, null).LineSpacing;
				A_1 = serviceOrThrow.GetResource<SpriteFont>(wj.gh, null).LineSpacing;
				A_2 = serviceOrThrow.GetResource<SpriteFont>(wj.gi, null).LineSpacing;
			}
			catch
			{
			}
		}
	}

	// Token: 0x0600C3C6 RID: 50118 RVA: 0x0043E490 File Offset: 0x0043C690
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.b();
	}

	// Token: 0x0400473C RID: 18236
	private new avo a;

	// Token: 0x0400473D RID: 18237
	private new avo b;

	// Token: 0x0400473E RID: 18238
	private new Type c;
}
