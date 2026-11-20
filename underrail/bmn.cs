using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000D28 RID: 3368
[e79("Cc_TrippyDrugs3")]
public sealed class bmn : dgy
{
	// Token: 0x06004A53 RID: 19027 RVA: 0x001F6B90 File Offset: 0x001F4D90
	public bmn()
	{
		bmn.a a = new bmn.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		new List<amc>();
		if (a.a != null && a.a.aqu() != null)
		{
			a.b = (a.a.aqu().v().b() as c5x);
			a.c = new ar7(a.b);
			a.d = new ar7();
			a.e = new ar7();
			if (a.b != null)
			{
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new ace(new epw(new CharacterState?(CharacterState.Stunned)))
					{
						TargetRef = new ar7(a.b)
					}
				});
				base.a(new btm[]
				{
					new am8()
				});
				btm[] array = new btm[1];
				int num = 0;
				dky dky = new dky();
				dky.a(0.2f);
				dky.IsAsync = false;
				dky.a(false);
				array[num] = dky;
				base.a(array);
				base.a(new btm[]
				{
					new cmc(null)
				});
				base.a(new btm[]
				{
					new ace(new epw(null))
					{
						TargetRef = new ar7(a.b)
					}
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
				base.a(new btm[]
				{
					new di4(new c2w("cc6", "FromMotion"), false, new bool?(false), 0, null, true, false, false)
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				dva dva = new dva(null, null, null, null, null);
				dva.a(new Func<e6d, bool>(bmn.b.a.b));
				array2[num2] = dva;
				base.a(array2);
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				dva dva2 = new dva(null, null, null, null, null);
				dva2.a(new Func<e6d, bool>(a.e));
				array3[num3] = dva2;
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				if (a.b.h.b.aa().Gender == Gender.Female)
				{
					btm[] array4 = new btm[1];
					int num4 = 0;
					egx egx = new egx();
					egx.a("Девочка-краулер, девочка-краулер...");
					array4[num4] = new ace(egx)
					{
						TargetRef = a.c
					};
					base.a(array4);
				}
				else
				{
					btm[] array5 = new btm[1];
					int num5 = 0;
					egx egx2 = new egx();
					egx2.a("Человек-краулер, человек-краулер...");
					array5[num5] = new ace(egx2)
					{
						TargetRef = a.c
					};
					base.a(array5);
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array6 = new btm[1];
				int num6 = 0;
				dva dva3 = new dva(null, null, null, null, null);
				dva3.a(new Func<e6d, bool>(a.d));
				array6[num6] = dva3;
				base.a(array6);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				if (a.b.h.b.aa().Gender == Gender.Female)
				{
					btm[] array7 = new btm[1];
					int num7 = 0;
					egx egx3 = new egx();
					egx3.a("Добрый краулер из злой Зоны...");
					array7[num7] = new ace(egx3)
					{
						TargetRef = a.c
					};
					base.a(array7);
				}
				else
				{
					btm[] array8 = new btm[1];
					int num8 = 0;
					egx egx4 = new egx();
					egx4.a("Добрый краулер из злой Зоны...");
					array8[num8] = new ace(egx4)
					{
						TargetRef = a.c
					};
					base.a(array8);
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array9 = new btm[1];
				int num9 = 0;
				dva dva4 = new dva(null, null, null, null, null);
				dva4.a(new Func<e6d, bool>(a.c));
				array9[num9] = dva4;
				base.a(array9);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				if (a.b.h.b.aa().Gender == Gender.Female)
				{
					btm[] array10 = new btm[1];
					int num10 = 0;
					egx egx5 = new egx();
					egx5.a("Разобьётся ли она насмерть...");
					array10[num10] = new ace(egx5)
					{
						TargetRef = a.c
					};
					base.a(array10);
				}
				else
				{
					btm[] array11 = new btm[1];
					int num11 = 0;
					egx egx6 = new egx();
					egx6.a("Разобьётся ли он насмерть...");
					array11[num11] = new ace(egx6)
					{
						TargetRef = a.c
					};
					base.a(array11);
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array12 = new btm[1];
				int num12 = 0;
				dva dva5 = new dva(null, null, null, null, null);
				dva5.a(new Func<e6d, bool>(a.i));
				array12[num12] = dva5;
				base.a(array12);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				if (a.b.h.b.aa().Gender == Gender.Female)
				{
					btm[] array13 = new btm[1];
					int num13 = 0;
					egx egx7 = new egx();
					egx7.a("Упоролась и свернула шею...");
					array13[num13] = new ace(egx7)
					{
						TargetRef = a.c
					};
					base.a(array13);
				}
				else
				{
					btm[] array14 = new btm[1];
					int num14 = 0;
					egx egx8 = new egx();
					egx8.a("Упоролся и свернул шею...");
					array14[num14] = new ace(egx8)
					{
						TargetRef = a.c
					};
					base.a(array14);
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array15 = new btm[1];
				int num15 = 0;
				dva dva6 = new dva(null, null, null, null, null);
				dva6.a(new Func<e6d, bool>(a.h));
				array15[num15] = dva6;
				base.a(array15);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array16 = new btm[1];
				int num16 = 0;
				egx egx9 = new egx();
				egx9.a("Бе-е-е-ерегись...");
				array16[num16] = new ace(egx9)
				{
					TargetRef = a.c
				};
				base.a(array16);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				btm[] array17 = new btm[1];
				int num17 = 0;
				dva dva7 = new dva(null, null, null, null, null);
				dva7.a(new Func<e6d, bool>(a.g));
				array17[num17] = dva7;
				base.a(array17);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.25))
				});
				btm[] array18 = new btm[1];
				int num18 = 0;
				dva dva8 = new dva(null, null, null, null, null);
				dva8.a(new Func<e6d, bool>(a.f));
				array18[num18] = dva8;
				base.a(array18);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				if (a.b.h.b.aa().Gender == Gender.Female)
				{
					btm[] array19 = new btm[1];
					int num19 = 0;
					egx egx10 = new egx();
					egx10.a("Это девочка-краулер!");
					array19[num19] = new ace(egx10)
					{
						TargetRef = a.c
					};
					base.a(array19);
				}
				else
				{
					btm[] array20 = new btm[1];
					int num20 = 0;
					egx egx11 = new egx();
					egx11.a("Это человек-краулер!");
					array20[num20] = new ace(egx11)
					{
						TargetRef = a.c
					};
					base.a(array20);
				}
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array21 = new btm[1];
				int num21 = 0;
				bb8 bb = new bb8();
				bb.a(CharacterState.Custom1);
				bb.a(atp.a);
				bb.IsAsync = false;
				bb.a(a.d);
				bb.b(1);
				array21[num21] = bb;
				base.a(array21);
				btm[] array22 = new btm[1];
				int num22 = 0;
				dva dva9 = new dva(null, null, null, null, null);
				dva9.a(new Func<e6d, bool>(a.a));
				array22[num22] = dva9;
				base.a(array22);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array23 = new btm[1];
				int num23 = 0;
				dky dky2 = new dky();
				dky2.a(0.2f);
				dky2.IsAsync = false;
				dky2.a(false);
				array23[num23] = dky2;
				base.a(array23);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
				btm[] array24 = new btm[1];
				int num24 = 0;
				dva dva10 = new dva(null, null, null, null, null);
				dva10.a(new Func<e6d, bool>(bmn.b.a.a));
				array24[num24] = dva10;
				base.a(array24);
				base.a(new btm[]
				{
					new di4(new c2w("cc14x", "FromNorth"), false, new bool?(false), 0, null, true, false, false)
				});
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				btm[] array25 = new btm[1];
				int num25 = 0;
				dva dva11 = new dva(null, null, null, null, null);
				dva11.a(new Func<e6d, bool>(a.b));
				array25[num25] = dva11;
				base.a(array25);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array26 = new btm[1];
				int num26 = 0;
				egx egx12 = new egx();
				egx12.a("...нет, не может, он же свинья... мммм-хммм....");
				array26[num26] = new ace(egx12)
				{
					TargetRef = a.e
				};
				base.a(array26);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000D29 RID: 3369
	[CompilerGenerated]
	[Serializable]
	private new sealed class b
	{
		// Token: 0x06004A56 RID: 19030 RVA: 0x001F75B8 File Offset: 0x001F57B8
		internal bool b(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.a);
			}
			return true;
		}

		// Token: 0x06004A57 RID: 19031 RVA: 0x001F75DC File Offset: 0x001F57DC
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			return true;
		}

		// Token: 0x04001DA8 RID: 7592
		public static readonly bmn.b a = new bmn.b();

		// Token: 0x04001DA9 RID: 7593
		public static Func<e6d, bool> b;

		// Token: 0x04001DAA RID: 7594
		public static Func<e6d, bool> c;
	}

	// Token: 0x02000D2A RID: 3370
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004A59 RID: 19033 RVA: 0x001F760C File Offset: 0x001F580C
		internal bool e(e6d A_0)
		{
			this.b = (this.a.aqu().v().b() as c5x);
			this.c.a(this.b);
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				foreach (d4n d4n in service.ahl())
				{
					if (!d4n.b.aa().Passive && d4n.b.aa().FactionId != asp.a && d4n.b.aa().c(d8o.b))
					{
						aw1.b(d4n.b.a8(), this.b, false);
					}
				}
			}
			return true;
		}

		// Token: 0x06004A5A RID: 19034 RVA: 0x001F7700 File Offset: 0x001F5900
		internal bool d(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("2af1a94e-caac-4d54-9aa4-598e7c26213d"), this.b.Area).ao() as c5x;
			if (c5x != null && c5x.u.b != null)
			{
				c5x.u.b.a("Прыгай уже! Тупые подвижники...", true, null, null);
			}
			return true;
		}

		// Token: 0x06004A5B RID: 19035 RVA: 0x001F7774 File Offset: 0x001F5974
		internal bool c(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("710f492e-93ac-432e-9230-95f82cfbe4f1"), this.b.Area).ao() as c5x;
			if (c5x != null && c5x.u.b != null)
			{
				if (this.b.h.b.aa().Gender == Gender.Female)
				{
					c5x.u.b.a("Это как она туда забралась?", true, null, null);
				}
				else
				{
					c5x.u.b.a("Это как он туда забрался?", true, null, null);
				}
			}
			return true;
		}

		// Token: 0x06004A5C RID: 19036 RVA: 0x001F7834 File Offset: 0x001F5A34
		internal bool i(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("6548f015-0cfb-4386-b298-00b989f1c04d"), this.b.Area).ao() as c5x;
			if (c5x != null && c5x.u.b != null)
			{
				if (this.b.h.b.aa().Gender == Gender.Female)
				{
					c5x.u.b.a("Не делай этого, девочка!", true, null, null);
				}
				else
				{
					c5x.u.b.a("Не делай этого, сынок!", true, null, null);
				}
			}
			return true;
		}

		// Token: 0x06004A5D RID: 19037 RVA: 0x001F78F4 File Offset: 0x001F5AF4
		internal bool h(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("2af1a94e-caac-4d54-9aa4-598e7c26213d"), this.b.Area).ao() as c5x;
			if (c5x != null && c5x.u.b != null)
			{
				c5x.u.b.a("А ну заткнись!", true, null, null);
			}
			return true;
		}

		// Token: 0x06004A5E RID: 19038 RVA: 0x001F7968 File Offset: 0x001F5B68
		internal bool g(e6d A_0)
		{
			if (this.c.ao() != null)
			{
				boj.a(this.c.ao() as c5x, "Smoke", 1, double.MaxValue, true, true, null, null, null, null, false);
			}
			return true;
		}

		// Token: 0x06004A5F RID: 19039 RVA: 0x001F79D4 File Offset: 0x001F5BD4
		internal bool f(e6d A_0)
		{
			if (this.c.ao() != null)
			{
				(this.c.ao() as c5x).ae = new float?(0f);
			}
			c5x c5x = vq.a("creatures\\crawler", this.b.Zone.g("FromMotion"), false);
			this.d.a(c5x);
			if (c5x != null && c5x.h.b != null)
			{
				c5x.Layer = 0;
			}
			return true;
		}

		// Token: 0x06004A60 RID: 19040 RVA: 0x001F7A5C File Offset: 0x001F5C5C
		internal bool a(e6d A_0)
		{
			if (this.d.ao() != null)
			{
				(this.d.ao() as c5x).ae = new float?(0f);
			}
			return true;
		}

		// Token: 0x06004A61 RID: 19041 RVA: 0x001F7A94 File Offset: 0x001F5C94
		internal bool b(e6d A_0)
		{
			this.b = (this.a.aqu().v().b() as c5x);
			this.c.a(this.b);
			this.e.a(new ar7(new Guid("2ea8386a-44a0-4546-90b8-5f8b1e8de4ad"), this.b.Area).ao() as c5x);
			return true;
		}

		// Token: 0x04001DAB RID: 7595
		public cnk a;

		// Token: 0x04001DAC RID: 7596
		public c5x b;

		// Token: 0x04001DAD RID: 7597
		public ar7 c;

		// Token: 0x04001DAE RID: 7598
		public ar7 d;

		// Token: 0x04001DAF RID: 7599
		public ar7 e;
	}
}
