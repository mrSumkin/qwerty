using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B8F RID: 2959
[eiz("CCCAHA")]
[Serializable]
public sealed class cxx : cze, ISerializable
{
	// Token: 0x0600436E RID: 17262 RVA: 0x001A5FDC File Offset: 0x001A41DC
	private cxx(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600436F RID: 17263 RVA: 0x001A5FE8 File Offset: 0x001A41E8
	public cxx()
	{
	}

	// Token: 0x06004370 RID: 17264 RVA: 0x001A5FF4 File Offset: 0x001A41F4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqu().a(new bw0("lup-a11", new cqz(), 1));
			serviceOrThrow.aqu().a(new bw0("cc_cityEnter", new cq1(), 1));
			serviceOrThrow.aqu().a(new bw0("cc1", new cq0(), 1));
			serviceOrThrow.aqu().a(new bw0("cc10", new cq3(), 1));
			serviceOrThrow.aqu().a(new bw0("cc-res", new cd4(), 1));
		}
	}
}
