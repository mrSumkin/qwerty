using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x02000A8D RID: 2701
[eiz("TOFPG")]
[Serializable]
public sealed class e0s : cze, ISerializable
{
	// Token: 0x06003F69 RID: 16233 RVA: 0x001807B0 File Offset: 0x0017E9B0
	private e0s(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("TOFPG:P", typeof(Guid?)) as Guid?);
	}

	// Token: 0x06003F6A RID: 16234 RVA: 0x001807E0 File Offset: 0x0017E9E0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TOFPG:P", this.a);
	}

	// Token: 0x06003F6B RID: 16235 RVA: 0x00180800 File Offset: 0x0017EA00
	public e0s()
	{
	}

	// Token: 0x06003F6C RID: 16236 RVA: 0x00180808 File Offset: 0x0017EA08
	public Guid? a()
	{
		return this.a;
	}

	// Token: 0x06003F6D RID: 16237 RVA: 0x00180810 File Offset: 0x0017EA10
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003F6E RID: 16238 RVA: 0x0018081C File Offset: 0x0017EA1C
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
					if (this.a != null)
					{
						List<auv> list = qy.ad();
						a4s a4s = new a4s(new eb7(this.a, true), null, null, null);
						a4s.b(new ar7(A_1));
						list.Add(a4s);
					}
					d6v item = new d6v(entityAspectReference);
					qy.ad().Add(item);
					bfq bfq = new bfq();
					bfq.b("expand");
					bfq.c("PowerGenConductorLift");
					bfq.a(0.6f);
					qy.ad().Add(new a4s(bfq, null, new ar7(entityAspectReference.ao().a8()), null));
					ddg ddg = new ddg(entityAspectReference);
					ddg.b(3);
					ddg.c(3);
					ddg.a(250.0);
					ddg.a(-1);
					ddg.a(true);
					qy.ad().Add(ddg);
					b18 b = new b18();
					b.b("humming");
					b.c("PowerGenConductorHumming");
					b.d(true);
					b.a(0.2f);
					b.a(c9z.b);
					qy.ad().Add(new a4s(b, null, new ar7(entityAspectReference.ao().a8()), null));
					A_1.Zone.ActionManager.g9(qy, atp.a);
				}
			}
		}
	}

	// Token: 0x04001BDA RID: 7130
	private new Guid? a;
}
