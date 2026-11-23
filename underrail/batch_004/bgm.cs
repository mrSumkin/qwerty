using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000AEE RID: 2798
[eiz("XPBLPIREAAJ")]
[Serializable]
public sealed class bgm : cze, ISerializable
{
	// Token: 0x06004105 RID: 16645 RVA: 0x0018C7DC File Offset: 0x0018A9DC
	private bgm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004106 RID: 16646 RVA: 0x0018C7E8 File Offset: 0x0018A9E8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06004107 RID: 16647 RVA: 0x0018C7F4 File Offset: 0x0018A9F4
	public bgm()
	{
	}

	// Token: 0x06004108 RID: 16648 RVA: 0x0018C800 File Offset: 0x0018AA00
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_portCeto_aegisAttack_ended", new bool?(false)).Value && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_xpbl_portCeto_attackedByAegis", new bool?(false)).Value)
		{
			foreach (string a_ in new List<string>
			{
				"xpbl_e3",
				"xpbl_f3",
				"xpbl_g3"
			})
			{
				serviceOrThrow.aqu().a(new bw0(a_, new f2(), 1));
			}
			serviceOrThrow.aqu().r()["loc_xpbl_portCeto_underAttack"] = false;
			serviceOrThrow.aqu().r()["loc_xpbl_portCeto_aegisAttack_ended"] = true;
		}
	}
}
