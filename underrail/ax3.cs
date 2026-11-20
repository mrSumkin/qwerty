using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x02000573 RID: 1395
public sealed class ax3 : a9t, bsq, amj
{
	// Token: 0x060023F9 RID: 9209 RVA: 0x000C7188 File Offset: 0x000C5388
	public ax3()
	{
		this.a();
	}

	// Token: 0x060023FA RID: 9210 RVA: 0x000C71BC File Offset: 0x000C53BC
	public Rectangle? s2()
	{
		Point point = base.at();
		return new Rectangle?(new Rectangle(point.X, point.Y, base.Size.c, base.Size.d));
	}

	// Token: 0x060023FB RID: 9211 RVA: 0x000C71FC File Offset: 0x000C53FC
	public bool b(string A_0)
	{
		for (int i = 0; i < this.c; i++)
		{
			if (this.b[i] == A_0)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060023FC RID: 9212 RVA: 0x000C7238 File Offset: 0x000C5438
	public new bool d(string A_0)
	{
		if (this.b(A_0))
		{
			return false;
		}
		for (int i = 0; i < this.c; i++)
		{
			if (this.b[i] == null)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060023FD RID: 9213 RVA: 0x000C727C File Offset: 0x000C547C
	public bool a(string A_0)
	{
		if (this.b(A_0))
		{
			return false;
		}
		for (int i = 0; i < this.c; i++)
		{
			if (this.b[i] == null)
			{
				this.b[i] = A_0;
				return true;
			}
		}
		return false;
	}

	// Token: 0x060023FE RID: 9214 RVA: 0x000C72CC File Offset: 0x000C54CC
	public bool c(string A_0)
	{
		for (int i = 0; i < this.c; i++)
		{
			if (this.b[i] == A_0)
			{
				this.b[i] = null;
				return true;
			}
		}
		return false;
	}

	// Token: 0x060023FF RID: 9215 RVA: 0x000C7314 File Offset: 0x000C5514
	public override void ag5(e6d A_0)
	{
		if (this.k == null)
		{
			this.k = bd1.a(this.f, this, this.s2());
		}
		efk efk = ces.c();
		double num = c2h.a(efk, this.b);
		this.i.Text = string.Format("{0}%", Convert.ToInt32(num * 100.0));
		if (num > 1.2)
		{
			this.i.Color = Color.OrangeRed;
		}
		else if (num > 1.1)
		{
			this.i.Color = Color.Orange;
		}
		else if (num > 1.0)
		{
			this.i.Color = Color.Yellow;
		}
		else if (num < 1.0)
		{
			this.i.Color = Color.Green;
		}
		else
		{
			this.i.Color = Color.LightGray;
		}
		base.ag5(A_0);
		bool a_ = false;
		bool flag = false;
		if (efk != null)
		{
			flag = (dz6.e() || efk.IsInCombat);
			if (!flag)
			{
				for (int i = 0; i < this.b.Length; i++)
				{
					if (efk.Offense.ai[i] != this.b[i])
					{
						a_ = true;
						break;
					}
				}
			}
			int num2 = efk.PsiAbilities.a();
			efk.BaseAbilities.a(aiy.a(efk)).f();
			if (num2 != this.j)
			{
				this.e.a();
				this.j = num2;
			}
			int num3 = c2h.b(efk);
			if (this.c != num3)
			{
				this.c = num3;
				this.b();
			}
		}
		this.f.Enabled = a_;
		this.g.Visible = flag;
	}

	// Token: 0x06002400 RID: 9216 RVA: 0x000C7518 File Offset: 0x000C5718
	private void b()
	{
		wj wj = wj.a();
		int num = 4;
		int num2;
		int num3;
		int num4;
		int num5;
		if (wj.c())
		{
			num2 = 30;
			num3 = 65;
			num4 = 60;
			num5 = 60;
		}
		else
		{
			num2 = wj.e1.X;
			num3 = wj.e1.Y;
			num4 = wj.e2.X;
			num5 = wj.e2.Y;
		}
		if (this.c > 8)
		{
			if (wj.c())
			{
				num3 -= 10;
				num4 -= 7;
				num5 -= 7;
				num5 = Convert.ToInt32((double)num5 * 0.85);
			}
			else
			{
				num3 -= wj.e2.Y / 4;
				num5 = Convert.ToInt32((double)num5 * 0.8);
			}
			this.a[8].Visible = true;
			this.a[9].Visible = true;
			this.a[10].Visible = true;
		}
		else
		{
			this.a[8].Visible = false;
			this.a[9].Visible = false;
			this.a[10].Visible = false;
		}
		for (int i = 0; i < aiy.au; i++)
		{
			double num6 = (double)(i / num);
			double num7 = (double)(i % num);
			if (num6 == 2.0)
			{
				num7 += 0.5;
			}
			et9 et = this.a[i];
			et.Location = new Point(Convert.ToInt32((double)num2 + (double)num4 * num7), Convert.ToInt32((double)num3 + (double)num5 * num6));
			this.a[i] = et;
		}
	}

	// Token: 0x06002401 RID: 9217 RVA: 0x000C76E4 File Offset: 0x000C58E4
	public override void iv(e6d A_0, cp9 A_1)
	{
		if (this.k != null)
		{
			this.k.a(A_0);
		}
		base.iv(A_0, A_1);
	}

	// Token: 0x06002402 RID: 9218 RVA: 0x000C7708 File Offset: 0x000C5908
	public ecs yf(euz A_0)
	{
		if (A_0 == this.f)
		{
			return new ecs(new List<dl6>
			{
				new dl6(new List<bph>
				{
					new bph(new d22(cq4.c(), Color.White), qv.b("Concepts/Innervate"), null)
				})
			});
		}
		return null;
	}

	// Token: 0x06002403 RID: 9219 RVA: 0x000C7764 File Offset: 0x000C5964
	private void c(object A_0, b25 A_1)
	{
		if (!dz6.e())
		{
			au2 au = ces.c();
			if (au != null && !au.IsInCombat)
			{
				float num = au.Offense.d(-1000000, true);
				float num2 = au.Offense.b(-1000000, true);
				Array.Copy(this.b, 0, au.Offense.ai, 0, this.b.Length);
				au.bl();
				if (au.b() != null && au.b().Zone != null)
				{
					if (num2 != 0f)
					{
						c5x a_ = au.b() as c5x;
						string a_2 = "BlueSparkExpiration";
						int a_3 = 2;
						double maxValue = double.MaxValue;
						bool a_4 = false;
						bool a_5 = true;
						Vector3? a_6 = new Vector3?(new Vector3(0f, 0f, au.b().Size.Z));
						float? a_7 = dz6.b();
						a7j a_8 = new a7j(a_, a_2, a_3, maxValue, a_4, a_5, a_6, null, null, a_7, false, null);
						au.b().Zone.ActionManager.g9(a_8, atp.a);
					}
					if (num != 0f)
					{
						qy qy = new qy();
						c5x a_9 = au.b() as c5x;
						string a_10 = "PurpleSparkExpiration";
						int a_11 = 2;
						double maxValue2 = double.MaxValue;
						bool a_12 = false;
						bool a_13 = true;
						Vector3? a_14 = new Vector3?(new Vector3(0f, 0f, au.b().Size.Z));
						float? a_7 = dz6.b();
						a7j item = new a7j(a_9, a_10, a_11, maxValue2, a_12, a_13, a_14, null, null, a_7, false, null);
						qy.ad().Add(new bm3(dz6.b(200)));
						qy.ad().Add(item);
						au.b().Zone.ActionManager.g9(qy, atp.a);
					}
				}
			}
		}
	}

	// Token: 0x06002404 RID: 9220 RVA: 0x000C7948 File Offset: 0x000C5B48
	private void b(object A_0, b25 A_1)
	{
		if (this.k != null)
		{
			this.k.b();
		}
	}

	// Token: 0x06002405 RID: 9221 RVA: 0x000C7960 File Offset: 0x000C5B60
	private void a(object A_0, b25 A_1)
	{
		if (this.k != null)
		{
			this.k.b();
		}
	}

	// Token: 0x06002406 RID: 9222 RVA: 0x000C797C File Offset: 0x000C5B7C
	private void a()
	{
		wj wj = wj.a();
		efk efk = ces.c();
		if (efk != null)
		{
			this.j = efk.PsiAbilities.a();
			this.c = c2h.b(efk);
			Array.Copy(efk.Offense.ai, 0, this.b, 0, this.b.Length);
		}
		base.Text = dh9.c("PsiWindow_Caption");
		this.d = new bg1();
		if (wj.c())
		{
			base.Size = new esj(500, 450);
			this.d.Location = new Point(10, 30);
			this.d.b = bo1.bw;
			this.d.Size = new esj(256, 180);
		}
		else
		{
			esj ex = wj.ex;
			wj.a(ref ex.d);
			base.Size = ex;
			this.d.Location = new Point(10, wj.b9.d);
			this.d.b = string.Format(bo1.bx, wj.e);
			this.d.Size = wj.ew;
		}
		this.aox(this.d);
		this.e = new abf(this, this);
		if (wj.c())
		{
			this.e.Location = new Point((base.Size.c - this.e.Size.c) / 2, 220);
		}
		else
		{
			this.e.Location = new Point((base.Size.c - this.e.Size.c) / 2, this.d.Location.Y + this.d.Size.d + 10);
		}
		this.aox(this.e);
		for (int i = 0; i < aiy.au; i++)
		{
			et9 et = new et9(this, this);
			et.m = i;
			this.aox(et);
			this.a[i] = et;
		}
		this.f = new dak();
		this.f.Text = dh9.c("PsiWindow_Button_Innervate");
		if (wj.c())
		{
			this.f.Size = new esj(120, 25);
			if (egg.v)
			{
				this.f.Font = egg.a;
				this.f.TextLabelOffset = new Point(0, 6);
			}
			else
			{
				this.f.Font = egg.aq;
				this.f.TextLabelOffset = new Point(0, egg.b(this.f.Font));
			}
			this.f.d = bo1.z;
		}
		else
		{
			this.f.Size = wj.c2;
			this.f.Font = wj.c5;
			this.f.TextLabelOffset = new Point(0, egg.b(this.f.Font));
			this.f.d = wj.f;
			this.f.f = wj.e7;
			this.f.e = new esj?(wj.e8);
		}
		this.f.Location = new Point(base.Size.c - this.f.Size.c - 20, base.Size.d - this.f.Size.d - 20);
		this.f.g = adi.a;
		this.f.j = adi.b;
		this.f.p(new EventHandler<b25>(this.c));
		this.f.j(new EventHandler<b25>(this.a));
		this.f.l(new EventHandler<b25>(this.b));
		this.f.Enabled = false;
		e4z.j(this.f);
		this.aox(this.f);
		this.g = new avo();
		this.g.Location = new Point(20, this.f.Location.Y + 2);
		this.g.a(true);
		this.g.Visible = false;
		if (wj.c())
		{
			this.g.a(egg.ai);
		}
		else
		{
			this.g.a(wj.e0);
		}
		this.g.Color = Color.Red;
		this.g.Text = dh9.c("PsiWindow_CannotInnervateInCombat");
		this.aox(this.g);
		this.h = new avo();
		this.h.a(true);
		if (wj.c())
		{
			this.h.Location = new Point(270, 80);
			this.h.a(egg.ai);
		}
		else
		{
			this.h.Location = new Point(this.d.Location.X + this.d.Size.c + 10, this.d.Location.Y + this.d.Size.d / 3);
			this.h.a(wj.e0);
		}
		this.h.Text = dh9.c("PsiWindow_BasePsiCostModifier") + ":";
		this.aox(this.h);
		this.i = new avo();
		this.i.a(true);
		this.i.Location = new Point(this.h.Location.X + this.h.Size.c + 15, this.h.Location.Y);
		if (wj.c())
		{
			this.i.a(egg.ai);
		}
		else
		{
			this.i.a(wj.e0);
		}
		this.i.Color = Color.LightGray;
		this.i.Text = "100%";
		this.aox(this.i);
		this.b();
	}

	// Token: 0x040014D0 RID: 5328
	public new et9[] a = new et9[aiy.au];

	// Token: 0x040014D1 RID: 5329
	public new string[] b = new string[aiy.au];

	// Token: 0x040014D2 RID: 5330
	public new int c;

	// Token: 0x040014D3 RID: 5331
	private new bg1 d;

	// Token: 0x040014D4 RID: 5332
	private new abf e;

	// Token: 0x040014D5 RID: 5333
	private new dak f;

	// Token: 0x040014D6 RID: 5334
	private new avo g;

	// Token: 0x040014D7 RID: 5335
	private new avo h;

	// Token: 0x040014D8 RID: 5336
	private new avo i;

	// Token: 0x040014D9 RID: 5337
	private new int j;

	// Token: 0x040014DA RID: 5338
	private new dsy k;
}
