using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules;

// Token: 0x020011C9 RID: 4553
public abstract class ccn
{
	// Token: 0x170001D3 RID: 467
	// (get) Token: 0x060061A4 RID: 24996
	public abstract string Id { get; }

	// Token: 0x170001D4 RID: 468
	// (get) Token: 0x060061A5 RID: 24997
	public abstract string Name { get; }

	// Token: 0x170001D5 RID: 469
	// (get) Token: 0x060061A6 RID: 24998 RVA: 0x002A6E90 File Offset: 0x002A5090
	public virtual double TriggeringChance
	{
		get
		{
			return e3a.a;
		}
	}

	// Token: 0x170001D6 RID: 470
	// (get) Token: 0x060061A7 RID: 24999 RVA: 0x002A6E98 File Offset: 0x002A5098
	public virtual bool Singular
	{
		get
		{
			return false;
		}
	}

	// Token: 0x170001D7 RID: 471
	// (get) Token: 0x060061A8 RID: 25000 RVA: 0x002A6E9C File Offset: 0x002A509C
	public virtual bool Unique
	{
		get
		{
			return false;
		}
	}

	// Token: 0x170001D8 RID: 472
	// (get) Token: 0x060061A9 RID: 25001 RVA: 0x002A6EA0 File Offset: 0x002A50A0
	public virtual string Dlc
	{
		get
		{
			return null;
		}
	}

	// Token: 0x170001D9 RID: 473
	// (get) Token: 0x060061AA RID: 25002 RVA: 0x002A6EA4 File Offset: 0x002A50A4
	public HashSet<string> Categories
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x170001DA RID: 474
	// (get) Token: 0x060061AB RID: 25003 RVA: 0x002A6EAC File Offset: 0x002A50AC
	public virtual GameDifficulty MinimalGameDifficulty
	{
		get
		{
			return GameDifficulty.Easy;
		}
	}

	// Token: 0x170001DB RID: 475
	// (get) Token: 0x060061AC RID: 25004 RVA: 0x002A6EB0 File Offset: 0x002A50B0
	public virtual bool IsStatic
	{
		get
		{
			return false;
		}
	}

	// Token: 0x060061AD RID: 25005 RVA: 0x002A6EB4 File Offset: 0x002A50B4
	protected ccn()
	{
		this.a.Add(e3a.f);
	}

	// Token: 0x060061AE RID: 25006 RVA: 0x002A6ED8 File Offset: 0x002A50D8
	protected ccn(params string[] A_0)
	{
		if (A_0 != null)
		{
			foreach (string text in A_0)
			{
				this.a.Add(text);
			}
		}
	}

	// Token: 0x060061AF RID: 25007
	public abstract bool e2(cyt A_0, c1a A_1, bop A_2);

	// Token: 0x060061B0 RID: 25008
	public abstract void ov(cyt A_0, c1a A_1, bop A_2);

	// Token: 0x060061B1 RID: 25009
	public abstract bool kg(cyt A_0, c1a A_1);

	// Token: 0x04002978 RID: 10616
	private HashSet<string> a = new HashSet<string>();
}
