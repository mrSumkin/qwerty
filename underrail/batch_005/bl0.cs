using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001C77 RID: 7287
public abstract class bl0 : aw2
{
	// Token: 0x06009FB9 RID: 40889
	protected abstract DamageType sl();

	// Token: 0x06009FBA RID: 40890 RVA: 0x003E43E0 File Offset: 0x003E25E0
	public bl0(string A_0) : base(A_0)
	{
	}

	// Token: 0x06009FBB RID: 40891 RVA: 0x003E43EC File Offset: 0x003E25EC
	public override object[] at()
	{
		return new object[]
		{
			(int)(bl0.a * 100.0)
		};
	}

	// Token: 0x06009FBC RID: 40892 RVA: 0x003E440C File Offset: 0x003E260C
	public override List<d3e> cy(efk A_0)
	{
		return new List<d3e>
		{
			new e3r(this.sl(), -bl0.a)
		};
	}

	// Token: 0x06009FBD RID: 40893 RVA: 0x003E442C File Offset: 0x003E262C
	public override List<brl> j0()
	{
		List<brl> list = base.j0();
		List<Type> list2 = new List<Type>();
		foreach (ai8 ai in ck.b())
		{
			if (ai is bl0)
			{
				Type type = ai.GetType();
				if (type != base.GetType())
				{
					list2.Add(type);
				}
			}
		}
		list.Add(new awr(typeof(axa), 12));
		list.Add(new c2y(list2.ToArray()));
		return list;
	}

	// Token: 0x04003DB2 RID: 15794
	private new static readonly double a = 0.3;
}
