using System;
using System.Runtime.Serialization;

// Token: 0x020016D1 RID: 5841
[eiz("A64")]
[Serializable]
public sealed class cve : a6k, ISerializable
{
	// Token: 0x06007F2C RID: 32556 RVA: 0x0035D5AC File Offset: 0x0035B7AC
	private cve(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F2D RID: 32557 RVA: 0x0035D5B8 File Offset: 0x0035B7B8
	public cve()
	{
	}

	// Token: 0x06007F2E RID: 32558 RVA: 0x0035D5C4 File Offset: 0x0035B7C4
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			amc b = c5x.h.b;
			if (b != null)
			{
				dij a_ = new dij(amv.a(base.vg().e()));
				b.aa().StatusEffects.a(a_, false, false, false);
				return dc4.c;
			}
		}
		return dc4.e;
	}
}
