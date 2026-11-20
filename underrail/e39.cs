using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000AF0 RID: 2800
[eiz("XPBLLEUCJ")]
[Serializable]
public sealed class e39 : cze, ISerializable
{
	// Token: 0x06004110 RID: 16656 RVA: 0x0018CBAC File Offset: 0x0018ADAC
	private e39(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004111 RID: 16657 RVA: 0x0018CBB8 File Offset: 0x0018ADB8
	public e39()
	{
	}

	// Token: 0x06004112 RID: 16658 RVA: 0x0018CBC4 File Offset: 0x0018ADC4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			foreach (string a_ in new List<string>
			{
				"xpbl_d5",
				"xpbl_d6",
				"xpbl_e5",
				"xpbl_e6",
				"xpbl_fu"
			})
			{
				serviceOrThrow.aqu().a(new bw0(a_, new dtk(), 1));
			}
			serviceOrThrow.aqu().r()["global_xpbl_expeditionUndeployed"] = true;
		}
	}
}
