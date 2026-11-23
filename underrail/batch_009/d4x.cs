using System;
using System.Collections.Generic;

// Token: 0x0200027A RID: 634
public abstract class d4x
{
	// Token: 0x06001285 RID: 4741
	public abstract Dictionary<string, Type> jn();

	// Token: 0x06001286 RID: 4742 RVA: 0x0004D640 File Offset: 0x0004B840
	public b0b a(c5k A_0, Guid? A_1 = null, bool A_2 = false)
	{
		czh.a(A_0, "blueprint");
		b0b b0b = this.aj8(A_0, A_1, A_2);
		foreach (cn7 cn in b0b.Aspects)
		{
			d4o d4o = cn as d4o;
			if (d4o != null)
			{
				d4o.qx(A_2);
			}
		}
		return b0b;
	}

	// Token: 0x06001287 RID: 4743 RVA: 0x0004D6B8 File Offset: 0x0004B8B8
	public bool a(c5k A_0, b0b A_1, List<string> A_2)
	{
		czh.a(A_0, "blueprint");
		czh.a(A_1, "entity");
		return this.afd(A_0, A_1, A_2);
	}

	// Token: 0x06001288 RID: 4744 RVA: 0x0004D6DC File Offset: 0x0004B8DC
	protected virtual b0b aj8(c5k A_0, Guid? A_1 = null, bool A_2 = false)
	{
		return this.jo(A_0, A_1);
	}

	// Token: 0x06001289 RID: 4745 RVA: 0x0004D6E8 File Offset: 0x0004B8E8
	protected virtual b0b jo(c5k A_0, Guid? A_1 = null)
	{
		return null;
	}

	// Token: 0x0600128A RID: 4746 RVA: 0x0004D6EC File Offset: 0x0004B8EC
	protected virtual bool afd(c5k A_0, b0b A_1, List<string> A_2)
	{
		return false;
	}
}
