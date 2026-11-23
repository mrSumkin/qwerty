using System;
using System.Runtime.Serialization;

// Token: 0x02000799 RID: 1945
[eiz("FOLeonieRF")]
[Serializable]
public sealed class bss : egv, ISerializable
{
	// Token: 0x060030FD RID: 12541 RVA: 0x0012D124 File Offset: 0x0012B324
	private bss(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060030FE RID: 12542 RVA: 0x0012D12C File Offset: 0x0012B32C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x060030FF RID: 12543 RVA: 0x0012D130 File Offset: 0x0012B330
	public bss()
	{
	}

	// Token: 0x06003100 RID: 12544 RVA: 0x0012D13C File Offset: 0x0012B33C
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 != null && A_0.ap9() != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_fo_mineReopened", new bool?(false)).Value)
				{
					return 2f;
				}
				return bhm.a;
			}
		}
		return bhm.a;
	}
}
