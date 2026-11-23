using System;
using System.Collections.Generic;
using Ouroboros.Playfield.Space;

// Token: 0x02000FF5 RID: 4085
public static class dm0
{
	// Token: 0x06005416 RID: 21526 RVA: 0x00253538 File Offset: 0x00251738
	public static void a(c5x A_0)
	{
		if (A_0.h.b != null && !A_0.h.b.aa().SpecialStates.h && !A_0.h.b.aa().SpecialStates.k)
		{
			qy qy = new qy();
			qy.b(false);
			qy.c(false);
			List<auv> list = qy.ad();
			string a_ = "SlimeBurst";
			int a_2 = 1;
			double maxValue = double.MaxValue;
			bool a_3 = false;
			bool a_4 = false;
			float? a_5 = dz6.b();
			list.Add(new a7j(A_0, a_, a_2, maxValue, a_3, a_4, null, null, null, a_5, false, null));
			ezd ezd = new ezd("locale\\creatures\\spawn", new bt4(A_0.Area.y8(), A_0.Location.a().a()), new HorizontalDirection?((HorizontalDirection)cuo.a.Next(8)), null, null, null, null);
			foreach (cze a_6 in A_0.h.b.ay())
			{
				List<auv> list2 = qy.ad();
				a4s a4s = new a4s(a_6, null, null, null);
				a4s.b(new ar7(A_0));
				list2.Add(a4s);
			}
			List<auv> list3 = qy.ad();
			c7 c = new c7(A_0, false, false, true, false);
			c.a(true);
			list3.Add(c);
			qy.ad().Add(new a4s(ezd, null, null, null));
			List<auv> list4 = qy.ad();
			a4s a4s2 = new a4s(new bfq(Guid.NewGuid().ToString(), "BurrowerEggBurst"), null, null, null);
			a4s2.b(ezd.f());
			list4.Add(a4s2);
			A_0.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
		}
	}
}
