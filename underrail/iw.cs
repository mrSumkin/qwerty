using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020005AE RID: 1454
public class iw : daj, el2
{
	// Token: 0x060026D2 RID: 9938 RVA: 0x000E1658 File Offset: 0x000DF858
	public a9m h()
	{
		return this.a;
	}

	// Token: 0x060026D3 RID: 9939 RVA: 0x000E1660 File Offset: 0x000DF860
	public e3q g()
	{
		return this.k;
	}

	// Token: 0x060026D4 RID: 9940 RVA: 0x000E1668 File Offset: 0x000DF868
	public bau i()
	{
		return this.l;
	}

	// Token: 0x060026D5 RID: 9941 RVA: 0x000E1674 File Offset: 0x000DF874
	public iw(e3q A_0, a9m A_1, bool A_2)
	{
		czh.a(A_0, "character");
		this.m = A_2;
		this.k = A_0;
		this.a = A_1;
		this.n = (this.a == a9m.c);
		this.k.bl();
		this.e();
		this.d();
		this.c();
	}

	// Token: 0x060026D6 RID: 9942 RVA: 0x000E16D4 File Offset: 0x000DF8D4
	private void c(object A_0, b25 A_1)
	{
		if (this.a == a9m.a)
		{
			this.a();
			return;
		}
		string a_;
		if (this.n)
		{
			a_ = dh9.c("CharScreen_CancelNewCharGen");
		}
		else
		{
			a_ = dh9.c("CharScreen_CancelLevelUp");
		}
		bnr.a(new esj(500, 200), new iw.b(this), dh9.c("Cancel"), a_, dh9.c("OptionBox_Code_Y"), dh9.c("OptionBox_Code_N"), null, null, 0, new cpk[]
		{
			new cpk(dh9.c("OptionBox_Code_Y"), dh9.c("Yes"), true),
			new cpk(dh9.c("OptionBox_Code_N"), dh9.c("No"), true)
		}, null, null);
	}

	// Token: 0x060026D7 RID: 9943 RVA: 0x000E17B4 File Offset: 0x000DF9B4
	private void b(object A_0, b25 A_1)
	{
		if (this.b())
		{
			base.a(cku.a);
			base.z();
		}
	}

	// Token: 0x060026D8 RID: 9944 RVA: 0x000E17D0 File Offset: 0x000DF9D0
	private void a(object A_0, b25 A_1)
	{
		e7u e7u = new e7u();
		e7u.Gravity = axy.c;
		e7u.b();
		e7u.a9();
		e7u.a(new EventHandler<el5>(this.a));
		bpo.GetServiceOrThrow<bcm>().aau().aox(e7u);
	}

	// Token: 0x060026D9 RID: 9945 RVA: 0x000E181C File Offset: 0x000DFA1C
	private void a(object A_0, el5 A_1)
	{
		e7u e7u = A_0 as e7u;
		if (e7u != null && e7u.g != null)
		{
			this.a(e7u.g.a);
			ExperienceSystem experienceSystem = this.k.e();
			this.k = e7u.g.a;
			if (this.k.e() != experienceSystem)
			{
				this.k.e(0);
			}
			this.k.a(experienceSystem);
			this.l = e7u.g.d;
			this.a = a9m.b;
			this.f();
		}
	}

	// Token: 0x060026DA RID: 9946 RVA: 0x000E18B8 File Offset: 0x000DFAB8
	protected override void g6(object A_0, ane A_1)
	{
		base.vx(A_0, A_1);
		if (A_1.a == Keys.Escape)
		{
			e4z.j();
			this.c(this, new b25());
		}
	}

	// Token: 0x060026DB RID: 9947 RVA: 0x000E18E4 File Offset: 0x000DFAE4
	public override void ag5(e6d A_0)
	{
		base.ag5(A_0);
		d1a serviceOrThrow = bpo.GetServiceOrThrow<d1a>();
		if (serviceOrThrow.aa7() == this && !this.o && this.a == a9m.b && this.k.Level == aiy.bk + 1)
		{
			this.o = true;
			bnr.a(new esj(500, 332), null, dh9.c("CharScreen_Veteran"), qv.b("Rules/Veteran"), "OK", "OK", null, null, 0, new cpk[]
			{
				new cpk("OK", dh9.c("OK"), true)
			}, this, this);
		}
		if (serviceOrThrow.aa7() == this && dk2.f() && !this.p && this.a == a9m.b && this.k.Level >= aiy.an + 1)
		{
			bool flag = this.k.Level == aiy.an + 1;
			if (!flag)
			{
				if (Enumerable.Sum<f>(this.k.Specializations.Values, new Func<f, int>(iw.a.a.a)) == 0)
				{
					flag = true;
				}
			}
			if (flag)
			{
				this.p = true;
				bnr.a(new esj(500, 236), null, dh9.c("CharScreen_Specialization"), qv.b("Rules/Specialization"), "OK", "OK", null, null, 0, new cpk[]
				{
					new cpk("OK", dh9.c("OK"), true)
				}, this, this);
			}
		}
	}

	// Token: 0x060026DC RID: 9948 RVA: 0x000E1AC0 File Offset: 0x000DFCC0
	private void f()
	{
		foreach (euz a_ in Enumerable.ToList<euz>(base.Controls))
		{
			this.g(a_);
		}
		this.e();
		this.d();
		this.c();
	}

	// Token: 0x060026DD RID: 9949 RVA: 0x000E1B34 File Offset: 0x000DFD34
	private void a(e3q A_0)
	{
		A_0.Dead = false;
		A_0.StatusEffects.c();
		A_0.Defense.q().zp(A_0.Defense.q().zm());
		A_0.Offense.aa().zp(A_0.Offense.aa().zm());
		A_0.PersonalAttitudes.Clear();
		A_0.bl();
	}

	// Token: 0x060026DE RID: 9950 RVA: 0x000E1BA4 File Offset: 0x000DFDA4
	private void e()
	{
		wj wj = wj.a();
		esj a_ = bpo.GetServiceOrThrow<bef>().k0();
		if (this.m)
		{
			this.b = czo.a(a_);
			this.aox(this.b);
		}
		else
		{
			this.aox(new d0p(false)
			{
				Size = a_,
				Gravity = axy.a,
				Color = adi.e
			});
		}
		this.c = new dpg();
		if (wj.c())
		{
			this.c.b(new esj(200, 35));
			this.c.Size = new esj(965, 704);
			this.c.a(new esj(2, 2));
			this.c.a(5);
			this.c.a(egg.b);
			this.c.a(new Point(0, 6));
			this.c.b(bo1.y);
			this.c.n = bo1.m;
		}
		else
		{
			this.c.b(wj.fw);
			esj a_2 = new esj(wj.fu.c, wj.fw.d + wj.fu.d);
			this.c.Size = a_2;
			this.c.a(wj.fx);
			this.c.a(wj.fy);
			this.c.a(wj.fz);
			this.c.a(new Point(0, wj.f0));
			this.c.b(wj.f);
			this.c.b(wj.e5);
			this.c.a(new esj?(wj.e6));
			this.c.n = wj.f;
			this.c.o = wj.cc;
			this.c.p = new esj?(wj.cd);
		}
		this.c.a(new Color(255, 255, 255, 255));
		this.c.d(new Color(174, 87, 0, 255));
		this.c.b(new Color(255, 255, 255, 255));
		this.c.c(new Color(255, 255, 255, 255));
		this.c.Text = null;
		this.c.Location = new Point(26, 28);
		this.c.Enabled = true;
		this.c.Visible = true;
		this.c.Name = "CharacterSheet";
		this.c.Color = new Color(255, 255, 255, 255);
		this.c.Gravity = axy.a;
		this.c.Focusable = false;
		this.c.Movable = false;
		this.c.Resizable = false;
		this.c.Anchoring = new mu();
		this.c.Anchoring.a(false);
		this.c.Anchoring.d(false);
		this.c.Anchoring.c(false);
		this.c.Anchoring.b(false);
		this.c.IsPrivateComponent = false;
		this.c.b();
		base.Text = null;
		base.Location = new Point(0, 0);
		base.Size = a_;
		this.Enabled = true;
		base.Visible = true;
		base.Name = "CharacterScreen";
		base.Color = new Color(255, 255, 255, 255);
		this.Gravity = axy.a;
		this.Focusable = false;
		base.Movable = false;
		base.Resizable = false;
		base.Anchoring = new mu();
		base.Anchoring.a(false);
		base.Anchoring.d(false);
		base.Anchoring.c(false);
		base.Anchoring.b(false);
		base.IsPrivateComponent = false;
		this.aox(this.c);
	}

	// Token: 0x060026DF RID: 9951 RVA: 0x000E2010 File Offset: 0x000E0210
	private void d()
	{
		wj wj = wj.a();
		this.i = new dak();
		this.i.Text = ((this.a == a9m.a) ? dh9.c("Close") : dh9.c("Cancel"));
		this.i.c(new EventHandler<b25>(this.c));
		iw.a(this.i, wj);
		if (wj.c())
		{
			this.i.Location = new Point(this.c.Location.X + this.c.Size.c - (this.i.Size.c + 35), this.c.Location.Y + this.c.Size.d - (this.i.Size.d + 25));
		}
		else
		{
			this.i.Location = new Point(this.c.Location.X + this.c.Size.c - this.i.Size.c - wj.fv.c, this.c.Location.Y + this.c.Size.d - this.i.Size.d - wj.fv.d);
		}
		e4z.j(this.i);
		this.aox(this.i);
		this.h = new dak();
		this.h.Text = dh9.c("Accept");
		this.h.Visible = (this.a > a9m.a);
		this.h.c(new EventHandler<b25>(this.b));
		iw.a(this.h, wj);
		if (wj.c())
		{
			this.h.Location = new Point(this.i.Location.X - this.h.Size.c - 15, this.i.Location.Y);
		}
		else
		{
			this.h.Location = new Point(this.i.Location.X - (int)((float)this.h.Size.c * 1.1f), this.i.Location.Y);
		}
		e4z.j(this.h);
		this.aox(this.h);
		this.j = new dak();
		this.j.Text = dh9.c("Import");
		this.j.Visible = this.n;
		this.j.c(new EventHandler<b25>(this.a));
		iw.a(this.j, wj);
		if (wj.c())
		{
			this.j.Location = new Point(this.h.Location.X - this.j.Size.c - 35, this.h.Location.Y);
		}
		else
		{
			this.j.Location = new Point(this.h.Location.X - (int)((float)this.j.Size.c * 1.1f), this.h.Location.Y);
		}
		e4z.j(this.j);
		this.aox(this.j);
	}

	// Token: 0x060026E0 RID: 9952 RVA: 0x000E23C4 File Offset: 0x000E05C4
	private static void a(dak A_0, wj A_1)
	{
		if (A_1.c())
		{
			A_0.Size = new esj(120, 35);
			A_0.Font = egg.b;
			A_0.d = bo1.y;
			A_0.TextLabelOffset = new Point(0, 6);
		}
		else
		{
			A_0.Size = A_1.f3;
			A_0.Font = A_1.f5;
			A_0.TextLabelOffset = new Point(0, A_1.f4);
			A_0.d = A_1.f;
			A_0.f = A_1.e3;
			A_0.e = new esj?(A_1.e4);
		}
		A_0.g = adi.a;
	}

	// Token: 0x060026E1 RID: 9953 RVA: 0x000E2474 File Offset: 0x000E0674
	private void c()
	{
		this.d = new cvh();
		this.d.Text = dh9.c("CharScreen_Tab_Base");
		this.d.aox(new e44(this.k, this.a));
		this.e = new cvh();
		this.e.Text = dh9.c("CharScreen_Tab_Skills");
		dh5 dh = new dh5(this.k, this.a);
		this.e.aox(dh);
		this.f = new cvh();
		this.f.Text = dh9.c("CharScreen_Tab_Feats");
		cra cra = new cra(this.k, this.a);
		cra cra2 = cra;
		cra2.e = (EventHandler)Delegate.Combine(cra2.e, new EventHandler(dh.b));
		this.f.aox(cra);
		this.c.n().Add(this.d);
		this.c.n().Add(this.e);
		this.c.n().Add(this.f);
		if (this.g().Level > aiy.an && dk2.f())
		{
			this.g = new cvh();
			this.g.Text = dh9.c("CharScreen_Tab_Specialization");
			k8 k = new k8(this.k, this.a);
			cra cra3 = cra;
			cra3.e = (EventHandler)Delegate.Combine(cra3.e, new EventHandler(k.b));
			this.g.aox(k);
			this.c.n().Add(this.g);
		}
	}

	// Token: 0x060026E2 RID: 9954 RVA: 0x000E2638 File Offset: 0x000E0838
	private bool b()
	{
		if (this.a == a9m.a)
		{
			return true;
		}
		if (string.IsNullOrEmpty(this.k.Name))
		{
			this.a(dh9.c("CharScreen_MustEnterName"), 150);
			return false;
		}
		if (this.k.g() > 0)
		{
			this.a(dh9.c("CharScreen_MustSpendAllBaseAbilities"), 180);
			return false;
		}
		if (this.k.h() > 0)
		{
			this.a(dh9.c("CharScreen_MustSpendAllSkills"), 180);
			return false;
		}
		if (this.k.h() < 0)
		{
			this.a(dh9.c("CharScreen_InsufficientSkills"), 180);
			return false;
		}
		if (this.k.j() > 0)
		{
			this.a(dh9.c("CharScreen_MustSpendAllFeats"), 180);
			return false;
		}
		if (this.k.f() > 0)
		{
			this.a(dh9.c("CharScreen_MustSpendAllSpecs"), 180);
			return false;
		}
		if (this.k.f() < 0)
		{
			this.a(dh9.c("CharScreen_InsufficientSpecs"), 180);
			return false;
		}
		return true;
	}

	// Token: 0x060026E3 RID: 9955 RVA: 0x000E2770 File Offset: 0x000E0970
	private void a(string A_0, int A_1)
	{
		bnr.a(new esj(500, A_1), null, dh9.c("Error"), A_0, "OK", "OK", null, null, 0, new cpk[]
		{
			new cpk("OK", dh9.c("OK"), true)
		}, this, this);
	}

	// Token: 0x060026E4 RID: 9956 RVA: 0x000E27DC File Offset: 0x000E09DC
	private void a()
	{
		base.a(cku.b);
		base.z();
	}

	// Token: 0x0400161D RID: 5661
	private new a9m a;

	// Token: 0x0400161E RID: 5662
	private new bg1 b;

	// Token: 0x0400161F RID: 5663
	private new dpg c;

	// Token: 0x04001620 RID: 5664
	private new cvh d;

	// Token: 0x04001621 RID: 5665
	private new cvh e;

	// Token: 0x04001622 RID: 5666
	private new cvh f;

	// Token: 0x04001623 RID: 5667
	private new cvh g;

	// Token: 0x04001624 RID: 5668
	private dak h;

	// Token: 0x04001625 RID: 5669
	private dak i;

	// Token: 0x04001626 RID: 5670
	private new dak j;

	// Token: 0x04001627 RID: 5671
	private new e3q k;

	// Token: 0x04001628 RID: 5672
	private new bau l;

	// Token: 0x04001629 RID: 5673
	private new bool m;

	// Token: 0x0400162A RID: 5674
	private bool n;

	// Token: 0x0400162B RID: 5675
	private bool o;

	// Token: 0x0400162C RID: 5676
	private bool p;

	// Token: 0x0200207F RID: 8319
	private new sealed class b : eyp
	{
		// Token: 0x0600C6A6 RID: 50854 RVA: 0x00459420 File Offset: 0x00457620
		public b(iw A_0)
		{
			this.a = A_0;
		}

		// Token: 0x0600C6A7 RID: 50855 RVA: 0x00459430 File Offset: 0x00457630
		public void g0(string A_0)
		{
			if (A_0 == dh9.c("OptionBox_Code_Y"))
			{
				this.a.a();
			}
		}

		// Token: 0x04004928 RID: 18728
		private iw a;
	}

	// Token: 0x02002080 RID: 8320
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600C6AA RID: 50858 RVA: 0x00459468 File Offset: 0x00457668
		internal int a(f A_0)
		{
			return A_0.Value;
		}

		// Token: 0x04004929 RID: 18729
		public static readonly iw.a a = new iw.a();

		// Token: 0x0400492A RID: 18730
		public static Func<f, int> b;
	}
}
