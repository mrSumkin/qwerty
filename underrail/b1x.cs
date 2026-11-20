using System;

// Token: 0x02000BE1 RID: 3041
public sealed class b1x : jn
{
	// Token: 0x06004574 RID: 17780 RVA: 0x001C3990 File Offset: 0x001C1B90
	public b1x() : base("tch_percival", "creature\\characters\\tch_percival")
	{
	}

	// Token: 0x06004575 RID: 17781 RVA: 0x001C39A8 File Offset: 0x001C1BA8
	public override string b1(cyt A_0)
	{
		if (!A_0.r().GetPrimitivePropertyValue<bool>("global_sawTchoristsSnatchCube", new bool?(false)).Value)
		{
			return "cc20";
		}
		return "tch-lq";
	}

	// Token: 0x06004576 RID: 17782 RVA: 0x001C39E4 File Offset: 0x001C1BE4
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		amc aspect = A_0.GetAspect<amc>();
		if (aspect != null)
		{
			if (string.Equals(A_2, "cc20", StringComparison.OrdinalIgnoreCase))
			{
				aspect.aa().FactionId = asp.ea;
				return;
			}
			aspect.aa().FactionId = asp.es;
		}
	}
}
