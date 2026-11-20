using System;
using System.Runtime.Serialization;

// Token: 0x02000C64 RID: 3172
[eiz("DCTCFICC")]
[Serializable]
public sealed class cr7 : dnh
{
	// Token: 0x0600475C RID: 18268 RVA: 0x001D7288 File Offset: 0x001D5488
	private cr7(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600475D RID: 18269 RVA: 0x001D7294 File Offset: 0x001D5494
	public cr7()
	{
	}

	// Token: 0x0600475E RID: 18270 RVA: 0x001D72A0 File Offset: 0x001D54A0
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			agn classPropertyValue = A_0.GetClassPropertyValue<agn>("dc_mutagenCompound");
			if (classPropertyValue != null)
			{
				return serviceOrThrow.aqu().u().e.Equals(classPropertyValue);
			}
		}
		return false;
	}
}
