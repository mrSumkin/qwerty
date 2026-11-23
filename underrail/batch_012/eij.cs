using System;
using System.Collections.Generic;

// Token: 0x02001CB1 RID: 7345
[d29("Polymath", "Polymath")]
public sealed class eij : ai8
{
	// Token: 0x0600A0F9 RID: 41209 RVA: 0x003E6C58 File Offset: 0x003E4E58
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A0FA RID: 41210 RVA: 0x003E6C5C File Offset: 0x003E4E5C
	public eij() : base("肈Эрудит")
	{
	}

	// Token: 0x0600A0FB RID: 41211 RVA: 0x003E6C6C File Offset: 0x003E4E6C
	public override void ar(efk A_0)
	{
		e3q e3q = A_0 as e3q;
		if (e3q != null)
		{
			e3q e3q2 = e3q;
			e3q2.d(e3q2.h() + aiy.aj * aiy.ak);
		}
	}

	// Token: 0x0600A0FC RID: 41212 RVA: 0x003E6CA0 File Offset: 0x003E4EA0
	public override void @as(efk A_0)
	{
		e3q e3q = A_0 as e3q;
		if (e3q != null)
		{
			e3q e3q2 = e3q;
			e3q2.d(e3q2.h() - aiy.aj * aiy.ak);
		}
	}

	// Token: 0x0600A0FD RID: 41213 RVA: 0x003E6CD4 File Offset: 0x003E4ED4
	public override object[] at()
	{
		return new object[]
		{
			aiy.aj * aiy.ak,
			aiy.aj
		};
	}

	// Token: 0x0600A0FE RID: 41214 RVA: 0x003E6CFC File Offset: 0x003E4EFC
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(av8), 8)
		};
	}
}
