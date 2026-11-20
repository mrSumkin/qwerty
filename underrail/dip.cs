using System;
using System.Collections.Generic;

// Token: 0x0200121D RID: 4637
public abstract class dip : lh
{
	// Token: 0x060063D8 RID: 25560
	public abstract string md();

	// Token: 0x060063D9 RID: 25561
	public abstract string me();

	// Token: 0x060063DA RID: 25562 RVA: 0x002AFD6C File Offset: 0x002ADF6C
	public virtual void akc(amc A_0)
	{
	}

	// Token: 0x060063DB RID: 25563 RVA: 0x002AFD70 File Offset: 0x002ADF70
	public virtual void q5(ak1 A_0, c5x A_1)
	{
	}

	// Token: 0x060063DC RID: 25564 RVA: 0x002AFD74 File Offset: 0x002ADF74
	public virtual void q6(amc A_0)
	{
	}

	// Token: 0x060063DD RID: 25565 RVA: 0x002AFD78 File Offset: 0x002ADF78
	public virtual void mg(c5x A_0)
	{
	}

	// Token: 0x060063DE RID: 25566 RVA: 0x002AFD80 File Offset: 0x002ADF80
	public cd1 akd(efk A_0)
	{
		cd1 cd = this.mf(A_0);
		if (cd != null && cd.TypedDefinition != null)
		{
			cd.TypedDefinition.aa().Add(new edm("carriedObjHit", 1.0, 1, true));
		}
		return cd;
	}

	// Token: 0x060063DF RID: 25567
	protected abstract cd1 mf(efk A_0);

	// Token: 0x060063E0 RID: 25568 RVA: 0x002AFDCC File Offset: 0x002ADFCC
	public virtual void mh(amc A_0)
	{
	}

	// Token: 0x060063E1 RID: 25569 RVA: 0x002AFDD0 File Offset: 0x002ADFD0
	public virtual void q7(amc A_0, c5i A_1)
	{
	}

	// Token: 0x060063E2 RID: 25570 RVA: 0x002AFDD4 File Offset: 0x002ADFD4
	public virtual void qr(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
	}

	// Token: 0x060063E3 RID: 25571 RVA: 0x002AFDD8 File Offset: 0x002ADFD8
	public virtual void qt(amc A_0, dj7 A_1)
	{
	}

	// Token: 0x060063E4 RID: 25572 RVA: 0x002AFDDC File Offset: 0x002ADFDC
	public virtual void qs(amc A_0, dj7 A_1)
	{
	}

	// Token: 0x060063E5 RID: 25573 RVA: 0x002AFDE0 File Offset: 0x002ADFE0
	public virtual Dictionary<string, app> mi(amc A_0)
	{
		return null;
	}
}
