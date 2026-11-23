using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000014 RID: 20
public abstract class c3n : a9q, c6m
{
	// Token: 0x17000003 RID: 3
	// (get) Token: 0x0600002E RID: 46
	public abstract string Name { get; }

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x0600002F RID: 47 RVA: 0x000031F8 File Offset: 0x000013F8
	public string LocalizedName
	{
		get
		{
			if (aji.a == null)
			{
				return this.Name;
			}
			string text = qv.b("AbilityNames/" + this.Name);
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return this.Name;
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000030 RID: 48
	public abstract string TechnicalName { get; }

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000031 RID: 49 RVA: 0x00003240 File Offset: 0x00001440
	public virtual IList<string> CooldownCodes
	{
		get
		{
			return new List<string>();
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000032 RID: 50
	public abstract ci8 Nature { get; }

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000033 RID: 51 RVA: 0x00003248 File Offset: 0x00001448
	public virtual string InvocationText
	{
		get
		{
			return this.Name;
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000034 RID: 52 RVA: 0x00003250 File Offset: 0x00001450
	public virtual int Order
	{
		get
		{
			return 0;
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000035 RID: 53 RVA: 0x00003254 File Offset: 0x00001454
	public virtual bool RequiresMedium
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000036 RID: 54 RVA: 0x00003258 File Offset: 0x00001458
	public virtual v5 PrimaryExecutionMode
	{
		get
		{
			return v5.a;
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x06000037 RID: 55 RVA: 0x0000325C File Offset: 0x0000145C
	public virtual bool HasSecondaryEffectRadius
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x06000038 RID: 56 RVA: 0x00003260 File Offset: 0x00001460
	public virtual bool CanBeUsedWhileDriving
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00003264 File Offset: 0x00001464
	public virtual string p6(cnm A_0)
	{
		return this.InvocationText;
	}

	// Token: 0x0600003A RID: 58 RVA: 0x0000326C File Offset: 0x0000146C
	public virtual bool c3(cnm A_0)
	{
		return true;
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00003270 File Offset: 0x00001470
	public virtual string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00003274 File Offset: 0x00001474
	public ip v(cnm A_0)
	{
		if (A_0.b8() != null)
		{
			return A_0.b8().Cooldowns.a(this.CooldownCodes);
		}
		return null;
	}

	// Token: 0x0600003D RID: 61 RVA: 0x000032A4 File Offset: 0x000014A4
	public virtual bool v0(cnm A_0)
	{
		return false;
	}

	// Token: 0x0600003E RID: 62 RVA: 0x000032A8 File Offset: 0x000014A8
	public virtual bool hm(cnm A_0)
	{
		if (A_0.b8() != null && !A_0.b8().IsInControl)
		{
			return false;
		}
		if (bzl.a() && !this.c3(A_0))
		{
			return false;
		}
		int num = this.afh(A_0);
		if (num > 0)
		{
			io service = bpo.GetService<io>();
			if (service != null && service.ahh() && service.ahv(A_0.b8()) < num)
			{
				return false;
			}
		}
		if (A_0 != null && A_0.b8() != null)
		{
			coh coh = A_0.b9() as coh;
			if (coh != null)
			{
				c6m c6m = coh.Definition as c6m;
				if (c6m != null)
				{
					List<brl> list = c6m.j0();
					if (list != null && list.Count > 0)
					{
						using (List<brl>.Enumerator enumerator = list.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								if (!enumerator.Current.oh(A_0.b8()))
								{
									return false;
								}
							}
						}
					}
				}
			}
			if (this.EquippedItemBased && !this.t(A_0))
			{
				return false;
			}
			if (this.WieldedWeaponBased && !Enumerable.Any<aia>(A_0.b8().Offense.u().TypedDefinition.@as(), new Func<aia, bool>(this.b)))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00003428 File Offset: 0x00001628
	protected bool t(cnm A_0)
	{
		if (A_0 == null || A_0.b8() == null)
		{
			return false;
		}
		bool result = false;
		foreach (coh coh in A_0.b8().Gear.i())
		{
			a06 a = coh as a06;
			if (a != null && Enumerable.Any<aia>(a.fu().@as(), new Func<aia, bool>(this.a)))
			{
				result = true;
				if (!ke.a(A_0.b8(), a))
				{
					return false;
				}
				break;
			}
		}
		return result;
	}

	// Token: 0x06000040 RID: 64
	public abstract bool cu(cnm A_0);

	// Token: 0x06000041 RID: 65 RVA: 0x000034E4 File Offset: 0x000016E4
	public virtual IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x06000042 RID: 66 RVA: 0x000034EC File Offset: 0x000016EC
	public virtual IList<cfd> p5(cnm A_0, v5 A_1)
	{
		return new List<cfd>();
	}

	// Token: 0x06000043 RID: 67 RVA: 0x000034F4 File Offset: 0x000016F4
	public aia e()
	{
		return new aia(base.GetType());
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00003504 File Offset: 0x00001704
	public virtual List<brl> j0()
	{
		return new List<brl>();
	}

	// Token: 0x06000045 RID: 69
	public abstract string bo(cnm A_0);

	// Token: 0x06000046 RID: 70
	public abstract string bp(cnm A_0);

	// Token: 0x06000047 RID: 71 RVA: 0x0000350C File Offset: 0x0000170C
	public virtual dsk cv(cnm A_0)
	{
		return dsk.a;
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00003510 File Offset: 0x00001710
	public virtual int afh(cnm A_0)
	{
		return Convert.ToInt32((float)this.hi(A_0) * this.cl(A_0));
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00003528 File Offset: 0x00001728
	public override string ToString()
	{
		return this.Name;
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x0600004A RID: 74 RVA: 0x00003530 File Offset: 0x00001730
	public virtual bool EquippedItemBased
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x0600004B RID: 75 RVA: 0x00003534 File Offset: 0x00001734
	public virtual bool WieldedWeaponBased
	{
		get
		{
			return false;
		}
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00003538 File Offset: 0x00001738
	protected virtual int hi(cnm A_0)
	{
		return 15;
	}

	// Token: 0x0600004D RID: 77 RVA: 0x0000353C File Offset: 0x0000173C
	protected virtual float cl(cnm A_0)
	{
		return 1f;
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00003544 File Offset: 0x00001744
	protected double u(cnm A_0)
	{
		return c3n.a(this.TechnicalName, A_0);
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00003554 File Offset: 0x00001754
	protected static double a(string A_0, cnm A_1)
	{
		eax eax;
		if (A_0 != null && A_1 != null && A_1.b8() != null && A_1.b8().Offense.@as().TryGetValue(A_0.ToLowerInvariant(), out eax))
		{
			return eax.b.GetValueOrDefault(1.0);
		}
		return 1.0;
	}

	// Token: 0x06000050 RID: 80 RVA: 0x000035B8 File Offset: 0x000017B8
	protected static int GetSpecSafe<T>(cnm invocationSet) where T : apq
	{
		if (invocationSet != null && invocationSet.b8() != null)
		{
			return invocationSet.b8().GetSpecializationValue<T>(true);
		}
		return 0;
	}

	// Token: 0x06000052 RID: 82 RVA: 0x000035E4 File Offset: 0x000017E4
	[CompilerGenerated]
	private bool b(aia A_0)
	{
		return A_0.Value == this;
	}

	// Token: 0x06000053 RID: 83 RVA: 0x000035F0 File Offset: 0x000017F0
	[CompilerGenerated]
	private bool a(aia A_0)
	{
		return A_0.Value == this;
	}
}
