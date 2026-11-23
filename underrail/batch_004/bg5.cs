using System;
using System.Runtime.Serialization;

// Token: 0x0200172A RID: 5930
[eiz("ISGCA")]
[Serializable]
public sealed class bg5 : a6k
{
	// Token: 0x06008012 RID: 32786 RVA: 0x00360EA8 File Offset: 0x0035F0A8
	private bg5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008013 RID: 32787 RVA: 0x00360EB4 File Offset: 0x0035F0B4
	public bg5()
	{
	}

	// Token: 0x06008014 RID: 32788 RVA: 0x00360EBC File Offset: 0x0035F0BC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			bli bli = c5x.s.b as bli;
			if (bli != null && !bli.i())
			{
				c5x.c().a("Xpbl_BoneCrankInsert");
				bli.a(true);
				bli.k();
				base.vg().e().a(true);
				return dc4.c;
			}
		}
		return dc4.e;
	}
}
