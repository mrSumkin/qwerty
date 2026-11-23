using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x02000D50 RID: 3408
[e79("Xpbl_Le_FortMoveToOffices")]
public sealed class bmi : dgy
{
	// Token: 0x06004AAE RID: 19118 RVA: 0x001FF3CC File Offset: 0x001FD5CC
	public bmi()
	{
		bmi.a a = new bmi.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			c5x c5x = a.a.aqu().v().b() as c5x;
			if (c5x != null && c5x.Area != null)
			{
				bmi.b b = new bmi.b();
				c5x a_ = new ar7(new Guid("d4ac396e-10f7-4a61-8f0e-941c31813923"), c5x.Area).ao() as c5x;
				b.a = (new ar7(new Guid("fb77cf3a-ae4a-4ab8-9ef3-695f0920db83"), c5x.Area).ao() as c5x);
				b.b = (new ar7(new Guid("34b8bf7c-45dc-45b5-a4a0-79fe5ee77c39"), c5x.Area).ao() as c5x);
				b.c = (new ar7(new Guid("f613302e-99a5-451c-9172-b845bc211152"), c5x.Area).ao() as c5x);
				b.d = (new ar7(new Guid("773484b5-c07b-49c0-9ee8-5aea6a05e748"), c5x.Area).ao() as c5x);
				b.e = (new ar7(new Guid("256697bc-d119-47f8-b155-0c6ae47d5c36"), c5x.Area).ao() as c5x);
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				btm[] array = new btm[1];
				int num = 0;
				s5 s = new s5();
				s.a(new ar7(b.c));
				s.a(new bt4("guard_move1"));
				s.IsAsync = true;
				s.a(true);
				array[num] = s;
				base.a(array);
				btm[] array2 = new btm[1];
				int num2 = 0;
				s5 s2 = new s5();
				s2.a(new ar7(b.d));
				s2.a(new bt4("guard_move2"));
				s2.IsAsync = true;
				s2.a(true);
				array2[num2] = s2;
				base.a(array2);
				btm[] array3 = new btm[1];
				int num3 = 0;
				s5 s3 = new s5();
				s3.a(new ar7(b.a));
				s3.a(new bt4("briggs_move1"));
				s3.IsAsync = true;
				s3.a(true);
				array3[num3] = s3;
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				s5 s4 = new s5();
				s4.a(new ar7(c5x));
				s4.a(new bt4("player_move1"));
				s4.IsAsync = true;
				s4.a(true);
				array4[num4] = s4;
				base.a(array4);
				btm[] array5 = new btm[1];
				int num5 = 0;
				kw kw = new kw();
				kw.a(new bt4("xpbl_fu", new Vector3(4f, 15f, 0f)));
				kw.IsAsync = true;
				array5[num5] = kw;
				base.a(array5);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array6 = new btm[1];
				int num6 = 0;
				s5 s5 = new s5();
				s5.a(new ar7(a_));
				s5.a(new bt4("oldfield_move1"));
				s5.IsAsync = true;
				s5.a(true);
				array6[num6] = s5;
				base.a(array6);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array7 = new btm[1];
				int num7 = 0;
				s5 s6 = new s5();
				s6.a(new ar7(b.b));
				s6.a(new bt4("seeger_move1"));
				s6.IsAsync = true;
				s6.a(true);
				array7[num7] = s6;
				base.a(array7);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(5.0))
				});
				btm[] array8 = new btm[1];
				int num8 = 0;
				s5 s7 = new s5();
				s7.a(new ar7(b.c));
				s7.a(new bt4("guard_move11"));
				s7.IsAsync = true;
				s7.a(true);
				array8[num8] = s7;
				base.a(array8);
				btm[] array9 = new btm[1];
				int num9 = 0;
				s5 s8 = new s5();
				s8.a(new ar7(b.d));
				s8.a(new bt4("global:xpbl_aegis_guard2:tun"));
				s8.IsAsync = true;
				s8.a(true);
				array9[num9] = s8;
				base.a(array9);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array10 = new btm[1];
				int num10 = 0;
				s5 s9 = new s5();
				s9.a(new ar7(b.a));
				s9.a(new bt4("global:xpbl_briggs:tun"));
				s9.IsAsync = true;
				s9.a(true);
				array10[num10] = s9;
				base.a(array10);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array11 = new btm[1];
				int num11 = 0;
				kw kw2 = new kw();
				kw2.a(new bt4("xpbl_fu", new Vector3(14f, 10f, 0f)));
				kw2.IsAsync = true;
				array11[num11] = kw2;
				base.a(array11);
				btm[] array12 = new btm[1];
				int num12 = 0;
				s5 s10 = new s5();
				s10.a(new ar7(a_));
				s10.a(new bt4("global:xpbl_oldfield:tun"));
				s10.IsAsync = true;
				s10.a(true);
				array12[num12] = s10;
				base.a(array12);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.2))
				});
				btm[] array13 = new btm[1];
				int num13 = 0;
				s5 s11 = new s5();
				s11.a(new ar7(c5x));
				s11.a(new bt4("player_tun"));
				s11.IsAsync = true;
				s11.a(true);
				array13[num13] = s11;
				base.a(array13);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.2))
				});
				btm[] array14 = new btm[1];
				int num14 = 0;
				s5 s12 = new s5();
				s12.a(new ar7(b.b));
				s12.a(new bt4("global:xpbl_seeger:tun"));
				s12.IsAsync = true;
				s12.a(true);
				array14[num14] = s12;
				base.a(array14);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(10.0))
				});
				btm[] array15 = new btm[1];
				int num15 = 0;
				dva dva = new dva(null, null, null, null, null);
				dva.a(new Func<e6d, bool>(b.a));
				array15[num15] = dva;
				base.a(array15);
				btm[] array16 = new btm[1];
				int num16 = 0;
				d92 d = new d92();
				d.a("events\\xpbl\\le_openingFort");
				d.b(new ar7(a_));
				d.a(new ar7(c5x));
				array16[num16] = d;
				base.a(array16);
				btm[] array17 = new btm[1];
				int num17 = 0;
				dva dva2 = new dva(null, null, null, null, null);
				dva2.a(new Func<e6d, bool>(a.a));
				array17[num17] = dva2;
				base.a(array17);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000D51 RID: 3409
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004AB0 RID: 19120 RVA: 0x001FFAA4 File Offset: 0x001FDCA4
		internal bool a(e6d A_0)
		{
			if (this.a.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_le_savage_navcom_sentSupplies", new bool?(false)).Value && this.a.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_briggs_knowLiedToDocAboutSupplies", new bool?(false)).Value)
			{
				this.a.aqu().b(new ejy());
			}
			return true;
		}

		// Token: 0x04001DDB RID: 7643
		public cnk a;
	}

	// Token: 0x02000D52 RID: 3410
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004AB2 RID: 19122 RVA: 0x001FFB30 File Offset: 0x001FDD30
		internal bool a(e6d A_0)
		{
			if (this.a != null && this.a.t.b != null)
			{
				this.a.t.b.y6()[ddq.ay] = new bt4("global:xpbl_briggs:tun");
			}
			if (this.b != null && this.b.t.b != null)
			{
				this.b.t.b.y6()[ddq.ay] = new bt4("global:xpbl_seeger:research");
			}
			if (this.c != null && this.c.t.b != null)
			{
				this.c.t.b.y6()[ddq.ay] = new bt4("global:xpbl_aegis_guard1:tun");
			}
			if (this.d != null && this.d.t.b != null)
			{
				this.d.t.b.y6()[ddq.ay] = new bt4("global:xpbl_aegis_guard2:tun");
			}
			if (this.e != null && this.e.t.b != null)
			{
				this.e.t.b.y6()[ddq.ay] = new bt4("global:xpbl_aegis_guard3:tun");
			}
			return true;
		}

		// Token: 0x04001DDC RID: 7644
		public c5x a;

		// Token: 0x04001DDD RID: 7645
		public c5x b;

		// Token: 0x04001DDE RID: 7646
		public c5x c;

		// Token: 0x04001DDF RID: 7647
		public c5x d;

		// Token: 0x04001DE0 RID: 7648
		public c5x e;
	}
}
