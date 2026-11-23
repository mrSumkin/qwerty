using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x02000EF3 RID: 3827
[e79("Xphw_ExoBase_RevealFusionCannon")]
public sealed class b4v : dgy
{
	// Token: 0x06004E5D RID: 20061 RVA: 0x0022D824 File Offset: 0x0022BA24
	public b4v()
	{
		b4v.a a = new b4v.a();
		a.a = bpo.GetServiceOrThrow<cnk>();
		if (a.a != null && a.a.aqu() != null)
		{
			a.b = (a.a.aqu().v().b() as c5x);
			if (a.b != null)
			{
				a.b.i.b.a(true, false);
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
					new dva(null, new Func<e6d, bool>(a.a), null, null, null)
				});
				btm[] array = new btm[1];
				int num = 0;
				bfq bfq = new bfq();
				bfq.c("LargeDoor");
				array[num] = new ace(bfq)
				{
					TargetRef = new ar7(a.b)
				};
				base.a(array);
				btm[] array2 = new btm[1];
				int num2 = 0;
				kw kw = new kw();
				kw.a(new bt4("xphw_exobase_lab1", new Vector3(17f, 17f, 0f)));
				kw.a(false);
				kw.IsAsync = true;
				array2[num2] = kw;
				base.a(array2);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(3.0))
				});
				btm[] array3 = new btm[1];
				int num3 = 0;
				eb7 eb = new eb7();
				eb.a(new Guid?(new Guid("509d960e-27e8-4c04-9017-68eb05459dfc")));
				eb.a(true);
				array3[num3] = new ace(eb)
				{
					TargetRef = new ar7(a.b)
				};
				base.a(array3);
				base.a(new btm[]
				{
					new os(TimeSpan.FromSeconds(2.0))
				});
				base.a(new btm[]
				{
					new ace(new bu0("cp_heavyDuty_fusionCannon"))
				});
				base.a(new btm[]
				{
					new ace(new e80(true))
				});
			}
		}
	}

	// Token: 0x02000EF4 RID: 3828
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004E5F RID: 20063 RVA: 0x0022DA50 File Offset: 0x0022BC50
		internal bool a(e6d A_0)
		{
			d60 d = this.b.Zone.a();
			if (d != null)
			{
				foreach (b0b b0b in d.ab4(new string[]
				{
					"FusionLabWall"
				}))
				{
					c5x c5x = (c5x)b0b;
					dtb dtb = new dtb();
					int num = 0;
					do
					{
						if (num < 11)
						{
							num++;
						}
						else
						{
							num--;
						}
						List<auv> list = dtb.ad();
						cm5 cm = new cm5();
						cm.a(num);
						a4s a4s = new a4s(cm, null, null, null);
						a4s.b(new ar7(c5x));
						list.Add(a4s);
						dtb.ad().Add(new bm3(100));
					}
					while (num != 11);
					c5x.i.b.b(dtb, atp.a);
					c5x.TileFormationModifiers.s4(1);
					c5x.TileFormationModifiers.s4(2);
					c5x.TileFormationModifiers.s4(0);
					c5x.z();
					c5x.IsFloor = true;
				}
			}
			c5x c5x2 = new ar7(new Guid("82bb9f55-2d18-43dd-a2dd-8195e0f3b4fb"), this.b.Area).ao() as c5x;
			if (c5x2 != null)
			{
				c5x2.RemoveAspect<bim>();
				d85 d2 = new d85(c5x2);
				c5x2.SetAspect<bim>(d2);
				d2.a().Add("Вы взглянули на результаты тестирования: Все выполненные тестовые задания отмечены зелёным цветом \"Пройдено!\".");
				d2.a().Add("Испытание было прервано на чем-то под названием PsiNeRad, по которому нет никаких данных.");
			}
			this.a.aqu().r()["loc_xphw_exobaselab1_fusionCannonRevealed"] = true;
			return true;
		}

		// Token: 0x04001FF8 RID: 8184
		public cnk a;

		// Token: 0x04001FF9 RID: 8185
		public c5x b;
	}
}
