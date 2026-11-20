using System;
using System.Runtime.Serialization;

// Token: 0x020016E5 RID: 5861
[eiz("A62")]
[Serializable]
public sealed class efh : a6k, ISerializable
{
	// Token: 0x06007F72 RID: 32626 RVA: 0x0035F860 File Offset: 0x0035DA60
	private efh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F73 RID: 32627 RVA: 0x0035F86C File Offset: 0x0035DA6C
	public efh()
	{
	}

	// Token: 0x06007F74 RID: 32628 RVA: 0x0035F878 File Offset: 0x0035DA78
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			amc b = c5x.h.b;
			if (b != null)
			{
				f9 a_ = new f9(pv.c);
				b.aa().StatusEffects.a(a_, false, false, false);
				return dc4.c;
			}
		}
		return dc4.e;
	}
}
