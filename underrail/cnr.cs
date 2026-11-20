using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000E16 RID: 3606
[e79("Tch_GlimpseOfFacelessInvasion")]
public sealed class cnr : dgy
{
	// Token: 0x06004C6B RID: 19563 RVA: 0x00215D48 File Offset: 0x00213F48
	public cnr()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null && c5x.Area != null)
			{
				cnr.a a = new cnr.a();
				new ar7(new Guid("3a20277c-1990-48b3-8f3f-bebb6112fbb3"), c5x.Area).ao();
				a.b = (new ar7(new Guid("cca42405-b9ca-4856-9939-bab0ca25ddaa"), c5x.Area).ao() as c5x);
				new ar7(new Guid("1c57d511-5e80-4676-8a53-3b5bed9a1186"), c5x.Area).ao();
				c5x c5x2 = new ar7(new Guid("0f0775e9-9f59-4826-ac74-bd7f4463be53"), c5x.Area).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("df58a686-badb-4c49-9db4-5f5fec80c9f7"), c5x.Area).ao() as c5x;
				new ar7(new Guid("51528027-9468-4ebc-aba5-c9a203df5d33"), c5x.Area).ao();
				a.a = (new ar7(new Guid("95af6125-e493-4e05-8f3e-d9991318ade6"), c5x.Area).ao() as c5x);
				c5x c5x4 = new ar7(new Guid("62078c55-01e8-4a30-9982-d30d850b164c"), c5x.Area).ao() as c5x;
				new ar7(new Guid("6f1ffcb9-f0e1-4886-ad49-8024dec56d69"), c5x.Area).ao();
				c5x a_ = new ar7(new Guid("86b5c3ea-4d0f-4b64-bdd0-59cb18b5b6a6"), c5x.Area).ao() as c5x;
				btm[] array = new btm[1];
				int num = 0;
				dky dky = new dky();
				dky.a(0.2f);
				dky.a(false);
				array[num] = dky;
				base.a(array);
				btm[] array2 = new btm[1];
				int num2 = 0;
				dva dva = new dva(null, null, null, null, null);
				dva.a(new Func<e6d, bool>(cnr.b.a.b));
				array2[num2] = dva;
				base.a(array2);
				btm[] array3 = new btm[1];
				int num3 = 0;
				kw kw = new kw();
				kw.a(new bt4("tch-inv", new Vector3(10f, 8f, 0f)));
				kw.IsAsync = false;
				kw.a(true);
				array3[num3] = kw;
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				array4[num4] = c8s;
				base.a(array4);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array5 = new btm[1];
				int num5 = 0;
				kw kw2 = new kw();
				kw2.a(new bt4("tch-inv", new Vector3(10f, 23f, 0f)));
				kw2.IsAsync = true;
				kw2.a(new float?(0.8f));
				array5[num5] = kw2;
				base.a(array5);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				if (a.a != null)
				{
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.d), null, null, null)
					});
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				if (a.a != null)
				{
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.c), null, null, null)
					});
				}
				if (a.b != null)
				{
					btm[] array6 = new btm[1];
					int num6 = 0;
					s5 s = new s5();
					s.a(new ar7(a.b));
					s.a(new bt4("weapon_pickup"));
					s.IsAsync = true;
					s.a(true);
					array6[num6] = s;
					base.a(array6);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(3.0))
					});
					btm[] array7 = new btm[1];
					int num7 = 0;
					bb8 bb = new bb8();
					bb.a(CharacterState.OperateShort);
					bb.a(atp.a);
					bb.IsAsync = false;
					bb.a(new ar7(a.b));
					bb.b(1);
					array7[num7] = bb;
					base.a(array7);
					btm[] array8 = new btm[1];
					int num8 = 0;
					a5 a2 = new a5();
					a2.a(new ar7(a_));
					array8[num8] = a2;
					base.a(array8);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
					});
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.b), null, null, null)
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.2))
					});
					btm[] array9 = new btm[1];
					int num9 = 0;
					s5 s2 = new s5();
					s2.a(new ar7(a.b));
					s2.a(new bt4("weapon_leave"));
					s2.IsAsync = true;
					s2.a(true);
					array9[num9] = s2;
					base.a(array9);
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.5))
				});
				if (c5x4 != null)
				{
					btm[] array10 = new btm[1];
					int num10 = 0;
					bb8 bb2 = new bb8();
					bb2.a(CharacterState.FinishPsi);
					bb2.a(atp.a);
					bb2.IsAsync = true;
					bb2.a(new ar7(c5x4));
					bb2.b(2);
					array10[num10] = bb2;
					base.a(array10);
				}
				if (c5x3 != null)
				{
					btm[] array11 = new btm[1];
					int num11 = 0;
					s5 s3 = new s5();
					s3.a(new ar7(c5x3));
					s3.a(new bt4("faceless_approach"));
					s3.IsAsync = true;
					s3.a(true);
					array11[num11] = s3;
					base.a(array11);
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				if (a.a != null)
				{
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				if (c5x2 != null)
				{
					btm[] array12 = new btm[1];
					int num12 = 0;
					s5 s4 = new s5();
					s4.a(new ar7(c5x2));
					s4.a(new bt4("medic_approach"));
					s4.IsAsync = true;
					s4.a(true);
					array12[num12] = s4;
					base.a(array12);
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array13 = new btm[1];
				int num13 = 0;
				dky dky2 = new dky();
				dky2.a(0.2f);
				dky2.a(false);
				array13[num13] = dky2;
				base.a(array13);
				btm[] array14 = new btm[1];
				int num14 = 0;
				dva dva2 = new dva(null, null, null, null, null);
				dva2.a(new Func<e6d, bool>(cnr.b.a.a));
				array14[num14] = dva2;
				base.a(array14);
				btm[] array15 = new btm[1];
				int num15 = 0;
				kw kw3 = new kw();
				kw3.a(new bt4("tch-inv", c5x.Location));
				kw3.IsAsync = false;
				kw3.a(true);
				array15[num15] = kw3;
				base.a(array15);
				btm[] array16 = new btm[1];
				int num16 = 0;
				c8s c8s2 = new c8s();
				c8s2.a(0.2f);
				array16[num16] = c8s2;
				base.a(array16);
			}
		}
	}

	// Token: 0x02000E17 RID: 3607
	[CompilerGenerated]
	[Serializable]
	private new sealed class b
	{
		// Token: 0x06004C6E RID: 19566 RVA: 0x002164B4 File Offset: 0x002146B4
		internal bool b(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.a);
			}
			return true;
		}

		// Token: 0x06004C6F RID: 19567 RVA: 0x002164D8 File Offset: 0x002146D8
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			return true;
		}

		// Token: 0x04001EEE RID: 7918
		public static readonly cnr.b a = new cnr.b();

		// Token: 0x04001EEF RID: 7919
		public static Func<e6d, bool> b;

		// Token: 0x04001EF0 RID: 7920
		public static Func<e6d, bool> c;
	}

	// Token: 0x02000E18 RID: 3608
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004C71 RID: 19569 RVA: 0x00216508 File Offset: 0x00214708
		internal bool d(e6d A_0)
		{
			boj.a(this.a, "Electricity", 100, 300.0, true, true, null, null, null, null, false);
			boj.a(this.a, "Smoke", 1, double.MaxValue, true, true, null, null, null, null, false);
			this.a.c().a(Guid.NewGuid().ToString(), "Tazer", 0.4f, c9z.a, false, false);
			return true;
		}

		// Token: 0x06004C72 RID: 19570 RVA: 0x002165CC File Offset: 0x002147CC
		internal bool c(e6d A_0)
		{
			boj.a(this.a, "Smoke", 1, double.MaxValue, true, true, null, null, null, null, false);
			return true;
		}

		// Token: 0x06004C73 RID: 19571 RVA: 0x0021661C File Offset: 0x0021481C
		internal bool b(e6d A_0)
		{
			this.b.h.b.aa().Offense.k();
			this.b.c().a(Guid.NewGuid().ToString(), "PistolReload", 0.7f, c9z.a, false, false);
			return true;
		}

		// Token: 0x06004C74 RID: 19572 RVA: 0x0021667C File Offset: 0x0021487C
		internal bool a(e6d A_0)
		{
			boj.a(this.a, "Electricity", 100, 300.0, true, true, null, null, null, null, false);
			this.a.c().a(Guid.NewGuid().ToString(), "Tazer", 0.4f, c9z.a, false, false);
			return true;
		}

		// Token: 0x04001EF1 RID: 7921
		public c5x a;

		// Token: 0x04001EF2 RID: 7922
		public c5x b;
	}
}
