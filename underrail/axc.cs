using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02000A52 RID: 2642
[eiz("CCDJ")]
[Serializable]
public sealed class axc : cze, ISerializable
{
	// Token: 0x06003E7F RID: 15999 RVA: 0x001797A0 File Offset: 0x001779A0
	private axc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003E80 RID: 16000 RVA: 0x001797AC File Offset: 0x001779AC
	public axc()
	{
	}

	// Token: 0x06003E81 RID: 16001 RVA: 0x001797B8 File Offset: 0x001779B8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null)
		{
			c5x.c().a("WheeledBot1Explosion");
			c5x.c().a("WheeledBot1Rumble");
			c5x a_ = c5x;
			string a_2 = "ExplosionMedium";
			int a_3 = 1;
			double maxValue = double.MaxValue;
			bool a_4 = true;
			bool a_5 = true;
			float? a_6 = dz6.b();
			c5x c5x2 = boj.a(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false);
			if (c5x2 != null && c5x2.o.b != null)
			{
				c5x2.o.b.b = new Point(c5x2.o.b.b.X, cuo.a.Next(7));
			}
			c5x a_7 = A_1 as c5x;
			string a_8 = "BlurredSmokeSlow" + (cuo.a.Next(3) + 1).ToString();
			int a_9 = 1;
			double maxValue2 = double.MaxValue;
			bool a_10 = true;
			bool a_11 = true;
			a_6 = dz6.b();
			boj.a(a_7, a_8, a_9, maxValue2, a_10, a_11, null, null, null, a_6, false);
		}
	}
}
