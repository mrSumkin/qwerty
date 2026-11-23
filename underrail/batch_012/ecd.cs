using System;
using System.Runtime.Serialization;

// Token: 0x020007A9 RID: 1961
[eiz("XPBLRCDudeRF")]
[Serializable]
public sealed class ecd : egv, ISerializable
{
	// Token: 0x0600313D RID: 12605 RVA: 0x0012E798 File Offset: 0x0012C998
	private ecd(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600313E RID: 12606 RVA: 0x0012E7A0 File Offset: 0x0012C9A0
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x0600313F RID: 12607 RVA: 0x0012E7A4 File Offset: 0x0012C9A4
	public ecd()
	{
	}

	// Token: 0x06003140 RID: 12608 RVA: 0x0012E7AC File Offset: 0x0012C9AC
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 != null && A_0.ap9() != null)
		{
			return bhm.c;
		}
		return bhm.a;
	}
}
