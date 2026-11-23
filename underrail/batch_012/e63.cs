using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020006EE RID: 1774
[eiz("C55")]
[Serializable]
public sealed class e63 : y8, ISerializable
{
	// Token: 0x06002DC1 RID: 11713 RVA: 0x00104308 File Offset: 0x00102508
	private e63(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06002DC2 RID: 11714 RVA: 0x00104314 File Offset: 0x00102514
	public e63()
	{
	}

	// Token: 0x06002DC3 RID: 11715 RVA: 0x00104320 File Offset: 0x00102520
	protected override List<coh> a2()
	{
		List<coh> list = new List<coh>();
		cr4 cr = d79.Get<cr4>();
		if (cr != null)
		{
			int a_ = base.i();
			fv fv = y8.a("Devices\\EmDeflector", null);
			fv fv2 = y8.a("Devices\\EmFieldStabilizer", null);
			fv fv3 = zp.b(y8.a(a_));
			if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null)
			{
				fv.QualityLevel = y8.a(a_);
				fv2.QualityLevel = y8.a(a_);
				fv3.QualityLevel = y8.a(a_);
				coh coh = cr.a(null, new Dictionary<string, coh>
				{
					{
						cr4.a,
						fv
					},
					{
						cr4.b,
						fv2
					},
					{
						cr4.c,
						fv3
					}
				}).a();
				if (coh != null)
				{
					list.Add(coh);
				}
			}
		}
		return list;
	}

	// Token: 0x06002DC4 RID: 11716 RVA: 0x00104430 File Offset: 0x00102630
	public override aw4 a1()
	{
		e63 e = new e63();
		this.rg(e);
		return e;
	}
}
