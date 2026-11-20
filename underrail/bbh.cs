using System;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000E40 RID: 3648
[e79("lux_oculus")]
public sealed class bbh : dgy
{
	// Token: 0x06004CBF RID: 19647 RVA: 0x0021A424 File Offset: 0x00218624
	public bbh()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			bbh.a a = new bbh.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			ar7 a_ = new ar7(new Guid("a9bac539-587c-4fa1-9dea-d819bb87c78c"), a.a.Area);
			if (a.a != null)
			{
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array = new btm[1];
				int num = 0;
				kw kw = new kw();
				kw.a(new bt4("global:azif"));
				kw.a(false);
				array[num] = kw;
				base.a(array);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new ace(new dvn("lux-wa", "Oculus"))
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				bb8 bb = new bb8();
				bb.a(CharacterState.CastingPsi);
				bb.a(atp.a);
				bb.IsAsync = false;
				bb.a(a_);
				bb.b(3);
				array2[num2] = bb;
				base.a(array2);
				btm[] array3 = new btm[1];
				int num3 = 0;
				bb8 bb2 = new bb8();
				bb2.a(CharacterState.FinishPsi);
				bb2.a(atp.a);
				bb2.IsAsync = false;
				bb2.a(a_);
				bb2.b(1);
				array3[num3] = bb2;
				base.a(array3);
				base.a(new btm[]
				{
					new ace(new bfq("NeuralOverload", "NeuralOverloadHit"))
					{
						TargetRef = new ar7(a.a)
					}
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				e01 e = new e01();
				e.a(true);
				e.b(true);
				e.a("NeuralOverload");
				e.a(1);
				e.a(2147483647.0);
				e.a(new Vector3?(new Vector3(0f, 0f, a.a.Size.Z / 2f)));
				array4[num4] = new ace(e)
				{
					TargetRef = new ar7(a.a)
				};
				base.a(array4);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				btm[] array5 = new btm[1];
				int num5 = 0;
				kw kw2 = new kw();
				kw2.a(new bt4("FromOculus"));
				kw2.a(false);
				array5[num5] = kw2;
				base.a(array5);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new ace(new bfq("DarkSecretReveal", "DarkSecretReveal"))
					{
						TargetRef = new ar7(a.a)
					}
				});
				btm[] array6 = new btm[1];
				int num6 = 0;
				dva dva = new dva(null, null, null, null, null);
				dva.a(new Func<e6d, bool>(a.a));
				array6[num6] = dva;
				base.a(array6);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(4.0))
				});
				btm[] array7 = new btm[1];
				int num7 = 0;
				s5 s = new s5();
				s.a(a_);
				s.a(new bt4("oculus"));
				array7[num7] = s;
				base.a(array7);
				btm[] array8 = new btm[1];
				int num8 = 0;
				uk uk = new uk();
				uk.c(true);
				array8[num8] = new ace(uk)
				{
					TargetRef = a_
				};
				base.a(array8);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
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

	// Token: 0x02000E41 RID: 3649
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004CC1 RID: 19649 RVA: 0x0021A814 File Offset: 0x00218A14
		internal bool a(e6d A_0)
		{
			doq a_ = doq.a(Path.Combine(d5x.q(), "lux-wa_l2") + ".uzl");
			this.a.Zone.a(a_, 2, null);
			foreach (b0b b0b in this.a.Area.Entities)
			{
				c5x c5x = (c5x)b0b;
				if (c5x.Layer == 2)
				{
					c5x.ae = new float?(0f);
					c5x.Layer = 1;
					ad6 ad = new ad6(c5x);
					ad.b(0.0);
					ad.c(1.0);
					ad.a(0.0005);
					ad6 a_2 = ad;
					c5x.Zone.ActionManager.g9(a_2, atp.a);
				}
			}
			foreach (ya ya in this.a.Area.Triggers)
			{
				if (ya.Layer == 2)
				{
					ya.Layer = 1;
				}
			}
			return true;
		}

		// Token: 0x04001F35 RID: 7989
		public c5x a;
	}
}
