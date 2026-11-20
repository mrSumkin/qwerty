using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000AB2 RID: 2738
[eiz("TOPG")]
[Serializable]
public sealed class dvc : cze, ISerializable
{
	// Token: 0x06003FF7 RID: 16375 RVA: 0x001843E4 File Offset: 0x001825E4
	private dvc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 230)
		{
			this.a = (A_0.GetValue("TOPG:P", typeof(Guid?)) as Guid?);
		}
	}

	// Token: 0x06003FF8 RID: 16376 RVA: 0x00184424 File Offset: 0x00182624
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TOPG:P", this.a);
	}

	// Token: 0x06003FF9 RID: 16377 RVA: 0x00184444 File Offset: 0x00182644
	public dvc()
	{
	}

	// Token: 0x06003FFA RID: 16378 RVA: 0x0018444C File Offset: 0x0018264C
	public Guid? a()
	{
		return this.a;
	}

	// Token: 0x06003FFB RID: 16379 RVA: 0x00184454 File Offset: 0x00182654
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003FFC RID: 16380 RVA: 0x00184460 File Offset: 0x00182660
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_1 == null)
		{
			return;
		}
		a3f aspect = A_1.GetAspect<a3f>();
		if (aspect != null && aspect.a() != null)
		{
			Guid? primitivePropertyValue = aspect.a().GetPrimitivePropertyValue<Guid>("local_conductorId", null);
			if (primitivePropertyValue != null)
			{
				EntityAspectReference<alv, alv> entityAspectReference = new EntityAspectReference<alv, alv>(A_1.Area, primitivePropertyValue.Value);
				if (entityAspectReference.ao() != null)
				{
					entityAspectReference.ao().a8().bc(true);
					qy qy = new qy();
					bfq bfq = new bfq();
					bfq.b("expand");
					bfq.c("PowerGenConductorLift");
					bfq.a(0.6f);
					qy.ad().Add(new a4s(bfq, null, new ar7(entityAspectReference.ao().a8()), null));
					ddg ddg = new ddg(entityAspectReference);
					ddg.c(3);
					ddg.a(250.0);
					ddg.a(true);
					qy.ad().Add(ddg);
					eea item = new eea(entityAspectReference);
					qy.ad().Add(item);
					bfq bfq2 = new bfq();
					bfq2.b("humming");
					bfq2.c("PowerGenConductorHumming");
					bfq2.d(true);
					bfq2.a(0.2f);
					bfq2.a(c9z.b);
					qy.ad().Add(new a4s(bfq2, null, new ar7(entityAspectReference.ao().a8()), null));
					if (this.a != null)
					{
						List<auv> list = qy.ad();
						a4s a4s = new a4s(new eb7(this.a, true), null, null, null);
						a4s.b(new ar7(A_1));
						list.Add(a4s);
					}
					A_1.Zone.ActionManager.g9(qy, atp.a);
				}
			}
		}
	}

	// Token: 0x04001BE7 RID: 7143
	private new Guid? a;
}
