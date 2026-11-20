using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.Space;

// Token: 0x02000F41 RID: 3905
[e79("Xpbl_Pir_RescueArrivesToPrison")]
public sealed class ww : dgy
{
	// Token: 0x06004F18 RID: 20248 RVA: 0x0023A1B4 File Offset: 0x002383B4
	public ww()
	{
		ww.a a = new ww.a();
		base..ctor();
		a.a = this;
		a.b = bpo.GetServiceOrThrow<cnk>();
		if (a.b != null && a.b.aqu() != null)
		{
			a.c = (a.b.aqu().v().b() as c5x);
			ar7 a_ = new ar7(a.c);
			if (a.c != null)
			{
				ww.b b = new ww.b();
				b.b = a;
				b.a = b.b.c.Area;
				if (b.a != null)
				{
					ww.c c = new ww.c();
					c.e = b;
					c.d = (new ar7(new Guid("d4ac396e-10f7-4a61-8f0e-941c31813923"), c.e.b.c.Area).ao() as c5x);
					new ar7(c.d);
					c5x c5x = new ar7(new Guid("ddcf0026-3691-4d73-b3df-ed96068b2654"), c.e.a).ao() as c5x;
					c.a = new ar7();
					c.b = new ar7();
					c.c = new ar7();
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					bfq bfq = new bfq();
					bfq.c("TntExplode");
					array[num] = new ace(bfq)
					{
						TargetRef = a_
					};
					base.a(array);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.5))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					dva dva = new dva(null, null, null, null, null);
					dva.a(new Func<e6d, bool>(c.e.d));
					array2[num2] = dva;
					base.a(array2);
					if (c5x != null)
					{
						btm[] array3 = new btm[1];
						int num3 = 0;
						egx egx = new egx();
						egx.a("На нас напали!");
						array3[num3] = new ace(egx)
						{
							TargetRef = new ar7(c5x)
						};
						base.a(array3);
						btm[] array4 = new btm[1];
						int num4 = 0;
						s5 s = new s5();
						s.a(new ar7(c5x));
						s.a(new bt4("FromDownStairs"));
						s.IsAsync = true;
						s.a(true);
						array4[num4] = s;
						base.a(array4);
					}
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array5 = new btm[1];
					int num5 = 0;
					kw kw = new kw();
					kw.a(new bt4("secTrooper3"));
					array5[num5] = kw;
					base.a(array5);
					btm[] array6 = new btm[1];
					int num6 = 0;
					bfq bfq2 = new bfq();
					bfq2.c("pistolShot");
					array6[num6] = new ace(bfq2)
					{
						TargetRef = a_
					};
					base.a(array6);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.3))
					});
					btm[] array7 = new btm[1];
					int num7 = 0;
					dva dva2 = new dva(null, null, null, null, null);
					dva2.a(new Func<e6d, bool>(c.e.c));
					array7[num7] = dva2;
					base.a(array7);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array8 = new btm[1];
					int num8 = 0;
					bfq bfq3 = new bfq();
					bfq3.c("TntExplode");
					array8[num8] = new ace(bfq3)
					{
						TargetRef = a_
					};
					base.a(array8);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.5))
					});
					btm[] array9 = new btm[1];
					int num9 = 0;
					bfq bfq4 = new bfq();
					bfq4.c("pistolShot");
					array9[num9] = new ace(bfq4)
					{
						TargetRef = a_
					};
					base.a(array9);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.1))
					});
					btm[] array10 = new btm[1];
					int num10 = 0;
					bfq bfq5 = new bfq();
					bfq5.c("pistolShot");
					array10[num10] = new ace(bfq5)
					{
						TargetRef = a_
					};
					base.a(array10);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.1))
					});
					btm[] array11 = new btm[1];
					int num11 = 0;
					bfq bfq6 = new bfq();
					bfq6.c("pistolShot");
					array11[num11] = new ace(bfq6)
					{
						TargetRef = a_
					};
					base.a(array11);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array12 = new btm[1];
					int num12 = 0;
					bfq bfq7 = new bfq();
					bfq7.c("pistolShot");
					array12[num12] = new ace(bfq7)
					{
						TargetRef = a_
					};
					base.a(array12);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.4))
					});
					btm[] array13 = new btm[1];
					int num13 = 0;
					bfq bfq8 = new bfq();
					bfq8.c("FlashbangExplode");
					array13[num13] = new ace(bfq8)
					{
						TargetRef = a_
					};
					base.a(array13);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.6))
					});
					btm[] array14 = new btm[1];
					int num14 = 0;
					bfq bfq9 = new bfq();
					bfq9.c("TntExplode");
					array14[num14] = new ace(bfq9)
					{
						TargetRef = a_
					};
					base.a(array14);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					btm[] array15 = new btm[1];
					int num15 = 0;
					dva dva3 = new dva(null, null, null, null, null);
					dva3.a(new Func<e6d, bool>(c.b));
					array15[num15] = dva3;
					base.a(array15);
					btm[] array16 = new btm[1];
					int num16 = 0;
					s5 s2 = new s5();
					s2.a(c.a);
					s2.a(new bt4("secTrooper1"));
					s2.IsAsync = true;
					s2.a(true);
					array16[num16] = s2;
					base.a(array16);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array17 = new btm[1];
					int num17 = 0;
					dva dva4 = new dva(null, null, null, null, null);
					dva4.a(new Func<e6d, bool>(c.a));
					array17[num17] = dva4;
					base.a(array17);
					btm[] array18 = new btm[1];
					int num18 = 0;
					s5 s3 = new s5();
					s3.a(c.b);
					s3.a(new bt4("secTrooper2"));
					s3.IsAsync = true;
					s3.a(true);
					array18[num18] = s3;
					base.a(array18);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array19 = new btm[1];
					int num19 = 0;
					dva dva5 = new dva(null, null, null, null, null);
					dva5.a(new Func<e6d, bool>(c.d));
					array19[num19] = dva5;
					base.a(array19);
					btm[] array20 = new btm[1];
					int num20 = 0;
					s5 s4 = new s5();
					s4.a(c.c);
					s4.a(new bt4("secTrooper3"));
					s4.IsAsync = true;
					s4.a(true);
					array20[num20] = s4;
					base.a(array20);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.5))
					});
					btm[] array21 = new btm[1];
					int num21 = 0;
					dva dva6 = new dva(null, null, null, null, null);
					dva6.a(new Func<e6d, bool>(c.e));
					array21[num21] = dva6;
					base.a(array21);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array22 = new btm[1];
					int num22 = 0;
					dva dva7 = new dva(null, null, null, null, null);
					dva7.a(new Func<e6d, bool>(c.e.b.a));
					array22[num22] = dva7;
					base.a(array22);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.5))
					});
					btm[] array23 = new btm[1];
					int num23 = 0;
					egx egx2 = new egx();
					egx2.a("Зона охраняется. Мы забираем тебя обратно в лагерь.");
					array23[num23] = new ace(egx2)
					{
						TargetRef = c.c
					};
					base.a(array23);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					btm[] array24 = new btm[1];
					int num24 = 0;
					e2l e2l = new e2l();
					e2l.a("xpbl_e3");
					e2l.a(new b4w());
					array24[num24] = new ace(e2l);
					base.a(array24);
					base.a(new btm[]
					{
						new ace(new c8z("nospawn"))
						{
							InitiatorRef = a_
						}
					});
					btm[] array25 = new btm[1];
					int num25 = 0;
					dva dva8 = new dva(null, null, null, null, null);
					dva8.a(new Func<e6d, bool>(c.e.b.b));
					array25[num25] = dva8;
					base.a(array25);
					cky cky = (c.e.b.b.aqu().ac() as bv9).abu(asp.a, asp.f5);
					if ((cky != null && cky.a == h.a) || c.e.b.b.aqu().r().GetPrimitivePropertyValue<bool>("faction_xpbl_aegis_betrayed", new bool?(false)).Value)
					{
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						btm[] array26 = new btm[1];
						int num26 = 0;
						dva dva9 = new dva(null, null, null, null, null);
						dva9.a(new Func<e6d, bool>(c.c));
						array26[num26] = dva9;
						base.a(array26);
						btm[] array27 = new btm[1];
						int num27 = 0;
						egx egx3 = new egx();
						egx3.a("А что до тебя...");
						array27[num27] = new ace(egx3)
						{
							TargetRef = c.c
						};
						base.a(array27);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(3.0))
						});
						btm[] array28 = new btm[1];
						int num28 = 0;
						egx egx4 = new egx();
						egx4.a("Rot.");
						array28[num28] = new ace(egx4)
						{
							TargetRef = c.c
						};
						base.a(array28);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						btm[] array29 = new btm[1];
						int num29 = 0;
						dky dky = new dky();
						dky.a(0.2f);
						dky.a(false);
						array29[num29] = dky;
						base.a(array29);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array30 = new btm[1];
						int num30 = 0;
						dva dva10 = new dva(null, null, null, null, null);
						dva10.a(new Func<e6d, bool>(c.e.b));
						array30[num30] = dva10;
						base.a(array30);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.5))
						});
						btm[] array31 = new btm[1];
						int num31 = 0;
						c8s c8s = new c8s();
						c8s.a(0.2f);
						c8s.a(false);
						array31[num31] = c8s;
						base.a(array31);
					}
					else
					{
						btm[] array32 = new btm[1];
						int num32 = 0;
						dky dky2 = new dky();
						dky2.a(0.2f);
						dky2.a(false);
						array32[num32] = dky2;
						base.a(array32);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.5))
						});
						btm[] array33 = new btm[1];
						int num33 = 0;
						dva dva11 = new dva(null, null, null, null, null);
						dva11.a(new Func<e6d, bool>(c.e.a));
						array33[num33] = dva11;
						base.a(array33);
						base.a(new btm[]
						{
							new di4(new c2w("xpbl_d6", "player_oldTent"), false, new bool?(false), 0, null, true, false, false)
						});
					}
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000F42 RID: 3906
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004F1A RID: 20250 RVA: 0x0023AD24 File Offset: 0x00238F24
		internal bool a(e6d A_0)
		{
			this.c.VisualDirection = HorizontalDirection.Southwest;
			return true;
		}

		// Token: 0x06004F1B RID: 20251 RVA: 0x0023AD34 File Offset: 0x00238F34
		internal bool b(e6d A_0)
		{
			foreach (aud aud in Enumerable.ToList<aud>(this.c.Zone.Areas))
			{
				foreach (b0b b0b in Enumerable.ToList<b0b>(aud.Entities))
				{
					c5x c5x = (c5x)b0b;
					if (c5x != null && c5x.h.b != null && !c5x.h.b.aa().Dead && c5x.h.b.aa().FactionId.Contains("pirate"))
					{
						c5x.w();
						c5x.h.b.aa().a(null, null, false);
					}
				}
			}
			this.b.aqu().r()["quests_xpbl_expedition_professorSaved"] = true;
			this.b.aqu().r()["quests_xpbl_expedition_saveTheProfessor_professorAndPlayerRescuedFromJail"] = true;
			return true;
		}

		// Token: 0x04002071 RID: 8305
		public ww a;

		// Token: 0x04002072 RID: 8306
		public cnk b;

		// Token: 0x04002073 RID: 8307
		public c5x c;
	}

	// Token: 0x02000F43 RID: 3907
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004F1D RID: 20253 RVA: 0x0023AEA0 File Offset: 0x002390A0
		internal bool d(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.a);
			}
			foreach (b0b b0b in Enumerable.ToList<b0b>(this.a.Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x != null && c5x.h.b != null)
				{
					c5x.VisualDirection = HorizontalDirection.West;
				}
			}
			return true;
		}

		// Token: 0x06004F1E RID: 20254 RVA: 0x0023AF34 File Offset: 0x00239134
		internal bool c(e6d A_0)
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(this.a.Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x != null && c5x.h.b != null && c5x.h.b.aa().FactionId.Contains("pirate"))
				{
					di6 di = this.b.a;
					btm[] array = new btm[1];
					int num = 0;
					s5 s = new s5();
					s.a(new ar7(c5x));
					s.a(new bt4("FromDownStairs"));
					s.IsAsync = false;
					s.a(true);
					array[num] = s;
					di.a(array);
				}
			}
			return true;
		}

		// Token: 0x06004F1F RID: 20255 RVA: 0x0023B01C File Offset: 0x0023921C
		internal bool b(e6d A_0)
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(this.a.Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x != null && c5x.h.b != null && c5x.h.b.aa().FactionId.Contains("expedition"))
				{
					uk uk = new uk();
					uk.c(true);
					uk.b(false);
					uk.ym(null, c5x, null);
				}
			}
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			return true;
		}

		// Token: 0x06004F20 RID: 20256 RVA: 0x0023B0E8 File Offset: 0x002392E8
		internal bool a(e6d A_0)
		{
			foreach (b0b b0b in Enumerable.ToList<b0b>(this.a.Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x != null && c5x.h.b != null && c5x.h.b.aa().FactionId.Contains("expedition"))
				{
					uk uk = new uk();
					uk.c(true);
					uk.b(false);
					uk.ym(null, c5x, null);
				}
			}
			c5x c5x2 = new ar7(new Guid("939c37bb-b75c-439c-a535-262aa36c02ed"), this.b.c.Area).ao() as c5x;
			if (c5x2 != null)
			{
				c7j c7j = c5x2.s.b as c7j;
				d2b aspect = c5x2.GetAspect<d2b>();
				if (c7j != null)
				{
					foreach (coh a_ in Enumerable.ToList<coh>(c7j.ItemContainer.z2()))
					{
						c7j.ItemContainer.z5(a_);
						this.b.c.h.b.aa().Bag.z3(a_, true);
					}
				}
				if (aspect != null && aspect.n())
				{
					aspect.e(false);
				}
			}
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			return true;
		}

		// Token: 0x04002074 RID: 8308
		public aud a;

		// Token: 0x04002075 RID: 8309
		public ww.a b;
	}

	// Token: 0x02000F44 RID: 3908
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x06004F22 RID: 20258 RVA: 0x0023B2AC File Offset: 0x002394AC
		internal bool b(e6d A_0)
		{
			c5x a_ = vq.a("creatures\\generichumans\\xpbl\\aegisSecTrooperHeavyGunner", this.e.b.c.Zone.g("DownStairs"), false);
			this.a.a(a_);
			return true;
		}

		// Token: 0x06004F23 RID: 20259 RVA: 0x0023B2F4 File Offset: 0x002394F4
		internal bool a(e6d A_0)
		{
			c5x a_ = vq.a("creatures\\generichumans\\xpbl\\aegisSecTrooperShotgunner", this.e.b.c.Zone.g("DownStairs"), false);
			this.b.a(a_);
			return true;
		}

		// Token: 0x06004F24 RID: 20260 RVA: 0x0023B33C File Offset: 0x0023953C
		internal bool d(e6d A_0)
		{
			c5x a_;
			if (!this.e.b.b.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_yahota_dead", new bool?(false)).Value)
			{
				a_ = vq.a("creature\\characters\\xpbl\\Yahota", this.e.b.c.Zone.g("DownStairs"), false);
			}
			else
			{
				a_ = vq.a("creatures\\generichumans\\xpbl\\aegisSecTrooperHeavyGunner", this.e.b.c.Zone.g("DownStairs"), false);
			}
			this.c.a(a_);
			return true;
		}

		// Token: 0x06004F25 RID: 20261 RVA: 0x0023B3EC File Offset: 0x002395EC
		internal bool e(e6d A_0)
		{
			this.d.VisualDirection = HorizontalDirection.South;
			return true;
		}

		// Token: 0x06004F26 RID: 20262 RVA: 0x0023B3FC File Offset: 0x002395FC
		internal bool c(e6d A_0)
		{
			this.c.ao().VisualDirection = HorizontalDirection.Northeast;
			return true;
		}

		// Token: 0x04002076 RID: 8310
		public ar7 a;

		// Token: 0x04002077 RID: 8311
		public ar7 b;

		// Token: 0x04002078 RID: 8312
		public ar7 c;

		// Token: 0x04002079 RID: 8313
		public c5x d;

		// Token: 0x0400207A RID: 8314
		public ww.b e;
	}
}
