using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02001AC9 RID: 6857
[eiz("PRSEF")]
[Serializable]
public sealed class jm : els, ISerializable
{
	// Token: 0x060094AD RID: 38061 RVA: 0x003A74F0 File Offset: 0x003A56F0
	private jm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060094AE RID: 38062 RVA: 0x003A7500 File Offset: 0x003A5700
	public jm(int A_0, int A_1, bool A_2 = true) : base(A_2 ? jm.a : (jm.a + Guid.NewGuid().ToString()), "Восстановление пси", ci8.b)
	{
		base.Duration = A_1;
		base.TickPeriod = d0u.b;
		base.Icon = "Status.PsiRegeneration";
		base.Stacking = (A_2 ? axm.b : axm.c);
		base.Power = A_0;
		base.DynamicEffects.Add(new ag8(A_0, true));
	}

	// Token: 0x060094AF RID: 38063 RVA: 0x003A7590 File Offset: 0x003A5790
	public override string cb(ll A_0)
	{
		ag8 ag = Enumerable.FirstOrDefault<wq>(base.DynamicEffects) as ag8;
		if (ag != null)
		{
			return qv.a("StatusEffects/PsiRegeneration", new object[]
			{
				ag.a()
			});
		}
		return string.Empty;
	}

	// Token: 0x04003945 RID: 14661
	public new static readonly string a = "psiRegeneration";
}
