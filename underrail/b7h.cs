using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000CC0 RID: 3264
[e79("Xpbl_KirillLab1_PlayerJumpsInAcid")]
public sealed class b7h : dgy
{
	// Token: 0x06004974 RID: 18804 RVA: 0x001E8A5C File Offset: 0x001E6C5C
	public b7h()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			b7h.a a = new b7h.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			serviceOrThrow.aqu().a(new bw0("xpbl_kirillLab2", new b8(), 1));
			serviceOrThrow.aqu().r()["npc_xpbl_kirill_acidJump "] = true;
			if (a.a != null && a.a.Area != null)
			{
				b7h.b b = new b7h.b();
				b.c = a;
				b.a = b.c.a.Zone.g("jumpIntoAcid");
				b.b = b.c.a.Zone.g("swimExitAcid");
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				btm[] array = new btm[1];
				int num = 0;
				kw kw = new kw();
				kw.a(new bt4("jumpSpot"));
				kw.a(false);
				array[num] = kw;
				base.a(array);
				btm[] array2 = new btm[1];
				int num2 = 0;
				s5 s = new s5();
				s.a(new ar7(b.c.a));
				s.a(new bt4("jumpSpot"));
				s.IsAsync = true;
				s.a(false);
				array2[num2] = s;
				base.a(array2);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.c.d), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.c.c), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.75))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.c.b), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.5))
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				c6w c6w = new c6w();
				c6w.a(new ar7(b.c.a));
				c6w.IsAsync = false;
				c6w.a = new Func<auv>(b.b);
				array3[num3] = c6w;
				base.a(array3);
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(b.c.a), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				c6w c6w2 = new c6w();
				c6w2.a(new ar7(b.c.a));
				c6w2.IsAsync = true;
				c6w2.a = new Func<auv>(b.a);
				array4[num4] = c6w2;
				base.a(array4);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.25))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(11)))
					{
						TargetRef = new ar7(b.c.a)
					}
				});
				btm[] array5 = new btm[1];
				int num5 = 0;
				c6w c6w3 = new c6w();
				c6w3.a(new ar7(b.c.a));
				c6w3.IsAsync = false;
				c6w3.a = new Func<auv>(b.c.e);
				array5[num5] = c6w3;
				base.a(array5);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.25))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(10)))
					{
						TargetRef = new ar7(b.c.a)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.25))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(9)))
					{
						TargetRef = new ar7(b.c.a)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.25))
				});
				btm[] array6 = new btm[1];
				int num6 = 0;
				c6w c6w4 = new c6w();
				c6w4.a(new ar7(b.c.a));
				c6w4.IsAsync = false;
				c6w4.a = new Func<auv>(b.c.d);
				array6[num6] = c6w4;
				base.a(array6);
				base.a(new btm[]
				{
					new ace(new b16(new int?(10)))
					{
						TargetRef = new ar7(b.c.a)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.25))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(11)))
					{
						TargetRef = new ar7(b.c.a)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.25))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(12)))
					{
						TargetRef = new ar7(b.c.a)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.25))
				});
				btm[] array7 = new btm[1];
				int num7 = 0;
				c6w c6w5 = new c6w();
				c6w5.a(new ar7(b.c.a));
				c6w5.IsAsync = false;
				c6w5.a = new Func<auv>(b.c.c);
				array7[num7] = c6w5;
				base.a(array7);
				base.a(new btm[]
				{
					new ace(new b16(new int?(11)))
					{
						TargetRef = new ar7(b.c.a)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.25))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(10)))
					{
						TargetRef = new ar7(b.c.a)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.25))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(9)))
					{
						TargetRef = new ar7(b.c.a)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.25))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(10)))
					{
						TargetRef = new ar7(b.c.a)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.25))
				});
				btm[] array8 = new btm[1];
				int num8 = 0;
				c6w c6w6 = new c6w();
				c6w6.a(new ar7(b.c.a));
				c6w6.IsAsync = false;
				c6w6.a = new Func<auv>(b.c.b);
				array8[num8] = c6w6;
				base.a(array8);
				base.a(new btm[]
				{
					new ace(new b16(new int?(11)))
					{
						TargetRef = new ar7(b.c.a)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.25))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(12)))
					{
						TargetRef = new ar7(b.c.a)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.25))
				});
				base.a(new btm[]
				{
					new ace(new b16(new int?(11)))
					{
						TargetRef = new ar7(b.c.a)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.25))
				});
				btm[] array9 = new btm[1];
				int num9 = 0;
				c6w c6w7 = new c6w();
				c6w7.a(new ar7(b.c.a));
				c6w7.IsAsync = false;
				c6w7.a = new Func<auv>(b.c.a);
				array9[num9] = c6w7;
				base.a(array9);
				base.a(new btm[]
				{
					new ace(new b16(new int?(10)))
					{
						TargetRef = new ar7(b.c.a)
					}
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
				base.a(new btm[]
				{
					new di4(new c2w("xpbl_kirillLab2", "FromAcid"), true, new bool?(false), 0, null, true, false, false)
				});
			}
		}
	}

	// Token: 0x02000CC1 RID: 3265
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004976 RID: 18806 RVA: 0x001E945C File Offset: 0x001E765C
		internal bool d(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.East;
			return true;
		}

		// Token: 0x06004977 RID: 18807 RVA: 0x001E946C File Offset: 0x001E766C
		internal bool c(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.Northeast;
			return true;
		}

		// Token: 0x06004978 RID: 18808 RVA: 0x001E947C File Offset: 0x001E767C
		internal bool b(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.North;
			return true;
		}

		// Token: 0x06004979 RID: 18809 RVA: 0x001E9490 File Offset: 0x001E7690
		internal bool a(e6d A_0)
		{
			this.a.h.b.aa().MovementSpeed = 0.6f;
			this.a.h.b.ap = new CharacterState?(CharacterState.Custom4);
			this.a.h.b.aq = new int?(12);
			this.a.x = true;
			return true;
		}

		// Token: 0x0600497A RID: 18810 RVA: 0x001E9504 File Offset: 0x001E7704
		internal auv e()
		{
			awx awx = new awx();
			awx.a(awx.kh() | m7.b);
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new bfq("AcidFizz"), null, null, null);
			a4s.b(new ar7(this.a));
			list.Add(a4s);
			Vector3 a_ = new Vector3(this.a.Location.X, this.a.Location.Y, this.a.Location.Z - 0.2f);
			awx.ad().Add(new au0(this.a.Area, a_, "xpbl_JetskiWave_WaterDustDirty", 1, double.MaxValue, new float?(0.9f), null, null));
			return awx;
		}

		// Token: 0x0600497B RID: 18811 RVA: 0x001E95D8 File Offset: 0x001E77D8
		internal auv d()
		{
			awx awx = new awx();
			awx.a(awx.kh() | m7.b);
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new bfq("xpbl_AcidLeak"), null, null, null);
			a4s.b(new ar7(this.a));
			list.Add(a4s);
			Vector3 a_ = new Vector3(this.a.Location.X, this.a.Location.Y, this.a.Location.Z - 0.6f);
			awx.ad().Add(new au0(this.a.Area, a_, "xpbl_JetskiWave_WaterDustDirty", 1, double.MaxValue, new float?(0.9f), null, null));
			return awx;
		}

		// Token: 0x0600497C RID: 18812 RVA: 0x001E96AC File Offset: 0x001E78AC
		internal auv c()
		{
			awx awx = new awx();
			awx.a(awx.kh() | m7.b);
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new bfq("AcidFizz"), null, null, null);
			a4s.b(new ar7(this.a));
			list.Add(a4s);
			Vector3 a_ = new Vector3(this.a.Location.X, this.a.Location.Y, this.a.Location.Z - 0.6f);
			awx.ad().Add(new au0(this.a.Area, a_, "xpbl_JetskiWave_WaterDustDirty", 1, double.MaxValue, new float?(0.9f), null, null));
			return awx;
		}

		// Token: 0x0600497D RID: 18813 RVA: 0x001E9780 File Offset: 0x001E7980
		internal auv b()
		{
			awx awx = new awx();
			awx.a(awx.kh() | m7.b);
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new bfq("xpbl_AcidLeak"), null, null, null);
			a4s.b(new ar7(this.a));
			list.Add(a4s);
			Vector3 a_ = new Vector3(this.a.Location.X, this.a.Location.Y, this.a.Location.Z - 0.6f);
			awx.ad().Add(new au0(this.a.Area, a_, "xpbl_JetskiWave_WaterDustDirty", 1, double.MaxValue, new float?(0.9f), null, null));
			return awx;
		}

		// Token: 0x0600497E RID: 18814 RVA: 0x001E9854 File Offset: 0x001E7A54
		internal auv a()
		{
			awx awx = new awx();
			awx.a(awx.kh() | m7.b);
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new bfq("AcidFizz"), null, null, null);
			a4s.b(new ar7(this.a));
			list.Add(a4s);
			Vector3 a_ = new Vector3(this.a.Location.X, this.a.Location.Y, this.a.Location.Z - 0.6f);
			awx.ad().Add(new au0(this.a.Area, a_, "xpbl_JetskiWave_WaterDustDirty", 1, double.MaxValue, new float?(0.9f), null, null));
			return awx;
		}

		// Token: 0x04001D13 RID: 7443
		public c5x a;
	}

	// Token: 0x02000CC2 RID: 3266
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004980 RID: 18816 RVA: 0x001E9934 File Offset: 0x001E7B34
		internal auv b()
		{
			awx awx = new awx();
			awx awx2 = awx;
			awx2.a(awx2.kh() | m7.b);
			float num = 0f;
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new b16(new int?(0)), null, null, null);
			a4s.b(new ar7(this.c.a));
			list.Add(a4s);
			List<auv> list2 = awx.ad();
			a4s a4s2 = new a4s(new epw(new CharacterState?(CharacterState.Custom3)), null, null, null);
			a4s2.b(new ar7(this.c.a));
			list2.Add(a4s2);
			List<auv> list3 = awx.ad();
			a4s a4s3 = new a4s(new b16(new int?(0)), null, null, null);
			a4s3.b(new ar7(this.c.a));
			list3.Add(a4s3);
			for (int i = 0; i <= 25; i++)
			{
				if (i <= 12)
				{
					List<auv> list4 = awx.ad();
					a4s a4s4 = new a4s(new epw(new CharacterState?(CharacterState.Custom3)), null, null, null);
					a4s4.b(new ar7(this.c.a));
					list4.Add(a4s4);
					List<auv> list5 = awx.ad();
					a4s a4s5 = new a4s(new b16(new int?(i)), null, null, null);
					a4s5.b(new ar7(this.c.a));
					list5.Add(a4s5);
				}
				else if (i > 13)
				{
					List<auv> list6 = awx.ad();
					a4s a4s6 = new a4s(new b16(new int?(i - 13)), null, null, null);
					a4s6.b(new ar7(this.c.a));
					list6.Add(a4s6);
					List<auv> list7 = awx.ad();
					a4s a4s7 = new a4s(new epw(new CharacterState?(CharacterState.Custom4)), null, null, null);
					a4s7.b(new ar7(this.c.a));
					list7.Add(a4s7);
				}
				if (i >= 5 && i <= 12)
				{
					if (i > 9)
					{
						num -= 0.15f;
					}
					else
					{
						num += 0.1f;
					}
					if (i < 9)
					{
						awx.ad().Add(new a8v(this.c.a, new Vector3(this.c.a.Location.X, this.c.a.Location.Y - (((float)i + 3f) / 6f - 1.1f), this.c.a.Location.Z + num)));
						awx.ad().Add(new bm3(1));
						awx.ad().Add(new a8v(this.c.a, new Vector3(this.c.a.Location.X, this.c.a.Location.Y - (((float)i + 3f) / 6f - 1.1f), this.c.a.Location.Z + num)));
					}
					else
					{
						awx.ad().Add(new a8v(this.c.a, new Vector3(this.c.a.Location.X, this.c.a.Location.Y - (((float)i + 3f) / 6f - 0.75f), this.c.a.Location.Z + num)));
						awx.ad().Add(new bm3(1));
						awx.ad().Add(new a8v(this.c.a, new Vector3(this.c.a.Location.X, this.c.a.Location.Y - (((float)i + 3f) / 6f - 0.75f), this.c.a.Location.Z + num)));
					}
				}
				if (i == 15)
				{
					List<auv> list8 = awx.ad();
					a4s a4s8 = new a4s(new bfq("WaterSplashGiant"), null, null, null);
					a4s8.b(new ar7(this.c.a));
					list8.Add(a4s8);
					awx.ad().Add(new au0(this.c.a.Area, this.a.Location, "WaterSplashLargeDirty", 1, double.MaxValue, null, null, null));
				}
				awx.ad().Add(new bm3(5));
			}
			return awx;
		}

		// Token: 0x06004981 RID: 18817 RVA: 0x001E9DCC File Offset: 0x001E7FCC
		internal auv a()
		{
			awx awx = new awx();
			awx.a(awx.kh() | m7.b);
			List<auv> list = awx.ad();
			bpr bpr = new bpr(this.c.a.j.b, new Vector3(this.b.Location.X, this.b.Location.Y, this.b.Location.Z + 0.8f));
			bpr.a(false);
			list.Add(bpr);
			return awx;
		}

		// Token: 0x04001D14 RID: 7444
		public csd a;

		// Token: 0x04001D15 RID: 7445
		public csd b;

		// Token: 0x04001D16 RID: 7446
		public b7h.a c;
	}
}
