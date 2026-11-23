using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000AF3 RID: 2803
[eiz("XPBLSKPDJ")]
[Serializable]
public sealed class lf : cze, ISerializable
{
	// Token: 0x06004119 RID: 16665 RVA: 0x0018D220 File Offset: 0x0018B420
	private lf(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600411A RID: 16666 RVA: 0x0018D22C File Offset: 0x0018B42C
	public lf()
	{
	}

	// Token: 0x0600411B RID: 16667 RVA: 0x0018D234 File Offset: 0x0018B434
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.Zone != null)
		{
			c5x c5x = A_1.Zone.a().ab5("Corpse_" + A_1.qe().ToString()) as c5x;
			if (c5x != null)
			{
				dm dm = new dm(c5x);
				dm.d().Add(new apu());
				dm.a(new int?(d0u.b / 5));
				c5x.SetAspect<dm>(dm);
				if (c5x.o.b != null)
				{
					if (c5x.o.b.a.StartsWith("Creatures\\xpbl_svgkgt\\", StringComparison.OrdinalIgnoreCase))
					{
						c5x.o.b.a = "Creatures\\xpbl_svgkgt\\c4";
					}
					else
					{
						c5x.o.b.a = "Creatures\\xpbl_svgkg\\c4";
					}
					c5x.o.b.b = new Point(0, c5x.o.b.b.Y);
					qy qy = new qy();
					qy.ad().Add(new bm3(dz6.b(1000)));
					qy.ad().Add(new a4s(new bfq("Xpbl_SavageKingSpearShatter"), null, new ar7(c5x), null));
					List<auv> list = qy.ad();
					dqm dqm = new dqm(c5x.o.b);
					dqm.c(6);
					dqm.a((double)dz6.b(80));
					list.Add(dqm);
					if (c5x.o.b.a.StartsWith("Creatures\\xpbl_svgkgt\\", StringComparison.OrdinalIgnoreCase))
					{
						List<auv> list2 = qy.ad();
						c66 c = new c66();
						c.d(true);
						c.a("Creatures\\xpbl_svgkgt\\c5");
						c.a(true);
						c.b(0);
						list2.Add(new a4s(c, null, new ar7(c5x), null));
					}
					else
					{
						List<auv> list3 = qy.ad();
						c66 c2 = new c66();
						c2.d(true);
						c2.a("Creatures\\xpbl_svgkg\\c5");
						c2.a(true);
						c2.b(0);
						list3.Add(new a4s(c2, null, new ar7(c5x), null));
					}
					for (int i = 0; i < 4; i++)
					{
						qy.ad().Add(new a4s(new rp(0), null, new ar7(c5x), null));
						List<auv> list4 = qy.ad();
						dqm dqm2 = new dqm(c5x.o.b);
						dqm2.c(4);
						dqm2.a((double)dz6.b(40));
						list4.Add(dqm2);
					}
					if (c5x.o.b.a.StartsWith("Creatures\\xpbl_svgkgt\\", StringComparison.OrdinalIgnoreCase))
					{
						List<auv> list5 = qy.ad();
						c66 c3 = new c66();
						c3.d(true);
						c3.a("Creatures\\xpbl_svgkgt\\c6");
						c3.a(true);
						c3.b(0);
						list5.Add(new a4s(c3, null, new ar7(c5x), null));
					}
					else
					{
						List<auv> list6 = qy.ad();
						c66 c4 = new c66();
						c4.d(true);
						c4.a("Creatures\\xpbl_svgkg\\c6");
						c4.a(true);
						c4.b(0);
						list6.Add(new a4s(c4, null, new ar7(c5x), null));
					}
					List<auv> list7 = qy.ad();
					dqm dqm3 = new dqm(c5x.o.b);
					dqm3.c(7);
					dqm3.a((double)dz6.b(50));
					list7.Add(dqm3);
					qy.ad().Add(new a4s(new bfq("FleshStab2"), null, new ar7(c5x), null));
					c5x.Zone.ActionManager.g9(qy, atp.a);
					dz6.a(qy);
				}
			}
		}
	}
}
