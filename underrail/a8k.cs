using System;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common;
using TimelapseVertigo.Common.Settings;
using TimelapseVertigo.UI;

// Token: 0x0200208F RID: 8335
public class a8k : daj, el2
{
	// Token: 0x0600C787 RID: 51079 RVA: 0x00463C50 File Offset: 0x00461E50
	public a8k(azl A_0)
	{
		czh.a(A_0, "controller");
		this.a = A_0;
		this.c();
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		this.d.Enabled = (serviceOrThrow.arj() != null);
	}

	// Token: 0x0600C788 RID: 51080 RVA: 0x00463C98 File Offset: 0x00461E98
	private void c()
	{
		wj wj = wj.a();
		esj esj = bpo.GetServiceOrThrow<bef>().k0();
		this.b = czo.a(esj);
		esj ad;
		if (wj.c())
		{
			ad = new esj(350, 35);
		}
		else
		{
			ad = wj.ad;
		}
		MainMenuTheme mainMenuTheme = bpo.GetServiceOrThrow<cnk>().aq1().b().s();
		ec9 ec = new ec9();
		if (wj.c())
		{
			if (mainMenuTheme == MainMenuTheme.HeavyDuty)
			{
				ec.Location = new Point((int)Math.Max(10.0, (double)esj.c * 0.125 - (double)(ad.c / 2)), esj.d - 455);
			}
			else
			{
				ec.Location = new Point((int)((double)esj.c * 0.75 - (double)(ad.c / 2)), esj.d - 455);
			}
			ec.Size = new esj(350, 356);
			ec.c = bo1.t;
		}
		else
		{
			esj a_ = new esj(ad.c, (int)((float)ad.d * 9.5f));
			wj.a(ref a_.d);
			ec.Size = a_;
			if (mainMenuTheme == MainMenuTheme.HeavyDuty)
			{
				ec.Location = new Point((int)Math.Max(10.0, (double)esj.c * 0.125 - (double)(ad.c / 2)), esj.d - ec.Size.d - ad.d * 2);
			}
			else
			{
				ec.Location = new Point((int)((double)esj.c * 0.75 - (double)(ad.c / 2)), esj.d - ec.Size.d - ad.d);
			}
			ec.c = wj.f;
			ec.e = wj.ca;
			ec.d = new esj?(wj.cb);
		}
		ec.IsPrivateComponent = true;
		ec.Color = Color.White * 0.75f;
		this.aox(ec);
		this.c = new zt();
		this.c.b = new Color(255, 255, 255, 255);
		this.c.c = this.a();
		if (wj.c())
		{
			this.c.Location = new Point(0, 25);
		}
		else
		{
			this.c.Location = new Point(0, (int)(0.5f * (float)ad.d));
		}
		this.c.HorizontalAlignment = cab.b;
		this.c.VerticalAlignment = ad4.b;
		this.c.h = new Color(255, 255, 255, 200);
		this.c.Text = qv.b("ui/MainMenu_NewGame");
		this.c.Size = ad;
		this.a(this.c);
		e4z.j(this.c);
		ec.aox(this.c);
		this.c.p(new EventHandler<b25>(this.f));
		this.d = new zt();
		this.d.b = new Color(255, 255, 255, 255);
		this.d.c = this.a();
		if (wj.c())
		{
			this.d.Location = new Point(0, 80);
		}
		else
		{
			this.d.Location = new Point(0, (int)(2f * (float)ad.d));
		}
		this.d.HorizontalAlignment = cab.b;
		this.d.VerticalAlignment = ad4.b;
		this.d.h = new Color(255, 255, 255, 200);
		this.d.Text = qv.b("ui/MainMenu_ResumeLastSaved");
		this.d.Size = ad;
		this.d.c(new EventHandler<b25>(this.d));
		this.a(this.d);
		e4z.j(this.d);
		ec.aox(this.d);
		this.e = new zt();
		this.e.b = new Color(255, 255, 255, 255);
		this.e.c = this.a();
		if (wj.c())
		{
			this.e.Location = new Point(0, 135);
		}
		else
		{
			this.e.Location = new Point(0, (int)(3.5f * (float)ad.d));
		}
		this.e.HorizontalAlignment = cab.b;
		this.e.VerticalAlignment = ad4.b;
		this.e.h = new Color(255, 255, 255, 200);
		this.e.Text = qv.b("ui/MainMenu_LoadGame");
		this.e.Size = ad;
		this.a(this.e);
		e4z.j(this.e);
		ec.aox(this.e);
		this.e.p(new EventHandler<b25>(this.e));
		this.f = new zt();
		this.f.b = new Color(255, 255, 255, 255);
		this.f.c = this.a();
		if (wj.c())
		{
			this.f.Location = new Point(0, 190);
		}
		else
		{
			this.f.Location = new Point(0, (int)(5f * (float)ad.d));
		}
		this.f.HorizontalAlignment = cab.b;
		this.f.VerticalAlignment = ad4.b;
		this.f.h = new Color(255, 255, 255, 200);
		this.f.Text = qv.b("ui/MainMenu_Options");
		this.f.Size = ad;
		this.a(this.f);
		e4z.j(this.f);
		ec.aox(this.f);
		this.f.p(new EventHandler<b25>(this.c));
		this.g = new zt();
		this.g.b = new Color(255, 255, 255, 255);
		this.g.c = this.a();
		if (wj.c())
		{
			this.g.Location = new Point(0, 245);
		}
		else
		{
			this.g.Location = new Point(0, (int)(6.5f * (float)ad.d));
		}
		this.g.HorizontalAlignment = cab.b;
		this.g.VerticalAlignment = ad4.b;
		this.g.h = new Color(255, 255, 255, 200);
		this.g.Text = qv.b("ui/MainMenu_Credits");
		this.g.Size = ad;
		this.a(this.g);
		e4z.j(this.g);
		ec.aox(this.g);
		this.g.p(new EventHandler<b25>(this.b));
		this.h = new zt();
		this.h.b = new Color(255, 255, 255, 255);
		this.h.c = this.a();
		if (wj.c())
		{
			this.h.Location = new Point(0, 300);
		}
		else
		{
			this.h.Location = new Point(0, (int)(8f * (float)ad.d));
		}
		this.h.HorizontalAlignment = cab.b;
		this.h.VerticalAlignment = ad4.b;
		this.h.h = new Color(255, 255, 255, 200);
		this.h.Text = qv.b("ui/MainMenu_Exit");
		this.h.Size = ad;
		this.a(this.h);
		e4z.j(this.h);
		ec.aox(this.h);
		this.h.p(new EventHandler<b25>(this.a));
		avo avo = new avo();
		avo.a(true);
		avo.Text = string.Format(qv.b("ui/MainMenu_Version") + ": {0}", dm9.d.ToString());
		avo.Color = Color.White;
		if (wj.c())
		{
			avo.a(egg.b);
			avo.Location = new Point(15, esj.d - 35);
		}
		else
		{
			avo.a(wj.ag);
			avo.Location = new Point(15, esj.d - (int)((float)avo.Size.d * 1.5f));
		}
		this.b.aox(avo);
		base.Text = null;
		base.Location = new Point(0, 0);
		base.Size = esj;
		this.Enabled = true;
		base.Visible = true;
		base.Name = "MainMenuScreen";
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
		this.aox(this.b);
		this.b.aox(ec);
	}

	// Token: 0x0600C789 RID: 51081 RVA: 0x004646F4 File Offset: 0x004628F4
	private void a(zt A_0)
	{
		wj wj = wj.a();
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (wj.c())
		{
			A_0.Font = egg.e;
			A_0.TextLabelOffset = new Point(0, 8);
		}
		else
		{
			A_0.Font = wj.ae;
			A_0.TextLabelOffset = new Point(0, wj.af);
		}
		if (serviceOrThrow.aq1().b().s() == MainMenuTheme.HeavyDuty)
		{
			A_0.a = new Color(135, 149, 221);
			if (wj.c())
			{
				A_0.d = bo1.b;
				return;
			}
			A_0.d = wj.f;
			A_0.e = wj.fk;
			A_0.f = new esj?(wj.fl);
			return;
		}
		else if (serviceOrThrow.aq1().b().s() == MainMenuTheme.Expedition)
		{
			A_0.a = adi.s;
			if (wj.c())
			{
				A_0.d = bo1.c;
				return;
			}
			A_0.d = wj.f;
			A_0.e = wj.fi;
			A_0.f = new esj?(wj.fj);
			return;
		}
		else
		{
			A_0.a = adi.c;
			if (wj.c())
			{
				A_0.d = bo1.b;
				return;
			}
			A_0.d = wj.f;
			A_0.e = wj.fg;
			A_0.f = new esj?(wj.fh);
			return;
		}
	}

	// Token: 0x0600C78A RID: 51082 RVA: 0x00464874 File Offset: 0x00462A74
	private void f(object A_0, b25 A_1)
	{
		this.a.aty();
	}

	// Token: 0x0600C78B RID: 51083 RVA: 0x00464884 File Offset: 0x00462A84
	private void e(object A_0, b25 A_1)
	{
		bpo.GetServiceOrThrow<d4m>().avp(dla.a(TimelapseWorkflows.MakeScreen, new object[]
		{
			new adm(SavedGameManipulationMode.Load, abx.a)
		}));
	}

	// Token: 0x0600C78C RID: 51084 RVA: 0x004648AC File Offset: 0x00462AAC
	private void d(object A_0, b25 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		a3r a3r = serviceOrThrow.arj();
		if (a3r == null)
		{
			this.d.Enabled = false;
			return;
		}
		if (ast.a(a3r.GameVersion, a3r.DLCs))
		{
			bnr.a(new esj(550, 200), null, "Загрузить", "Это сохранение несовместимо с текущей версией игры и не может быть загружено.", "O", "O", null, null, 0, new cpk[]
			{
				new cpk("O", "Ok", true)
			}, null, null);
			return;
		}
		if (ast.a(a3r.GameVersion) && serviceOrThrow.aq1().d().e())
		{
			bnr.a(new esj(550, 250), new a8k.a(this), "Загрузить", "Это сохранение несовместимо с текущей версией игры и не может быть загружено. Всё равно загрузить его?", "Y", "N", null, null, 0, new cpk[]
			{
				new cpk("Y", "Да", true),
				new cpk("A", "Да, и хватит спрашивать", true),
				new cpk("N", "Нет", true)
			}, null, null);
			return;
		}
		this.b();
	}

	// Token: 0x0600C78D RID: 51085 RVA: 0x00464A08 File Offset: 0x00462C08
	private void c(object A_0, b25 A_1)
	{
		bpo.GetServiceOrThrow<d4m>().avp(dla.a(TimelapseWorkflows.OpenOptionsScreenWorkflow, new object[0]));
	}

	// Token: 0x0600C78E RID: 51086 RVA: 0x00464A24 File Offset: 0x00462C24
	private void b(object A_0, b25 A_1)
	{
		cco cco = new cco();
		cco.Gravity = axy.c;
		this.aox(cco);
		cco.a9();
	}

	// Token: 0x0600C78F RID: 51087 RVA: 0x00464A4C File Offset: 0x00462C4C
	private void a(object A_0, b25 A_1)
	{
		this.a.atz();
	}

	// Token: 0x0600C790 RID: 51088 RVA: 0x00464A5C File Offset: 0x00462C5C
	private void b()
	{
		a3r a3r = bpo.GetServiceOrThrow<cnk>().arj();
		if (a3r != null && !ast.a(a3r.GameVersion, a3r.DLCs))
		{
			bpo.GetServiceOrThrow<d4m>().avp(dla.a(TimelapseWorkflows.LoadGameFromMainMenu, new object[]
			{
				a3r
			}));
		}
	}

	// Token: 0x0600C791 RID: 51089 RVA: 0x00464AAC File Offset: 0x00462CAC
	private Color a()
	{
		if (bpo.GetServiceOrThrow<cnk>().aq1().b().s() == MainMenuTheme.Expedition)
		{
			return adi.t;
		}
		return new Color(89, 47, 7, 255);
	}

	// Token: 0x040049EF RID: 18927
	private new azl a;

	// Token: 0x040049F0 RID: 18928
	private new bg1 b;

	// Token: 0x040049F1 RID: 18929
	private new zt c;

	// Token: 0x040049F2 RID: 18930
	private new zt d;

	// Token: 0x040049F3 RID: 18931
	private new zt e;

	// Token: 0x040049F4 RID: 18932
	private new zt f;

	// Token: 0x040049F5 RID: 18933
	private new zt g;

	// Token: 0x040049F6 RID: 18934
	private zt h;

	// Token: 0x02002090 RID: 8336
	private new class a : eyp
	{
		// Token: 0x0600C792 RID: 51090 RVA: 0x00464AE0 File Offset: 0x00462CE0
		public a(a8k A_0)
		{
			this.a = A_0;
		}

		// Token: 0x0600C793 RID: 51091 RVA: 0x00464AF4 File Offset: 0x00462CF4
		public void g0(string A_0)
		{
			if (A_0 == "Y")
			{
				this.a.b();
			}
			else if (A_0 == "A")
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				serviceOrThrow.aq1().d().a(false);
				serviceOrThrow.arb(serviceOrThrow.aq1());
				this.a.b();
			}
			this.a.a9();
		}

		// Token: 0x040049F7 RID: 18935
		private a8k a;
	}
}
