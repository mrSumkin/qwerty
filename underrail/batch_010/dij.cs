using System;
using System.Runtime.Serialization;

// Token: 0x02001B1C RID: 6940
[eiz("UDSE")]
[Serializable]
public sealed class dij : els, ISerializable
{
	// Token: 0x0600962A RID: 38442 RVA: 0x003ACA84 File Offset: 0x003AAC84
	private dij(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600962B RID: 38443 RVA: 0x003ACA90 File Offset: 0x003AAC90
	public dij(int A_0) : base(dij.a, "Невероятное уклонение", ci8.b)
	{
		base.Duration = bov.c * d0u.b;
		base.Stacking = axm.b;
		base.MaxStacks = 100;
		base.Stacks = A_0;
		base.Icon = "UncannyDodge";
	}

	// Token: 0x0600962C RID: 38444 RVA: 0x003ACAE0 File Offset: 0x003AACE0
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/UncannyDodge");
	}

	// Token: 0x040039C8 RID: 14792
	public new static readonly string a = "uncannyDodge";
}
