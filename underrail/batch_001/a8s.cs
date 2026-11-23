using System;
using System.Collections.Generic;

// Token: 0x02000011 RID: 17
public abstract class a8s : c3n
{
	// Token: 0x0600001E RID: 30 RVA: 0x00002DDC File Offset: 0x00000FDC
	public override bool v0(cnm A_0)
	{
		return A_0.b8().Auras.c(this);
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002DF0 File Offset: 0x00000FF0
	public virtual List<Type> f(cnm A_0)
	{
		return new List<Type>();
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002DF8 File Offset: 0x00000FF8
	public virtual List<els> j8(cnm A_0)
	{
		return new List<els>();
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002E00 File Offset: 0x00001000
	public override string bp(cnm A_0)
	{
		return "Activate " + this.Name;
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002E14 File Offset: 0x00001014
	public override bool hm(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(bdm.a))
		{
			return false;
		}
		if (!base.hm(A_0))
		{
			return false;
		}
		if (A_0.b8() != null && !this.CanBeUsedWhileDriving && A_0.b8().Vehicle != null)
		{
			return false;
		}
		coh coh = A_0.b9() as coh;
		return coh == null || A_0.b8() == null || coh.anx(A_0.b8());
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002EB0 File Offset: 0x000010B0
	public override bool cu(cnm A_0)
	{
		if (A_0 != null && A_0.b8() != null && A_0.b8().StatusEffects.a(bdm.a))
		{
			return false;
		}
		if (this.EquippedItemBased && !base.t(A_0))
		{
			return false;
		}
		if (A_0.b8() != null && !this.CanBeUsedWhileDriving && A_0.b8().Vehicle != null)
		{
			return false;
		}
		coh coh = A_0.b9() as coh;
		return coh == null || A_0.b8() == null || coh.anx(A_0.b8());
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002F58 File Offset: 0x00001158
	public override dsk cv(cnm A_0)
	{
		return dsk.c;
	}
}
