using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;
using Ouroboros.Playfield.References;

// Token: 0x02000F96 RID: 3990
[eiz("APCLA")]
[Serializable]
public sealed class eea : b1z, ISerializable
{
	// Token: 0x06005197 RID: 20887 RVA: 0x0024B8D0 File Offset: 0x00249AD0
	private eea(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (EntityAspectReference<alv, alv>)A_0.GetValue("APCLA:CEAR", typeof(EntityAspectReference<alv, alv>));
			return;
		}
		if (base.GetType() == typeof(eea))
		{
			this.a = (EntityAspectReference<alv, alv>)A_0.GetValue("_ComplexEntityAspectRef", typeof(EntityAspectReference<alv, alv>));
			return;
		}
		this.a = (EntityAspectReference<alv, alv>)A_0.GetValue("AddPowerConductorLightningAction+_ComplexEntityAspectRef", typeof(EntityAspectReference<alv, alv>));
	}

	// Token: 0x06005198 RID: 20888 RVA: 0x0024B96C File Offset: 0x00249B6C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("APCLA:CEAR", this.a);
	}

	// Token: 0x06005199 RID: 20889 RVA: 0x0024B988 File Offset: 0x00249B88
	public eea(EntityAspectReference<alv, alv> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600519A RID: 20890 RVA: 0x0024B99C File Offset: 0x00249B9C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a == null || this.a.ao() == null || this.a.ao().a8() == null || this.a.ao().a8().Zone == null)
		{
			return dc4.e;
		}
		ny ny = this.a.ao().a8().GetAspect<ny>();
		if (ny == null)
		{
			ny = new ny(this.a.ao().a8());
			this.a.ao().a8().SetAspect<ny>(ny);
		}
		etz etz = new etz(this.a.ao().a8());
		etz.c(4);
		etz.d(70);
		etz.a = "Effects\\PowerConductorLightning";
		etz.c = new Color?(Color.White);
		etz.d = new float?(0.878f);
		this.a.ao().a(1, etz);
		ah7 ah = this.a.ao().a8().Zone.i("powerConductorLightning");
		if (ah == null)
		{
			ah = new ah7("powerConductorLightning", null);
			ah.LightFadeRate = 0.2f;
			ah.Range = 4f;
			ah.Light = new ae8(new Color(0, 0, 255), 0f, LightType.Increment);
			ah.Layer = this.a.ao().a8().Layer;
			this.a.ao().a8().Zone.a(ah);
		}
		ah.g().be(this.a.ao().a8());
		e1o a_ = new e1o(ah, 0.82f, 1f, 0.002);
		ny.b(a_, atp.a);
		return dc4.c;
	}

	// Token: 0x04002177 RID: 8567
	private new EntityAspectReference<alv, alv> a;
}
