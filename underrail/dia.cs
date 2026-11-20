using System;
using System.Runtime.Serialization;

// Token: 0x020007B2 RID: 1970
[eiz("PGFADIA")]
[Serializable]
public sealed class dia : esc, ISerializable
{
	// Token: 0x06003162 RID: 12642 RVA: 0x0012EFAC File Offset: 0x0012D1AC
	private dia(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003163 RID: 12643 RVA: 0x0012EFB8 File Offset: 0x0012D1B8
	public dia()
	{
	}

	// Token: 0x06003164 RID: 12644 RVA: 0x0012EFC4 File Offset: 0x0012D1C4
	public override int d5(bq8 A_0, bq8 A_1)
	{
		ps serviceOrThrow = bpo.GetServiceOrThrow<ps>();
		c5x classPropertyValue = A_0.GetClassPropertyValue<c5x>(c49.a);
		c5x classPropertyValue2 = A_0.GetClassPropertyValue<c5x>(c49.b);
		string value = null;
		if (classPropertyValue2 != null && !classPropertyValue2.IsPlayer)
		{
			value = classPropertyValue2.qe().ToString();
		}
		else if (classPropertyValue != null && !classPropertyValue.IsPlayer)
		{
			value = classPropertyValue.qe().ToString();
		}
		A_0.set_Item("cutsceneDespawneeId", value);
		serviceOrThrow.am3("GenericFadeAndDespawnInterlocutor");
		return 0;
	}
}
