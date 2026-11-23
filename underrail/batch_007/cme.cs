using System;
using System.Collections.Generic;
using TimelapseVertigo.Common;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02001F4A RID: 8010
[ayj("applyGearBooster")]
public sealed class cme : c0r
{
	// Token: 0x0600BAF2 RID: 47858 RVA: 0x00413D44 File Offset: 0x00411F44
	public override string y8()
	{
		return "ApplyGearBooster";
	}

	// Token: 0x0600BAF3 RID: 47859 RVA: 0x00413D4C File Offset: 0x00411F4C
	public override string c1()
	{
		return "Применяет";
	}

	// Token: 0x0600BAF4 RID: 47860 RVA: 0x00413D54 File Offset: 0x00411F54
	public override string os()
	{
		return "ApplyGearBooster";
	}

	// Token: 0x0600BAF5 RID: 47861 RVA: 0x00413D5C File Offset: 0x00411F5C
	public override ci8 bg()
	{
		return ci8.b;
	}

	// Token: 0x0600BAF6 RID: 47862 RVA: 0x00413D60 File Offset: 0x00411F60
	public override TimelapseCursor? bj()
	{
		return new TimelapseCursor?(TimelapseCursor.InvokeSpell);
	}

	// Token: 0x0600BAF7 RID: 47863 RVA: 0x00413D68 File Offset: 0x00411F68
	public override a3b c0()
	{
		return new a3b
		{
			a = c0e.d
		};
	}

	// Token: 0x0600BAF8 RID: 47864 RVA: 0x00413D7C File Offset: 0x00411F7C
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600BAF9 RID: 47865 RVA: 0x00413D80 File Offset: 0x00411F80
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}

	// Token: 0x0600BAFA RID: 47866 RVA: 0x00413D84 File Offset: 0x00411F84
	public override SpellTargetType bn(cnm A_0)
	{
		dbj dbj = cme.a(A_0);
		if (dbj != null)
		{
			return dbj.TargetType;
		}
		return SpellTargetType.Item;
	}

	// Token: 0x0600BAFB RID: 47867 RVA: 0x00413DA8 File Offset: 0x00411FA8
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600BAFC RID: 47868 RVA: 0x00413DAC File Offset: 0x00411FAC
	public override string bo(cnm A_0)
	{
		return this.bp(A_0);
	}

	// Token: 0x0600BAFD RID: 47869 RVA: 0x00413DB8 File Offset: 0x00411FB8
	public override string bp(cnm A_0)
	{
		dbj dbj = cme.a(A_0);
		if (dbj != null)
		{
			return dbj.a(A_0);
		}
		return string.Empty;
	}

	// Token: 0x0600BAFE RID: 47870 RVA: 0x00413DE0 File Offset: 0x00411FE0
	public override bool hm(cnm A_0)
	{
		if (!base.hm(A_0))
		{
			return false;
		}
		if (A_0 != null && A_0.b8() != null)
		{
			fv fv = A_0.b9() as fv;
			if (fv != null)
			{
				Dictionary<string, int> dictionary = fv.a();
				if (dictionary != null && dictionary.Count > 0)
				{
					foreach (KeyValuePair<string, int> keyValuePair in dictionary)
					{
						csn csn = A_0.b8().Skills.a(keyValuePair.Key);
						if (csn != null && csn.g() < keyValuePair.Value)
						{
							return false;
						}
					}
					return true;
				}
			}
		}
		return true;
	}

	// Token: 0x0600BAFF RID: 47871 RVA: 0x00413EB8 File Offset: 0x004120B8
	protected override int br(cnm A_0)
	{
		return 5000;
	}

	// Token: 0x0600BB00 RID: 47872 RVA: 0x00413EC0 File Offset: 0x004120C0
	protected override int hi(cnm A_0)
	{
		return 20;
	}

	// Token: 0x0600BB01 RID: 47873 RVA: 0x00413EC8 File Offset: 0x004120C8
	public new static dbj a(cnm A_0)
	{
		if (A_0 != null)
		{
			coh coh = A_0.b9() as coh;
			if (coh != null && coh.Definition != null)
			{
				dy0 dy = coh.Definition as dy0;
				if (dy != null)
				{
					if (dy.a() != null)
					{
						return dy.a();
					}
				}
				else
				{
					dbj classPropertyValue = coh.Definition.a7().GetClassPropertyValue<dbj>("GearBooster");
					if (classPropertyValue != null)
					{
						return classPropertyValue;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x040043DB RID: 17371
	internal new const int a = 5000;
}
