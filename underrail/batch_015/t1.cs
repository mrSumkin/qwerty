using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Ouroboros.Common;
using TimelapseVertigo.Common;
using TimelapseVertigo.Common.Settings;

// Token: 0x02002086 RID: 8326
public class t1 : daj, e8p, el2, amj
{
	// Token: 0x0600C6F6 RID: 50934 RVA: 0x0045D7FC File Offset: 0x0045B9FC
	public t1(bool A_0)
	{
		wj wj = wj.a();
		if (!wj.c())
		{
			this.a = wj.hh;
			this.c = wj.hj;
			this.d = wj.hk;
			this.e = wj.hl;
			this.f = wj.hm;
			this.g = wj.hn;
			this.h = wj.ho;
			this.i = wj.hp;
			this.j = wj.hq;
			this.k = wj.hr;
			this.l = wj.hs;
		}
		this.b = egg.b(this.a);
		this.n = A_0;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		this.o = serviceOrThrow.aq1().f();
		this.i();
		this.h();
		if (t1.m != null)
		{
			this.u.e(this.u.n()[t1.m.Value]);
		}
		int a_;
		if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Huge)
		{
			a_ = 900;
		}
		else if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.ExtraLarge)
		{
			a_ = 650;
		}
		else if (serviceOrThrow.aq1().b().g() == InterfaceElementSize2.Large)
		{
			a_ = 500;
		}
		else
		{
			a_ = 300;
		}
		Point value = new Point(this.u.Location.X + 20, this.u.Location.Y + this.u.Size.d - 20);
		this.bb = new dsy(this, this, esj.a(), a_, null, new Point?(value), 500, false, true);
		this.bb.a(true);
	}

	// Token: 0x0600C6F7 RID: 50935 RVA: 0x0045DA6C File Offset: 0x0045BC6C
	public override void iv(e6d A_0, cp9 A_1)
	{
		ds6.a();
		this.bb.a(A_0);
		base.iv(A_0, A_1);
		ds6.a(A_1, A_0);
	}

	// Token: 0x0600C6F8 RID: 50936 RVA: 0x0045DA90 File Offset: 0x0045BC90
	public ecs yf(euz A_0)
	{
		foreach (euz euz in this.bc)
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
					string text = null;
					if (euz2 == this.ah)
					{
						text = qv.b("ui/Options_Tooltip_SpriteMask");
					}
					if (euz2 == this.ai)
					{
						text = qv.b("ui/Options_Tooltip_SpriteComposition");
					}
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

	// Token: 0x0600C6F9 RID: 50937 RVA: 0x0045DB98 File Offset: 0x0045BD98
	private void i()
	{
		wj wj = wj.a();
		this.c();
		esj a_ = bpo.GetServiceOrThrow<bef>().k0();
		if (this.n)
		{
			bg1 a_2 = czo.a(a_);
			this.aox(a_2);
		}
		this.u = new dpg();
		if (wj.c())
		{
			this.u.Size = new esj(1000, 724);
			this.u.b(new esj(160, 35));
			this.u.a(new esj(2, 2));
			this.u.a(5);
			this.u.a(new Point(0, 6));
			this.u.b(bo1.y);
			this.u.a(egg.b);
			this.u.n = bo1.m;
		}
		else
		{
			this.u.b(wj.hi);
			this.u.Size = new esj(wj.fu.c, wj.hi.d + wj.fu.d);
			this.u.a(wj.fx);
			this.u.a(wj.fy);
			this.u.a(wj.fz);
			this.u.a(new Point(0, wj.f0));
			this.u.b(wj.f);
			this.u.b(wj.e5);
			this.u.a(new esj?(wj.e6));
			this.u.n = wj.f;
			this.u.o = wj.cc;
			this.u.p = new esj?(wj.cd);
		}
		this.u.a(new Color(255, 255, 255, 255));
		this.u.d(new Color(174, 87, 0, 255));
		this.u.b(new Color(255, 255, 255, 255));
		this.u.c(new Color(255, 255, 255, 255));
		this.u.Location = new Point(26, 28);
		this.u.b();
		this.aox(this.u);
		this.v = new cvh();
		this.v.Text = qv.b("ui/Options_Tab_General");
		this.u.n().Add(this.v);
		this.w = new cvh();
		this.w.Text = qv.b("ui/Options_Tab_Video");
		this.u.n().Add(this.w);
		this.x = new cvh();
		this.x.Text = qv.b("ui/Options_Tab_Audio");
		this.u.n().Add(this.x);
		this.y = new cvh();
		this.y.Text = qv.b("ui/Options_Tab_Interface");
		this.u.n().Add(this.y);
		this.z = new cvh();
		this.z.Text = qv.b("ui/Options_Tab_Controls");
		this.u.n().Add(this.z);
		this.aa = new cvh();
		this.aa.Text = qv.b("ui/Options_Tab_Gameplay");
		this.u.n().Add(this.aa);
		this.ac = new dak();
		this.ac.Text = qv.b("ui/Cancel");
		this.ac.c(new EventHandler<b25>(this.b));
		t1.a(this.ac, wj);
		if (wj.c())
		{
			this.ac.Location = new Point(this.u.Location.X + this.u.Size.c - (this.ac.Size.c + 35), this.u.Location.Y + this.u.Size.d - (this.ac.Size.d + 25));
		}
		else
		{
			this.ac.Location = new Point(this.u.Location.X + this.u.Size.c - this.ac.Size.c - wj.fv.c, this.u.Location.Y + this.u.Size.d - this.ac.Size.d - wj.fv.d);
		}
		e4z.j(this.ac);
		this.aox(this.ac);
		this.ab = new dak();
		this.ab.Text = qv.b("ui/Accept");
		this.ab.c(new EventHandler<b25>(this.a));
		t1.a(this.ab, wj);
		if (wj.c())
		{
			this.ab.Location = new Point(this.ac.Location.X - this.ab.Size.c - 15, this.ac.Location.Y);
		}
		else
		{
			this.ab.Location = new Point(this.ac.Location.X - (int)((float)this.ab.Size.c * 1.1f), this.ac.Location.Y);
		}
		e4z.j(this.ab);
		this.aox(this.ab);
	}

	// Token: 0x0600C6FA RID: 50938 RVA: 0x0045E1E4 File Offset: 0x0045C3E4
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

	// Token: 0x0600C6FB RID: 50939 RVA: 0x0045E294 File Offset: 0x0045C494
	private void h()
	{
		wj wj = wj.a();
		this.g();
		this.s = this.v;
		this.aw = this.b(this.o.c().a());
		this.a(this.c("Options_Language"), this.aw, null, true, true, 0, false);
		this.ax = this.b(this.o.d().c());
		this.a(this.c("Options_AutosaveOnTransitions"), this.ax, null, true, true, 0, false);
		this.ay = this.b(this.o.d().b());
		this.a(this.c("Options_RetainSaves"), this.ay, null, true, true, 0, false);
		this.a0 = this.b(this.o.d().d());
		this.a(this.c("Options_AutoOverwriteSaves"), this.a0, null, true, true, 0, false);
		this.az = this.b(this.o.d().e());
		this.a(this.c("Options_SaveCompatibilityWarning"), this.az, null, true, true, 0, false);
		this.f();
		this.g();
		this.s = this.w;
		if (!cxc.b())
		{
			this.ad = new aw9(efw.a(), null, null);
			this.ad.b(efw.a(this.o.g().a));
			this.ad.a(new EventHandler<c1>(this.c));
			if (wj.c())
			{
				this.ad.Size = new esj(this.i, 30);
			}
			else
			{
				this.ad.Size = new esj(this.i, this.l);
			}
			this.ad.a(this.a);
			this.ad.Gravity = axy.c;
			this.a(this.c("Options_Resolution"), this.ad, null, false, true, 0, false);
			this.ae = this.CreateComboBoxFromEnum<OuroborosDisplayMode>(this.o.g().b, new Func<object, string>(dh9.a), null);
			this.a(this.c("Options_DisplayMode"), this.ae, null, false, true, 0, false);
		}
		this.af = this.b(this.o.g().d);
		this.a(this.c("Options_AllowZoom"), this.af, null, true, true, 0, false);
		this.ag = this.b(this.o.g().c);
		this.a(this.c("Options_VSync"), this.ag, null, true, true, 0, false);
		this.ah = this.b(this.o.g().e);
		this.a(this.c("Options_SpriteTargetMask"), this.ah, null, true, true, 0, true);
		this.ai = this.b(this.o.g().g);
		this.a(this.c("Options_SpriteComposition"), this.ai, null, true, true, 0, true);
		this.aj = this.CreateComboBoxFromEnum<TimelapseShader>(this.o.g().f, new Func<object, string>(dh9.a), null);
		this.a(this.c("Options_Shader"), this.aj, null, false, true, 0, false);
		this.f();
		this.g();
		this.s = this.x;
		this.a("master", this.c("Options_MasterVolume"), this.o.h().c(), 0, 100, 10, 25, true, null, null, true);
		this.a("effects", this.c("Options_EffectsVolume"), this.o.h().b()[c9z.a], 0, 100, 10, 25, true, null, null, true);
		this.a("ambiental", this.c("Options_AmbientalVolume"), this.o.h().b()[c9z.b], 0, 100, 10, 25, true, null, null, true);
		this.a("music", this.c("Options_MusicVolume"), this.o.h().b()[c9z.c], 0, 100, 10, 25, true, null, null, true);
		this.a("interface", this.c("Options_InterfaceVolume"), this.o.h().b()[c9z.e], 0, 100, 10, 25, true, null, null, true);
		this.f();
		this.g();
		this.s = this.y;
		this.au = this.CreateComboBoxFromEnum<MainMenuTheme>(this.o.b().q(), null, new Func<object, bool>(t1.b.a.d));
		this.au.f = new Func<object, string>(t1.b.a.c);
		this.a(this.c("Options_MainMenuTheme"), this.au, null, false, false, 0, false);
		this.a(false);
		if (!cxc.b())
		{
			this.ao = this.CreateComboBoxFromEnum<UiSize>(this.o.b().m(), new Func<object, string>(dh9.a), null);
			this.ao.h = new Func<object, bool>(this.a);
			this.a(this.c("Options_InterfaceSize"), this.ao, null, false, false, 0, false);
		}
		this.ap = this.CreateComboBoxFromEnum<UiSize>(this.o.b().d(), new Func<object, string>(dh9.a), null);
		this.a(this.c("Options_CursorSize"), this.ap, null, false, false, 0, false);
		this.aq = this.b(this.o.b().q);
		this.a(this.c("Options_OnScreenKeyboard"), this.aq, null, true, false, 0, false);
		this.a(false);
		this.a4 = this.b(this.o.b().a());
		this.a(this.c("Options_PortraitLighting"), this.a4, null, true, false, 0, false);
		this.ar = this.CreateComboBoxFromEnum<InterfaceElementSize2>(this.o.b().o(), new Func<object, string>(dh9.a), null);
		this.a(this.c("Options_DialogPortraits"), this.ar, null, false, false, 0, false);
		this.ak = this.CreateComboBoxFromEnum<InterfaceElementSize2>(this.o.b().c(), new Func<object, string>(dh9.a), null);
		this.a(this.c("Options_DialogFont"), this.ak, null, false, false, 0, false);
		this.al = this.CreateComboBoxFromEnum<InterfaceElementSize2>(this.o.b().v(), new Func<object, string>(dh9.a), null);
		this.a(this.c("Options_TooltipFont"), this.al, null, false, false, 0, false);
		this.am = this.CreateComboBoxFromEnum<InterfaceElementSize2>(this.o.b().r(), new Func<object, string>(dh9.a), null);
		this.a(this.c("Options_LabelFont"), this.am, null, false, false, 0, false);
		this.a("dialogWindowAlpha", this.c("Options_DialogBackgroundAlpha"), this.o.b().x(), 0, 100, 10, 25, true, null, null, false);
		this.a(false);
		this.an = this.CreateComboBoxFromEnum<InterfaceElementSize2>(this.o.b().u(), new Func<object, string>(dh9.a), null);
		this.a(this.c("Options_LogFont"), this.an, null, false, false, 0, false);
		avo avo = this.a(50);
		avo.Location = new Point(10, this.b);
		avo.Text = ((int)(this.o.b().j() * 100.0)).ToString() + "%";
		this.a("logWidth", this.c("Options_LogWidth"), (float)this.o.b().j(), 100, 250, 20, 50, true, null, null, false);
		this.a(false);
		this.@as = this.CreateComboBoxFromEnum<AutoSelectOption>(this.o.b().b(), new Func<object, string>(t1.b.a.b), null);
		this.a(this.c("Options_AutoselectTarget"), this.@as, null, false, false, 0, false);
		this.at = this.CreateComboBoxFromEnum<OutlinesOption>(this.o.b().k(), new Func<object, string>(t1.b.a.a), null);
		this.a(this.c("Options_CharacterOutlines"), this.at, null, false, false, 0, false);
		this.a("unobscuration", this.c("Options_UnobscurationAlpha"), this.o.b().i(), 0, 100, 10, 25, true, null, null, false);
		this.a("transitionAlpha", this.c("Options_TransitionAlpha"), this.o.b().f(), 0, 100, 10, 25, true, null, null, false);
		if (this.q == 0)
		{
			this.e();
		}
		else if (wj.d != UiSize.Large)
		{
			this.a(false);
		}
		this.a("   " + this.c("Options_ScrollingCombatText"));
		this.av = new ac5(new Dictionary<string, ScrollingCombatTextOptions>
		{
			{
				"Player",
				this.o.b().w().d()
			},
			{
				"Selected",
				this.o.b().w().g()
			},
			{
				"Others",
				this.o.b().w().e()
			}
		});
		this.b(this.av);
		this.a("sctDuration", this.c("Options_SCT_Duration"), (float)this.o.b().w().b() / 100f, 150, 5000, 100, 1000, false, new EventHandler<c1>(this.b), new Func<int, string>(t1.b.a.b), false);
		this.a("timeBetween", this.c("Option_SCT_TimeBetween"), (float)this.o.b().w().a() / 100f, 150, 5000, 100, 1000, false, new EventHandler<c1>(this.a), new Func<int, string>(t1.b.a.a), false);
		this.a5 = this.b(this.o.b().w().f());
		this.a(this.c("Options_SCT_AggregateByDamageTypes"), this.a5, null, true, false, 0, false);
		this.f();
		this.g();
		this.s = this.z;
		this.a(this.c("Options_KeyBindings"));
		if (wj.c())
		{
			if (egg.v)
			{
				this.ba = new ar4(new esj(450, 550));
			}
			else
			{
				this.ba = new ar4(new esj(450, 530));
			}
		}
		else
		{
			esj a_ = new esj(this.g - this.e, wj.ht);
			this.ba = new ar4(a_);
		}
		this.b(this.ba);
		this.e();
		this.a1 = this.b(this.o.e().b());
		this.a(this.c("Options_FullscreenMouseLock"), this.a1, null, true, false, 50, false);
		this.a2 = this.b(this.o.e().f());
		this.a(this.c("Options_RightClickScrolling"), this.a2, null, true, false, 50, false);
		this.a3 = this.b(this.o.e().d());
		this.a(this.c("Options_ScreenEdgeScrolling"), this.a3, null, true, false, 50, false);
		this.g();
		this.s = this.aa;
		this.a6 = this.b(this.o.c().d());
		this.a(this.c("Options_AutomaticallyOpenDoors"), this.a6, null, true, true, 0, false);
		this.a7 = this.b(this.o.c().c());
		this.a(this.c("Options_AutomaticallyEndTurn"), this.a7, null, true, true, 0, false);
		this.a8 = this.b(this.o.c().g());
		this.a(this.c("Options_CombatTaunts"), this.a8, null, true, true, 0, false);
		this.a("combatMovementSpeed", this.c("Options_CombatMovementSpeed"), this.o.c().e(), 100, 500, 25, 100, true, null, null, true);
		this.a("combatActionSpeed", this.c("Options_CombatActionSpeed"), this.o.c().f(), 100, 500, 25, 100, true, null, null, true);
	}

	// Token: 0x0600C6FC RID: 50940 RVA: 0x0045F0AC File Offset: 0x0045D2AC
	private string c(string A_0)
	{
		return qv.b("ui/" + A_0);
	}

	// Token: 0x0600C6FD RID: 50941 RVA: 0x0045F0C0 File Offset: 0x0045D2C0
	private cao b(bool A_0)
	{
		cao cao;
		if (wj.a().c())
		{
			eki eki = new eki();
			eki.Checked = A_0;
			eki.a(new Point(10, this.b));
			eki.a(true);
			eki.a(adi.a);
			eki.c(adi.b);
			eki.b(this.a);
			cao = eki;
		}
		else
		{
			aad aad = new aad();
			aad.Checked = A_0;
			aad.a(new Point(10, this.b));
			aad.a(true);
			aad.a(adi.a);
			aad.c(adi.b);
			aad.a(this.a);
			cao = aad;
		}
		e4z.g(cao);
		return cao;
	}

	// Token: 0x0600C6FE RID: 50942 RVA: 0x0045F17C File Offset: 0x0045D37C
	private void a(bool A_0 = false)
	{
		cxh cxh = new cxh();
		if (A_0)
		{
			cxh.Size = new esj(this.i * 2 + this.h, 2);
		}
		else
		{
			cxh.Size = new esj(this.i + this.h, 2);
		}
		cxh.Location = new Point(this.e + this.q * (this.e + this.g), this.r + this.f);
		this.s.aox(cxh);
		this.r += 2 + this.f * 3;
	}

	// Token: 0x0600C6FF RID: 50943 RVA: 0x0045F228 File Offset: 0x0045D428
	private aw9 b(string A_0)
	{
		t1.a a = new t1.a();
		a.a = A_0;
		List<evo> list = aji.a();
		if (list == null)
		{
			list = new List<evo>();
		}
		list.Insert(0, null);
		aw9 aw = new aw9(list, new Func<object, string>(this.b), new Func<object, bool>(this.c));
		aw.b(Enumerable.FirstOrDefault<evo>(Enumerable.Where<evo>(list, new Func<evo, bool>(a.a))));
		aw.Size = new esj(this.i, this.l);
		aw.a(this.a);
		aw.Gravity = axy.c;
		return aw;
	}

	// Token: 0x0600C700 RID: 50944 RVA: 0x0045F2C4 File Offset: 0x0045D4C4
	private bool c(object A_0)
	{
		evo evo = A_0 as evo;
		return evo == null || !string.Equals(evo.a, "template", StringComparison.OrdinalIgnoreCase);
	}

	// Token: 0x0600C701 RID: 50945 RVA: 0x0045F2F8 File Offset: 0x0045D4F8
	private string b(object A_0)
	{
		if (A_0 == null)
		{
			return "Русский [инжектор]";
		}
		evo evo = A_0 as evo;
		if (evo != null)
		{
			return evo.b;
		}
		return "[Unknown]";
	}

	// Token: 0x0600C702 RID: 50946 RVA: 0x0045F32C File Offset: 0x0045D52C
	private aw9 CreateComboBoxFromEnum<T>(T current, Func<object, string> getItemLabelDelegate = null, Func<object, bool> filterDelegate = null)
	{
		aw9 aw = new aw9(Enum.GetValues(typeof(T)), getItemLabelDelegate, filterDelegate);
		aw.b(current);
		aw.Size = new esj(this.i, this.l);
		aw.a(this.a);
		aw.Gravity = axy.c;
		return aw;
	}

	// Token: 0x0600C703 RID: 50947 RVA: 0x0045F388 File Offset: 0x0045D588
	private void a(string A_0, string A_1, float A_2, int A_3 = 0, int A_4 = 100, int A_5 = 10, int A_6 = 25, bool A_7 = true, EventHandler<c1> A_8 = null, Func<int, string> A_9 = null, bool A_10 = false)
	{
		t1.c c = new t1.c();
		c.b = A_9;
		c.d = A_7;
		wj wj = wj.a();
		int a_;
		if (wj.c())
		{
			a_ = 50;
		}
		else
		{
			a_ = wj.hu;
		}
		c.a = this.a(a_);
		c.a.Location = new Point(10, this.b);
		if (c.b != null)
		{
			c.a.Text = c.b((int)(A_2 * 100f));
		}
		else
		{
			c.a.Text = ((int)(A_2 * 100f)).ToString() + (c.d ? "%" : "");
		}
		if (wj.c())
		{
			c.c = new c8b();
		}
		else
		{
			c.c = new ebu();
		}
		c.c.b(A_3);
		c.c.a(A_4);
		c.c.e((int)(A_2 * 100f));
		if (wj.c())
		{
			c.c.Size = new esj(this.i - 50, 27);
		}
		else
		{
			c.c.Size = new esj(this.i - 50, wj.bq.d);
		}
		if (A_10)
		{
			c.c.Size = new esj((int)((double)c.c.Size.c * 2.5), c.c.Size.d);
		}
		c.c.c(A_5);
		c.c.d(A_6);
		if (A_8 != null)
		{
			c.c.f(A_8);
		}
		if (c.b != null)
		{
			c.c.f(new EventHandler<c1>(c.a));
		}
		else
		{
			c.c.f(new EventHandler<c1>(c.b));
		}
		this.a9[A_0] = c.c;
		this.a(A_1, c.c, c.a, false, false, 0, false);
	}

	// Token: 0x0600C704 RID: 50948 RVA: 0x0045F5D4 File Offset: 0x0045D7D4
	private avo a(int A_0)
	{
		avo avo = new avo();
		avo.a(this.a);
		avo.Color = adi.a;
		avo.Size = new esj(A_0, this.k);
		return avo;
	}

	// Token: 0x0600C705 RID: 50949 RVA: 0x0045F610 File Offset: 0x0045D810
	private void g()
	{
		this.q = 0;
		this.r = this.c;
		this.t = new List<aw9>();
	}

	// Token: 0x0600C706 RID: 50950 RVA: 0x0045F634 File Offset: 0x0045D834
	private void f()
	{
		if (this.t != null && this.t.Count > 0)
		{
			for (int i = this.t.Count - 1; i >= 0; i--)
			{
				this.s.aox(this.t[i]);
			}
		}
	}

	// Token: 0x0600C707 RID: 50951 RVA: 0x0045F690 File Offset: 0x0045D890
	private void e()
	{
		this.r = this.c;
		this.q++;
	}

	// Token: 0x0600C708 RID: 50952 RVA: 0x0045F6AC File Offset: 0x0045D8AC
	private void a(string A_0)
	{
		avo avo = this.a(this.h - this.j + this.i);
		avo.a(cab.a);
		avo.Text = A_0;
		avo.Location = new Point(this.e + this.q * this.g, this.r + this.b);
		this.s.aox(avo);
		this.r = avo.Location.Y + avo.Size.d + this.f;
	}

	// Token: 0x0600C709 RID: 50953 RVA: 0x0045F740 File Offset: 0x0045D940
	private void b(euz A_0)
	{
		A_0.Location = new Point(A_0.Location.X + this.e + this.q * this.g, A_0.Location.Y + this.r);
		this.s.aox(A_0);
		this.r = A_0.Location.Y + A_0.Size.d + this.f;
	}

	// Token: 0x0600C70A RID: 50954 RVA: 0x0045F7BC File Offset: 0x0045D9BC
	private void a(string A_0, euz A_1, euz A_2 = null, bool A_3 = false, bool A_4 = false, int A_5 = 0, bool A_6 = false)
	{
		avo avo;
		if (A_4)
		{
			avo = this.a((int)((double)this.h * 2.5) + A_5 - this.j);
		}
		else
		{
			avo = this.a(this.h + A_5 - this.j);
		}
		avo.a(cab.c);
		avo.Text = A_0;
		if (this.r + avo.Size.d > this.s.Size.d - this.d)
		{
			this.e();
		}
		avo.Location = new Point(this.e + this.q * this.g, this.r + this.b);
		this.s.aox(avo);
		if (A_4)
		{
			if (A_3)
			{
				A_1.Location = new Point(A_1.Location.X + avo.Location.X + (int)((double)this.h * 2.5) + (this.i - A_1.Size.c) / 2, A_1.Location.Y + this.r);
			}
			else
			{
				A_1.Location = new Point(A_1.Location.X + avo.Location.X + (int)((double)this.h * 2.5), A_1.Location.Y + this.r);
			}
		}
		else if (A_3)
		{
			A_1.Location = new Point(A_1.Location.X + avo.Location.X + this.h + (this.i - A_1.Size.c) / 2, A_1.Location.Y + this.r);
		}
		else
		{
			A_1.Location = new Point(A_1.Location.X + avo.Location.X + this.h + A_5, A_1.Location.Y + this.r);
		}
		wj wj = wj.a();
		if (!wj.c())
		{
			int num = (A_1.Size.d - avo.Size.d) / 2;
			A_1.Location = new Point(A_1.Location.X, A_1.Location.Y - num);
		}
		if (A_1 is aw9)
		{
			this.t.Add((aw9)A_1);
		}
		else
		{
			this.s.aox(A_1);
		}
		this.r = A_1.Location.Y + A_1.Size.d + this.f;
		if (A_2 != null)
		{
			A_2.Location = new Point(A_2.Location.X + A_1.Location.X + A_1.Size.c, A_2.Location.Y + A_1.Location.Y);
			if (!wj.c())
			{
				int num2 = (A_1.Size.d - A_2.Size.d) / 2;
				A_2.Location = new Point(A_2.Location.X, A_2.Location.Y + num2);
			}
			this.s.aox(A_2);
		}
		if (A_6)
		{
			this.a(avo);
			avo.Tag = A_1;
			this.a(A_1);
			if (A_2 != null)
			{
				A_2.Tag = A_1;
				this.a(A_2);
			}
		}
	}

	// Token: 0x0600C70B RID: 50955 RVA: 0x0045FB50 File Offset: 0x0045DD50
	private void a(euz A_0)
	{
		if (A_0 != null)
		{
			A_0.j(new EventHandler<b25>(this.c));
			A_0.l(new EventHandler<b25>(this.d));
			this.bc.Add(A_0);
		}
	}

	// Token: 0x0600C70C RID: 50956 RVA: 0x0045FB88 File Offset: 0x0045DD88
	private void d(object A_0, b25 A_1)
	{
		this.bb.b();
	}

	// Token: 0x0600C70D RID: 50957 RVA: 0x0045FB98 File Offset: 0x0045DD98
	private void c(object A_0, b25 A_1)
	{
		this.bb.b();
	}

	// Token: 0x0600C70E RID: 50958 RVA: 0x0045FBA8 File Offset: 0x0045DDA8
	private void d()
	{
		this.o.d().d(this.ax.Checked);
		this.o.d().c(this.ay.Checked);
		this.o.d().a(this.az.Checked);
		this.o.d().b(this.a0.Checked);
		if (!cxc.b())
		{
			this.o.g().a = ((egd)this.ad.l()).d;
			this.o.g().b = (OuroborosDisplayMode)this.ae.l();
		}
		this.o.g().d = this.af.Checked;
		this.o.g().c = this.ag.Checked;
		this.o.g().e = this.ah.Checked;
		this.o.g().f = (TimelapseShader)this.aj.l();
		this.o.g().g = this.ai.Checked;
		this.o.h().a((float)this.a9["master"].l() / 100f);
		this.o.h().b()[c9z.a] = (float)this.a9["effects"].l() / 100f;
		this.o.h().b()[c9z.b] = (float)this.a9["ambiental"].l() / 100f;
		this.o.h().b()[c9z.c] = (float)this.a9["music"].l() / 100f;
		this.o.h().b()[c9z.e] = (float)this.a9["interface"].l() / 100f;
		if (!cxc.b())
		{
			this.o.b().b((UiSize)this.ao.l());
		}
		this.o.b().c((UiSize)this.ap.l());
		this.o.b().q = this.aq.Checked;
		this.o.b().d((InterfaceElementSize2)this.ar.l());
		this.o.b().f((InterfaceElementSize2)this.ak.l());
		this.o.b().a((float)this.a9["dialogWindowAlpha"].l() / 100f);
		this.o.b().b((InterfaceElementSize2)this.al.l());
		this.o.b().c((InterfaceElementSize2)this.am.l());
		this.o.b().e((InterfaceElementSize2)this.an.l());
		this.o.b().a((AutoSelectOption)this.@as.l());
		this.o.b().a((double)this.a9["logWidth"].l() / 100.0);
		this.o.b().a(this.a4.Checked);
		this.o.b().a((OutlinesOption)this.at.l());
		this.o.b().c((float)this.a9["unobscuration"].l() / 100f);
		this.o.b().b((float)this.a9["transitionAlpha"].l() / 100f);
		this.o.b().a((MainMenuTheme)this.au.l());
		this.o.b().w().a(this.a9["sctDuration"].l());
		this.o.b().w().b(this.a9["timeBetween"].l());
		this.o.b().w().b(this.av.c()["Player"]);
		this.o.b().w().a(this.av.c()["Selected"]);
		this.o.b().w().c(this.av.c()["Others"]);
		this.o.b().w().a(this.a5.Checked);
		this.o.e().a(this.a1.Checked);
		this.o.e().c(this.a2.Checked);
		this.o.e().b(this.a3.Checked);
		this.ba.a(this.o);
		this.o.c().a(this.a6.Checked);
		this.o.c().b(this.a7.Checked);
		this.o.c().c(this.a8.Checked);
		this.o.c().b((float)this.a9["combatMovementSpeed"].l() / 100f);
		this.o.c().a((float)this.a9["combatActionSpeed"].l() / 100f);
		a94 a = this.o.c();
		evo evo = this.aw.l() as evo;
		a.a((evo != null) ? evo.a : null);
	}

	// Token: 0x0600C70F RID: 50959 RVA: 0x00460254 File Offset: 0x0045E454
	private void c()
	{
		base.a(cku.b);
		base.z();
	}

	// Token: 0x0600C710 RID: 50960 RVA: 0x00460264 File Offset: 0x0045E464
	private void b()
	{
		if (this.o != null)
		{
			bpo.GetServiceOrThrow<cnk>().arb(this.o);
		}
	}

	// Token: 0x0600C711 RID: 50961 RVA: 0x00460284 File Offset: 0x0045E484
	private void a()
	{
		if (this.p != null)
		{
			bpo.GetServiceOrThrow<cnk>().arb(this.p);
			if (bpo.GetServiceOrThrow<bcm>().aau() is a8k)
			{
				bpo.GetServiceOrThrow<d4m>().avp(dla.a(TimelapseWorkflows.ReturnToMainMenu, new object[0]));
			}
		}
	}

	// Token: 0x0600C712 RID: 50962 RVA: 0x004602D8 File Offset: 0x0045E4D8
	private void b(object A_0, b25 A_1)
	{
		base.a9();
		base.a(cku.b);
		base.z();
	}

	// Token: 0x0600C713 RID: 50963 RVA: 0x004602F0 File Offset: 0x0045E4F0
	private void a(object A_0, b25 A_1)
	{
		base.a9();
		this.d();
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		base.a(cku.a);
		base.z();
		if (serviceOrThrow.aq1() == null || serviceOrThrow.aq1().g().a != this.o.g().a || serviceOrThrow.aq1().g().b != this.o.g().b || serviceOrThrow.aq1().g().c != this.o.g().c)
		{
			cnt cnt = serviceOrThrow.aq1().g().a();
			this.p = this.o.f();
			this.p.a(cnt.a());
			serviceOrThrow.arb(this.p);
			serviceOrThrow.arc(this.o);
			euz euz = null;
			bcm serviceOrThrow2 = bpo.GetServiceOrThrow<bcm>();
			if (serviceOrThrow2.aau() != null)
			{
				cef cef = Enumerable.FirstOrDefault<cef>(Enumerable.OfType<cef>(serviceOrThrow2.aau().Controls));
				if (cef != null)
				{
					euz = cef;
				}
			}
			bnr.a(new esj(500, 250), new t1.d(this), "Настройки видео", "Вы хотите применить эти настройки видео? Изменения будут автоматически отменены через {0} сек.", null, "R", null, null, 10000, new cpk[]
			{
				new cpk("K", "Принять", true),
				new cpk("R", "Отменить", true)
			}, euz, euz);
			return;
		}
		serviceOrThrow.arb(this.o);
	}

	// Token: 0x0600C714 RID: 50964 RVA: 0x0046049C File Offset: 0x0045E69C
	protected override void g6(object A_0, ane A_1)
	{
		base.vx(A_0, A_1);
		if (A_1.a == Keys.Enter)
		{
			e4z.j();
			this.a(this, new b25());
		}
		if (A_1.a == Keys.Escape)
		{
			e4z.j();
			this.b(this, new b25());
		}
	}

	// Token: 0x0600C715 RID: 50965 RVA: 0x004604F0 File Offset: 0x0045E6F0
	protected override void i1()
	{
		base.i1();
		t1.m = new int?(this.u.n().IndexOf(this.u.m()));
	}

	// Token: 0x0600C716 RID: 50966 RVA: 0x00460528 File Offset: 0x0045E728
	[CompilerGenerated]
	private void c(object A_0, c1 A_1)
	{
		egd egd = this.ad.l() as egd;
		if (egd != null && this.ao != null)
		{
			object obj = this.ao.l();
			if (obj is UiSize)
			{
				UiSize uiSize = (UiSize)obj;
				if (egd.g < uiSize)
				{
					this.ao.b(UiSize.Auto);
				}
			}
		}
	}

	// Token: 0x0600C717 RID: 50967 RVA: 0x00460594 File Offset: 0x0045E794
	[CompilerGenerated]
	private bool a(object A_0)
	{
		if (A_0 is UiSize)
		{
			UiSize uiSize = (UiSize)A_0;
			if (this.ad != null)
			{
				egd egd = this.ad.l() as egd;
				if (egd != null)
				{
					return uiSize <= egd.g;
				}
			}
		}
		return true;
	}

	// Token: 0x0600C718 RID: 50968 RVA: 0x004605E4 File Offset: 0x0045E7E4
	[CompilerGenerated]
	private void b(object A_0, c1 A_1)
	{
		object obj = A_1.a();
		if (obj is int)
		{
			int a_ = (int)obj;
			this.o.b().w().a(a_);
		}
	}

	// Token: 0x0600C719 RID: 50969 RVA: 0x00460620 File Offset: 0x0045E820
	[CompilerGenerated]
	private void a(object A_0, c1 A_1)
	{
		object obj = A_1.a();
		if (obj is int)
		{
			int a_ = (int)obj;
			this.o.b().w().b(a_);
		}
	}

	// Token: 0x0400496C RID: 18796
	private new string a = egg.aq;

	// Token: 0x0400496D RID: 18797
	private new int b;

	// Token: 0x0400496E RID: 18798
	private new int c = 20;

	// Token: 0x0400496F RID: 18799
	private new int d = 20;

	// Token: 0x04004970 RID: 18800
	private new int e = 20;

	// Token: 0x04004971 RID: 18801
	private new int f = 10;

	// Token: 0x04004972 RID: 18802
	private new int g = 475;

	// Token: 0x04004973 RID: 18803
	private int h = 200;

	// Token: 0x04004974 RID: 18804
	private int i = 265;

	// Token: 0x04004975 RID: 18805
	private new int j = 15;

	// Token: 0x04004976 RID: 18806
	private new int k = 22;

	// Token: 0x04004977 RID: 18807
	private new int l = 25;

	// Token: 0x04004978 RID: 18808
	private new static int? m;

	// Token: 0x04004979 RID: 18809
	private bool n;

	// Token: 0x0400497A RID: 18810
	private ls o;

	// Token: 0x0400497B RID: 18811
	private ls p;

	// Token: 0x0400497C RID: 18812
	private int q;

	// Token: 0x0400497D RID: 18813
	private int r;

	// Token: 0x0400497E RID: 18814
	private cvh s;

	// Token: 0x0400497F RID: 18815
	private List<aw9> t;

	// Token: 0x04004980 RID: 18816
	private dpg u;

	// Token: 0x04004981 RID: 18817
	private cvh v;

	// Token: 0x04004982 RID: 18818
	private cvh w;

	// Token: 0x04004983 RID: 18819
	private new cvh x;

	// Token: 0x04004984 RID: 18820
	private cvh y;

	// Token: 0x04004985 RID: 18821
	private new cvh z;

	// Token: 0x04004986 RID: 18822
	private cvh aa;

	// Token: 0x04004987 RID: 18823
	private dak ab;

	// Token: 0x04004988 RID: 18824
	private dak ac;

	// Token: 0x04004989 RID: 18825
	private aw9 ad;

	// Token: 0x0400498A RID: 18826
	private aw9 ae;

	// Token: 0x0400498B RID: 18827
	private new cao af;

	// Token: 0x0400498C RID: 18828
	private cao ag;

	// Token: 0x0400498D RID: 18829
	private cao ah;

	// Token: 0x0400498E RID: 18830
	private cao ai;

	// Token: 0x0400498F RID: 18831
	private aw9 aj;

	// Token: 0x04004990 RID: 18832
	private aw9 ak;

	// Token: 0x04004991 RID: 18833
	private aw9 al;

	// Token: 0x04004992 RID: 18834
	private new aw9 am;

	// Token: 0x04004993 RID: 18835
	private aw9 an;

	// Token: 0x04004994 RID: 18836
	private new aw9 ao;

	// Token: 0x04004995 RID: 18837
	private new aw9 ap;

	// Token: 0x04004996 RID: 18838
	private cao aq;

	// Token: 0x04004997 RID: 18839
	private aw9 ar;

	// Token: 0x04004998 RID: 18840
	private aw9 @as;

	// Token: 0x04004999 RID: 18841
	private new aw9 at;

	// Token: 0x0400499A RID: 18842
	private aw9 au;

	// Token: 0x0400499B RID: 18843
	private ac5 av;

	// Token: 0x0400499C RID: 18844
	private aw9 aw;

	// Token: 0x0400499D RID: 18845
	private cao ax;

	// Token: 0x0400499E RID: 18846
	private cao ay;

	// Token: 0x0400499F RID: 18847
	private cao az;

	// Token: 0x040049A0 RID: 18848
	private cao a0;

	// Token: 0x040049A1 RID: 18849
	private cao a1;

	// Token: 0x040049A2 RID: 18850
	private cao a2;

	// Token: 0x040049A3 RID: 18851
	private cao a3;

	// Token: 0x040049A4 RID: 18852
	private cao a4;

	// Token: 0x040049A5 RID: 18853
	private new cao a5;

	// Token: 0x040049A6 RID: 18854
	private new cao a6;

	// Token: 0x040049A7 RID: 18855
	private new cao a7;

	// Token: 0x040049A8 RID: 18856
	private new cao a8;

	// Token: 0x040049A9 RID: 18857
	private new Dictionary<string, oz> a9 = new Dictionary<string, oz>();

	// Token: 0x040049AA RID: 18858
	private ar4 ba;

	// Token: 0x040049AB RID: 18859
	private new dsy bb;

	// Token: 0x040049AC RID: 18860
	private List<euz> bc = new List<euz>();

	// Token: 0x02002087 RID: 8327
	public new class d : eyp
	{
		// Token: 0x0600C71A RID: 50970 RVA: 0x0046065C File Offset: 0x0045E85C
		public d(t1 A_0)
		{
			this.a = A_0;
		}

		// Token: 0x0600C71B RID: 50971 RVA: 0x0046066C File Offset: 0x0045E86C
		public void g0(string A_0)
		{
			if (A_0 == "K")
			{
				this.a.b();
				return;
			}
			this.a.a();
		}

		// Token: 0x040049AD RID: 18861
		private t1 a;
	}

	// Token: 0x02002088 RID: 8328
	[CompilerGenerated]
	[Serializable]
	private new sealed class b
	{
		// Token: 0x0600C71E RID: 50974 RVA: 0x004606AC File Offset: 0x0045E8AC
		internal bool d(object A_0)
		{
			if (A_0 is MainMenuTheme && (MainMenuTheme)A_0 == MainMenuTheme.Expedition)
			{
				return dk2.f();
			}
			return !(A_0 is MainMenuTheme) || (MainMenuTheme)A_0 != MainMenuTheme.HeavyDuty || dk2.e();
		}

		// Token: 0x0600C71F RID: 50975 RVA: 0x004606EC File Offset: 0x0045E8EC
		internal string c(object A_0)
		{
			if (A_0 == null)
			{
				return "";
			}
			return dh9.a(A_0);
		}

		// Token: 0x0600C720 RID: 50976 RVA: 0x00460700 File Offset: 0x0045E900
		internal string b(object A_0)
		{
			if (A_0 != null)
			{
				return dh9.a(A_0);
			}
			return "";
		}

		// Token: 0x0600C721 RID: 50977 RVA: 0x00460714 File Offset: 0x0045E914
		internal string a(object A_0)
		{
			if (A_0 != null)
			{
				return dh9.a(A_0);
			}
			return "";
		}

		// Token: 0x0600C722 RID: 50978 RVA: 0x0046072C File Offset: 0x0045E92C
		internal string b(int A_0)
		{
			return ((double)A_0 / 1000.0).ToString("0.00");
		}

		// Token: 0x0600C723 RID: 50979 RVA: 0x00460754 File Offset: 0x0045E954
		internal string a(int A_0)
		{
			return ((double)A_0 / 1000.0).ToString("0.00");
		}

		// Token: 0x040049AE RID: 18862
		public static readonly t1.b a = new t1.b();

		// Token: 0x040049AF RID: 18863
		public static Func<object, bool> b;

		// Token: 0x040049B0 RID: 18864
		public static Func<object, string> c;

		// Token: 0x040049B1 RID: 18865
		public static Func<object, string> d;

		// Token: 0x040049B2 RID: 18866
		public static Func<object, string> e;

		// Token: 0x040049B3 RID: 18867
		public static Func<int, string> f;

		// Token: 0x040049B4 RID: 18868
		public static Func<int, string> g;
	}

	// Token: 0x02002089 RID: 8329
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x0600C725 RID: 50981 RVA: 0x00460784 File Offset: 0x0045E984
		internal bool a(evo A_0)
		{
			return ((A_0 != null) ? A_0.a : null) == this.a;
		}

		// Token: 0x040049B5 RID: 18869
		public string a;
	}

	// Token: 0x0200208A RID: 8330
	[CompilerGenerated]
	private new sealed class c
	{
		// Token: 0x0600C727 RID: 50983 RVA: 0x004607AC File Offset: 0x0045E9AC
		internal void a(object A_0, c1 A_1)
		{
			this.a.Text = this.b(this.c.l());
		}

		// Token: 0x0600C728 RID: 50984 RVA: 0x004607D0 File Offset: 0x0045E9D0
		internal void b(object A_0, c1 A_1)
		{
			this.a.Text = this.c.l().ToString() + (this.d ? "%" : "");
		}

		// Token: 0x040049B6 RID: 18870
		public avo a;

		// Token: 0x040049B7 RID: 18871
		public Func<int, string> b;

		// Token: 0x040049B8 RID: 18872
		public oz c;

		// Token: 0x040049B9 RID: 18873
		public bool d;
	}
}
