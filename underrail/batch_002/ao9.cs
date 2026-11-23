using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators;

// Token: 0x020006E0 RID: 1760
[eiz("TBG")]
[Serializable]
public sealed class ao9 : y8, ISerializable
{
	// Token: 0x06002D51 RID: 11601 RVA: 0x0010284C File Offset: 0x00100A4C
	private ao9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06002D52 RID: 11602 RVA: 0x00102858 File Offset: 0x00100A58
	public ao9()
	{
	}

	// Token: 0x06002D53 RID: 11603 RVA: 0x00102864 File Offset: 0x00100A64
	public override aw4 a1()
	{
		ao9 ao = new ao9();
		this.rg(ao);
		return ao;
	}

	// Token: 0x06002D54 RID: 11604 RVA: 0x00102880 File Offset: 0x00100A80
	protected override List<coh> a2()
	{
		List<coh> list = new List<coh>();
		d46 d = d79.Get<d46>();
		if (d != null)
		{
			int num = y8.a(base.i());
			fv fv = this.a(num);
			fv fv2 = y8.a("armors\\RubberSole", null);
			if (fv != null && fv2 != null)
			{
				fv2.Stacks = 2;
				if (fv.TypedDefinition.i() == ms.d)
				{
					fv.QualityLevel = d05.a(1, num, 40);
				}
				else
				{
					fv.QualityLevel = num;
				}
				a12 a = d.a(null, new Dictionary<string, coh>
				{
					{
						d46.a,
						fv
					},
					{
						d46.b,
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

	// Token: 0x06002D55 RID: 11605 RVA: 0x00102954 File Offset: 0x00100B54
	private fv a(int A_0)
	{
		new ItemPoolForQuality<string>(A_0);
		if (zp.a.NextDouble() < 0.35)
		{
			return zp.b(A_0, null);
		}
		return zp.c(A_0, null);
	}
}
