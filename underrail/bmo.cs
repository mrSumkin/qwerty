using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02000D26 RID: 3366
[e79("Cc_TrippyDrugs2")]
public sealed class bmo : dgy
{
	// Token: 0x06004A4A RID: 19018 RVA: 0x001F5FEC File Offset: 0x001F41EC
	public bmo()
	{
		bmo.a a = new bmo.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			a.b = (a.a.aqu().v().b() as c5x);
			a.c = new ar7(a.b);
			a.d = new ar7();
			new ar7();
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
					new di4(new c2w("cc10", "FromMotion"), false, new bool?(false), 0, null, false, false, false)
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				dva dva = new dva(null, null, null, null, null);
				dva.a(new Func<e6d, bool>(a.d));
				array2[num2] = dva;
				base.a(array2);
				btm[] array3 = new btm[1];
				int num3 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.IsAsync = false;
				array3[num3] = c8s;
				base.a(array3);
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				egx egx = new egx();
				egx.a("Посмотрим...");
				array4[num4] = new ace(egx)
				{
					TargetRef = a.c
				};
				base.a(array4);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array5 = new btm[1];
				int num5 = 0;
				egx egx2 = new egx();
				egx2.a("\"Расположите остриё скальпеля чуть ниже грудины...\"");
				array5[num5] = new ace(egx2)
				{
					TargetRef = a.c
				};
				base.a(array5);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				btm[] array6 = new btm[1];
				int num6 = 0;
				dva dva2 = new dva(null, null, null, null, null);
				dva2.a(new Func<e6d, bool>(a.c));
				array6[num6] = dva2;
				base.a(array6);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(0.2))
				});
				btm[] array7 = new btm[1];
				int num7 = 0;
				dva dva3 = new dva(null, null, null, null, null);
				dva3.a(new Func<e6d, bool>(a.b));
				array7[num7] = dva3;
				base.a(array7);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array8 = new btm[1];
				int num8 = 0;
				egx egx3 = new egx();
				egx3.a("Позвольте мне помочь, доктор.");
				array8[num8] = new ace(egx3)
				{
					TargetRef = a.d
				};
				base.a(array8);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array9 = new btm[1];
				int num9 = 0;
				egx egx4 = new egx();
				egx4.a("Ох, спасибо...");
				array9[num9] = new ace(egx4)
				{
					TargetRef = a.c
				};
				base.a(array9);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array10 = new btm[1];
				int num10 = 0;
				dva dva4 = new dva(null, null, null, null, null);
				dva4.a(new Func<e6d, bool>(a.a));
				array10[num10] = dva4;
				base.a(array10);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array11 = new btm[1];
				int num11 = 0;
				egx egx5 = new egx();
				egx5.a("Не волнуйтесь. Больно не будет.");
				array11[num11] = new ace(egx5)
				{
					TargetRef = a.d
				};
				base.a(array11);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				for (int i = 0; i < 3; i++)
				{
					btm[] array12 = new btm[1];
					int num12 = 0;
					bfq bfq = new bfq();
					bfq.c("FleshStab2");
					array12[num12] = new ace(bfq)
					{
						TargetRef = a.d
					};
					base.a(array12);
					btm[] array13 = new btm[1];
					int num13 = 0;
					bb8 bb = new bb8();
					bb.a(CharacterState.Attack1);
					bb.a(atp.a);
					bb.IsAsync = false;
					bb.a(a.d);
					bb.b(1);
					array13[num13] = bb;
					base.a(array13);
					btm[] array14 = new btm[1];
					int num14 = 0;
					dva dva5 = new dva(null, null, null, null, null);
					Func<e6d, bool> a_;
					if ((a_ = a.e) == null)
					{
						a_ = (a.e = new Func<e6d, bool>(a.g));
					}
					dva5.a(a_);
					array14[num14] = dva5;
					base.a(array14);
				}
				btm[] array15 = new btm[1];
				int num15 = 0;
				dky dky2 = new dky();
				dky2.a(0.2f);
				dky2.IsAsync = false;
				dky2.a(false);
				array15[num15] = dky2;
				base.a(array15);
				btm[] array16 = new btm[1];
				int num16 = 0;
				dva dva6 = new dva(null, null, null, null, null);
				dva6.a(new Func<e6d, bool>(a.f));
				array16[num16] = dva6;
				base.a(array16);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
				base.a(new btm[]
				{
					new di4(new c2w("cc16", "FromMotion"), false, new bool?(false), 0, null, true, false, false)
				});
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				btm[] array17 = new btm[1];
				int num17 = 0;
				dva dva7 = new dva(null, null, null, null, null);
				dva7.a(new Func<e6d, bool>(a.e));
				array17[num17] = dva7;
				base.a(array17);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array18 = new btm[1];
				int num18 = 0;
				egx egx6 = new egx();
				egx6.a("Фу... как меня угораздило это съесть?..");
				array18[num18] = new ace(egx6)
				{
					TargetRef = a.c
				};
				base.a(array18);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000D27 RID: 3367
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004A4C RID: 19020 RVA: 0x001F6724 File Offset: 0x001F4924
		internal bool d(e6d A_0)
		{
			this.b = (this.a.aqu().v().b() as c5x);
			this.c.a(this.b);
			c5x c5x = new ar7(new Guid("5f46b03e-638d-4b46-b30f-2f520d8104aa"), this.b.Zone.n("cc10")).ao() as c5x;
			if (c5x != null)
			{
				a0l.a(c5x, "forgerGuard_p2", true);
			}
			return true;
		}

		// Token: 0x06004A4D RID: 19021 RVA: 0x001F67A4 File Offset: 0x001F49A4
		internal bool c(e6d A_0)
		{
			c5x c5x = vq.a("creatures\\generichumans\\commoner", this.b.Zone.g("MotionDoc"), false);
			c5x.ae = new float?(0f);
			this.d.a(c5x);
			if (c5x != null && c5x.h.b != null)
			{
				c5x.Layer = 0;
				c5x.h.b.a("doc_f1");
				coh a_ = Enumerable.FirstOrDefault<coh>(new an5().np());
				c5x.h.b.aa().Gear.j()[WeaponKey.Primary].po(a_);
				boj.a(c5x, "Smoke", 1, double.MaxValue, true, true, null, null, null, null, false);
			}
			return true;
		}

		// Token: 0x06004A4E RID: 19022 RVA: 0x001F6898 File Offset: 0x001F4A98
		internal bool b(e6d A_0)
		{
			c5x c5x = this.d.ao() as c5x;
			if (c5x != null)
			{
				c5x.ae = null;
			}
			return true;
		}

		// Token: 0x06004A4F RID: 19023 RVA: 0x001F68CC File Offset: 0x001F4ACC
		internal bool a(e6d A_0)
		{
			this.a.aqu().r()["hidePlayer"] = true;
			if (this.c.ao() != null)
			{
				(this.c.ao() as c5x).ae = new float?(0f);
				c5x c5x = vq.a("object\\container\\corpse\\humanMaleCorpse", this.b.Zone, new bt4(this.b.Area.y8(), new Vector3(20.5f, 28f, 0.9f)), false);
				if (c5x != null)
				{
					c5x.Layer = 0;
					c5x.VisualPriority = 2;
					if (c5x.o.b != null)
					{
						c5x.o.b.a = "Creatures\\" + this.b.h.b.g.a[CharacterState.Die].b;
					}
				}
			}
			return true;
		}

		// Token: 0x06004A50 RID: 19024 RVA: 0x001F69CC File Offset: 0x001F4BCC
		internal bool g(e6d A_0)
		{
			boj.a(this.b.Area, new Vector3(20.5f, 28f, 0.9f), null, "BloodImpact", 1, double.MaxValue, null, null, null, null);
			return true;
		}

		// Token: 0x06004A51 RID: 19025 RVA: 0x001F6A3C File Offset: 0x001F4C3C
		internal bool f(e6d A_0)
		{
			this.d.ao();
			if (this.c.ao() != null)
			{
				(this.c.ao() as c5x).ae = new float?(0f);
			}
			return true;
		}

		// Token: 0x06004A52 RID: 19026 RVA: 0x001F6A80 File Offset: 0x001F4C80
		internal bool e(e6d A_0)
		{
			this.a.aqu().r()["hidePlayer"] = false;
			this.b = (this.a.aqu().v().b() as c5x);
			this.b.Location = this.b.Zone.g("FromMotion").Location + new Vector3(-1f, 0f, 0f);
			this.b.ah();
			this.b.ae = null;
			this.c.a(this.b);
			c5x c5x = new ar7(new Guid("a8539006-64a0-424b-8f1a-8b7dadcf2979"), this.b.Area).ao() as c5x;
			if (c5x != null && c5x.s.b is b0e)
			{
				(c5x.s.b as b0e).d(true);
			}
			return true;
		}

		// Token: 0x04001DA3 RID: 7587
		public cnk a;

		// Token: 0x04001DA4 RID: 7588
		public c5x b;

		// Token: 0x04001DA5 RID: 7589
		public ar7 c;

		// Token: 0x04001DA6 RID: 7590
		public ar7 d;

		// Token: 0x04001DA7 RID: 7591
		public Func<e6d, bool> e;
	}
}
