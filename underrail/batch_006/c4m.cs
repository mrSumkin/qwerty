using System;
using System.Collections.Generic;

// Token: 0x02000647 RID: 1607
public sealed class c4m : am7
{
	// Token: 0x060028F0 RID: 10480 RVA: 0x000EA068 File Offset: 0x000E8268
	public bn3 ai2()
	{
		return this.a;
	}

	// Token: 0x060028F1 RID: 10481 RVA: 0x000EA070 File Offset: 0x000E8270
	public void ai3(c2g A_0, bn3 A_1)
	{
		this.b[A_0] = A_1;
	}

	// Token: 0x060028F2 RID: 10482 RVA: 0x000EA080 File Offset: 0x000E8280
	public void ai4(c2g A_0)
	{
		this.b.Remove(A_0);
	}

	// Token: 0x060028F3 RID: 10483 RVA: 0x000EA090 File Offset: 0x000E8290
	public void ai5()
	{
		this.b.Clear();
	}

	// Token: 0x060028F4 RID: 10484 RVA: 0x000EA0A0 File Offset: 0x000E82A0
	public void ai6()
	{
		dd7 serviceOrThrow = bpo.GetServiceOrThrow<dd7>();
		bn3 bn = null;
		Array values = Enum.GetValues(typeof(c2g));
		for (int i = values.Length - 1; i >= 0; i--)
		{
			c2g key = (c2g)values.GetValue(i);
			bn3 bn2;
			this.b.TryGetValue(key, out bn2);
			if (bn2 != null && !string.IsNullOrEmpty(bn2.a()))
			{
				bn = bn2;
				break;
			}
		}
		if (bn != null)
		{
			if (this.a == null)
			{
				serviceOrThrow.ad3(bn.a(), bn.c(), bn.b(), null);
			}
			else if (!this.a.Equals(bn))
			{
				serviceOrThrow.ad3(bn.a(), bn.c(), bn.b(), this.a.d());
			}
		}
		else if (this.a != null)
		{
			serviceOrThrow.ad3(null, 1f, null, this.a.d());
		}
		this.a = bn;
	}

	// Token: 0x04001664 RID: 5732
	private bn3 a;

	// Token: 0x04001665 RID: 5733
	private Dictionary<c2g, bn3> b = new Dictionary<c2g, bn3>();
}
