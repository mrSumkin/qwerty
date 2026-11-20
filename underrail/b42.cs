using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000E02 RID: 3586
[e79("Tch_RitualRoomInvasion")]
public sealed class b42 : dgy
{
	// Token: 0x06004C3E RID: 19518 RVA: 0x00213CF0 File Offset: 0x00211EF0
	public b42()
	{
		b42.c c = new b42.c();
		c.a = bpo.GetServiceOrThrow<cnk>();
		if (c.a != null && c.a.aqu() != null)
		{
			b42.b b = new b42.b();
			new dvn(c.a.ar0(c.a.aqu().c().b(), c.a.aqu()).Id, "Faceless").ym(null, null, null);
			bool value = c.a.aqu().r().GetPrimitivePropertyValue<bool>("loc_tch_eideinUsesElevator", new bool?(false)).Value;
			c.a.aqz().atb("tch_escapeTheInstitute", true);
			c.a.aqu().r()["loc_tch_allowedPassage"] = true;
			b.a = (c.a.aqu().v().b() as c5x);
			if (b.a != null)
			{
				b.b = b.a.Area;
				if (b.b != null)
				{
					b42.a a = new b42.a();
					string[] array = new string[]
					{
						"creatures\\Faceless\\FacelessCentaur",
						"creature\\Faceless\\FacelessSoldier-AssaultRifle",
						"creature\\Faceless\\FacelessSoldier-EnergyPistol",
						"creatures\\Faceless\\FacelessDoctor",
						"creatures\\Faceless\\FacelessMindreader"
					};
					string[] array2 = new string[]
					{
						"facelessIn2",
						"facelessIn5",
						"facelessIn3",
						"facelessIn4",
						"facelessIn1"
					};
					a.f = new List<c5x>();
					for (int i = 0; i < 5; i++)
					{
						c5x c5x = vq.a(array[i], b.b.Zone.g("fb" + (i + 1).ToString()), false);
						a.f.Add(c5x);
						c5x.t.b.y6()[ddq.ay] = new bt4("facelessGuard" + (i + 1).ToString());
						c5x.h.b.ap = new CharacterState?(CharacterState.Attack1);
						c5x.h.b.aq = new int?(0);
						a6p aspect = c5x.GetAspect<a6p>();
						if (aspect != null)
						{
							aspect.d().Add("-jobs");
						}
						c5x.h.b.ay().Clear();
					}
					a.b = (new ar7(new Guid("bd00f015-1b3b-4b25-86d2-bc5a418b5aa4"), b.a.Area).ao() as c5x);
					a.a = (new ar7(new Guid("fa4af03c-26e5-4107-93ea-bb94815b0be0"), b.a.Area).ao() as c5x);
					a.d = (new ar7(new Guid("67fa931a-325c-4ebd-bd86-a541b3ba8cd2"), b.a.Area).ao() as c5x);
					a.c = (new ar7(new Guid("b7322195-9bfe-42a2-be9a-fb1afd97fbe0"), b.a.Area).ao() as c5x);
					d02 service = bpo.GetService<d02>();
					a.e = new List<amc>();
					if (service != null)
					{
						foreach (d4n d4n in service.ahl())
						{
							if (!d4n.b.aa().Dead && d4n.b.aa().FactionId == asp.es && d4n.b.ap == null)
							{
								a.e.Add(d4n.b);
							}
						}
					}
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array3 = new btm[1];
					int num = 0;
					dva dva = new dva(null, null, null, null, null);
					dva.a(new Func<e6d, bool>(b42.d.a.a));
					array3[num] = dva;
					base.a(array3);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(0.5))
					});
					if (value)
					{
						btm[] array4 = new btm[1];
						int num2 = 0;
						s5 s = new s5();
						s.a(new ar7(a.a));
						s.a(new bt4("eideinElevator"));
						s.IsAsync = false;
						array4[num2] = s;
						base.a(array4);
						btm[] array5 = new btm[1];
						int num3 = 0;
						dva dva2 = new dva(null, null, null, null, null);
						dva2.a(new Func<e6d, bool>(a.d));
						array5[num3] = dva2;
						base.a(array5);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.5))
						});
						btm[] array6 = new btm[1];
						int num4 = 0;
						bb8 bb = new bb8();
						bb.a(CharacterState.OperateShort);
						bb.a(atp.a);
						bb.IsAsync = false;
						bb.a(new ar7(a.a));
						bb.b(1);
						array6[num4] = bb;
						base.a(array6);
						base.a(new btm[]
						{
							new ace(new a9r())
							{
								InitiatorRef = new ar7(b.a)
							}
						});
						base.a(new btm[]
						{
							new ace(new bfq("ElevatorRespond"))
							{
								TargetRef = new ar7(b.a)
							}
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
					}
					else
					{
						base.a(new btm[]
						{
							new ace(new a9r())
							{
								InitiatorRef = new ar7(b.a)
							}
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
					}
					btm[] array7 = new btm[1];
					int num5 = 0;
					kw kw = new kw();
					kw.a(new bt4("messenger2"));
					array7[num5] = kw;
					base.a(array7);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					if (a.b != null)
					{
						btm[] array8 = new btm[1];
						int num6 = 0;
						dva dva3 = new dva(null, null, null, null, null);
						dva3.a(new Func<e6d, bool>(a.c));
						array8[num6] = dva3;
						base.a(array8);
						if (a.c != null)
						{
							btm[] array9 = new btm[1];
							int num7 = 0;
							dva dva4 = new dva(null, null, null, null, null);
							dva4.a(new Func<e6d, bool>(a.b));
							array9[num7] = dva4;
							base.a(array9);
						}
						btm[] array10 = new btm[1];
						int num8 = 0;
						egx egx = new egx();
						egx.a("Безликие... они здесь!");
						array10[num8] = new ace(egx)
						{
							TargetRef = new ar7(a.b)
						};
						base.a(array10);
						btm[] array11 = new btm[1];
						int num9 = 0;
						s5 s2 = new s5();
						s2.a(new ar7(a.b));
						s2.a(new bt4("messenger2"));
						s2.IsAsync = true;
						array11[num9] = s2;
						base.a(array11);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						if (a.d != null)
						{
							btm[] array12 = new btm[1];
							int num10 = 0;
							dva dva5 = new dva(null, null, null, null, null);
							dva5.a(new Func<e6d, bool>(a.g));
							array12[num10] = dva5;
							base.a(array12);
						}
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.25))
						});
						btm[] array13 = new btm[1];
						int num11 = 0;
						c6w c6w = new c6w();
						c6w.a = new Func<auv>(b.a);
						c6w.a(new ar7(a.b));
						array13[num11] = c6w;
						base.a(array13);
						btm[] array14 = new btm[1];
						int num12 = 0;
						dva dva6 = new dva(null, null, null, null, null);
						dva6.a(new Func<e6d, bool>(a.f));
						array14[num12] = dva6;
						base.a(array14);
						btm[] array15 = new btm[1];
						int num13 = 0;
						dva dva7 = new dva(null, null, null, null, null);
						dva7.a(new Func<e6d, bool>(a.e));
						array15[num13] = dva7;
						base.a(array15);
					}
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.5))
					});
					for (int j = 0; j < a.f.Count; j++)
					{
						base.a(new btm[]
						{
							new ace(new be6
							{
								DestinationWaypoint = array2[j]
							})
							{
								InitiatorRef = new ar7(a.f[j])
							}
						});
						btm[] array16 = new btm[1];
						int num14 = 0;
						s5 s3 = new s5();
						s3.a(new ar7(a.f[j]));
						s3.a(new bt4("fc" + (j + 1).ToString()));
						s3.IsAsync = true;
						array16[num14] = s3;
						base.a(array16);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.5))
						});
					}
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array17 = new btm[1];
					int num15 = 0;
					kw kw2 = new kw();
					kw2.a(new bt4("eideinElevator"));
					array17[num15] = kw2;
					base.a(array17);
					if (a.a != null)
					{
						btm[] array18 = new btm[1];
						int num16 = 0;
						egx egx2 = new egx();
						egx2.a("Защищайте лифт!");
						array18[num16] = new ace(egx2)
						{
							TargetRef = new ar7(a.a)
						};
						base.a(array18);
					}
					btm[] array19 = new btm[1];
					int num17 = 0;
					dva dva8 = new dva(null, null, null, null, null);
					dva8.a(new Func<e6d, bool>(a.a));
					array19[num17] = dva8;
					base.a(array19);
					btm[] array20 = new btm[1];
					int num18 = 0;
					dva dva9 = new dva(null, null, null, null, null);
					dva9.a(new Func<e6d, bool>(c.a));
					array20[num18] = dva9;
					base.a(array20);
					base.a(new btm[]
					{
						new ace(new ag1())
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000E03 RID: 3587
	[CompilerGenerated]
	[Serializable]
	private new sealed class d
	{
		// Token: 0x06004C41 RID: 19521 RVA: 0x0021476C File Offset: 0x0021296C
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.a);
			}
			return true;
		}

		// Token: 0x04001ED3 RID: 7891
		public static readonly b42.d a = new b42.d();

		// Token: 0x04001ED4 RID: 7892
		public static Func<e6d, bool> b;
	}

	// Token: 0x02000E04 RID: 3588
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x06004C43 RID: 19523 RVA: 0x0021479C File Offset: 0x0021299C
		internal bool a(e6d A_0)
		{
			this.a.aqu().r()["loc_tch_elevatorCalled"] = true;
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			return true;
		}

		// Token: 0x04001ED5 RID: 7893
		public cnk a;
	}

	// Token: 0x02000E05 RID: 3589
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004C45 RID: 19525 RVA: 0x002147EC File Offset: 0x002129EC
		internal auv a()
		{
			dtb dtb = new dtb();
			dtb.ad().Add(new a4s(new bfq("LaserShoot"), null, new ar7(this.a), null));
			b0b a_;
			dtb.ad().Add(es2.a(new Vector3(0.7f, 11f, 2.7f), new Vector3(7f, 11f, 1f), this.b, "RedLaser", null, out a_));
			dtb.ad().Add(new au0(this.b, new Vector3(7f, 11f, 1f), "LaserHit", 1, double.MaxValue, null, null, null));
			dtb.ad().Add(new a4s(new bfq("LaserHit"), null, new ar7(this.a), null));
			dtb.ad().Add(new c7(a_, false, false, true, false));
			return dtb;
		}

		// Token: 0x04001ED6 RID: 7894
		public c5x a;

		// Token: 0x04001ED7 RID: 7895
		public aud b;
	}

	// Token: 0x02000E06 RID: 3590
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004C47 RID: 19527 RVA: 0x00214908 File Offset: 0x00212B08
		internal bool d(e6d A_0)
		{
			d2b d2b = new EntityAspectReference<d2b, d2b>(this.a.Area, new Guid("20ff6489-7d39-4f3a-98a6-79b973070c18")).ao();
			if (d2b != null)
			{
				d2b.a(true, false);
			}
			this.a.VisualDirection = HorizontalDirection.Northeast;
			return true;
		}

		// Token: 0x06004C48 RID: 19528 RVA: 0x00214954 File Offset: 0x00212B54
		internal bool c(e6d A_0)
		{
			new be6
			{
				DestinationWaypoint = "messenger1"
			}.ym(this.b, null, null);
			return true;
		}

		// Token: 0x06004C49 RID: 19529 RVA: 0x00214974 File Offset: 0x00212B74
		internal bool b(e6d A_0)
		{
			this.c.VisualDirection = HorizontalDirection.North;
			return true;
		}

		// Token: 0x06004C4A RID: 19530 RVA: 0x00214984 File Offset: 0x00212B84
		internal bool g(e6d A_0)
		{
			aw1.b(this.d, this.b, false);
			return true;
		}

		// Token: 0x06004C4B RID: 19531 RVA: 0x0021499C File Offset: 0x00212B9C
		internal bool f(e6d A_0)
		{
			this.b.h.b.a(null, false);
			return true;
		}

		// Token: 0x06004C4C RID: 19532 RVA: 0x002149B8 File Offset: 0x00212BB8
		internal bool e(e6d A_0)
		{
			foreach (amc amc in this.e)
			{
				if (!amc.aa().Dead)
				{
					amc.ap = new CharacterState?(CharacterState.Attack1);
					amc.aq = new int?(0);
				}
			}
			return true;
		}

		// Token: 0x06004C4D RID: 19533 RVA: 0x00214A34 File Offset: 0x00212C34
		internal bool a(e6d A_0)
		{
			foreach (amc amc in this.e)
			{
				if (!amc.aa().Dead)
				{
					amc.ap = null;
					amc.aq = null;
				}
			}
			foreach (c5x c5x in this.f)
			{
				if (!c5x.h.b.aa().Dead)
				{
					c5x.h.b.ap = null;
					c5x.h.b.aq = null;
				}
			}
			return true;
		}

		// Token: 0x04001ED8 RID: 7896
		public c5x a;

		// Token: 0x04001ED9 RID: 7897
		public c5x b;

		// Token: 0x04001EDA RID: 7898
		public c5x c;

		// Token: 0x04001EDB RID: 7899
		public c5x d;

		// Token: 0x04001EDC RID: 7900
		public List<amc> e;

		// Token: 0x04001EDD RID: 7901
		public List<c5x> f;
	}
}
