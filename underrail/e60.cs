using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TimelapseVertigo.Common.Settings;

// Token: 0x0200206C RID: 8300
public sealed class e60 : euz, amj
{
	// Token: 0x0600C5F8 RID: 50680 RVA: 0x00453024 File Offset: 0x00451224
	public cao d()
	{
		return this.j;
	}

	// Token: 0x0600C5F9 RID: 50681 RVA: 0x0045302C File Offset: 0x0045122C
	public cao i()
	{
		return this.k;
	}

	// Token: 0x0600C5FA RID: 50682 RVA: 0x00453034 File Offset: 0x00451234
	public cao e()
	{
		return this.p;
	}

	// Token: 0x0600C5FB RID: 50683 RVA: 0x0045303C File Offset: 0x0045123C
	public cao c()
	{
		return this.n;
	}

	// Token: 0x0600C5FC RID: 50684 RVA: 0x00453044 File Offset: 0x00451244
	public cao j()
	{
		return this.h;
	}

	// Token: 0x0600C5FD RID: 50685 RVA: 0x0045304C File Offset: 0x0045124C
	public cao h()
	{
		return this.i;
	}

	// Token: 0x0600C5FE RID: 50686 RVA: 0x00453054 File Offset: 0x00451254
	public cao f()
	{
		return this.l;
	}

	// Token: 0x0600C5FF RID: 50687 RVA: 0x0045305C File Offset: 0x0045125C
	public cao l()
	{
		return this.m;
	}

	// Token: 0x0600C600 RID: 50688 RVA: 0x00453064 File Offset: 0x00451264
	public cao g()
	{
		return this.q;
	}

	// Token: 0x0600C601 RID: 50689 RVA: 0x0045306C File Offset: 0x0045126C
	public cao k()
	{
		return this.o;
	}

	// Token: 0x0600C602 RID: 50690 RVA: 0x00453074 File Offset: 0x00451274
	public override bool et()
	{
		if (!base.IsMousedOver)
		{
			return Enumerable.Any<euz>(base.Controls, new Func<euz, bool>(e60.a.a.a));
		}
		return true;
	}

	// Token: 0x0600C603 RID: 50691 RVA: 0x004530B4 File Offset: 0x004512B4
	public e60()
	{
		this.d = new dsy(this, this, esj.a(), 150, null, null, 3000, false, false);
		this.b();
		this.a();
	}

	// Token: 0x0600C604 RID: 50692 RVA: 0x00453110 File Offset: 0x00451310
	public override void ag5(e6d A_0)
	{
		wj wj = wj.a();
		this.b();
		base.ag5(A_0);
		cnk cnk = ces.b();
		if (this.k != null)
		{
			if (cnk.aqu() != null && cnk.aqu().v() != null)
			{
				this.k.Enabled = (cnk.aqu().v().PsiAbilities.a() > 0);
			}
			else
			{
				this.k.Enabled = false;
			}
		}
		if (this.l != null)
		{
			if (cnk.aqu() != null && cnk.aqu().v() != null && cnk.aqu().v().b(d8o.t))
			{
				this.l.Enabled = false;
			}
			else
			{
				this.l.Enabled = true;
			}
		}
		if ((this.f += A_0.a().ElapsedGameTime.TotalMilliseconds) > 500.0)
		{
			this.f = 0.0;
			this.g = !this.g;
			bool flag = false;
			if (cnk.aqu() != null)
			{
				flag = !cnk.aqu().r().GetPrimitivePropertyValue<bool>("sys_readHelp", new bool?(false)).Value;
				int num = cnk.aqu().t().d();
				if (wj.d == UiSize.Classic)
				{
					if (num > 0)
					{
						((bi)this.n).a(new int?(num));
					}
					else
					{
						((bi)this.n).a(null);
					}
				}
				else
				{
					if (this.g)
					{
						((cep)this.n).f = Color.White;
					}
					else
					{
						((cep)this.n).f = adi.c;
					}
					if (num > 0)
					{
						((cep)this.n).d = num.ToString();
					}
					else
					{
						((cep)this.n).d = null;
					}
				}
			}
			string a_;
			if (this.g && flag)
			{
				a_ = "HelpUnseen";
			}
			else
			{
				a_ = "Help";
			}
			if (wj.d == UiSize.Classic)
			{
				((bi)this.q).a(this.b(a_));
				((bi)this.q).b(this.a(a_));
				((bi)this.q).c(this.a(a_));
			}
		}
	}

	// Token: 0x0600C605 RID: 50693 RVA: 0x004533BC File Offset: 0x004515BC
	public override void iv(e6d A_0, cp9 A_1)
	{
		wj wj = wj.a();
		if (wj.c())
		{
			Texture2D resource = A_1.a.GetResource<Texture2D>(bo1.ax, null);
			if (resource != null)
			{
				A_1.b().w4(resource, base.at().b(), Color.White * 0.6f);
			}
		}
		else
		{
			Point point = base.at();
			Texture2D resource2 = A_1.a.GetResource<Texture2D>(wj.f, null);
			Rectangle rectangle = new Rectangle(point.X, point.Y, base.Size.c, base.Size.d);
			rectangle.Height += wj.g - rectangle.Height % wj.g;
			c4o.b(A_1, resource2, wj.dd, Point.Zero, rectangle, Color.White * 0.6f, true, new Point?(wj.dc));
		}
		this.d.a(A_0);
		base.iv(A_0, A_1);
	}

	// Token: 0x0600C606 RID: 50694 RVA: 0x004534D8 File Offset: 0x004516D8
	public ecs yf(euz A_0)
	{
		foreach (euz euz in base.Controls)
		{
			if (euz.IsMousedOver && euz.Enabled)
			{
				ecs ecs = new ecs();
				string text = null;
				Hotkey a_;
				if (this.e.TryGetValue(euz, out a_))
				{
					text = d1o.b(a_).ToUpperInvariant();
				}
				if (!string.IsNullOrEmpty(text))
				{
					ecs.a.Add(new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), adi.c), euz.Text + " (", null),
						new bph(new d22(cq4.c(), Color.White), text, null),
						new bph(new d22(cq4.c(), adi.c), ")", null)
					}));
				}
				else
				{
					ecs.a.Add(new dl6(new List<bph>
					{
						new bph(new d22(cq4.c(), adi.c), euz.Text, null)
					}));
				}
				ecs.a.Add(new dl6(new List<bph>
				{
					new bph(new d22(cq4.c(), Color.White), null, null)
				}));
				ecs.a.Add(new dl6(new List<bph>
				{
					new bph(new d22(cq4.c(), Color.LightGray), (euz.Tag != null) ? euz.Tag.ToString() : "", null)
				}));
				return ecs;
			}
		}
		return null;
	}

	// Token: 0x0600C607 RID: 50695 RVA: 0x004536C4 File Offset: 0x004518C4
	private void b()
	{
		if (this.d != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			int a_;
			if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Huge)
			{
				a_ = 450;
			}
			else if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.ExtraLarge)
			{
				a_ = 325;
			}
			else if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Large)
			{
				a_ = 250;
			}
			else
			{
				a_ = 150;
			}
			this.d.a(a_);
		}
	}

	// Token: 0x0600C608 RID: 50696 RVA: 0x00453758 File Offset: 0x00451958
	private void a()
	{
		wj wj = wj.a();
		this.h = this.a(0, "CharacterSheet", dh9.c("SystemBar_CharacterSheet"), Hotkey.CharacterSheet, dh9.c("SystemBar_CharacterSheet_Tooltip"), false, null);
		this.i = this.a(1, "CharacterOverview", dh9.c("SystemBar_CombatStats"), Hotkey.CombatStatsOverview, dh9.c("SystemBar_CombatStats_Tooltip"), false, null);
		this.j = this.a(2, "Inventory", dh9.c("SystemBar_Inventory"), Hotkey.Inventory, dh9.c("SystemBar_Inventory_Tooltip"), false, null);
		if (dm9.f)
		{
			this.k = this.a(10, "Psi", dh9.c("SystemBar_Psi"), Hotkey.Psi, dh9.c("SystemBar_Psi_Tooltip"), true, null);
			cnk cnk = ces.a();
			if (cnk != null && cnk.aqu() != null && cnk.aqu().v() != null)
			{
				this.k.Enabled = (cnk.aqu().v().PsiAbilities.a() > 0);
			}
		}
		this.l = this.a(3, "Crafting", dh9.c("SystemBar_Crafting"), Hotkey.CraftingWindow, dh9.c("SystemBar_Crafting_Tooltip"), true, null);
		this.n = this.a(4, "Notes", dh9.c("SystemBar_Notes"), Hotkey.Notes, dh9.c("SystemBar_Notes_Tooltip"), false, new Color?(Color.Orange));
		this.m = this.a(9, "Oddities", dh9.c("SystemBar_Oddities"), Hotkey.OdditiesWindow, dh9.c("SystemBar_Oddities_Tooltip"), false, null);
		this.o = this.a(7, "Map", dh9.c("SystemBar_GlobalMap"), Hotkey.GlobalMapWindow, dh9.c("SystemBar_GlobalMap_Tooltip"), false, null);
		this.q = this.a(5, "Help", dh9.c("SystemBar_Help"), Hotkey.HelpScreen, dh9.c("SystemBar_Help_Tooltip"), false, null);
		this.p = this.a(8, "Menu", dh9.c("SystemBar_Menu"), Hotkey.Escape, dh9.c("SystemBar_Menu_Tooltip"), false, null);
		if (wj.d == UiSize.Classic)
		{
			base.Size = new esj(20 + this.c * (bj8.a.c + 2), bj8.a.c + 8);
			return;
		}
		base.Size = new esj(this.p.Location.X + this.p.Size.c + 2 * wj.db, this.p.Location.Y + this.p.Size.d + 2 * wj.db);
	}

	// Token: 0x0600C609 RID: 50697 RVA: 0x00453A50 File Offset: 0x00451C50
	private cao a(int A_0, string A_1, string A_2, Hotkey A_3, string A_4, bool A_5 = false, Color? A_6 = null)
	{
		wj wj = wj.a();
		string a_ = this.b(A_1);
		string text = this.a(A_1);
		string a_2 = null;
		if (A_5)
		{
			a_2 = "SysBar." + A_1 + ".Disabled";
		}
		cao cao;
		if (wj.d == UiSize.Classic)
		{
			cao = new bi(a_, text, text, a_2, null);
			cao.Location = new Point(10 + this.c * (cao.Size.c + 2), 4);
			if (A_6 != null)
			{
				((bi)cao).a(A_6.Value);
			}
		}
		else
		{
			cep cep = new cep();
			cep.a = wj.f;
			cep.b = new Point(wj.c9.X, wj.c9.Y + wj.da.d * A_0);
			cep.c = wj.da;
			cep.Size = wj.da;
			cep.e = wj.de;
			cep.Location = new Point(wj.db * 2 + this.c * (cep.Size.c + wj.db), wj.db * 2);
			if (A_6 != null)
			{
				cep.f = A_6.Value;
			}
			cao = cep;
		}
		cao.Text = A_2;
		cao.Tag = A_4;
		cao.j(new EventHandler<b25>(this.a));
		cao.l(new EventHandler<b25>(this.b));
		e4z.i(cao);
		this.aox(cao);
		this.e[cao] = A_3;
		this.c++;
		return cao;
	}

	// Token: 0x0600C60A RID: 50698 RVA: 0x00453C20 File Offset: 0x00451E20
	private string b(string A_0)
	{
		return "SysBar." + A_0;
	}

	// Token: 0x0600C60B RID: 50699 RVA: 0x00453C30 File Offset: 0x00451E30
	private string a(string A_0)
	{
		return "SysBar." + A_0 + ".Highlight";
	}

	// Token: 0x0600C60C RID: 50700 RVA: 0x00453C44 File Offset: 0x00451E44
	private void b(object A_0, b25 A_1)
	{
		this.d.b();
	}

	// Token: 0x0600C60D RID: 50701 RVA: 0x00453C54 File Offset: 0x00451E54
	private void a(object A_0, b25 A_1)
	{
		this.d.b();
	}

	// Token: 0x040048A0 RID: 18592
	private new const int a = 500;

	// Token: 0x040048A1 RID: 18593
	private new const string b = "SysBar.";

	// Token: 0x040048A2 RID: 18594
	private new int c;

	// Token: 0x040048A3 RID: 18595
	private new dsy d;

	// Token: 0x040048A4 RID: 18596
	private new Dictionary<euz, Hotkey> e = new Dictionary<euz, Hotkey>();

	// Token: 0x040048A5 RID: 18597
	private new double f;

	// Token: 0x040048A6 RID: 18598
	private new bool g;

	// Token: 0x040048A7 RID: 18599
	private cao h;

	// Token: 0x040048A8 RID: 18600
	private cao i;

	// Token: 0x040048A9 RID: 18601
	private new cao j;

	// Token: 0x040048AA RID: 18602
	private new cao k;

	// Token: 0x040048AB RID: 18603
	private new cao l;

	// Token: 0x040048AC RID: 18604
	private new cao m;

	// Token: 0x040048AD RID: 18605
	private cao n;

	// Token: 0x040048AE RID: 18606
	private cao o;

	// Token: 0x040048AF RID: 18607
	private cao p;

	// Token: 0x040048B0 RID: 18608
	private cao q;

	// Token: 0x0200206D RID: 8301
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600C610 RID: 50704 RVA: 0x00453C78 File Offset: 0x00451E78
		internal bool a(euz A_0)
		{
			return A_0.IsMousedOver;
		}

		// Token: 0x040048B1 RID: 18609
		public static readonly e60.a a = new e60.a();

		// Token: 0x040048B2 RID: 18610
		public static Func<euz, bool> b;
	}
}
