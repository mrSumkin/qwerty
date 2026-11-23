using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020010B3 RID: 4275
[eiz("TTDJ")]
[Serializable]
public sealed class al6 : cze, ISerializable
{
	// Token: 0x060059D3 RID: 22995 RVA: 0x0026C984 File Offset: 0x0026AB84
	private al6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060059D4 RID: 22996 RVA: 0x0026C990 File Offset: 0x0026AB90
	public al6()
	{
	}

	// Token: 0x060059D5 RID: 22997 RVA: 0x0026C99C File Offset: 0x0026AB9C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.Area != null)
		{
			c5x.TileFormationModifiers.s4(1);
			c5x.z();
			c5x c5x2 = new c5x();
			c5x2.Location = c5x.Location;
			c5x2.Size = c5x.Size;
			c5x2.IsGround = true;
			c5x2.ae = new float?(0f);
			c5x2.VisualPriority = 11;
			c5x2.SetAspect<cd0>(new cd0(c5x2)
			{
				a = "Effects\\TchortlingTumorEx",
				b = new Point(3, 1)
			});
			c5x.Area.a(c5x2);
			qy qy = new qy();
			qy.b(false);
			qy.c(false);
			List<auv> list = qy.ad();
			a4s a4s = new a4s(new bfq("TchortTumorBurst"), null, null, null);
			a4s.b(new ar7(c5x2));
			list.Add(a4s);
			List<auv> list2 = qy.ad();
			aud a_ = c5x.Area;
			Vector3 a_2 = c5x.Location;
			string a_3 = "TumorExplosionBack";
			int a_4 = 1;
			double maxValue = double.MaxValue;
			float? a_5 = dz6.b();
			list2.Add(new au0(a_, a_2, a_3, a_4, maxValue, null, null, a_5));
			List<auv> list3 = qy.ad();
			aud a_6 = c5x.Area;
			Vector3 a_7 = c5x.Location;
			string a_8 = "TumorExplosionFront";
			int a_9 = 1;
			double maxValue2 = double.MaxValue;
			a_5 = dz6.b();
			list3.Add(new au0(a_6, a_7, a_8, a_9, maxValue2, null, null, a_5));
			qy.ad().Add(new a4s(new b9f(new edx(Enumerable.FirstOrDefault<ak1>(c5x.l)), null, false), null, null, null));
			List<auv> list4 = qy.ad();
			ch3 ch = new ch3();
			ch.a(null);
			a4s a4s2 = new a4s(ch, null, null, null);
			a4s2.b(new ar7(c5x2));
			list4.Add(a4s2);
			qy.ad().Add(new bm3(dz6.b(500)));
			List<auv> list5 = qy.ad();
			ad6 ad = new ad6(c5x2);
			ad.b(1.0);
			ad.c(0.0);
			ad.a(dz6.a(0.001));
			list5.Add(ad);
			qy.ad().Add(new c7(c5x2, false, false, true, false));
			c5x.Zone.ActionManager.g9(qy, atp.a);
			dz6.a(qy);
		}
	}
}
