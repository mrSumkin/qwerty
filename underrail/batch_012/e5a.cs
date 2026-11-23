using System;
using System.Runtime.Serialization;

// Token: 0x020017D8 RID: 6104
[eiz("TDBA")]
[Serializable]
public sealed class e5a : a6k, ISerializable
{
	// Token: 0x06008212 RID: 33298 RVA: 0x0036C218 File Offset: 0x0036A418
	private e5a(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008213 RID: 33299 RVA: 0x0036C224 File Offset: 0x0036A424
	public e5a()
	{
	}

	// Token: 0x06008214 RID: 33300 RVA: 0x0036C230 File Offset: 0x0036A430
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		coh coh = base.vg().e().b9() as coh;
		if (coh != null)
		{
			avz avz = coh.Definition as avz;
			au2 au = base.vg().q().h.b.aa() as au2;
			if (avz != null && au != null && !string.IsNullOrEmpty(avz.b()) && base.vg().q().h.b != null && base.vg().q().h.b.aa() is e3q && df6.a(avz.b(), base.vg().q().h.b.aa() as e3q))
			{
				return dc4.c;
			}
		}
		return dc4.e;
	}
}
