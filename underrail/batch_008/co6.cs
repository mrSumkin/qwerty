using System;
using System.Runtime.Serialization;

// Token: 0x02001728 RID: 5928
[eiz("DEUA")]
[Serializable]
public sealed class co6 : a6k
{
	// Token: 0x0600800C RID: 32780 RVA: 0x00360C2C File Offset: 0x0035EE2C
	private co6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600800D RID: 32781 RVA: 0x00360C38 File Offset: 0x0035EE38
	public co6()
	{
	}

	// Token: 0x0600800E RID: 32782 RVA: 0x00360C44 File Offset: 0x0035EE44
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null && c5x.s.b != null)
		{
			c5x.s.b.a(base.vg().q(), base.vg().e().b9() as string, false);
			return dc4.c;
		}
		return dc4.e;
	}
}
