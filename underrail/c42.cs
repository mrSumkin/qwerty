using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000AF1 RID: 2801
[eiz("XPBLLEDMTCJ")]
[Serializable]
public sealed class c42 : cze, ISerializable
{
	// Token: 0x06004113 RID: 16659 RVA: 0x0018CC98 File Offset: 0x0018AE98
	private c42(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004114 RID: 16660 RVA: 0x0018CCA4 File Offset: 0x0018AEA4
	public c42()
	{
	}

	// Token: 0x06004115 RID: 16661 RVA: 0x0018CCB0 File Offset: 0x0018AEB0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqz().atb("xpbl_camp_mines", true);
			serviceOrThrow.aqz().atc("xpbl_camp_mines", true);
			serviceOrThrow.aqu().r()["loc_xpbl_le_campHasAcquiredMines"] = true;
			new beg(true).ym(null, null, null);
			serviceOrThrow.aqu().a(new bw0("xpbl_j1", new r4(), 1));
		}
	}
}
