using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000DDC RID: 3548
[e79("Dc_MushroomDream")]
public sealed class hc : dgy
{
	// Token: 0x06004BEC RID: 19436 RVA: 0x002103C8 File Offset: 0x0020E5C8
	public hc()
	{
		hc.a a = new hc.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			a.a.aqu().r()["hidePlayer"] = true;
			a.b = (a.a.aqu().v().b() as c5x);
			bool value = a.a.aqu().r().GetPrimitivePropertyValue<bool>("dc_mushroomDream_reachedLowerCaves", new bool?(false)).Value;
			a.c = new ar7(a.b);
			if (a.b != null)
			{
				if (a.b.i.b != null)
				{
					a.b.i.b.a(true, false);
				}
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
				btm[] array2 = new btm[1];
				int num2 = 0;
				dva dva = new dva(null, null, null, null, null);
				dva.a(new Func<e6d, bool>(hc.b.a.a));
				array2[num2] = dva;
				base.a(array2);
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
					new di4(new c2w("dc-fs5", "Dream"), false, new bool?(false), 0, null, true, false, false)
				});
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				dva dva2 = new dva(null, null, null, null, null);
				dva2.a(new Func<e6d, bool>(a.a));
				array3[num3] = dva2;
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(15.0))
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				dky dky2 = new dky();
				dky2.a(0.2f);
				dky2.IsAsync = false;
				dky2.a(false);
				array4[num4] = dky2;
				base.a(array4);
				btm[] array5 = new btm[1];
				int num5 = 0;
				dva dva3 = new dva(null, null, null, null, null);
				dva3.a(new Func<e6d, bool>(hc.b.a.b));
				array5[num5] = dva3;
				base.a(array5);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
				if (value)
				{
					base.a(new btm[]
					{
						new di4(new c2w("dc-fs4", "FromDream"), false, new bool?(false), 0, null, true, false, false)
					});
				}
				else
				{
					base.a(new btm[]
					{
						new di4(new c2w("dc-fs3", "FromDream"), false, new bool?(false), 0, null, true, false, false)
					});
				}
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				btm[] array6 = new btm[1];
				int num6 = 0;
				dva dva4 = new dva(null, null, null, null, null);
				dva4.a(new Func<e6d, bool>(a.b));
				array6[num6] = dva4;
				base.a(array6);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				btm[] array7 = new btm[1];
				int num7 = 0;
				egx egx = new egx();
				egx.a("Уф... голова раскалывается!");
				array7[num7] = new ace(egx)
				{
					TargetRef = a.c
				};
				base.a(array7);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(4.0))
				});
				if (value)
				{
					btm[] array8 = new btm[1];
					int num8 = 0;
					egx egx2 = new egx();
					egx2.a("Как я здесь оказался?");
					array8[num8] = new ace(egx2)
					{
						TargetRef = a.c
					};
					base.a(array8);
				}
				else
				{
					btm[] array9 = new btm[1];
					int num9 = 0;
					egx egx3 = new egx();
					egx3.a("Где я?");
					array9[num9] = new ace(egx3)
					{
						TargetRef = a.c
					};
					base.a(array9);
				}
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

	// Token: 0x02000DDD RID: 3549
	[CompilerGenerated]
	[Serializable]
	private new sealed class b
	{
		// Token: 0x06004BEF RID: 19439 RVA: 0x00210950 File Offset: 0x0020EB50
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.a);
			}
			return true;
		}

		// Token: 0x06004BF0 RID: 19440 RVA: 0x00210974 File Offset: 0x0020EB74
		internal bool b(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			return true;
		}

		// Token: 0x04001EA2 RID: 7842
		public static readonly hc.b a = new hc.b();

		// Token: 0x04001EA3 RID: 7843
		public static Func<e6d, bool> b;

		// Token: 0x04001EA4 RID: 7844
		public static Func<e6d, bool> c;
	}

	// Token: 0x02000DDE RID: 3550
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004BF2 RID: 19442 RVA: 0x002109A4 File Offset: 0x0020EBA4
		internal bool a(e6d A_0)
		{
			this.a.aqu().r()["hidePlayer"] = false;
			this.b = (this.a.aqu().v().b() as c5x);
			this.c.a(this.b);
			this.b.Location = new Vector3(16f, 8f, 2.2f);
			this.b.ah();
			this.b.ae = new float?(0f);
			this.b.h.b.ap = new CharacterState?(CharacterState.Die);
			this.b.h.b.aq = new int?(1);
			dtb dtb = new dtb();
			for (int i = 0; i < 25; i++)
			{
				for (int j = 0; j <= 7; j++)
				{
					dtb.ad().Add(new bxp(this.b, (HorizontalDirection)j));
					dtb.ad().Add(new bm3(Math.Max(200 - i * 15 - (int)((double)j * 2.1), 30)));
				}
			}
			this.b.i.b.b(dtb, atp.a);
			dtb dtb2 = new dtb();
			for (int k = 0; k <= 100; k++)
			{
				dtb2.ad().Add(new a8v(this.b, new Vector3(16f, 8f, 2.2f - (float)k / 50f)));
				dtb2.ad().Add(new bm3(70));
			}
			this.b.i.b.b(dtb2, atp.a);
			dtb dtb3 = new dtb();
			for (int l = 0; l < 100; l++)
			{
				List<auv> list = dtb3.ad();
				ch3 ch = new ch3();
				ch.a(new float?((float)l / 100f));
				a4s a4s = new a4s(ch, null, null, null);
				a4s.b(this.c);
				list.Add(a4s);
				dtb3.ad().Add(new bm3(15));
			}
			this.b.i.b.b(dtb3, atp.a);
			return true;
		}

		// Token: 0x06004BF3 RID: 19443 RVA: 0x00210BF0 File Offset: 0x0020EDF0
		internal bool b(e6d A_0)
		{
			this.b = (this.a.aqu().v().b() as c5x);
			this.c.a(this.b);
			c1c c1c = Enumerable.FirstOrDefault<c1c>(this.b.h.b.aa().StatusEffects.Get<c1c>());
			if (c1c != null)
			{
				this.b.h.b.aa().StatusEffects.d(c1c);
			}
			return true;
		}

		// Token: 0x04001EA5 RID: 7845
		public cnk a;

		// Token: 0x04001EA6 RID: 7846
		public c5x b;

		// Token: 0x04001EA7 RID: 7847
		public ar7 c;
	}
}
