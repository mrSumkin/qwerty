using System;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02002062 RID: 8290
public sealed class bex : au6
{
	// Token: 0x0600C523 RID: 50467 RVA: 0x0044BAAC File Offset: 0x00449CAC
	public string c()
	{
		return this.d;
	}

	// Token: 0x0600C524 RID: 50468 RVA: 0x0044BAB4 File Offset: 0x00449CB4
	public void a(string A_0)
	{
		this.d = A_0;
		this.a();
	}

	// Token: 0x0600C525 RID: 50469 RVA: 0x0044BAC8 File Offset: 0x00449CC8
	static bex()
	{
		if (dk2.e() && dk2.f())
		{
			bex.a[0] = qv.b("BaseAbilities/HeavyWeapons_Full");
			return;
		}
		if (dk2.e())
		{
			bex.a[0] = qv.b("BaseAbilities/HeavyWeapons_HeavyDuty");
			return;
		}
		if (dk2.f())
		{
			bex.a[0] = qv.b("BaseAbilities/HeavyWeapons_Expedition");
			return;
		}
		bex.a[0] = qv.b("BaseAbilities/HeavyWeapons_Base");
	}

	// Token: 0x0600C526 RID: 50470 RVA: 0x0044BB60 File Offset: 0x00449D60
	public bex()
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
		this.b = new avo();
		if (wj.c())
		{
			this.b.a(egg.e);
			this.b.Location = new Point(10, 20);
		}
		else
		{
			this.b.a(wj.gc);
			this.b.Location = new Point(wj.fv.c / 2, wj.fv.d / 2 + wj.gd.Y);
		}
		this.b.a(cab.a);
		this.b.a(ad4.a);
		this.b.IsPrivateComponent = true;
		this.c = new avo();
		if (wj.c())
		{
			if (egg.v)
			{
				this.c.a(egg.a);
			}
			else
			{
				this.c.a(egg.@as);
			}
			this.c.Location = new Point(10, 70);
		}
		else
		{
			this.c.a(wj.ge);
			this.c.Location = new Point(this.b.Location.X, this.b.Location.Y + (int)(1.5f * (float)wj.gf.d));
		}
		this.c.Color = adi.a;
		this.c.a(cab.a);
		this.c.a(ad4.a);
		this.c.IsPrivateComponent = true;
		this.aox(this.b);
		this.aox(this.c);
		this.b();
		this.a();
	}

	// Token: 0x0600C527 RID: 50471 RVA: 0x0044BD7C File Offset: 0x00449F7C
	private void b()
	{
		wj wj = wj.a();
		if (wj.c())
		{
			if (this.b != null)
			{
				this.b.Size = new esj(base.Size.c - 2 * this.c.Location.X, 40);
			}
			if (this.c != null)
			{
				this.c.Size = new esj(base.Size.c - 2 * this.c.Location.X, base.Size.d - this.c.Location.Y);
				return;
			}
		}
		else
		{
			if (this.b != null)
			{
				this.b.Size = new esj(base.Size.c - 2 * this.c.Location.X, wj.gf.d);
			}
			if (this.c != null)
			{
				this.c.Size = new esj(base.Size.c - 2 * this.c.Location.X, base.Size.d - this.c.Location.Y);
			}
		}
	}

	// Token: 0x0600C528 RID: 50472 RVA: 0x0044BEC4 File Offset: 0x0044A0C4
	private void a()
	{
		if (this.d == null)
		{
			this.b.Text = qv.b("BaseAbilities/BaseAbilityScores");
			this.c.Text = qv.b("BaseAbilities/GeneralInfo");
			return;
		}
		BaseAbilityEnum baseAbilityEnum;
		if (Enum.TryParse<BaseAbilityEnum>(this.d, true, out baseAbilityEnum))
		{
			this.b.Text = dh9.a(baseAbilityEnum);
		}
		if (string.IsNullOrEmpty(this.b.Text))
		{
			this.b.Text = this.d;
		}
		try
		{
			euz euz = this.c;
			string a_ = "BaseAbilities/" + this.d + this.e;
			object[] a_2 = bex.a;
			euz.Text = qv.a(a_, a_2);
		}
		catch
		{
			this.c.Text = "<Произошла ошибка>";
			throw;
		}
	}

	// Token: 0x0600C529 RID: 50473 RVA: 0x0044BFAC File Offset: 0x0044A1AC
	protected override void jq(object A_0, c1 A_1)
	{
		base.jq(A_0, A_1);
		this.b();
	}

	// Token: 0x04004824 RID: 18468
	private new static string[] a = new string[1];

	// Token: 0x04004825 RID: 18469
	private new avo b;

	// Token: 0x04004826 RID: 18470
	private new avo c;

	// Token: 0x04004827 RID: 18471
	private new string d;

	// Token: 0x04004828 RID: 18472
	public new string e;
}
