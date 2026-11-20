using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020013D7 RID: 5079
[eiz("R03")]
[Serializable]
public sealed class duh : dvv, ISerializable, cst
{
	// Token: 0x06007253 RID: 29267 RVA: 0x00300D78 File Offset: 0x002FEF78
	private duh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("R03:C", typeof(EntityAspectReference<amc, amc>));
		this.b = (A_0.GetValue("R03:S", typeof(HashSet<string>)) as HashSet<string>);
	}

	// Token: 0x06007254 RID: 29268 RVA: 0x00300DD0 File Offset: 0x002FEFD0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("R03:C", this.a);
		info.AddValue("R03:S", this.b);
	}

	// Token: 0x06007255 RID: 29269 RVA: 0x00300DFC File Offset: 0x002FEFFC
	private amc a()
	{
		return this.a.ao();
	}

	// Token: 0x06007256 RID: 29270 RVA: 0x00300E0C File Offset: 0x002FF00C
	public HashSet<string> b()
	{
		return this.b;
	}

	// Token: 0x06007257 RID: 29271 RVA: 0x00300E14 File Offset: 0x002FF014
	public m7 kh()
	{
		return m7.a;
	}

	// Token: 0x06007258 RID: 29272 RVA: 0x00300E18 File Offset: 0x002FF018
	public duh(amc A_0, params string[] A_1)
	{
		this.a = new EntityAspectReference<amc, amc>(A_0);
		if (A_1 != null)
		{
			this.b = new HashSet<string>(A_1);
			return;
		}
		this.b = new HashSet<string>();
	}

	// Token: 0x06007259 RID: 29273 RVA: 0x00300E4C File Offset: 0x002FF04C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a() == null || this.a().aa().Dead)
		{
			return dc4.e;
		}
		for (int i = this.a().aa().StatusEffects.d().Count - 1; i >= 0; i--)
		{
			els els = this.a().aa().StatusEffects.d()[i];
			if (this.b.Contains(els.Code))
			{
				this.a().aa().StatusEffects.d(els);
			}
		}
		return dc4.c;
	}

	// Token: 0x04002EA9 RID: 11945
	private new EntityAspectReference<amc, amc> a;

	// Token: 0x04002EAA RID: 11946
	private HashSet<string> b;
}
