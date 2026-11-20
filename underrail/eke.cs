using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x02000910 RID: 2320
[eiz("CCSFBQ")]
[Serializable]
public sealed class eke : bdw, ISerializable
{
	// Token: 0x0600392F RID: 14639 RVA: 0x00152DA0 File Offset: 0x00150FA0
	private eke(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003930 RID: 14640 RVA: 0x00152DA8 File Offset: 0x00150FA8
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003931 RID: 14641 RVA: 0x00152DAC File Offset: 0x00150FAC
	public eke()
	{
	}

	// Token: 0x06003932 RID: 14642 RVA: 0x00152DB8 File Offset: 0x00150FB8
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("cc15");
			if (aud != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "cc15_l2") + ".uzl");
				aud.Zone.a(a_, 1, null);
			}
			c5x c5x = new ar7(new Guid("f2055008-3318-4eab-b1a7-5428837d84b9"), aud).ao() as c5x;
			cnb aspect = c5x.GetAspect<cnb>();
			if (c5x != null)
			{
				d2b aspect2 = c5x.GetAspect<d2b>();
				if (aspect != null && aspect.q())
				{
					aspect.d(false);
				}
				if (aspect2 != null)
				{
					aspect2.a(true, false);
				}
			}
		}
	}
}
