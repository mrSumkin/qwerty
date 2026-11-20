using System;
using System.Runtime.Serialization;

// Token: 0x02001730 RID: 5936
[eiz("RCSWA")]
[Serializable]
public sealed class dpi : a6k
{
	// Token: 0x06008025 RID: 32805 RVA: 0x003623B8 File Offset: 0x003605B8
	private dpi(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008026 RID: 32806 RVA: 0x003623C4 File Offset: 0x003605C4
	public dpi()
	{
	}

	// Token: 0x06008027 RID: 32807 RVA: 0x003623D0 File Offset: 0x003605D0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			b2x aspect = c5x.GetAspect<b2x>();
			if (aspect != null && aspect.b(base.vg().q()))
			{
				return dc4.c;
			}
		}
		return dc4.e;
	}
}
