using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02000CAC RID: 3244
[e79("Lup_GrampusBranding")]
public sealed class e2h : dgy
{
	// Token: 0x06004937 RID: 18743 RVA: 0x001E1A40 File Offset: 0x001DFC40
	public e2h()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			e2h.a a = new e2h.a();
			a.b = (serviceOrThrow.aqu().v().b() as c5x);
			a.a = (new ar7(new Guid("67b56918-c61d-46ec-9e28-7df8b70863b4"), a.b.Area).ao() as c5x);
			a.c = new a7j(a.b, "BloodImpact", 1, double.MaxValue, true, true, null, null, null, null, false, null);
			if (a.b != null && a.a != null)
			{
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				btm[] array = new btm[1];
				int num = 0;
				kw kw = new kw();
				kw.a(new bt4("lup-grampus", new Vector3(5f, 5f, 0f)));
				kw.IsAsync = false;
				kw.a(true);
				array[num] = kw;
				base.a(array);
				btm[] array2 = new btm[1];
				int num2 = 0;
				s5 s = new s5();
				s.a(new ar7(a.b));
				s.a(new bt4("player_move1"));
				s.IsAsync = true;
				s.a(true);
				array2[num2] = s;
				base.a(array2);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				s5 s2 = new s5();
				s2.a(new ar7(a.a));
				s2.a(new bt4("grampus_move1"));
				s2.IsAsync = true;
				s2.a(true);
				array3[num3] = s2;
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				egx egx = new egx();
				egx.a("Встань лицом к этой стене... и не знай страха. ::Он хохочет.::");
				egx.a(true);
				array4[num4] = new ace(egx)
				{
					TargetRef = new ar7(a.a)
				};
				base.a(array4);
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.d), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array5 = new btm[1];
				int num5 = 0;
				s5 s3 = new s5();
				s3.a(new ar7(a.b));
				s3.a(new bt4("player_move2"));
				s3.IsAsync = true;
				s3.a(true);
				array5[num5] = s3;
				base.a(array5);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(5.0))
				});
				btm[] array6 = new btm[1];
				int num6 = 0;
				egx egx2 = new egx();
				egx2.a("Давай...");
				egx2.a(true);
				array6[num6] = new ace(egx2)
				{
					TargetRef = new ar7(a.b)
				};
				base.a(array6);
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_grampus_whip", new bool?(false)).Value)
				{
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array7 = new btm[1];
					int num7 = 0;
					bb8 bb = new bb8();
					bb.a(CharacterState.Attack1);
					bb.a(cux.m);
					bb.a(atp.a);
					bb.IsAsync = false;
					bb.a(new ar7(a.a));
					bb.b(1);
					array7[num7] = bb;
					base.a(array7);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.c), null, null, null)
					});
					btm[] array8 = new btm[1];
					int num8 = 0;
					egx egx3 = new egx();
					egx3.a("Кх-хкх-х...");
					egx3.a(true);
					array8[num8] = new ace(egx3)
					{
						TargetRef = new ar7(a.b)
					};
					base.a(array8);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.3))
					});
					btm[] array9 = new btm[1];
					int num9 = 0;
					bb8 bb2 = new bb8();
					bb2.a(CharacterState.Attack2);
					bb2.a(cux.m);
					bb2.a(atp.a);
					bb2.IsAsync = false;
					bb2.a(new ar7(a.a));
					bb2.b(1);
					array9[num9] = bb2;
					base.a(array9);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.b), null, null, null)
					});
					btm[] array10 = new btm[1];
					int num10 = 0;
					egx egx4 = new egx();
					egx4.a("Ар-ргр!");
					egx4.a(new Color?(new Color(255, 0, 0)));
					egx4.a(true);
					array10[num10] = new ace(egx4)
					{
						TargetRef = new ar7(a.b)
					};
					base.a(array10);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.3))
					});
					btm[] array11 = new btm[1];
					int num11 = 0;
					bb8 bb3 = new bb8();
					bb3.a(CharacterState.Attack1);
					bb3.a(cux.m);
					bb3.a(atp.a);
					bb3.IsAsync = false;
					bb3.a(new ar7(a.a));
					bb3.b(1);
					array11[num11] = bb3;
					base.a(array11);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
					btm[] array12 = new btm[1];
					int num12 = 0;
					egx egx5 = new egx();
					egx5.a("A-A-AХ-х-х!");
					egx5.a(new Color?(new Color(255, 0, 0)));
					egx5.a(true);
					array12[num12] = new ace(egx5)
					{
						TargetRef = new ar7(a.b)
					};
					base.a(array12);
				}
				else
				{
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					btm[] array13 = new btm[1];
					int num13 = 0;
					c6w c6w = new c6w();
					c6w.a(new ar7(a.a));
					c6w.IsAsync = false;
					c6w.a = new Func<auv>(a.a);
					array13[num13] = c6w;
					base.a(array13);
				}
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.f), null, null, null)
				});
				btm[] array14 = new btm[1];
				int num14 = 0;
				c93 c = new c93();
				c.a("Firebranded");
				c.a(true);
				array14[num14] = new ace(c);
				base.a(array14);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.25))
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.e), null, null, null)
				});
			}
		}
	}

	// Token: 0x02000CAD RID: 3245
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004939 RID: 18745 RVA: 0x001E2148 File Offset: 0x001E0348
		internal bool d(e6d A_0)
		{
			cd1 cd = Enumerable.FirstOrDefault<coh>(this.a.h.b.aa().Bag.b("firebrand")) as cd1;
			if (cd != null)
			{
				if (this.a.h.b.aa().Gear.j()[WeaponKey.Primary].Item != null)
				{
					this.a.h.b.aa().Bag.z3(this.a.h.b.aa().Gear.j()[WeaponKey.Primary].Item, true);
					this.a.h.b.aa().Gear.j()[WeaponKey.Primary].b(null);
				}
				this.a.h.b.aa().Gear.j()[WeaponKey.Primary].b(cd);
				this.a.h.b.aa().Bag.z5(cd);
			}
			return true;
		}

		// Token: 0x0600493A RID: 18746 RVA: 0x001E2280 File Offset: 0x001E0480
		internal bool c(e6d A_0)
		{
			new dld().b(this.a, this.b, null);
			this.b.Zone.ActionManager.g9(this.c, atp.a);
			return true;
		}

		// Token: 0x0600493B RID: 18747 RVA: 0x001E22C4 File Offset: 0x001E04C4
		internal bool b(e6d A_0)
		{
			new dld().b(this.a, this.b, null);
			this.b.Zone.ActionManager.g9(this.c, atp.a);
			return true;
		}

		// Token: 0x0600493C RID: 18748 RVA: 0x001E2308 File Offset: 0x001E0508
		internal bool a(e6d A_0)
		{
			new dld().b(this.a, this.b, null);
			this.b.Zone.ActionManager.g9(this.c, atp.a);
			return true;
		}

		// Token: 0x0600493D RID: 18749 RVA: 0x001E234C File Offset: 0x001E054C
		internal auv a()
		{
			au0 item = new au0(this.b.Area, this.b.Location, "BloodImpact", 1, double.MaxValue, null, null, null);
			awx awx = new awx();
			awx awx2 = awx;
			awx2.a(awx2.kh() | m7.b);
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new b16(new int?(0)), null, null, null);
			a4s.b(new ar7(this.a));
			list.Add(a4s);
			List<auv> list2 = awx.ad();
			a4s a4s2 = new a4s(new epw(new CharacterState?(CharacterState.Attack1)), null, null, null);
			a4s2.b(new ar7(this.a));
			list2.Add(a4s2);
			List<auv> list3 = awx.ad();
			a4s a4s3 = new a4s(new b16(new int?(0)), null, null, null);
			a4s3.b(new ar7(this.a));
			list3.Add(a4s3);
			int a_ = 7;
			for (int i = 0; i <= 32; i++)
			{
				if (i == 3)
				{
					awx.ad().Add(new eae("LUPGBP", null, null, null));
					a_ = 75;
					List<auv> list4 = awx.ad();
					egx egx = new egx();
					egx.a("НАААХХ!");
					egx.a(new Color?(new Color(255, 0, 0)));
					egx.a(true);
					a4s a4s4 = new a4s(egx, null, null, null);
					a4s4.b(new ar7(this.b));
					list4.Add(a4s4);
					awx.ad().Add(item);
				}
				if (i == 11)
				{
					List<auv> list5 = awx.ad();
					bfq bfq = new bfq("Searing");
					bfq.a(0.4f);
					a4s a4s5 = new a4s(bfq, null, null, null);
					a4s5.b(new ar7(this.b));
					list5.Add(a4s5);
					awx.ad().Add(item);
					List<auv> list6 = awx.ad();
					egx egx2 = new egx();
					egx2.a("А-А-А ха-а-а-а!");
					egx2.a(new Color?(new Color(255, 0, 0)));
					egx2.a(true);
					a4s a4s6 = new a4s(egx2, null, null, null);
					a4s6.b(new ar7(this.b));
					list6.Add(a4s6);
				}
				if (i == 22)
				{
					List<auv> list7 = awx.ad();
					a4s a4s7 = new a4s(new bfq("Searing"), null, null, null);
					a4s7.b(new ar7(this.b));
					list7.Add(a4s7);
					awx.ad().Add(item);
					List<auv> list8 = awx.ad();
					egx egx3 = new egx();
					egx3.a("А-ах-х-х...");
					egx3.a(new Color?(new Color(255, 0, 0)));
					egx3.a(true);
					a4s a4s8 = new a4s(egx3, null, null, null);
					a4s8.b(new ar7(this.b));
					list8.Add(a4s8);
				}
				if (i <= 2)
				{
					List<auv> list9 = awx.ad();
					a4s a4s9 = new a4s(new epw(new CharacterState?(CharacterState.Attack1)), null, null, null);
					a4s9.b(new ar7(this.a));
					list9.Add(a4s9);
					List<auv> list10 = awx.ad();
					a4s a4s10 = new a4s(new b16(new int?(i + 1)), null, null, null);
					a4s10.b(new ar7(this.a));
					list10.Add(a4s10);
				}
				else if (i > 3 && i < 30)
				{
					List<auv> list11 = awx.ad();
					a4s a4s11 = new a4s(new epw(new CharacterState?(CharacterState.Attack1)), null, null, null);
					a4s11.b(new ar7(this.a));
					list11.Add(a4s11);
					List<auv> list12 = awx.ad();
					a4s a4s12 = new a4s(new b16(new int?(3)), null, null, null);
					a4s12.b(new ar7(this.a));
					list12.Add(a4s12);
				}
				else if (i >= 30)
				{
					List<auv> list13 = awx.ad();
					a4s a4s13 = new a4s(new epw(new CharacterState?(CharacterState.Attack1)), null, null, null);
					a4s13.b(new ar7(this.a));
					list13.Add(a4s13);
					a_ = 15;
					List<auv> list14 = awx.ad();
					a4s a4s14 = new a4s(new b16(new int?(i - 27)), null, null, null);
					a4s14.b(new ar7(this.a));
					list14.Add(a4s14);
				}
				awx.ad().Add(new bm3(a_));
			}
			List<auv> list15 = awx.ad();
			a4s a4s15 = new a4s(new b16(null), null, null, null);
			a4s15.b(new ar7(this.a));
			list15.Add(a4s15);
			List<auv> list16 = awx.ad();
			a4s a4s16 = new a4s(new epw(null), null, null, null);
			a4s16.b(new ar7(this.a));
			list16.Add(a4s16);
			return awx;
		}

		// Token: 0x0600493E RID: 18750 RVA: 0x001E27DC File Offset: 0x001E09DC
		internal bool f(e6d A_0)
		{
			this.a.h.b.aa().Bag.z3(this.a.h.b.aa().Gear.j()[WeaponKey.Primary].Item, true);
			this.a.h.b.aa().Gear.j()[WeaponKey.Primary].b(null);
			cd1 cd = null;
			foreach (coh coh in Enumerable.ToList<coh>(this.a.h.b.aa().Bag.z2()))
			{
				if (coh is cd1 && (coh as cd1).TypedDefinition.ae().GetValueOrDefault() == WeaponSubtype.Spear)
				{
					cd = (coh as cd1);
				}
			}
			if (cd != null)
			{
				this.a.h.b.aa().Gear.j()[WeaponKey.Primary].b(cd);
				this.a.h.b.aa().Bag.z5(cd);
			}
			return true;
		}

		// Token: 0x0600493F RID: 18751 RVA: 0x001E294C File Offset: 0x001E0B4C
		internal bool e(e6d A_0)
		{
			this.b.GetAspect<j7>().a(this.a.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001CF5 RID: 7413
		public c5x a;

		// Token: 0x04001CF6 RID: 7414
		public c5x b;

		// Token: 0x04001CF7 RID: 7415
		public a7j c;
	}
}
