using System;
using System.Linq;

// Token: 0x02000BC9 RID: 3017
public sealed class d4q : eny
{
	// Token: 0x0600451E RID: 17694 RVA: 0x001C1A48 File Offset: 0x001BFC48
	public override string mt()
	{
		return "psionicTransceiver";
	}

	// Token: 0x0600451F RID: 17695 RVA: 0x001C1A50 File Offset: 0x001BFC50
	public override int? mu()
	{
		return new int?(10);
	}

	// Token: 0x06004520 RID: 17696 RVA: 0x001C1A5C File Offset: 0x001BFC5C
	public override int? mv()
	{
		return new int?(20);
	}

	// Token: 0x06004521 RID: 17697 RVA: 0x001C1A68 File Offset: 0x001BFC68
	public override void mw(coh A_0, int A_1)
	{
		int num = base.b(A_1);
		base.mw(A_0, num);
		bqu bqu = A_0.Definition as bqu;
		if (bqu != null)
		{
			double num2 = base.a(num);
			int a_ = Convert.ToInt32(10.0 + 20.0 * num2);
			bdz bdz = Enumerable.FirstOrDefault<d3e>(bqu.ar()) as bdz;
			if (bdz != null)
			{
				bdz.a(a_);
			}
			e12 e = Enumerable.FirstOrDefault<wq>(bqu.ao()) as e12;
			if (e != null)
			{
				e.a(Convert.ToInt32(10.0 + num2 * 10.0));
			}
			base.a(bqu, num, 0.35);
		}
	}
}
