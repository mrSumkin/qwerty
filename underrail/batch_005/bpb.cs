using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000AF7 RID: 2807
[eiz("XPBLIDLJ")]
[Serializable]
public sealed class bpb : cze, ISerializable
{
	// Token: 0x06004125 RID: 16677 RVA: 0x0018DA70 File Offset: 0x0018BC70
	private bpb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004126 RID: 16678 RVA: 0x0018DA7C File Offset: 0x0018BC7C
	public bpb()
	{
	}

	// Token: 0x06004127 RID: 16679 RVA: 0x0018DA88 File Offset: 0x0018BC88
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			double num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<double>(dzd.a, new double?(0.0)).Value;
			num = d05.b(0.0, num + bpb.a, 100.0);
			serviceOrThrow.aqu().r()[dzd.a] = num;
		}
	}

	// Token: 0x04001C11 RID: 7185
	private new static readonly double a = 5.0;
}
