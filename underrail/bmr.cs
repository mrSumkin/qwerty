using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000C93 RID: 3219
[e79("Cc_TrippyDrugs6")]
public sealed class bmr : dgy
{
	// Token: 0x060048F0 RID: 18672 RVA: 0x001DC0D4 File Offset: 0x001DA2D4
	public bmr()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			bmr.a a = new bmr.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			a.b = new ar7(a.a);
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
				base.a(new btm[]
				{
					new ace(new epw(new CharacterState?(CharacterState.Stunned)))
					{
						TargetRef = new ar7(a.a)
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
						TargetRef = new ar7(a.a)
					}
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.d), null, null, null)
				});
				btm[] array2 = new btm[1];
				int num2 = 0;
				c8s c8s = new c8s();
				c8s.a(0.2f);
				c8s.IsAsync = false;
				c8s.a(false);
				array2[num2] = c8s;
				base.a(array2);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.c), null, null, null)
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(4.0))
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				egx egx = new egx();
				egx.a("КР-Р-Р!");
				array3[num3] = new ace(egx)
				{
					TargetRef = a.b
				};
				base.a(array3);
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
					new os(TimeSpan.FromSeconds(3.2))
				});
				btm[] array4 = new btm[1];
				int num4 = 0;
				egx egx2 = new egx();
				egx2.a("Те-хе-хе-хе-хе!");
				array4[num4] = new ace(egx2)
				{
					TargetRef = a.b
				};
				base.a(array4);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				base.a(new btm[]
				{
					new dva(null, new Func<e6d, bool>(a.a), null, null, null)
				});
				btm[] array5 = new btm[1];
				int num5 = 0;
				dky dky2 = new dky();
				dky2.a(0.2f);
				dky2.IsAsync = false;
				dky2.a(false);
				array5[num5] = dky2;
				base.a(array5);
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(1.0))
				});
				base.a(new btm[]
				{
					new di4(new c2w("cc_utility1", "FromMotion"), false, new bool?(false), 0, null, true, false, false)
				});
				base.a(new btm[]
				{
					new ace(new e80(false))
				});
				btm[] array6 = new btm[1];
				int num6 = 0;
				egx egx3 = new egx();
				egx3.a("Чёрт, у меня руки горят!");
				array6[num6] = new ace(egx3)
				{
					TargetRef = a.b
				};
				base.a(array6);
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

	// Token: 0x02000C94 RID: 3220
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x060048F2 RID: 18674 RVA: 0x001DC530 File Offset: 0x001DA730
		internal bool d(e6d A_0)
		{
			a0l.a(this.a, "FromMotion", true);
			this.a.Location = new Vector3(13f, 12f, -2.9f);
			this.a.ah();
			return true;
		}

		// Token: 0x060048F3 RID: 18675 RVA: 0x001DC574 File Offset: 0x001DA774
		internal bool c(e6d A_0)
		{
			dtb dtb = new dtb();
			for (int i = 0; i <= 8; i++)
			{
				dtb.ad().Add(new a8v(this.a, new Vector3(13f, 12f, -2.9f + (float)i / 25f)));
				dtb.ad().Add(new bm3(70));
			}
			this.a.i.b.b(dtb, atp.a);
			return true;
		}

		// Token: 0x060048F4 RID: 18676 RVA: 0x001DC5F4 File Offset: 0x001DA7F4
		internal bool b(e6d A_0)
		{
			List<string> list = new List<string>
			{
				"Что за?!..",
				"Эй!",
				"Что с тобой не так?",
				"Чёртовы эмоции!",
				"Безликие атакуют!"
			};
			foreach (b0b b0b in Enumerable.ToList<b0b>(this.a.Area.Entities))
			{
				c5x c5x = (c5x)b0b;
				if (c5x.h.b != null && c5x.h.b.aa().b(d8o.b) && !c5x.IsPlayer)
				{
					dtb dtb = new dtb();
					dtb.ad().Add(new bm3(cuo.a.Next(1, 20) * 10));
					dtb.ad().Add(new a4s(new akw(), new ar7(c5x), this.b, null));
					if (c5x.u.b != null && cuo.a.Next(0, 101) <= 30)
					{
						List<auv> list2 = dtb.ad();
						egx egx = new egx();
						egx.a(list[cuo.a.Next(0, list.Count)]);
						egx.b(true);
						list2.Add(new a4s(egx, new ar7(c5x), null, null));
					}
					c5x.i.b.b(dtb, atp.a);
				}
			}
			return true;
		}

		// Token: 0x060048F5 RID: 18677 RVA: 0x001DC7A0 File Offset: 0x001DA9A0
		internal bool a(e6d A_0)
		{
			dtb dtb = new dtb();
			for (int i = 0; i <= 8; i++)
			{
				dtb.ad().Add(new a8v(this.a, new Vector3(13f, 12f, this.a.Location.Z - (float)i / 25f)));
				dtb.ad().Add(new bm3(70));
			}
			this.a.i.b.b(dtb, atp.a);
			return true;
		}

		// Token: 0x04001CCC RID: 7372
		public c5x a;

		// Token: 0x04001CCD RID: 7373
		public ar7 b;
	}
}
