using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;
using Ouroboros.Playfield.References;

// Token: 0x0200100E RID: 4110
[eiz("LCR")]
[Serializable]
public sealed class eru : TypedObjectReference<efk>, ISerializable
{
	// Token: 0x060054CF RID: 21711 RVA: 0x00257B2C File Offset: 0x00255D2C
	private eru(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("LCR:AR", typeof(EntityAspectReference<amc, amc>));
			return;
		}
		if (base.GetType() == typeof(eru))
		{
			this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("_AspectReference", typeof(EntityAspectReference<amc, amc>));
			return;
		}
		this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("LocaleCharacterReference+_AspectReference", typeof(EntityAspectReference<amc, amc>));
	}

	// Token: 0x060054D0 RID: 21712 RVA: 0x00257BC8 File Offset: 0x00255DC8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("LCR:AR", this.a);
	}

	// Token: 0x060054D1 RID: 21713 RVA: 0x00257BE4 File Offset: 0x00255DE4
	public eru(EntityAspectReference<amc, amc> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060054D2 RID: 21714 RVA: 0x00257BF4 File Offset: 0x00255DF4
	protected override efk h4()
	{
		if (this.a != null && this.a.ao() != null)
		{
			return this.a.ao().aa();
		}
		return null;
	}

	// Token: 0x04002287 RID: 8839
	public EntityAspectReference<amc, amc> a;
}
