using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000F97 RID: 3991
[eiz("RPCLA")]
[Serializable]
public sealed class d6v : b1z, ISerializable
{
	// Token: 0x0600519B RID: 20891 RVA: 0x0024BB78 File Offset: 0x00249D78
	private d6v(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (EntityAspectReference<alv, alv>)A_0.GetValue("RPCLA:C", typeof(EntityAspectReference<alv, alv>));
	}

	// Token: 0x0600519C RID: 20892 RVA: 0x0024BBA4 File Offset: 0x00249DA4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RPCLA:C", this.a);
	}

	// Token: 0x0600519D RID: 20893 RVA: 0x0024BBC0 File Offset: 0x00249DC0
	public d6v(EntityAspectReference<alv, alv> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600519E RID: 20894 RVA: 0x0024BBD0 File Offset: 0x00249DD0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a == null || this.a.ao() == null || this.a.ao().a8() == null || this.a.ao().a8().Zone == null)
		{
			return dc4.e;
		}
		ny aspect = this.a.ao().a8().GetAspect<ny>();
		if (aspect == null)
		{
			aspect.a(true, false);
		}
		foreach (cd0 cd in this.a.ao().a)
		{
			if (cd.a == "Effects\\PowerConductorLightning")
			{
				this.a.ao().a.Remove(cd);
				break;
			}
		}
		this.a.ao().a8().w();
		return dc4.c;
	}

	// Token: 0x04002178 RID: 8568
	private new EntityAspectReference<alv, alv> a;
}
