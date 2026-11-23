using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TimelapseVertigo.Common.Settings;
using TimelapseVertigo.Rules;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02002082 RID: 8322
public class c9v : daj, amj, eyp
{
	// Token: 0x0600C6B2 RID: 50866 RVA: 0x00459A68 File Offset: 0x00457C68
	public string j()
	{
		UiSize uiSize = wj.b();
		if (uiSize >= UiSize.Huge)
		{
			return egg.ay;
		}
		if (uiSize >= UiSize.Large)
		{
			return egg.au;
		}
		return egg.aq;
	}

	// Token: 0x0600C6B3 RID: 50867 RVA: 0x00459A9C File Offset: 0x00457C9C
	public int l()
	{
		UiSize uiSize = wj.b();
		if (uiSize >= UiSize.Huge)
		{
			return 32;
		}
		if (uiSize >= UiSize.Large)
		{
			return 26;
		}
		return 22;
	}

	// Token: 0x0600C6B4 RID: 50868 RVA: 0x00459AC8 File Offset: 0x00457CC8
	public int k()
	{
		UiSize uiSize = wj.b();
		if (uiSize >= UiSize.Huge)
		{
			return 400;
		}
		if (uiSize >= UiSize.Large)
		{
			return 300;
		}
		return 200;
	}

	// Token: 0x0600C6B5 RID: 50869 RVA: 0x00459AFC File Offset: 0x00457CFC
	public int i()
	{
		UiSize uiSize = wj.b();
		if (uiSize >= UiSize.Huge)
		{
			return 465;
		}
		if (uiSize >= UiSize.Large)
		{
			return 365;
		}
		return 265;
	}

	// Token: 0x0600C6B6 RID: 50870 RVA: 0x00459B30 File Offset: 0x00457D30
	public c9v(bool A_0, bool A_1)
	{
		this.h = A_0;
		this.i = A_1;
		this.h();
		this.g();
		this.f();
		this.e();
		this.b();
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		int num;
		if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Huge)
		{
			num = 900;
		}
		else if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.ExtraLarge)
		{
			num = 650;
		}
		else if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Large)
		{
			num = 500;
		}
		else
		{
			num = 300;
		}
		num /= 2;
		Point value = new Point(this.b.Location.X + this.b.Size.c, this.b.Location.Y);
		this.al = new dsy(this, this, esj.a(), num, null, new Point?(value), 500, true, false);
		this.al.a(true);
	}

	// Token: 0x0600C6B7 RID: 50871 RVA: 0x00459CB8 File Offset: 0x00457EB8
	private void h()
	{
		wj wj = wj.a();
		esj a_ = bpo.GetServiceOrThrow<bef>().k0();
		if (this.h)
		{
			this.a = czo.a(a_);
			this.aox(this.a);
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
		this.b = new dpg();
		this.b.a(true);
		if (wj.c())
		{
			this.b.b(new esj(160, 35));
			this.b.Size = new esj(965, 704);
			this.b.a(new esj(2, 2));
			this.b.a(5);
			this.b.a(egg.b);
			this.b.a(new Point(0, 6));
			this.b.b(bo1.y);
			this.b.n = bo1.m;
		}
		else
		{
			this.b.b(wj.fw);
			esj a_2 = new esj(wj.fu.c, wj.fw.d + wj.fu.d);
			this.b.Size = a_2;
			this.b.a(wj.fx);
			this.b.a(wj.fy);
			this.b.a(wj.fz);
			this.b.a(new Point(0, wj.f0));
			this.b.b(wj.f);
			this.b.b(wj.e5);
			this.b.a(new esj?(wj.e6));
			this.b.n = wj.f;
			this.b.o = wj.cc;
			this.b.p = new esj?(wj.cd);
		}
		this.b.a(new Color(255, 255, 255, 255));
		this.b.d(new Color(174, 87, 0, 255));
		this.b.b(new Color(255, 255, 255, 255));
		this.b.c(new Color(255, 255, 255, 255));
		this.b.Text = null;
		this.b.Location = new Point(26, 28);
		this.b.Enabled = true;
		this.b.Visible = true;
		this.b.Name = "RulesSheet";
		this.b.Color = new Color(255, 255, 255, 255);
		this.b.Gravity = axy.a;
		this.b.Focusable = false;
		this.b.Movable = false;
		this.b.Resizable = false;
		this.b.Anchoring = new mu();
		this.b.Anchoring.a(false);
		this.b.Anchoring.d(false);
		this.b.Anchoring.c(false);
		this.b.Anchoring.b(false);
		this.b.IsPrivateComponent = false;
		this.b.j(new EventHandler<b25>(this.s));
		this.b.g(new EventHandler<b25>(this.s));
		this.b.b();
		base.Text = null;
		base.Location = new Point(0, 0);
		base.Size = a_;
		this.Enabled = true;
		base.Visible = true;
		base.Name = "GameRulesScreen";
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
		this.aox(this.b);
	}

	// Token: 0x0600C6B8 RID: 50872 RVA: 0x0045A15C File Offset: 0x0045835C
	private void g()
	{
		wj wj = wj.a();
		this.f = new dak();
		this.f.Text = (this.i ? dh9.c("Close") : dh9.c("Cancel"));
		this.f.c(new EventHandler<b25>(this.ac));
		c9v.a(this.f, wj);
		if (wj.c())
		{
			this.f.Location = new Point(this.b.Location.X + this.b.Size.c - (this.f.Size.c + 35), this.b.Location.Y + this.b.Size.d - (this.f.Size.d + 25));
		}
		else
		{
			this.f.Location = new Point(this.b.Location.X + this.b.Size.c - this.f.Size.c - wj.fv.c, this.b.Location.Y + this.b.Size.d - this.f.Size.d - wj.fv.d);
		}
		e4z.j(this.f);
		this.aox(this.f);
		this.e = new dak();
		this.e.Text = dh9.c("Accept");
		this.e.c(new EventHandler<b25>(this.aa));
		this.e.Visible = this.i;
		c9v.a(this.e, wj);
		if (wj.c())
		{
			this.e.Location = new Point(this.f.Location.X - this.e.Size.c - 15, this.f.Location.Y);
		}
		else
		{
			this.e.Location = new Point(this.f.Location.X - (int)((float)this.e.Size.c * 1.1f), this.f.Location.Y);
		}
		e4z.j(this.e);
		this.aox(this.e);
	}

	// Token: 0x0600C6B9 RID: 50873 RVA: 0x0045A404 File Offset: 0x00458604
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

	// Token: 0x0600C6BA RID: 50874 RVA: 0x0045A4B4 File Offset: 0x004586B4
	private void f()
	{
		wj wj = wj.a();
		UiSize uiSize = wj.b();
		this.c = new cvh();
		this.c.Text = dh9.c("NewGame_Tab_Rules");
		this.c.j(new EventHandler<b25>(this.s));
		this.c.g(new EventHandler<b25>(this.s));
		this.j = new au6();
		if (wj.c())
		{
			this.j.Location = new Point(520, 30);
			this.j.Size = new esj(410, 530);
			this.j.b(bo1.r);
		}
		else
		{
			this.c.Size = wj.fu;
			this.j.Location = new Point(this.c.Size.c - wj.fv.c - (int)(3.2 * (double)wj.f3.c), wj.fv.d);
			esj a_ = new esj(this.c.Size.c - this.j.Location.X - wj.fv.c, this.c.Size.d - this.j.Location.Y - wj.fv.d * 2 - wj.f3.d);
			wj.a(ref a_.d);
			this.j.Size = a_;
			this.j.b(wj.f);
			this.j.n = wj.b8;
			this.j.o = new esj?(wj.b9);
		}
		this.j.Focusable = false;
		this.j.j(new EventHandler<b25>(this.s));
		this.j.g(new EventHandler<b25>(this.s));
		this.c.aox(this.j);
		this.t = new avo();
		if (wj.c())
		{
			this.t.a(egg.e);
			this.t.Location = new Point(this.j.Location.X + 10, this.j.Location.Y + 20);
		}
		else
		{
			this.t.a(wj.gh);
			this.t.Location = new Point(this.j.Location.X + wj.fv.c / 2, this.j.Location.Y + wj.fv.d);
		}
		this.t.a(cab.a);
		this.t.a(ad4.a);
		this.t.IsPrivateComponent = true;
		this.c.aox(this.t);
		this.u = new avo();
		this.u.a(false);
		if (wj.c())
		{
			if (egg.v)
			{
				this.u.a(egg.a);
			}
			else
			{
				this.u.a(egg.@as);
			}
			this.u.Location = new Point(this.j.Location.X + 10, this.j.Location.Y + 70);
			this.u.Size = new esj(this.j.Size.c - 20, this.j.Size.d - 80);
		}
		else
		{
			int num = 20;
			cne serviceOrThrow = bpo.GetServiceOrThrow<cne>();
			try
			{
				num = serviceOrThrow.GetResource<SpriteFont>(wj.gh, null).LineSpacing;
			}
			catch
			{
			}
			this.u.a(wj.gg);
			this.u.Location = new Point(this.t.Location.X, this.t.Location.Y + (int)(1.5f * (float)num));
			this.u.Size = new esj(this.j.Size.c - wj.fv.c, this.j.Size.d - wj.fv.d * 2);
		}
		this.u.Color = adi.a;
		this.u.a(cab.a);
		this.u.a(ad4.a);
		this.u.IsPrivateComponent = true;
		this.c.aox(this.u);
		if (!wj.c())
		{
			int num2;
			int num3;
			if (uiSize > UiSize.Small)
			{
				num2 = (int)((float)this.c.Size.d * 0.25f) - wj.he.d / 2;
				num3 = (int)((float)this.c.Size.d * 0.75f) - wj.he.d / 2;
			}
			else
			{
				num2 = (int)((float)this.c.Size.d * 0.33f) - wj.he.d / 2;
				num3 = (int)((float)this.c.Size.d * 0.66f) - wj.he.d / 2;
			}
			cxh cxh = new cxh();
			cxh.Location = new Point(wj.fv.c, num2 - wj.fv.d);
			cxh.Size = new esj(wj.he.c * ((uiSize > UiSize.Small) ? 3 : 5), wj.fx.d);
			this.c.aox(cxh);
			this.k = new avo();
			this.k.a(true);
			this.k.a(wj.hc);
			this.k.Color = adi.a;
			this.k.Text = dh9.c("NewGame_GameDifficulty");
			this.k.Location = new Point(cxh.Location.X + wj.fv.c, cxh.Location.Y - this.k.Size.d);
			this.k.a(cab.a);
			this.c.aox(this.k);
			cxh cxh2 = new cxh();
			cxh2.Location = new Point(wj.fv.c, num3 - wj.fv.d);
			cxh2.Size = new esj(wj.he.c * ((uiSize > UiSize.Small) ? 3 : 5), wj.fx.d);
			this.c.aox(cxh2);
			this.q = new avo();
			this.q.a(true);
			this.q.a(wj.hc);
			this.q.Color = adi.a;
			this.q.Text = dh9.c("NewGame_ExperienceSystem");
			this.q.Location = new Point(cxh2.Location.X + wj.fv.c, cxh2.Location.Y - this.q.Size.d);
			this.q.a(cab.a);
			this.c.aox(this.q);
			foreach (object obj in Enum.GetValues(typeof(GameDifficulty)))
			{
				GameDifficulty gameDifficulty = (GameDifficulty)obj;
				bw9 bw = new bw9();
				bw.Checked = (gameDifficulty == GameDifficulty.Easy);
				if (uiSize > UiSize.Small)
				{
					bw.Location = new Point((int)(wj.fv.c + gameDifficulty % GameDifficulty.Dominating * (GameDifficulty)(wj.he.c + wj.hf) + (int)(gameDifficulty / GameDifficulty.Dominating * (GameDifficulty)wj.he.c / GameDifficulty.Hard)), num2 + wj.he.d * (int)(gameDifficulty / GameDifficulty.Dominating));
				}
				else
				{
					bw.Location = new Point((int)(wj.fv.c + gameDifficulty * (GameDifficulty)(wj.he.c + wj.hf)), num2);
				}
				bw.Size = wj.he;
				bw.a = string.Format(bo1.b0, wj.e);
				bw.b = new Point((int)(wj.hd.X + gameDifficulty * (GameDifficulty)wj.he.c), wj.hd.Y);
				bw.c = wj.he;
				bw.Color = adi.a;
				bw.d = adi.d;
				bw.g = new Rectangle?(new Rectangle(wj.hd.X + 5 * wj.he.c, wj.hd.Y, wj.he.c, wj.he.d));
				bw.Tag = gameDifficulty;
				bw.g(new EventHandler<b25>(this.d));
				bw.j(new EventHandler<b25>(this.d));
				bw.c(new EventHandler<b25>(this.c));
				this.x.Add(bw);
				e4z.f(bw);
				this.c.aox(bw);
			}
			if (uiSize > UiSize.Small)
			{
				int num4 = this.j.Location.X - (cxh.Location.X + cxh.Size.c + wj.fv.c);
				if (num4 > 0)
				{
					this.j.Location = new Point(this.j.Location.X - num4, this.j.Location.Y);
					this.j.Size = new esj(this.j.Size.c + num4, this.j.Size.d);
					this.u.Location = new Point(this.u.Location.X - num4, this.u.Location.Y);
					this.u.Size = new esj(this.u.Size.c + num4, this.u.Size.d);
					this.t.Location = new Point(this.t.Location.X - num4, this.t.Location.Y);
					this.t.a(true);
				}
			}
			using (IEnumerator enumerator = Enum.GetValues(typeof(ExperienceSystem)).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj2 = enumerator.Current;
					ExperienceSystem experienceSystem = (ExperienceSystem)obj2;
					bw9 bw2 = new bw9();
					bw2.Checked = (experienceSystem == ExperienceSystem.Oddity);
					bw2.Location = new Point((int)(wj.fv.c + experienceSystem * (ExperienceSystem)(wj.hg.c + wj.hf)), num3);
					bw2.Size = wj.hg;
					bw2.a = string.Format(bo1.b0, wj.e);
					bw2.b = new Point((int)(wj.hd.X + (ExperienceSystem.Oddity - (int)experienceSystem) * (ExperienceSystem)wj.hg.c), wj.hd.Y + wj.he.d);
					bw2.c = wj.hg;
					bw2.Color = adi.a;
					bw2.d = adi.d;
					bw2.g = new Rectangle?(new Rectangle(wj.hd.X + 2 * wj.hg.c, wj.he.d, wj.hg.c, wj.hg.d));
					bw2.Tag = experienceSystem;
					bw2.g(new EventHandler<b25>(this.b));
					bw2.j(new EventHandler<b25>(this.b));
					bw2.c(new EventHandler<b25>(this.a));
					this.y.Add(bw2);
					e4z.f(bw2);
					this.c.aox(bw2);
				}
				goto IL_1613;
			}
		}
		this.k = new avo();
		this.k.Location = new Point(100, 100);
		this.k.Size = new esj(300, 50);
		this.k.a(egg.e);
		this.k.Color = adi.a;
		this.k.Text = dh9.c("NewGame_GameDifficulty");
		this.k.a(cab.a);
		this.c.aox(this.k);
		this.l = new zt();
		this.l.TextLabelOffset = new Point(25, 8);
		this.l.Text = dh9.c("NewGame_GameDifficulty_Easy");
		this.l.Font = egg.e;
		this.l.Size = new esj(225, 35);
		this.l.Location = new Point(30, this.k.Location.Y + 60);
		this.l.HorizontalAlignment = cab.a;
		this.l.Checked = true;
		this.l.c(new EventHandler<b25>(this.z));
		this.l.j(new EventHandler<b25>(this.i));
		this.l.g(new EventHandler<b25>(this.j));
		e4z.f(this.l);
		this.c.aox(this.l);
		this.m = new zt();
		this.m.TextLabelOffset = new Point(25, 8);
		this.m.Text = dh9.c("NewGame_GameDifficulty_Normal");
		this.m.Font = egg.e;
		this.m.Size = new esj(225, 35);
		this.m.Location = new Point(this.l.Location.X + this.l.Size.c + 20, this.l.Location.Y);
		this.m.HorizontalAlignment = cab.a;
		this.m.Checked = false;
		this.m.c(new EventHandler<b25>(this.y));
		this.m.j(new EventHandler<b25>(this.m));
		this.m.g(new EventHandler<b25>(this.n));
		e4z.f(this.m);
		this.c.aox(this.m);
		this.n = new zt();
		this.n.TextLabelOffset = new Point(25, 8);
		this.n.Text = dh9.c("NewGame_GameDifficulty_Hard");
		this.n.Font = egg.e;
		this.n.Size = new esj(225, 35);
		this.n.Location = new Point(30, this.l.Location.Y + 60);
		this.n.HorizontalAlignment = cab.a;
		this.n.c(new EventHandler<b25>(this.x));
		this.n.j(new EventHandler<b25>(this.k));
		this.n.g(new EventHandler<b25>(this.l));
		e4z.f(this.n);
		this.c.aox(this.n);
		this.o = new zt();
		this.o.TextLabelOffset = new Point(25, 8);
		this.o.Text = dh9.c("NewGame_GameDifficulty_DOMINATING");
		this.o.Font = egg.e;
		this.o.Size = new esj(225, 35);
		this.o.Location = new Point(this.n.Location.X + this.n.Size.c + 20, this.n.Location.Y);
		this.o.HorizontalAlignment = cab.a;
		this.o.c(new EventHandler<b25>(this.w));
		this.o.j(new EventHandler<b25>(this.g));
		this.o.g(new EventHandler<b25>(this.h));
		e4z.f(this.o);
		this.c.aox(this.o);
		this.p = new zt();
		this.p.TextLabelOffset = new Point(25, 8);
		this.p.Text = dh9.c("NewGame_GameDifficulty_Custom");
		this.p.Font = egg.e;
		this.p.Size = new esj(225, 35);
		this.p.Location = new Point(30, this.o.Location.Y + 60);
		this.p.HorizontalAlignment = cab.a;
		this.p.c(new EventHandler<b25>(this.v));
		this.p.j(new EventHandler<b25>(this.e));
		this.p.g(new EventHandler<b25>(this.f));
		e4z.f(this.p);
		this.c.aox(this.p);
		cxh cxh3 = new cxh();
		cxh3.Location = new Point(30, this.k.Location.Y + 40);
		cxh3.Size = new esj(this.m.Location.X + this.m.Size.c - this.l.Location.X, 2);
		this.c.aox(cxh3);
		this.q = new avo();
		this.q.Location = new Point(100, 370);
		this.q.Size = new esj(300, 50);
		this.q.a(egg.e);
		this.q.Color = adi.a;
		this.q.Text = dh9.c("NewGame_ExperienceSystem");
		this.q.a(cab.a);
		this.c.aox(this.q);
		this.r = new zt();
		this.r.TextLabelOffset = new Point(25, 8);
		this.r.Text = dh9.c("NewGame_ExperienceSystem_Oddity");
		this.r.Font = egg.e;
		this.r.Size = new esj(225, 35);
		this.r.Location = new Point(30, this.q.Location.Y + 60);
		this.r.HorizontalAlignment = cab.a;
		this.r.Checked = true;
		this.r.c(new EventHandler<b25>(this.u));
		this.r.j(new EventHandler<b25>(this.o));
		this.r.g(new EventHandler<b25>(this.p));
		e4z.f(this.r);
		this.c.aox(this.r);
		this.s = new zt();
		this.s.TextLabelOffset = new Point(25, 8);
		this.s.Text = dh9.c("NewGame_ExperienceSystem_Classic");
		this.s.Font = egg.e;
		this.s.Size = new esj(225, 35);
		this.s.Location = new Point(this.r.Location.X + this.r.Size.c + 20, this.q.Location.Y + 60);
		this.s.HorizontalAlignment = cab.a;
		this.s.c(new EventHandler<b25>(this.t));
		this.s.j(new EventHandler<b25>(this.q));
		this.s.g(new EventHandler<b25>(this.r));
		e4z.f(this.s);
		this.c.aox(this.s);
		cxh cxh4 = new cxh();
		cxh4.Location = new Point(30, this.q.Location.Y + 40);
		cxh4.Size = new esj(this.s.Location.X + this.s.Size.c - this.r.Location.X, 2);
		this.c.aox(cxh4);
		IL_1613:
		this.b.n().Add(this.c);
	}

	// Token: 0x0600C6BB RID: 50875 RVA: 0x0045BB38 File Offset: 0x00459D38
	private void e()
	{
		wj wj = wj.a();
		this.d = new cvh();
		this.d.Enabled = false;
		this.d.Text = dh9.c("NewGame_Tab_Custom");
		this.d.j(new EventHandler<b25>(this.s));
		this.d.g(new EventHandler<b25>(this.s));
		this.b.n().Add(this.d);
		this.ah = 0;
		this.ai = this.aa;
		this.ak = new List<aw9>();
		this.aj = this.d;
		this.an = this.a("encounter_diff", "Encounter Difficulty", 1, 0, 3, 1, 1, true, null, new Func<int, string>(this.b), true);
		this.an.a = true;
		this.an.b = true;
		this.ao = this.a("puzzle_diff", "Puzzle Difficulty", 1, 0, 3, 1, 1, true, null, new Func<int, string>(this.b), true);
		this.ao.a = true;
		this.b(true);
		if (dk2.f())
		{
			this.ap = this.a("max_level", "Max Level", aiy.bm, 1, 50, 1, 5, false, null, null, true);
			this.b(true);
		}
		this.aq = this.a("health_mod_player", "Player Health Mod", 150, 20, 1000, 10, 25, true, null, null, true);
		this.ar = this.a("health_mod_npc", "NPC Health Mod", 100, 20, 1000, 10, 25, true, null, null, true);
		this.@as = this.a("health_mod_boss", "Boss Health Mod", 100, 20, 1000, 10, 25, true, null, null, true);
		this.at = this.a("healing_modifier", "Player Healing Mod", 100, 20, 1000, 10, 25, true, null, null, true);
		this.au = this.a("healing_cooldown", "Player Healing CD", 6, 1, 20, 1, 1, false, null, new Func<int, string>(this.c), true);
		this.b(true);
		this.av = this.a("skill_mod_npc", "NPC Skill Mod", 100, 20, 300, 10, 25, true, null, null, true);
		this.aw = this.a("skill_mod_boss", "Boss Skill Mod", 100, 20, 300, 10, 25, true, null, null, true);
		this.ax = this.a("npc_crit_chance_bonus", "NPC Crit. Chance Bonus", 0, 0, 100, 1, 5, true, null, null, true);
		this.b(true);
		this.ay = this.a("zone_transition_ap_cost", "Zone Transition AP", 25, 0, 60, 5, 10, false, null, null, true);
		this.b(true);
		this.az = this.a("sold_item_value_modifier", "Sold Items Value Mod", 100, 10, 100, 10, 20, true, null, null, true);
		this.a0 = this.a("merchant_purchasing_power", "Merchant Purchasing Power", 100, 10, 1000, 10, 50, true, null, null, true);
		this.a1 = this.a("carry_capacity_mod", "Carry Capacity Mod", 100, 10, 1000, 10, 50, true, null, null, true);
		this.a2 = this.a("item_degradation_rate", "Item Degradation Rate", 100, 10, 1000, 10, 50, true, null, null, true);
		this.d();
		this.g = new dak();
		this.g.Text = dh9.c("Reset") + "...";
		this.g.c(new EventHandler<b25>(this.ab));
		this.g.Visible = this.i;
		c9v.a(this.g, wj);
		if (wj.c())
		{
			this.g.Location = new Point(30, this.d.Size.d - (this.f.Size.d + 25));
		}
		else
		{
			this.g.Location = new Point((int)((float)this.g.Size.c * 0.2f), this.d.Size.d - this.f.Size.d - wj.fv.d);
		}
		e4z.j(this.g);
		this.d.aox(this.g);
	}

	// Token: 0x0600C6BC RID: 50876 RVA: 0x0045BFC0 File Offset: 0x0045A1C0
	private string c(int A_0)
	{
		return l4.a(A_0, false);
	}

	// Token: 0x0600C6BD RID: 50877 RVA: 0x0045BFCC File Offset: 0x0045A1CC
	private string b(int A_0)
	{
		string str = "Rules/Difficulty_";
		GameDifficulty gameDifficulty = (GameDifficulty)A_0;
		return qv.b(str + gameDifficulty.ToString());
	}

	// Token: 0x0600C6BE RID: 50878 RVA: 0x0045BFF8 File Offset: 0x0045A1F8
	private void d()
	{
		if (this.ak != null && this.ak.Count > 0)
		{
			for (int i = this.ak.Count - 1; i >= 0; i--)
			{
				this.aj.aox(this.ak[i]);
			}
		}
	}

	// Token: 0x0600C6BF RID: 50879 RVA: 0x0045C054 File Offset: 0x0045A254
	private oz a(string A_0, string A_1, int A_2, int A_3 = 0, int A_4 = 100, int A_5 = 10, int A_6 = 25, bool A_7 = true, EventHandler<c1> A_8 = null, Func<int, string> A_9 = null, bool A_10 = false)
	{
		c9v.b b = new c9v.b();
		b.b = A_9;
		b.d = A_7;
		string text = qv.b("Rules/CustomDiffOption_Caption_" + A_0);
		if (!string.IsNullOrEmpty(text))
		{
			A_1 = text;
		}
		wj wj = wj.a();
		int num;
		if (wj.c())
		{
			num = 125;
		}
		else
		{
			num = Convert.ToInt32((float)wj.hu * 2.5f);
		}
		b.a = this.a(num);
		b.a.Location = new Point(10, this.z);
		if (b.b != null)
		{
			b.a.Text = b.b(A_2);
		}
		else
		{
			b.a.Text = A_2.ToString() + (b.d ? "%" : "");
		}
		if (wj.c())
		{
			b.c = new c8b();
		}
		else
		{
			b.c = new ebu();
		}
		b.c.b(A_3);
		b.c.a(A_4);
		b.c.e(A_2);
		b.c.b = true;
		b.c.Tag = A_0;
		if (wj.c())
		{
			b.c.Size = new esj(this.i() - 50, 27);
		}
		else
		{
			b.c.Size = new esj(this.i() - 50, wj.bq.d);
		}
		if (A_10)
		{
			b.c.Size = new esj((int)((double)b.c.Size.c * 2.5), b.c.Size.d);
		}
		b.c.Size = new esj(this.d.Size.c - num - 50 - this.k(), b.c.Size.d);
		b.c.c(A_5);
		b.c.d(A_6);
		if (A_8 != null)
		{
			b.c.f(A_8);
		}
		if (b.b != null)
		{
			b.c.f(new EventHandler<c1>(b.a));
		}
		else
		{
			b.c.f(new EventHandler<c1>(b.b));
		}
		this.a(A_0, A_1, b.c, b.a, false, false, 0, true);
		return b.c;
	}

	// Token: 0x0600C6C0 RID: 50880 RVA: 0x0045C2FC File Offset: 0x0045A4FC
	private d7w a(int A_0)
	{
		d7w d7w = new d7w();
		d7w.a(this.j());
		d7w.Color = adi.a;
		d7w.Size = new esj(A_0, this.l());
		return d7w;
	}

	// Token: 0x0600C6C1 RID: 50881 RVA: 0x0045C338 File Offset: 0x0045A538
	private void a(euz A_0)
	{
		if (A_0 != null)
		{
			A_0.j(new EventHandler<b25>(this.ad));
			A_0.l(new EventHandler<b25>(this.ae));
			this.am.Add(A_0);
		}
	}

	// Token: 0x0600C6C2 RID: 50882 RVA: 0x0045C370 File Offset: 0x0045A570
	private void ae(object A_0, b25 A_1)
	{
		this.al.b();
	}

	// Token: 0x0600C6C3 RID: 50883 RVA: 0x0045C380 File Offset: 0x0045A580
	private void ad(object A_0, b25 A_1)
	{
		this.al.b();
	}

	// Token: 0x0600C6C4 RID: 50884 RVA: 0x0045C390 File Offset: 0x0045A590
	private void b(bool A_0 = false)
	{
		cxh cxh = new cxh();
		cxh.Size = new esj(this.d.Size.c - 50, 2);
		cxh.Location = new Point(this.ac + this.ah * (this.ac + this.ae), this.ai + this.ad);
		this.aj.aox(cxh);
		this.ai += 2 + this.ad * 3;
		if (wj.a().c())
		{
			this.ai -= 10;
		}
	}

	// Token: 0x0600C6C5 RID: 50885 RVA: 0x0045C438 File Offset: 0x0045A638
	private void a(string A_0, string A_1, euz A_2, euz A_3 = null, bool A_4 = false, bool A_5 = false, int A_6 = 0, bool A_7 = true)
	{
		d7w d7w;
		if (A_5)
		{
			d7w = this.a((int)((double)this.k() * 2.5) + A_6 - this.af);
		}
		else
		{
			d7w = this.a(this.k() + A_6 - this.af);
		}
		d7w.a(cab.c);
		d7w.Text = A_1;
		if (this.ai + d7w.Size.d > this.aj.Size.d - this.ab)
		{
			this.c();
		}
		d7w.Location = new Point(this.ac + this.ah * this.ae, this.ai + this.z);
		this.aj.aox(d7w);
		if (A_5)
		{
			if (A_4)
			{
				A_2.Location = new Point(A_2.Location.X + d7w.Location.X + (int)((double)this.k() * 2.5) + (this.i() - A_2.Size.c) / 2, A_2.Location.Y + this.ai);
			}
			else
			{
				A_2.Location = new Point(A_2.Location.X + d7w.Location.X + (int)((double)this.k() * 2.5), A_2.Location.Y + this.ai);
			}
		}
		else if (A_4)
		{
			A_2.Location = new Point(A_2.Location.X + d7w.Location.X + this.k() + (this.i() - A_2.Size.c) / 2, A_2.Location.Y + this.ai);
		}
		else
		{
			A_2.Location = new Point(A_2.Location.X + d7w.Location.X + this.k() + A_6, A_2.Location.Y + this.ai);
		}
		wj wj = wj.a();
		if (!wj.c())
		{
			int num = (A_2.Size.d - d7w.Size.d) / 2;
			A_2.Location = new Point(A_2.Location.X, A_2.Location.Y - num);
		}
		if (A_2 is aw9)
		{
			this.ak.Add((aw9)A_2);
		}
		else
		{
			this.aj.aox(A_2);
		}
		if (wj.c())
		{
			this.ai = A_2.Location.Y + A_2.Size.d + this.ad - 10;
		}
		else
		{
			this.ai = A_2.Location.Y + A_2.Size.d + this.ad;
		}
		if (A_3 != null)
		{
			A_3.Location = new Point(A_3.Location.X + A_2.Location.X + A_2.Size.c, A_3.Location.Y + A_2.Location.Y);
			if (!wj.c())
			{
				int num2 = (A_2.Size.d - A_3.Size.d) / 2;
				A_3.Location = new Point(A_3.Location.X, A_3.Location.Y + num2);
			}
			this.aj.aox(A_3);
		}
		if (A_7)
		{
			this.a(d7w);
			d7w.Tag = A_2;
			this.a(A_2);
			if (A_3 != null)
			{
				A_3.Tag = A_2;
				this.a(A_3);
			}
		}
	}

	// Token: 0x0600C6C6 RID: 50886 RVA: 0x0045C810 File Offset: 0x0045AA10
	private void c()
	{
		this.ai = this.aa;
		this.ah++;
	}

	// Token: 0x0600C6C7 RID: 50887 RVA: 0x0045C830 File Offset: 0x0045AA30
	private void b()
	{
		if (this.w != this.v)
		{
			this.v = this.w;
			this.t.Text = qv.b("Rules/" + this.v + "_Caption");
			this.u.Text = qv.b("Rules/" + this.v);
		}
	}

	// Token: 0x0600C6C8 RID: 50888 RVA: 0x0045C8A4 File Offset: 0x0045AAA4
	private void ac(object A_0, b25 A_1)
	{
		base.a(cku.b);
		base.z();
	}

	// Token: 0x0600C6C9 RID: 50889 RVA: 0x0045C8B4 File Offset: 0x0045AAB4
	private void ab(object A_0, b25 A_1)
	{
		bnr.a(new esj(500, 300), this, dh9.c("Reset"), qv.b("Rules/ResetDiff"), "reset_0", "cancel", new Color?(adi.m), null, 0, new cpk[]
		{
			new cpk(GameDifficulty.Easy.ToString(), qv.b("Rules/Difficulty_" + GameDifficulty.Easy.ToString()), true),
			new cpk(GameDifficulty.Normal.ToString(), qv.b("Rules/Difficulty_" + GameDifficulty.Normal.ToString()), true),
			new cpk(GameDifficulty.Hard.ToString(), qv.b("Rules/Difficulty_" + GameDifficulty.Hard.ToString()), true),
			new cpk(GameDifficulty.Dominating.ToString(), qv.b("Rules/Difficulty_" + GameDifficulty.Dominating.ToString()), true),
			new cpk("cancel", dh9.c("Cancel"), true)
		}, this, this);
	}

	// Token: 0x0600C6CA RID: 50890 RVA: 0x0045CA14 File Offset: 0x0045AC14
	private void aa(object A_0, b25 A_1)
	{
		this.a(false);
	}

	// Token: 0x0600C6CB RID: 50891 RVA: 0x0045CA20 File Offset: 0x0045AC20
	private void a(bool A_0)
	{
		wj wj = wj.a();
		GameDifficulty gameDifficulty = GameDifficulty.Normal;
		ExperienceSystem experienceSystem = ExperienceSystem.Oddity;
		if (wj.c())
		{
			if (this.l.Checked)
			{
				gameDifficulty = GameDifficulty.Easy;
			}
			else if (this.m.Checked)
			{
				gameDifficulty = GameDifficulty.Normal;
			}
			else if (this.n.Checked)
			{
				gameDifficulty = GameDifficulty.Hard;
			}
			else if (this.o.Checked)
			{
				gameDifficulty = GameDifficulty.Dominating;
			}
			else
			{
				gameDifficulty = GameDifficulty.Custom;
			}
			experienceSystem = (this.s.Checked ? ExperienceSystem.Classic : ExperienceSystem.Oddity);
		}
		else
		{
			foreach (bw9 bw in this.x)
			{
				if (bw.Checked)
				{
					gameDifficulty = (GameDifficulty)bw.Tag;
					break;
				}
			}
			foreach (bw9 bw2 in this.y)
			{
				if (bw2.Checked)
				{
					experienceSystem = (ExperienceSystem)bw2.Tag;
					break;
				}
			}
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		serviceOrThrow.aqu().a(gameDifficulty);
		serviceOrThrow.aqu().v().a(experienceSystem);
		if (gameDifficulty == GameDifficulty.Custom)
		{
			GameDifficultySettings gameDifficultySettings = this.a();
			if (!A_0)
			{
				int? maxLevel = gameDifficultySettings.MaxLevel;
				int bm = aiy.bm;
				if ((maxLevel.GetValueOrDefault() > bm & maxLevel != null) && experienceSystem == ExperienceSystem.Oddity)
				{
					bnr.a(new esj(700, 300), this, dh9.c("Warning"), qv.b("Rules/MaxLevelWarning"), "OK", "cancel", new Color?(adi.m), null, 0, new cpk[]
					{
						new cpk("OK", dh9.c("OK"), true),
						new cpk("cancel", dh9.c("Cancel"), true)
					}, this, this);
					return;
				}
			}
			serviceOrThrow.aqu().r = gameDifficultySettings;
		}
		base.a(cku.a);
		base.z();
	}

	// Token: 0x0600C6CC RID: 50892 RVA: 0x0045CC8C File Offset: 0x0045AE8C
	private GameDifficultySettings a()
	{
		GameDifficultySettings gameDifficultySettings = new GameDifficultySettings();
		gameDifficultySettings.EncounterDifficulty = (GameDifficulty)this.an.l();
		gameDifficultySettings.PuzzleDifficulty = (GameDifficulty)this.ao.l();
		gameDifficultySettings.PlayerHealthModifier = Convert.ToSingle(Math.Round((double)((float)this.aq.l() * 0.01f), 2));
		gameDifficultySettings.NpcHealthModifier = Convert.ToSingle(Math.Round((double)((float)this.ar.l() * 0.01f), 2));
		gameDifficultySettings.NpcBossHealthModifier = Convert.ToSingle(Math.Round((double)((float)this.@as.l() * 0.01f), 2));
		gameDifficultySettings.HealingModifier = Convert.ToSingle(Math.Round((double)((float)this.at.l() * 0.01f), 2));
		gameDifficultySettings.HealingCooldown = this.au.l();
		gameDifficultySettings.NpcSkillModifier = Convert.ToSingle(Math.Round((double)((float)this.av.l() * 0.01f), 2));
		gameDifficultySettings.NpcBossSkillModifier = Convert.ToSingle(Math.Round((double)((float)this.aw.l() * 0.01f), 2));
		gameDifficultySettings.NpcCritChanceBonus = Convert.ToSingle(Math.Round((double)((float)this.ax.l() * 0.01f), 2));
		gameDifficultySettings.SoldItemValueModifier = Convert.ToSingle(Math.Round((double)((float)this.az.l() * 0.01f), 2));
		gameDifficultySettings.MerchantPurchasingPower = Convert.ToSingle(Math.Round((double)((float)this.a0.l() * 0.01f), 2));
		gameDifficultySettings.CarryCapacityMod = Convert.ToSingle(Math.Round((double)((float)this.a1.l() * 0.01f), 2));
		gameDifficultySettings.ItemDegradationRate = Convert.ToSingle(Math.Round((double)((float)this.a2.l() * 0.01f), 2));
		gameDifficultySettings.ZoneTransitionApCost = this.ay.l();
		if (this.ap != null)
		{
			gameDifficultySettings.MaxLevel = new int?(this.ap.l());
		}
		return gameDifficultySettings;
	}

	// Token: 0x0600C6CD RID: 50893 RVA: 0x0045CE94 File Offset: 0x0045B094
	private void a(GameDifficultySettings A_0)
	{
		if (A_0 == null)
		{
			return;
		}
		this.an.e((int)A_0.EncounterDifficulty);
		this.ao.e((int)A_0.PuzzleDifficulty);
		this.aq.e(Convert.ToInt32(A_0.PlayerHealthModifier * 100f));
		this.ar.e(Convert.ToInt32(A_0.NpcHealthModifier * 100f));
		this.@as.e(Convert.ToInt32(A_0.NpcBossHealthModifier * 100f));
		this.at.e(Convert.ToInt32(A_0.HealingModifier * 100f));
		this.au.e(A_0.HealingCooldown);
		this.av.e(Convert.ToInt32(A_0.NpcSkillModifier * 100f));
		this.aw.e(Convert.ToInt32(A_0.NpcBossSkillModifier * 100f));
		this.ax.e(Convert.ToInt32(A_0.NpcCritChanceBonus * 100f));
		this.az.e(Convert.ToInt32(A_0.SoldItemValueModifier * 100f));
		this.a0.e(Convert.ToInt32(A_0.MerchantPurchasingPower * 100f));
		this.a1.e(Convert.ToInt32(A_0.CarryCapacityMod * 100f));
		this.a2.e(Convert.ToInt32(A_0.ItemDegradationRate * 100f));
		this.ay.e(A_0.ZoneTransitionApCost);
		if (this.ap != null)
		{
			this.ap.e(A_0.MaxLevel ?? aiy.bm);
		}
	}

	// Token: 0x0600C6CE RID: 50894 RVA: 0x0045D05C File Offset: 0x0045B25C
	protected override void g6(object A_0, ane A_1)
	{
		base.vx(A_0, A_1);
		if (A_1.a == Keys.Escape)
		{
			e4z.j();
			this.ac(this, new b25());
		}
	}

	// Token: 0x0600C6CF RID: 50895 RVA: 0x0045D088 File Offset: 0x0045B288
	private void z(object A_0, b25 A_1)
	{
		this.m.Checked = false;
		this.l.Checked = true;
		this.n.Checked = false;
		this.o.Checked = false;
		this.d.Enabled = false;
	}

	// Token: 0x0600C6D0 RID: 50896 RVA: 0x0045D0D4 File Offset: 0x0045B2D4
	private void y(object A_0, b25 A_1)
	{
		this.m.Checked = true;
		this.l.Checked = false;
		this.n.Checked = false;
		this.o.Checked = false;
		this.p.Checked = false;
		this.d.Enabled = false;
	}

	// Token: 0x0600C6D1 RID: 50897 RVA: 0x0045D12C File Offset: 0x0045B32C
	private void x(object A_0, b25 A_1)
	{
		this.m.Checked = false;
		this.l.Checked = false;
		this.n.Checked = true;
		this.o.Checked = false;
		this.p.Checked = false;
		this.d.Enabled = false;
	}

	// Token: 0x0600C6D2 RID: 50898 RVA: 0x0045D184 File Offset: 0x0045B384
	private void w(object A_0, b25 A_1)
	{
		this.m.Checked = false;
		this.l.Checked = false;
		this.n.Checked = false;
		this.o.Checked = true;
		this.p.Checked = false;
		this.d.Enabled = false;
	}

	// Token: 0x0600C6D3 RID: 50899 RVA: 0x0045D1DC File Offset: 0x0045B3DC
	private void v(object A_0, b25 A_1)
	{
		this.m.Checked = false;
		this.l.Checked = false;
		this.n.Checked = false;
		this.o.Checked = false;
		this.p.Checked = true;
		this.d.Enabled = true;
		this.b.e(this.d);
	}

	// Token: 0x0600C6D4 RID: 50900 RVA: 0x0045D244 File Offset: 0x0045B444
	private void u(object A_0, b25 A_1)
	{
		this.r.Checked = true;
		this.s.Checked = false;
	}

	// Token: 0x0600C6D5 RID: 50901 RVA: 0x0045D260 File Offset: 0x0045B460
	private void t(object A_0, b25 A_1)
	{
		this.r.Checked = false;
		this.s.Checked = true;
	}

	// Token: 0x0600C6D6 RID: 50902 RVA: 0x0045D27C File Offset: 0x0045B47C
	private void s(object A_0, b25 A_1)
	{
		this.w = "gameRules";
		this.b();
	}

	// Token: 0x0600C6D7 RID: 50903 RVA: 0x0045D290 File Offset: 0x0045B490
	private void r(object A_0, b25 A_1)
	{
		this.w = "classicXp";
		this.b();
	}

	// Token: 0x0600C6D8 RID: 50904 RVA: 0x0045D2A4 File Offset: 0x0045B4A4
	private void q(object A_0, b25 A_1)
	{
		this.w = "classicXp";
		this.b();
	}

	// Token: 0x0600C6D9 RID: 50905 RVA: 0x0045D2B8 File Offset: 0x0045B4B8
	private void p(object A_0, b25 A_1)
	{
		this.w = "oddityXp";
		this.b();
	}

	// Token: 0x0600C6DA RID: 50906 RVA: 0x0045D2CC File Offset: 0x0045B4CC
	private void o(object A_0, b25 A_1)
	{
		this.w = "oddityXp";
		this.b();
	}

	// Token: 0x0600C6DB RID: 50907 RVA: 0x0045D2E0 File Offset: 0x0045B4E0
	private void n(object A_0, b25 A_1)
	{
		this.w = "normalDifficulty";
		this.b();
	}

	// Token: 0x0600C6DC RID: 50908 RVA: 0x0045D2F4 File Offset: 0x0045B4F4
	private void m(object A_0, b25 A_1)
	{
		this.w = "normalDifficulty";
		this.b();
	}

	// Token: 0x0600C6DD RID: 50909 RVA: 0x0045D308 File Offset: 0x0045B508
	private void l(object A_0, b25 A_1)
	{
		this.w = "hardDifficulty";
		this.b();
	}

	// Token: 0x0600C6DE RID: 50910 RVA: 0x0045D31C File Offset: 0x0045B51C
	private void k(object A_0, b25 A_1)
	{
		this.w = "hardDifficulty";
		this.b();
	}

	// Token: 0x0600C6DF RID: 50911 RVA: 0x0045D330 File Offset: 0x0045B530
	private void j(object A_0, b25 A_1)
	{
		this.w = "easyDifficulty";
		this.b();
	}

	// Token: 0x0600C6E0 RID: 50912 RVA: 0x0045D344 File Offset: 0x0045B544
	private void i(object A_0, b25 A_1)
	{
		this.w = "easyDifficulty";
		this.b();
	}

	// Token: 0x0600C6E1 RID: 50913 RVA: 0x0045D358 File Offset: 0x0045B558
	private void h(object A_0, b25 A_1)
	{
		this.w = "dominatingDifficulty";
		this.b();
	}

	// Token: 0x0600C6E2 RID: 50914 RVA: 0x0045D36C File Offset: 0x0045B56C
	private void g(object A_0, b25 A_1)
	{
		this.w = "dominatingDifficulty";
		this.b();
	}

	// Token: 0x0600C6E3 RID: 50915 RVA: 0x0045D380 File Offset: 0x0045B580
	private void f(object A_0, b25 A_1)
	{
		this.w = "customDifficulty";
		this.b();
	}

	// Token: 0x0600C6E4 RID: 50916 RVA: 0x0045D394 File Offset: 0x0045B594
	private void e(object A_0, b25 A_1)
	{
		this.w = "customDifficulty";
		this.b();
	}

	// Token: 0x0600C6E5 RID: 50917 RVA: 0x0045D3A8 File Offset: 0x0045B5A8
	private void d(object A_0, b25 A_1)
	{
		euz euz = A_0 as euz;
		if (euz != null)
		{
			object obj = euz.Tag;
			if (obj is GameDifficulty)
			{
				this.w = ((GameDifficulty)obj).ToString().ToLowerInvariant() + "Difficulty";
				this.b();
			}
		}
	}

	// Token: 0x0600C6E6 RID: 50918 RVA: 0x0045D404 File Offset: 0x0045B604
	private void c(object A_0, b25 A_1)
	{
		foreach (bw9 bw in this.x)
		{
			bw.Checked = (bw == A_0);
		}
		euz euz = this.d;
		bw9 bw2 = Enumerable.FirstOrDefault<bw9>(Enumerable.Where<bw9>(this.x, new Func<bw9, bool>(c9v.a.a.a)));
		euz.Enabled = (bw2 != null && bw2.Checked);
		if (this.d.Enabled)
		{
			this.b.e(this.d);
		}
	}

	// Token: 0x0600C6E7 RID: 50919 RVA: 0x0045D4D0 File Offset: 0x0045B6D0
	private void b(object A_0, b25 A_1)
	{
		euz euz = A_0 as euz;
		if (euz != null)
		{
			object obj = euz.Tag;
			if (obj is ExperienceSystem)
			{
				this.w = ((ExperienceSystem)obj).ToString().ToLowerInvariant() + "Xp";
				this.b();
			}
		}
	}

	// Token: 0x0600C6E8 RID: 50920 RVA: 0x0045D52C File Offset: 0x0045B72C
	private void a(object A_0, b25 A_1)
	{
		foreach (bw9 bw in this.y)
		{
			bw.Checked = (bw == A_0);
		}
	}

	// Token: 0x0600C6E9 RID: 50921 RVA: 0x0045D588 File Offset: 0x0045B788
	public ecs yf(euz A_0)
	{
		foreach (euz euz in this.am)
		{
			if (euz.IsMousedOver && euz.Enabled)
			{
				euz euz2 = euz;
				if (euz2 != null)
				{
					euz euz3 = euz2.Tag as euz;
					if (euz3 != null)
					{
						euz2 = euz3;
					}
					string str = "Rules/CustomDiffOption_";
					string str2;
					if (euz2 == null)
					{
						str2 = null;
					}
					else
					{
						object obj = euz2.Tag;
						str2 = ((obj != null) ? obj.ToString() : null);
					}
					string text = qv.b(str + str2);
					if (!string.IsNullOrEmpty(text))
					{
						return new ecs
						{
							a = 
							{
								new dl6(new List<bph>
								{
									new bph(new d22(cq4.c(), adi.c), text, null)
								})
							}
						};
					}
				}
			}
		}
		return null;
	}

	// Token: 0x0600C6EA RID: 50922 RVA: 0x0045D694 File Offset: 0x0045B894
	public override void iv(e6d A_0, cp9 A_1)
	{
		ds6.a();
		this.al.a(A_0);
		base.iv(A_0, A_1);
		ds6.a(A_1, A_0);
	}

	// Token: 0x0600C6EB RID: 50923 RVA: 0x0045D6B8 File Offset: 0x0045B8B8
	public void g0(string A_0)
	{
		if (A_0 == "OK")
		{
			this.a(true);
			return;
		}
		GameDifficulty gameDifficulty;
		if (Enum.TryParse<GameDifficulty>(A_0, out gameDifficulty))
		{
			try
			{
				this.a(aiy.cp[(int)gameDifficulty]);
			}
			catch
			{
			}
		}
	}

	// Token: 0x0400492F RID: 18735
	private new bg1 a;

	// Token: 0x04004930 RID: 18736
	private new dpg b;

	// Token: 0x04004931 RID: 18737
	private new cvh c;

	// Token: 0x04004932 RID: 18738
	private new cvh d;

	// Token: 0x04004933 RID: 18739
	private new dak e;

	// Token: 0x04004934 RID: 18740
	private new dak f;

	// Token: 0x04004935 RID: 18741
	private new dak g;

	// Token: 0x04004936 RID: 18742
	private bool h;

	// Token: 0x04004937 RID: 18743
	private bool i;

	// Token: 0x04004938 RID: 18744
	private new au6 j;

	// Token: 0x04004939 RID: 18745
	private new avo k;

	// Token: 0x0400493A RID: 18746
	private new zt l;

	// Token: 0x0400493B RID: 18747
	private new zt m;

	// Token: 0x0400493C RID: 18748
	private zt n;

	// Token: 0x0400493D RID: 18749
	private zt o;

	// Token: 0x0400493E RID: 18750
	private zt p;

	// Token: 0x0400493F RID: 18751
	private avo q;

	// Token: 0x04004940 RID: 18752
	private zt r;

	// Token: 0x04004941 RID: 18753
	private zt s;

	// Token: 0x04004942 RID: 18754
	private avo t;

	// Token: 0x04004943 RID: 18755
	private avo u;

	// Token: 0x04004944 RID: 18756
	private string v;

	// Token: 0x04004945 RID: 18757
	private string w = "gameRules";

	// Token: 0x04004946 RID: 18758
	private new List<bw9> x = new List<bw9>();

	// Token: 0x04004947 RID: 18759
	private List<bw9> y = new List<bw9>();

	// Token: 0x04004948 RID: 18760
	private new int z;

	// Token: 0x04004949 RID: 18761
	private int aa = 20;

	// Token: 0x0400494A RID: 18762
	private int ab = 20;

	// Token: 0x0400494B RID: 18763
	private int ac = 20;

	// Token: 0x0400494C RID: 18764
	private int ad = 8;

	// Token: 0x0400494D RID: 18765
	private int ae = 475;

	// Token: 0x0400494E RID: 18766
	private new int af = 15;

	// Token: 0x0400494F RID: 18767
	private int ag = 25;

	// Token: 0x04004950 RID: 18768
	private int ah;

	// Token: 0x04004951 RID: 18769
	private int ai;

	// Token: 0x04004952 RID: 18770
	private cvh aj;

	// Token: 0x04004953 RID: 18771
	private List<aw9> ak;

	// Token: 0x04004954 RID: 18772
	private dsy al;

	// Token: 0x04004955 RID: 18773
	private new List<euz> am = new List<euz>();

	// Token: 0x04004956 RID: 18774
	private oz an;

	// Token: 0x04004957 RID: 18775
	private new oz ao;

	// Token: 0x04004958 RID: 18776
	private new oz ap;

	// Token: 0x04004959 RID: 18777
	private oz aq;

	// Token: 0x0400495A RID: 18778
	private oz ar;

	// Token: 0x0400495B RID: 18779
	private oz @as;

	// Token: 0x0400495C RID: 18780
	private new oz at;

	// Token: 0x0400495D RID: 18781
	private oz au;

	// Token: 0x0400495E RID: 18782
	private oz av;

	// Token: 0x0400495F RID: 18783
	private oz aw;

	// Token: 0x04004960 RID: 18784
	private oz ax;

	// Token: 0x04004961 RID: 18785
	private oz ay;

	// Token: 0x04004962 RID: 18786
	private oz az;

	// Token: 0x04004963 RID: 18787
	private oz a0;

	// Token: 0x04004964 RID: 18788
	private oz a1;

	// Token: 0x04004965 RID: 18789
	private oz a2;

	// Token: 0x02002083 RID: 8323
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600C6EE RID: 50926 RVA: 0x0045D72C File Offset: 0x0045B92C
		internal bool a(bw9 A_0)
		{
			object obj = A_0.Tag;
			if (obj is GameDifficulty)
			{
				GameDifficulty gameDifficulty = (GameDifficulty)obj;
				return gameDifficulty == GameDifficulty.Custom;
			}
			return false;
		}

		// Token: 0x04004966 RID: 18790
		public static readonly c9v.a a = new c9v.a();

		// Token: 0x04004967 RID: 18791
		public static Func<bw9, bool> b;
	}

	// Token: 0x02002084 RID: 8324
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x0600C6F0 RID: 50928 RVA: 0x0045D760 File Offset: 0x0045B960
		internal void a(object A_0, c1 A_1)
		{
			this.a.Text = this.b(this.c.l());
		}

		// Token: 0x0600C6F1 RID: 50929 RVA: 0x0045D784 File Offset: 0x0045B984
		internal void b(object A_0, c1 A_1)
		{
			this.a.Text = this.c.l().ToString() + (this.d ? "%" : "");
		}

		// Token: 0x04004968 RID: 18792
		public d7w a;

		// Token: 0x04004969 RID: 18793
		public Func<int, string> b;

		// Token: 0x0400496A RID: 18794
		public oz c;

		// Token: 0x0400496B RID: 18795
		public bool d;
	}
}
