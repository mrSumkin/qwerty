using System;
using System.Runtime.Serialization;

// Token: 0x020008E7 RID: 2279
[eiz("CCTRPLDR")]
[Serializable]
public sealed class br6 : bdw, ISerializable
{
	// Token: 0x06003888 RID: 14472 RVA: 0x0014F058 File Offset: 0x0014D258
	private br6(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003889 RID: 14473 RVA: 0x0014F060 File Offset: 0x0014D260
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x0600388A RID: 14474 RVA: 0x0014F064 File Offset: 0x0014D264
	public br6()
	{
	}

	// Token: 0x0600388B RID: 14475 RVA: 0x0014F070 File Offset: 0x0014D270
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("cc17");
			if (aud != null)
			{
				e5u e5u = new e5u();
				e5u.a(aud.y8());
				e5u.a(true);
				e5u.a(new Guid?(new Guid("4305dcc5-e319-455b-98e9-3a2827a123f1")));
				e5u.ym(null, null, null);
			}
		}
	}
}
