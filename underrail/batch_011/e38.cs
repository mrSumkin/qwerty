using System;
using System.Runtime.Serialization;

// Token: 0x02001824 RID: 6180
[eiz("RSCOA")]
[Serializable]
public sealed class e38 : a6k, ISerializable
{
	// Token: 0x0600839A RID: 33690 RVA: 0x0036EC44 File Offset: 0x0036CE44
	private e38(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600839B RID: 33691 RVA: 0x0036EC50 File Offset: 0x0036CE50
	public e38()
	{
	}

	// Token: 0x0600839C RID: 33692 RVA: 0x0036EC5C File Offset: 0x0036CE5C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.vg().q() == null || base.vg().q().h == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h == null || c5x.h.b == null)
		{
			return dc4.e;
		}
		coh coh = base.vg().e().b9() as coh;
		if (coh == null || coh.Battery < (double)rb.d)
		{
			return dc4.e;
		}
		coh.Battery -= (double)rb.d;
		double num = rb.a(base.vg().e());
		co5 a_ = new co5(num, rb.g * d0u.b);
		c5x.h.b.aa().StatusEffects.a(a_, false, false, false);
		if (c5x.t.b != null)
		{
			foreach (string name in new string[]
			{
				ddq.h,
				ddq.b
			})
			{
				TimeSpan? primitivePropertyValue = c5x.t.b.y6().GetPrimitivePropertyValue<TimeSpan>(name, null);
				if (primitivePropertyValue != null && primitivePropertyValue > A_0)
				{
					primitivePropertyValue = new TimeSpan?(A_0 + TimeSpan.FromMilliseconds((primitivePropertyValue.Value - A_0).TotalMilliseconds * (1.0 + num)));
					c5x.t.b.y6()[name] = primitivePropertyValue;
				}
			}
		}
		c5x.c().a("ScrambleAi");
		boj.a(c5x, "AiScramble_Cast_Back", 1, double.MaxValue, false, true, null, null, null, null, false);
		boj.a(c5x, "AiScramble_Cast_Front", 1, double.MaxValue, false, true, null, null, null, null, false);
		return dc4.c;
	}
}
