using System;
using System.Runtime.Serialization;

// Token: 0x020009F3 RID: 2547
[eiz("XPBLLESGCA")]
[Serializable]
public sealed class cpo : bdw, ISerializable
{
	// Token: 0x06003CD8 RID: 15576 RVA: 0x00169444 File Offset: 0x00167644
	private cpo(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003CD9 RID: 15577 RVA: 0x0016944C File Offset: 0x0016764C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003CDA RID: 15578 RVA: 0x00169450 File Offset: 0x00167650
	public cpo()
	{
	}

	// Token: 0x06003CDB RID: 15579 RVA: 0x00169458 File Offset: 0x00167658
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null && bpo.GetServiceOrThrow<cnk>() != null)
		{
			c5x c5x = new ar7(new Guid("300c3b9d-949d-4b36-9ed5-2da3d942c759"), A_0.n("xpbl_e6")).ao() as c5x;
			if (c5x != null && c5x.GetAspect<c3g>() != null)
			{
				c5x.RemoveAspect<c3g>();
			}
		}
	}
}
