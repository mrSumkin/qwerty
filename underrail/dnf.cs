using System;
using System.Runtime.Serialization;

// Token: 0x02001351 RID: 4945
[eiz("T0")]
[Serializable]
public sealed class dnf : b1z, ISerializable
{
	// Token: 0x06006FEC RID: 28652 RVA: 0x002EF950 File Offset: 0x002EDB50
	private dnf(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("UPA:TER", typeof(ar7)) as ar7);
	}

	// Token: 0x06006FED RID: 28653 RVA: 0x002EF97C File Offset: 0x002EDB7C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("UPA:TER", this.a);
	}

	// Token: 0x06006FEE RID: 28654 RVA: 0x002EF998 File Offset: 0x002EDB98
	public dnf(b0b A_0, ak1 A_1)
	{
		if (A_0 != null)
		{
			this.a = new ar7(A_0);
		}
		if (A_1 != null)
		{
			this.b = new edx(A_1);
		}
	}

	// Token: 0x06006FEF RID: 28655 RVA: 0x002EF9C8 File Offset: 0x002EDBC8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a == null || this.a.ao() == null || this.a.ao().Zone == null || this.b == null || this.b.ao() == null)
		{
			return dc4.e;
		}
		amc amc = ((c5x)this.a.ao()).h.b;
		if (amc != null)
		{
			cnb cnb = null;
			foreach (b0b b0b in this.b.ao().c.Values)
			{
				cnb = (((c5x)b0b).s.b as cnb);
				if (cnb != null)
				{
					break;
				}
			}
			if (cnb != null && !cnb.q())
			{
				d2b aspect = cnb.a8().GetAspect<d2b>();
				if (aspect != null && aspect.n() && aspect.a(amc, false) != c9b.a)
				{
					return dc4.e;
				}
				d02 service = bpo.GetService<d02>();
				if (service != null && service.ahg() && service.ahe() != null && service.ahe().b == amc)
				{
					int num = d0u.a()[cnb.pr()];
					if (service.ahe().c < (double)num)
					{
						return dc4.e;
					}
				}
				if (cnb.a(amc.a8(), null, false, false))
				{
					dz6.a(amc.a8(), cnb);
				}
			}
		}
		return dc4.c;
	}

	// Token: 0x04002DBC RID: 11708
	private new ar7 a;

	// Token: 0x04002DBD RID: 11709
	private edx b;
}
