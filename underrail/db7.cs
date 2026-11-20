using System;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001CED RID: 7405
public sealed class db7 : ValueBasedRequirement<int>
{
	// Token: 0x0600A2A1 RID: 41633 RVA: 0x003E9990 File Offset: 0x003E7B90
	public bool a()
	{
		return this.a;
	}

	// Token: 0x0600A2A2 RID: 41634 RVA: 0x003E9998 File Offset: 0x003E7B98
	public override int og()
	{
		return Math.Max(1, (base.c() - aiy.aj * (aiy.ak - 1)) / aiy.aj);
	}

	// Token: 0x0600A2A3 RID: 41635 RVA: 0x003E99BC File Offset: 0x003E7BBC
	public db7(int A_0) : this(A_0, false)
	{
	}

	// Token: 0x0600A2A4 RID: 41636 RVA: 0x003E99C8 File Offset: 0x003E7BC8
	public db7(int A_0, bool A_1) : base(A_0)
	{
		this.a = A_1;
	}

	// Token: 0x0600A2A5 RID: 41637 RVA: 0x003E99DC File Offset: 0x003E7BDC
	public override bool oh(efk A_0)
	{
		czh.a(A_0, "character");
		foreach (Type a_ in new Type[]
		{
			typeof(rs),
			typeof(dql),
			typeof(fd),
			typeof(p5)
		})
		{
			csn csn = A_0.Skills.b(a_);
			if (csn != null && (csn.DLC == null || dk2.b(csn.DLC)))
			{
				if (this.a)
				{
					if (csn.g() >= base.c())
					{
						return true;
					}
				}
				else if (csn.f() >= base.c())
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600A2A6 RID: 41638 RVA: 0x003E9AA8 File Offset: 0x003E7CA8
	public override string ToString()
	{
		return qv.b("Skills/AnyPsi") + " " + base.c().ToString();
	}

	// Token: 0x04003E47 RID: 15943
	private bool a;
}
