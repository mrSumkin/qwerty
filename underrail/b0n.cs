using System;
using System.Runtime.Serialization;

// Token: 0x02000FDF RID: 4063
[eiz("SBA")]
[Serializable]
public sealed class b0n : esc, ISerializable
{
	// Token: 0x060053AD RID: 21421 RVA: 0x00251394 File Offset: 0x0024F594
	private b0n(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060053AE RID: 21422 RVA: 0x002513A0 File Offset: 0x0024F5A0
	public override int d5(bq8 A_0, bq8 A_1)
	{
		b0b classPropertyValue = A_0.GetClassPropertyValue<b0b>(c49.a);
		b0b classPropertyValue2 = A_0.GetClassPropertyValue<b0b>(c49.b);
		ps serviceOrThrow = bpo.GetServiceOrThrow<ps>();
		b0b a_;
		b0b a_2;
		if (classPropertyValue2 != null && classPropertyValue2.GetAspect<dvp>() != null)
		{
			a_ = classPropertyValue;
			a_2 = classPropertyValue2;
		}
		else
		{
			a_ = classPropertyValue2;
			a_2 = classPropertyValue;
		}
		if (serviceOrThrow.amw(a_, a_2))
		{
			return 0;
		}
		return -1;
	}

	// Token: 0x060053AF RID: 21423 RVA: 0x002513F8 File Offset: 0x0024F5F8
	public b0n()
	{
	}
}
