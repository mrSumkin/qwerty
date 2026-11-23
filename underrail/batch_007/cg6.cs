using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02001417 RID: 5143
[eiz("WD")]
[Serializable]
public sealed class cg6 : b1z, ISerializable
{
	// Token: 0x0600736B RID: 29547 RVA: 0x0030A690 File Offset: 0x00308890
	private cg6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("WD:A", typeof(EntityAspectReference<amc, amc>)) as EntityAspectReference<amc, amc>);
	}

	// Token: 0x0600736C RID: 29548 RVA: 0x0030A6BC File Offset: 0x003088BC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("WD:A", this.a);
	}

	// Token: 0x0600736D RID: 29549 RVA: 0x0030A6D8 File Offset: 0x003088D8
	public cg6(amc A_0)
	{
		this.a = new EntityAspectReference<amc, amc>(A_0);
	}

	// Token: 0x0600736E RID: 29550 RVA: 0x0030A6F0 File Offset: 0x003088F0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a != null && this.a.ao() != null && this.a.ao().aa().Offense.u().Definition != null && !this.a.ao().aa().Offense.u().Definition.a9() && this.a.ao().aa().Offense.u().MaxDurability > 0)
		{
			cd1 cd = this.a.ao().aa().Offense.u();
			double num = (double)this.a.ao().aa().Offense.av() * (dwh.m + (double)this.a.ao().aa().Offense.u().MaxDurability * dwh.l);
			if (cd.TypedDefinition.e() == btz.j || cd.TypedDefinition.e() == btz.k)
			{
				num *= 0.1;
			}
			else if (cd.TypedDefinition.e() == btz.j || cd.TypedDefinition.e() == btz.k)
			{
				num *= 0.2;
			}
			else if (cd.TypedDefinition.e() == btz.b || cd.TypedDefinition.e() == btz.c)
			{
				num *= 0.5;
			}
			num *= (double)euf.b().ItemDegradationRate;
			this.a.ao().aa().Offense.u().Durability = Math.Max(0.0, this.a.ao().aa().Offense.u().Durability - num);
			this.a.ao().aa().bl();
		}
		return dc4.c;
	}

	// Token: 0x04002F30 RID: 12080
	private new EntityAspectReference<amc, amc> a;
}
