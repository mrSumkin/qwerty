using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020013D4 RID: 5076
[eiz("R14")]
[Serializable]
public sealed class e43 : dvv, ISerializable, cst
{
	// Token: 0x06007249 RID: 29257 RVA: 0x003009FC File Offset: 0x002FEBFC
	private e43(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("R14:C", typeof(EntityAspectReference<amc, amc>));
		this.b = (A_0.GetValue("R14:I", typeof(HashSet<Guid>)) as HashSet<Guid>);
	}

	// Token: 0x0600724A RID: 29258 RVA: 0x00300A54 File Offset: 0x002FEC54
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("R14:C", this.a);
		info.AddValue("R14:I", this.b);
	}

	// Token: 0x0600724B RID: 29259 RVA: 0x00300A80 File Offset: 0x002FEC80
	public m7 kh()
	{
		return m7.a;
	}

	// Token: 0x0600724C RID: 29260 RVA: 0x00300A84 File Offset: 0x002FEC84
	public e43(amc A_0, params Guid[] A_1)
	{
		this.a = new EntityAspectReference<amc, amc>(A_0);
		if (A_1 != null)
		{
			this.b = new HashSet<Guid>(A_1);
			return;
		}
		this.b = new HashSet<Guid>();
	}

	// Token: 0x0600724D RID: 29261 RVA: 0x00300AB8 File Offset: 0x002FECB8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a == null || this.a.ao() == null || this.a.ao().aa().Dead)
		{
			return dc4.e;
		}
		efk efk = this.a.ao().aa();
		for (int i = efk.StatusEffects.d().Count - 1; i >= 0; i--)
		{
			els els = efk.StatusEffects.d()[i];
			if (this.b.Contains(els.Id))
			{
				efk.StatusEffects.d(els);
			}
		}
		return dc4.c;
	}

	// Token: 0x04002EA2 RID: 11938
	public new EntityAspectReference<amc, amc> a;

	// Token: 0x04002EA3 RID: 11939
	public HashSet<Guid> b;
}
