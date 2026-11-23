using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001C8C RID: 7308
[d29("Stoicism", "Stoicism")]
public sealed class c85 : ai8
{
	// Token: 0x0600A022 RID: 40994 RVA: 0x003E4F74 File Offset: 0x003E3174
	public c85() : base("肱Стоицизм")
	{
	}

	// Token: 0x0600A023 RID: 40995 RVA: 0x003E4F84 File Offset: 0x003E3184
	public override void ar(efk A_0)
	{
	}

	// Token: 0x0600A024 RID: 40996 RVA: 0x003E4F88 File Offset: 0x003E3188
	public override void @as(efk A_0)
	{
	}

	// Token: 0x0600A025 RID: 40997 RVA: 0x003E4F8C File Offset: 0x003E318C
	public override object[] at()
	{
		return new object[]
		{
			Convert.ToInt32(c85.a * 100.0),
			Convert.ToInt32(c85.b * 100.0)
		};
	}

	// Token: 0x0600A026 RID: 40998 RVA: 0x003E4FD0 File Offset: 0x003E31D0
	public override List<d3e> cy(efk A_0)
	{
		if (A_0 != null)
		{
			double num = (double)((int)((double)Math.Max(0f, 1f - euf.f(A_0)) / c85.b)) * (c85.a + (double)A_0.GetSpecializationValue<d20>(true) * d20.a);
			if (num > 0.0)
			{
				List<d3e> list = new List<d3e>();
				foreach (object obj in Enum.GetValues(typeof(DamageType)))
				{
					DamageType a_ = (DamageType)obj;
					list.Add(new e3r(a_, -num));
				}
				return list;
			}
		}
		return null;
	}

	// Token: 0x0600A027 RID: 40999 RVA: 0x003E5098 File Offset: 0x003E3298
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(axa), 7),
			new awr(typeof(axr), 7)
		};
	}

	// Token: 0x04003DC0 RID: 15808
	public new static readonly double a = 0.01;

	// Token: 0x04003DC1 RID: 15809
	public new static readonly double b = 0.04;
}
