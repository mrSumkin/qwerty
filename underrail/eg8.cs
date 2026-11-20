using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000D74 RID: 3444
[e79("Xpbl_Wumb2_Arrival")]
public sealed class eg8 : dgy
{
	// Token: 0x06004B00 RID: 19200 RVA: 0x00204028 File Offset: 0x00202228
	public eg8()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			eg8.a a = new eg8.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null && a.a.Area != null)
			{
				eg8.b b = new eg8.b();
				b.e = a;
				b.d = (new ar7(new Guid("3fb178ab-ee1d-4ac2-96b1-0f4bcce38750"), b.e.a.Area).ao() as c5x);
				b.a = (new ar7(new Guid("c283b222-355a-4649-9cfc-4ce88a185170"), b.e.a.Area).ao() as c5x);
				b.b = (new ar7(new Guid("cd13b2cb-3420-40f9-90ab-4f4ca2254382"), b.e.a.Area).ao() as c5x);
				b.c = (new ar7(new Guid("d967bdf4-f5a9-4546-8bab-d597f1db450a"), b.e.a.Area).ao() as c5x);
				eh6 eh = (new ar7(new Guid("90592d76-9341-40d2-9d29-5e41b82fe3e6"), b.e.a.Area).ao() as c5x).GetAspect<bim>() as eh6;
				if (eh != null)
				{
					eh.d();
				}
				b.e.a.ae = new float?(0f);
				cwy a_ = Enumerable.FirstOrDefault<cwy>(b.e.a.h.b.aa().StatusEffects.Get<cwy>());
				b.e.a.h.b.aa().StatusEffects.d(a_);
				if (b.d != null)
				{
					b.d.ae = new float?(0f);
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					btm[] array = new btm[1];
					int num = 0;
					bb8 bb = new bb8();
					bb.a(CharacterState.Operating);
					bb.a(atp.a);
					bb.IsAsync = false;
					bb.a(new ar7(b.a));
					bb.b(8);
					array[num] = bb;
					base.a(array);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					s5 s = new s5();
					s.a(new ar7(b.a));
					s.a(new bt4("cutscene_soldierStop"));
					s.IsAsync = false;
					s.a(true);
					array2[num2] = s;
					base.a(array2);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.e.b), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.e), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					egx egx = new egx();
					egx.a("A?");
					array3[num3] = new ace(egx)
					{
						TargetRef = new ar7(b.a)
					};
					base.a(array3);
					btm[] array4 = new btm[1];
					int num4 = 0;
					s5 s2 = new s5();
					s2.a(new ar7(b.b));
					s2.a(new bt4("cutscene_patrolStop"));
					s2.IsAsync = true;
					s2.a(true);
					array4[num4] = s2;
					base.a(array4);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					btm[] array5 = new btm[1];
					int num5 = 0;
					s5 s3 = new s5();
					s3.a(new ar7(b.a));
					s3.a(new bt4("cutscene_soldierMoveBack"));
					s3.IsAsync = true;
					s3.a(true);
					array5[num5] = s3;
					base.a(array5);
					btm[] array6 = new btm[1];
					int num6 = 0;
					egx egx2 = new egx();
					egx2.a("Дрдослав.");
					array6[num6] = new ace(egx2)
					{
						TargetRef = new ar7(b.b)
					};
					base.a(array6);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.d), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array7 = new btm[1];
					int num7 = 0;
					egx egx3 = new egx();
					egx3.a("За щто гу дргазрдищ?");
					array7[num7] = new ace(egx3)
					{
						TargetRef = new ar7(b.b)
					};
					base.a(array7);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(4.0))
					});
					btm[] array8 = new btm[1];
					int num8 = 0;
					egx egx4 = new egx();
					egx4.a("Бреко море, Препеченик Здислав треба те. Задугай слагзвно зстоп марщ.");
					array8[num8] = new ace(egx4)
					{
						TargetRef = new ar7(b.b)
					};
					base.a(array8);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(6.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.c), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array9 = new btm[1];
					int num9 = 0;
					egx egx5 = new egx();
					egx5.a("Тргнавим, тргнавим.");
					array9[num9] = new ace(egx5)
					{
						TargetRef = new ar7(b.a)
					};
					base.a(array9);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					btm[] array10 = new btm[1];
					int num10 = 0;
					s5 s4 = new s5();
					s4.a(new ar7(b.a));
					s4.a(new bt4("cutsceneStop"));
					s4.IsAsync = false;
					s4.a(true);
					array10[num10] = s4;
					base.a(array10);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.5))
					});
					btm[] array11 = new btm[1];
					int num11 = 0;
					bb8 bb2 = new bb8();
					bb2.a(CharacterState.OperateShort);
					bb2.a(atp.a);
					bb2.IsAsync = false;
					bb2.a(new ar7(b.a));
					bb2.b(1);
					array11[num11] = bb2;
					base.a(array11);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.h), null, null, null)
					});
					btm[] array12 = new btm[1];
					int num12 = 0;
					uk uk = new uk();
					uk.c(true);
					uk.b(true);
					array12[num12] = new ace(uk)
					{
						TargetRef = new ar7(b.a)
					};
					base.a(array12);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.g), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(4.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.f), null, null, null)
					});
					btm[] array13 = new btm[1];
					int num13 = 0;
					c6w c6w = new c6w();
					c6w.a(new ar7(b.d));
					c6w.IsAsync = false;
					c6w.a = new Func<auv>(b.a);
					array13[num13] = c6w;
					base.a(array13);
					btm[] array14 = new btm[1];
					int num14 = 0;
					s5 s5 = new s5();
					s5.a(new ar7(b.d));
					s5.a(new bt4("dude_temp"));
					s5.IsAsync = false;
					s5.a(true);
					array14[num14] = s5;
					base.a(array14);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.e.c), null, null, null)
					});
					btm[] array15 = new btm[1];
					int num15 = 0;
					c6w c6w2 = new c6w();
					c6w2.a(new ar7(b.e.a));
					c6w2.IsAsync = false;
					c6w2.a = new Func<auv>(b.e.a);
					array15[num15] = c6w2;
					base.a(array15);
					btm[] array16 = new btm[1];
					int num16 = 0;
					s5 s6 = new s5();
					s6.a(new ar7(b.e.a));
					s6.a(new bt4("player_talk"));
					s6.IsAsync = false;
					s6.a(true);
					array16[num16] = s6;
					base.a(array16);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.e.a), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.a), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array17 = new btm[1];
					int num17 = 0;
					s5 s7 = new s5();
					s7.a(new ar7(b.d));
					s7.a(new bt4("global:rc_dude:storage"));
					s7.IsAsync = false;
					s7.a(true);
					array17[num17] = s7;
					base.a(array17);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(b.b), null, null, null)
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000D75 RID: 3445
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004B02 RID: 19202 RVA: 0x00204A44 File Offset: 0x00202C44
		internal bool b(e6d A_0)
		{
			cwy a_ = new cwy(0);
			this.a.h.b.aa().StatusEffects.a(a_, false, false, false);
			return true;
		}

		// Token: 0x06004B03 RID: 19203 RVA: 0x00204A80 File Offset: 0x00202C80
		internal bool c(e6d A_0)
		{
			a0l.a(this.a, "rift_spawn", true);
			return true;
		}

		// Token: 0x06004B04 RID: 19204 RVA: 0x00204A98 File Offset: 0x00202C98
		internal auv a()
		{
			awx awx = new awx();
			awx.a(awx.kh() | m7.b);
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new bfq("TeleportExit"), null, null, null);
			a4s.b(new ar7(this.a));
			list.Add(a4s);
			awx.ad().Add(new a7j(this.a, "Teleport", 1, double.MaxValue, true, false, null, null, null, null, false, null));
			awx.ad().Add(new a4s(new akw(), new ar7(this.a), new ar7(this.a), null));
			awx.ad().Add(new bm3(150));
			List<auv> list2 = awx.ad();
			ad6 ad = new ad6(this.a);
			ad.b(0.0);
			ad.c(1.0);
			ad.a(0.005);
			list2.Add(ad);
			awx.ad().Add(new bm3(100));
			return awx;
		}

		// Token: 0x06004B05 RID: 19205 RVA: 0x00204BD4 File Offset: 0x00202DD4
		internal bool a(e6d A_0)
		{
			cwy a_ = Enumerable.FirstOrDefault<cwy>(this.a.h.b.aa().StatusEffects.Get<cwy>());
			this.a.h.b.aa().StatusEffects.d(a_);
			return true;
		}

		// Token: 0x04001E14 RID: 7700
		public c5x a;
	}

	// Token: 0x02000D76 RID: 3446
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004B07 RID: 19207 RVA: 0x00204C30 File Offset: 0x00202E30
		internal bool e(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.South;
			a0l.a(this.b, "pb2", true);
			return true;
		}

		// Token: 0x06004B08 RID: 19208 RVA: 0x00204C50 File Offset: 0x00202E50
		internal bool d(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.North;
			return true;
		}

		// Token: 0x06004B09 RID: 19209 RVA: 0x00204C60 File Offset: 0x00202E60
		internal bool c(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.South;
			return true;
		}

		// Token: 0x06004B0A RID: 19210 RVA: 0x00204C74 File Offset: 0x00202E74
		internal bool h(e6d A_0)
		{
			cnb cnb = this.c.GetAspect<bim>() as cnb;
			if (cnb != null)
			{
				cnb.d(false);
			}
			return true;
		}

		// Token: 0x06004B0B RID: 19211 RVA: 0x00204CA0 File Offset: 0x00202EA0
		internal bool g(e6d A_0)
		{
			a0l.a(this.b, "pb1", true);
			return true;
		}

		// Token: 0x06004B0C RID: 19212 RVA: 0x00204CB4 File Offset: 0x00202EB4
		internal bool f(e6d A_0)
		{
			a0l.a(this.d, "rift_spawn", true);
			return true;
		}

		// Token: 0x06004B0D RID: 19213 RVA: 0x00204CC8 File Offset: 0x00202EC8
		internal auv a()
		{
			awx awx = new awx();
			awx.a(awx.kh() | m7.b);
			List<auv> list = awx.ad();
			a4s a4s = new a4s(new bfq("TeleportExit"), null, null, null);
			a4s.b(new ar7(this.d));
			list.Add(a4s);
			awx.ad().Add(new a7j(this.d, "Teleport", 1, double.MaxValue, true, false, null, null, null, null, false, null));
			awx.ad().Add(new a4s(new akw(), new ar7(this.d), new ar7(this.d), null));
			awx.ad().Add(new bm3(150));
			List<auv> list2 = awx.ad();
			ad6 ad = new ad6(this.d);
			ad.b(0.0);
			ad.c(1.0);
			ad.a(0.005);
			list2.Add(ad);
			awx.ad().Add(new bm3(100));
			return awx;
		}

		// Token: 0x06004B0E RID: 19214 RVA: 0x00204E04 File Offset: 0x00203004
		internal bool a(e6d A_0)
		{
			this.e.a.VisualDirection = HorizontalDirection.North;
			this.d.VisualDirection = HorizontalDirection.Northwest;
			return true;
		}

		// Token: 0x06004B0F RID: 19215 RVA: 0x00204E28 File Offset: 0x00203028
		internal bool b(e6d A_0)
		{
			this.e.a.GetAspect<j7>().a(this.d.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001E15 RID: 7701
		public c5x a;

		// Token: 0x04001E16 RID: 7702
		public c5x b;

		// Token: 0x04001E17 RID: 7703
		public c5x c;

		// Token: 0x04001E18 RID: 7704
		public c5x d;

		// Token: 0x04001E19 RID: 7705
		public eg8.a e;
	}
}
