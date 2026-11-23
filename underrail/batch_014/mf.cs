using System;
using System.Runtime.Serialization;

// Token: 0x020016B4 RID: 5812
[eiz("BLTM")]
[Serializable]
public sealed class mf : a6k, ISerializable
{
	// Token: 0x06007ECC RID: 32460 RVA: 0x00359320 File Offset: 0x00357520
	private mf(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007ECD RID: 32461 RVA: 0x0035932C File Offset: 0x0035752C
	public mf()
	{
	}

	// Token: 0x06007ECE RID: 32462 RVA: 0x00359338 File Offset: 0x00357538
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			amc b = c5x.h.b;
			if (b != null)
			{
				b.aa().StatusEffects.a(new c4x(cyc.a(base.vg().e())), false, false, false);
				return dc4.c;
			}
		}
		return dc4.e;
	}
}
