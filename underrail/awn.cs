using System;

// Token: 0x02000FA0 RID: 4000
public abstract class awn : cxf
{
	// Token: 0x060051C0 RID: 20928 RVA: 0x0024C0B4 File Offset: 0x0024A2B4
	public override bool hm(cnm A_0)
	{
		return (A_0 == null || A_0.b8() == null || !A_0.b8().c(d8o.e)) && base.hm(A_0);
	}

	// Token: 0x060051C1 RID: 20929 RVA: 0x0024C0E4 File Offset: 0x0024A2E4
	protected override float cl(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null)
		{
			return A_0.b8().Defense.ah();
		}
		return 1f;
	}
}
