using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02001AE1 RID: 6881
[eiz("RSEF")]
[Serializable]
public sealed class ze : els, ISerializable
{
	// Token: 0x06009515 RID: 38165 RVA: 0x003A89C8 File Offset: 0x003A6BC8
	private ze(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009516 RID: 38166 RVA: 0x003A89D8 File Offset: 0x003A6BD8
	public ze(int A_0, int A_1, bool A_2 = true) : base(A_2 ? ze.a : (ze.a + Guid.NewGuid().ToString()), "Регенерация", ci8.b)
	{
		base.Duration = A_1;
		base.TickPeriod = d0u.b;
		base.Icon = "Status.69";
		base.Stacking = (A_2 ? axm.b : axm.c);
		base.Power = A_0;
		base.DynamicEffects.Add(new a7i(A_0, 0f));
	}

	// Token: 0x06009517 RID: 38167 RVA: 0x003A8A6C File Offset: 0x003A6C6C
	public override string cb(ll A_0)
	{
		a7i a7i = Enumerable.FirstOrDefault<wq>(base.DynamicEffects) as a7i;
		if (a7i != null)
		{
			return qv.a("StatusEffects/Regeneration", new object[]
			{
				a7i.Amount
			});
		}
		return string.Empty;
	}

	// Token: 0x04003964 RID: 14692
	public new static readonly string a = "regeneration";
}
