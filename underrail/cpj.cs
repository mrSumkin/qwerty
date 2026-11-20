using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators;

// Token: 0x020006FC RID: 1788
[eiz("SPG")]
[Serializable]
public sealed class cpj : d1k, ISerializable
{
	// Token: 0x06002E5D RID: 11869 RVA: 0x001070B0 File Offset: 0x001052B0
	private cpj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06002E5E RID: 11870 RVA: 0x001070BC File Offset: 0x001052BC
	public cpj()
	{
	}

	// Token: 0x06002E5F RID: 11871 RVA: 0x001070C8 File Offset: 0x001052C8
	public override aw4 a1()
	{
		cpj cpj = new cpj();
		this.rg(cpj);
		return cpj;
	}

	// Token: 0x06002E60 RID: 11872 RVA: 0x001070E4 File Offset: 0x001052E4
	protected override cd1 rf(int A_0)
	{
		afl afl = d79.Get<afl>();
		if (afl != null)
		{
			int a_ = y8.a(A_0);
			fv fv = zp.d(a_, null);
			fv fv2 = y8.a("Weapons\\Xpbl\\SpearShaft", null);
			if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null)
			{
				fv.QualityLevel = a_;
				fv fv3 = this.a(A_0);
				fv fv4 = null;
				if (fv3 != null)
				{
					fv3.QualityLevel = y8.a(A_0);
					int a_2 = y8.a(A_0);
					fv4 = zp.b(a_2);
					fv4.QualityLevel = a_2;
				}
				return afl.a(null, new Dictionary<string, coh>
				{
					{
						afl.a,
						fv
					},
					{
						afl.b,
						fv2
					},
					{
						afl.d,
						fv3
					},
					{
						afl.e,
						fv4
					}
				}).a() as cd1;
			}
		}
		return null;
	}

	// Token: 0x06002E61 RID: 11873 RVA: 0x001071DC File Offset: 0x001053DC
	private fv a(int A_0)
	{
		if (A_0 >= 3 && zp.a.NextDouble() < 0.15)
		{
			ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(10 + A_0 * 5);
			itemPoolForQuality.a("ElectroshockGenerator", int.MinValue, int.MaxValue, 1);
			string text = itemPoolForQuality.a();
			if (text != null)
			{
				return y8.a("Weapons\\" + text, null);
			}
		}
		return null;
	}
}
