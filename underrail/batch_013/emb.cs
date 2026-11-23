using System;
using System.Runtime.Serialization;

// Token: 0x02001484 RID: 5252
[eiz("IMA0")]
[Serializable]
public sealed class emb : a6k, ISerializable
{
	// Token: 0x06007670 RID: 30320 RVA: 0x00321A00 File Offset: 0x0031FC00
	private emb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007671 RID: 30321 RVA: 0x00321A0C File Offset: 0x0031FC0C
	public emb()
	{
	}

	// Token: 0x06007672 RID: 30322 RVA: 0x00321A18 File Offset: 0x0031FC18
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null && c5x.h.b != null && !c5x.h.b.aa().Dead && c5x.Zone != null && base.vg().q() != null && base.vg().q().h.b != null)
		{
			coh coh = base.vg().e().b9() as coh;
			if (coh != null && coh.Definition != null)
			{
				string classPropertyValue = coh.Definition.a7().GetClassPropertyValue<string>("Медицинский препарат");
				if (!string.IsNullOrEmpty(classPropertyValue))
				{
					a4x a4x = awu.a(classPropertyValue);
					if (a4x != null)
					{
						a4x.gu(base.vg().e(), base.vg().q().h.b, c5x.h.b);
						return dc4.c;
					}
				}
			}
			return dc4.e;
		}
		return dc4.c;
	}
}
