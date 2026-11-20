using System;
using System.Runtime.Serialization;

// Token: 0x020007B8 RID: 1976
[eiz("PGFCA")]
[Serializable]
public sealed class ah2 : esc, ISerializable
{
	// Token: 0x0600317D RID: 12669 RVA: 0x0012F6A8 File Offset: 0x0012D8A8
	private ah2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600317E RID: 12670 RVA: 0x0012F6B4 File Offset: 0x0012D8B4
	public ah2()
	{
	}

	// Token: 0x0600317F RID: 12671 RVA: 0x0012F6BC File Offset: 0x0012D8BC
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
		A_0.set_Item("cutsceneSpeakerId", value);
		serviceOrThrow.am3("GenericFadeTransition");
		return 0;
	}
}
