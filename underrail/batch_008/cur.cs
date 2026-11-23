using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02001845 RID: 6213
[eiz("PDCOC")]
[Serializable]
public sealed class cur : w0, ISerializable
{
	// Token: 0x06008472 RID: 33906 RVA: 0x003720AC File Offset: 0x003702AC
	private cur(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("PDCOC:TCR", typeof(EntityAspectReference<amc, amc>));
			return;
		}
		if (base.GetType() == typeof(cur))
		{
			this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("_TargetChracterRef", typeof(EntityAspectReference<amc, amc>));
			return;
		}
		this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("PlayerDetectsCharacterObservationCondition+_TargetChracterRef", typeof(EntityAspectReference<amc, amc>));
	}

	// Token: 0x06008473 RID: 33907 RVA: 0x00372148 File Offset: 0x00370348
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("PDCOC:TCR", this.a);
	}

	// Token: 0x06008474 RID: 33908 RVA: 0x0037215C File Offset: 0x0037035C
	public cur(amc A_0)
	{
		this.a = new EntityAspectReference<amc, amc>(A_0);
	}

	// Token: 0x06008475 RID: 33909 RVA: 0x00372170 File Offset: 0x00370370
	public cur(EntityAspectReference<amc, amc> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008476 RID: 33910 RVA: 0x00372180 File Offset: 0x00370380
	public bool @if(c1a A_0)
	{
		if (this.a != null && this.a.ao() != null)
		{
			bm6 aspect = bpo.GetServiceOrThrow<cnk>().aqu().v().b().GetAspect<bm6>();
			return aspect != null && aspect.a(this.a.ao());
		}
		return false;
	}

	// Token: 0x040032BE RID: 12990
	private EntityAspectReference<amc, amc> a;
}
