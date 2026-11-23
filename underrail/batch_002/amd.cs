using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020013DA RID: 5082
[eiz("SSEA")]
[Serializable]
public sealed class amd : dvv, ISerializable
{
	// Token: 0x0600726E RID: 29294 RVA: 0x003015A4 File Offset: 0x002FF7A4
	private amd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("SSEA:CR", typeof(EntityAspectReference<amc, amc>));
			di7.ReadArray<els>("SSEA:SE", ref this.b, A_0);
			return;
		}
		if (base.GetType() == typeof(amd))
		{
			this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("_CharacterRef", typeof(EntityAspectReference<amc, amc>));
			this.b = (els[])A_0.GetValue("_StatusEffects", typeof(els[]));
			return;
		}
		this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("SetStatusEffectsAction+_CharacterRef", typeof(EntityAspectReference<amc, amc>));
		this.b = (els[])A_0.GetValue("SetStatusEffectsAction+_StatusEffects", typeof(els[]));
	}

	// Token: 0x0600726F RID: 29295 RVA: 0x00301690 File Offset: 0x002FF890
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SSEA:CR", this.a);
		di7.WriteArray<els>("SSEA:SE", this.b, info);
	}

	// Token: 0x06007270 RID: 29296 RVA: 0x003016BC File Offset: 0x002FF8BC
	private amc a()
	{
		return this.a.ao();
	}

	// Token: 0x06007271 RID: 29297 RVA: 0x003016CC File Offset: 0x002FF8CC
	public amd(amc A_0, params els[] A_1)
	{
		this.a = new EntityAspectReference<amc, amc>(A_0);
		this.b = A_1;
	}

	// Token: 0x06007272 RID: 29298 RVA: 0x003016E8 File Offset: 0x002FF8E8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a() == null || this.a().aa().Dead || this.b == null)
		{
			return dc4.e;
		}
		foreach (els els in this.b)
		{
			if (els != null)
			{
				this.a().aa().StatusEffects.a(els, false, false, false);
			}
		}
		return dc4.c;
	}

	// Token: 0x04002EB9 RID: 11961
	private new EntityAspectReference<amc, amc> a;

	// Token: 0x04002EBA RID: 11962
	private els[] b;
}
