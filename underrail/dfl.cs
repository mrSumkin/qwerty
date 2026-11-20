using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020006DD RID: 1757
[eiz("G17")]
[Serializable]
public sealed class dfl : y8, ISerializable
{
	// Token: 0x06002D39 RID: 11577 RVA: 0x0010236C File Offset: 0x0010056C
	private dfl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06002D3A RID: 11578 RVA: 0x00102378 File Offset: 0x00100578
	public dfl()
	{
	}

	// Token: 0x06002D3B RID: 11579 RVA: 0x00102384 File Offset: 0x00100584
	public override aw4 a1()
	{
		dfl dfl = new dfl();
		this.rg(dfl);
		return dfl;
	}

	// Token: 0x06002D3C RID: 11580 RVA: 0x001023A0 File Offset: 0x001005A0
	protected override List<coh> a2()
	{
		List<coh> list = new List<coh>();
		aff aff = d79.Get<aff>();
		if (aff != null)
		{
			int a_ = base.i();
			int num = y8.a(a_);
			int a_2 = y8.a(a_);
			fv fv = zp.d(num, null);
			fv fv2 = zp.a(a_2);
			if (fv != null && fv2 != null)
			{
				if (fv.TypedDefinition.i() == ms.d)
				{
					fv.QualityLevel = d05.a(1, num, 40);
				}
				else
				{
					fv.QualityLevel = num;
				}
				fv2.QualityLevel = a_2;
				a12 a = aff.a(null, new Dictionary<string, coh>
				{
					{
						aff.a,
						fv
					},
					{
						aff.b,
						fv2
					}
				}).a() as a12;
				if (a != null)
				{
					list.Add(a);
				}
			}
		}
		return list;
	}
}
