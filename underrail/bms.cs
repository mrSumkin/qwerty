using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000D2E RID: 3374
[e79("Cc_TrippyDrugs5")]
public sealed class bms : dgy
{
	// Token: 0x06004A67 RID: 19047 RVA: 0x001F8CE4 File Offset: 0x001F6EE4
	public bms()
	{
		bms.a a = new bms.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			a.a.aqu().r()["hidePlayer"] = true;
			a.b = (a.a.aqu().v().b() as c5x);
			a.c = new ar7(a.b);
			a.d = new ar7();
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
					new di4(new c2w("cc_s6", "FromMotion"), false, new bool?(false), 0, null, true, false, false)
				});
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				dva dva = new dva(null, null, null, null, null);
				dva.a(new Func<e6d, bool>(a.c));
				array2[num2] = dva;
				base.a(array2);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(4.0))
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				egx egx = new egx();
				egx.a("Это довольно приятно.");
				array3[num3] = new ace(egx)
				{
					TargetRef = a.c
				};
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(4.0))
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				egx egx2 = new egx();
				egx2.a("Теперь мы ускоряемся, но это ничего \u0097 я люблю скорость.");
				array4[num4] = new ace(egx2)
				{
					TargetRef = a.c
				};
				base.a(array4);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(4.0))
				});
				btm[] array5 = new btm[1];
				int num5 = 0;
				egx egx3 = new egx();
				egx3.a("Немного быстровато.");
				array5[num5] = new ace(egx3)
				{
					TargetRef = a.c
				};
				base.a(array5);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(4.0))
				});
				btm[] array6 = new btm[1];
				int num6 = 0;
				egx egx4 = new egx();
				egx4.a("Так, давай поме-едленне-е-е-е-е-е-е-е....");
				array6[num6] = new ace(egx4)
				{
					TargetRef = a.c
				};
				base.a(array6);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array7 = new btm[1];
				int num7 = 0;
				egx egx5 = new egx();
				egx5.a("А-а-а-а-а-а-а!....");
				array7[num7] = new ace(egx5)
				{
					TargetRef = a.c
				};
				base.a(array7);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(7.0))
				});
				btm[] array8 = new btm[1];
				int num8 = 0;
				dky dky2 = new dky();
				dky2.a(0.2f);
				dky2.IsAsync = false;
				dky2.a(false);
				array8[num8] = dky2;
				base.a(array8);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
				btm[] array9 = new btm[1];
				int num9 = 0;
				dva dva2 = new dva(null, null, null, null, null);
				dva2.a(new Func<e6d, bool>(a.b));
				array9[num9] = dva2;
				base.a(array9);
				base.a(new btm[]
				{
					new di4(new c2w("cc_dock", "FromMotion"), false, new bool?(false), 0, null, true, false, false)
				});
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				btm[] array10 = new btm[1];
				int num10 = 0;
				dva dva3 = new dva(null, null, null, null, null);
				dva3.a(new Func<e6d, bool>(a.a));
				array10[num10] = dva3;
				base.a(array10);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array11 = new btm[1];
				int num11 = 0;
				egx egx6 = new egx();
				egx6.a("Фу-у... какая гадость.");
				array11[num11] = new ace(egx6)
				{
					TargetRef = a.d
				};
				base.a(array11);
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

	// Token: 0x02000D2F RID: 3375
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004A69 RID: 19049 RVA: 0x001F9280 File Offset: 0x001F7480
		internal bool c(e6d A_0)
		{
			this.a.aqu().r()["hidePlayer"] = false;
			this.b = (this.a.aqu().v().b() as c5x);
			this.c.a(this.b);
			this.b.Location = new Vector3(5f, 5f, -2f);
			this.b.ah();
			this.b.ae = new float?(0f);
			this.b.h.b.ap = new CharacterState?(CharacterState.Die);
			this.b.h.b.aq = new int?(1);
			dtb dtb = new dtb();
			for (int i = 0; i < 40; i++)
			{
				for (int j = 0; j <= 7; j++)
				{
					dtb.ad().Add(new bxp(this.b, (HorizontalDirection)j));
					dtb.ad().Add(new bm3(Math.Max(200 - i * 10 - (int)((double)j * 1.4), 50)));
				}
			}
			this.b.i.b.b(dtb, atp.a);
			dtb dtb2 = new dtb();
			for (int k = 0; k < 100; k++)
			{
				ah7 a_ = this.b.Zone.i("motion");
				dtb2.ad().Add(new ia(a_, (float)k / 100f));
				dtb2.ad().Add(new bm3(25));
			}
			this.b.i.b.b(dtb2, atp.a);
			dtb dtb3 = new dtb();
			for (int l = 0; l <= 100; l++)
			{
				dtb3.ad().Add(new a8v(this.b, new Vector3(5f, 5f, -2f + (float)l / 25f)));
				dtb3.ad().Add(new bm3(70));
			}
			this.b.i.b.b(dtb3, atp.a);
			dtb dtb4 = new dtb();
			for (int m = 0; m < 100; m++)
			{
				List<auv> list = dtb4.ad();
				ch3 ch = new ch3();
				ch.a(new float?((float)m / 100f));
				a4s a4s = new a4s(ch, null, null, null);
				a4s.b(this.c);
				list.Add(a4s);
				dtb4.ad().Add(new bm3(15));
			}
			this.b.i.b.b(dtb4, atp.a);
			return true;
		}

		// Token: 0x06004A6A RID: 19050 RVA: 0x001F9548 File Offset: 0x001F7748
		internal bool b(e6d A_0)
		{
			ah7 ah = this.b.Zone.i("motion");
			if (ah != null)
			{
				ah.Enabled = false;
				ah.d();
			}
			return true;
		}

		// Token: 0x06004A6B RID: 19051 RVA: 0x001F9580 File Offset: 0x001F7780
		internal bool a(e6d A_0)
		{
			this.b = (this.a.aqu().v().b() as c5x);
			this.c.a(this.b);
			this.d.a(new ar7(new Guid("2ec019eb-98a2-4c94-8094-fc4cc1284887"), this.b.Area).ao() as c5x);
			if (this.d.ao() != null)
			{
				aw1.b(this.d.ao(), this.b, false);
			}
			return true;
		}

		// Token: 0x04001DB8 RID: 7608
		public cnk a;

		// Token: 0x04001DB9 RID: 7609
		public c5x b;

		// Token: 0x04001DBA RID: 7610
		public ar7 c;

		// Token: 0x04001DBB RID: 7611
		public ar7 d;
	}
}
