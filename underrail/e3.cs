using System;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02001414 RID: 5140
[eiz("ECS")]
[Serializable]
public sealed class e3 : b1z, ISerializable
{
	// Token: 0x0600735F RID: 29535 RVA: 0x0030A1AC File Offset: 0x003083AC
	private e3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (EntityAspectReference<amc, amc>)A_0.GetValue("ECS:CR", typeof(EntityAspectReference<amc, amc>));
	}

	// Token: 0x06007360 RID: 29536 RVA: 0x0030A1D8 File Offset: 0x003083D8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ECS:CR", this.a);
	}

	// Token: 0x06007361 RID: 29537 RVA: 0x0030A1F4 File Offset: 0x003083F4
	private amc a()
	{
		return this.a.ao();
	}

	// Token: 0x06007362 RID: 29538 RVA: 0x0030A204 File Offset: 0x00308404
	public e3(amc A_0)
	{
		this.a = new EntityAspectReference<amc, amc>(A_0);
	}

	// Token: 0x06007363 RID: 29539 RVA: 0x0030A21C File Offset: 0x0030841C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a() != null)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null && service.ahe() != null)
			{
				d4n d4n = service.ahu(this.a().aa());
				if (d4n == service.ahe())
				{
					d4n.b(int.MaxValue, false);
				}
			}
			this.a().aa().Cooldowns.a(e5b.d);
			bl6 bl = ecf.a(dgk.Get<e5b>(), new eru(new EntityAspectReference<amc, amc>(this.a())), null) as bl6;
			if (bl != null)
			{
				cp.a(bl, this.a().a8(), true);
			}
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x04002F26 RID: 12070
	private new EntityAspectReference<amc, amc> a;
}
