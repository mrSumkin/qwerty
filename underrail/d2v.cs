using System;
using System.Linq;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;

// Token: 0x020013CD RID: 5069
[eiz("AHEA")]
[Serializable]
public sealed class d2v : b1z, ISerializable
{
	// Token: 0x06007218 RID: 29208 RVA: 0x002FF2CC File Offset: 0x002FD4CC
	private d2v(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (cwt)A_0.GetValue("AHEA:AR", typeof(cwt));
			this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("AHEA:AR1", typeof(EntityAspectReference<amc, amc>));
			this.c = (EntityAspectReference<amc, amc>)A_0.GetValue("AHEA:TR", typeof(EntityAspectReference<amc, amc>));
			if (ell.a() >= 262)
			{
				this.d = (cru)A_0.GetValue("AHEA:S", typeof(cru));
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(d2v))
			{
				this.a = (cwt)A_0.GetValue("_AttackResult", typeof(cwt));
				this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("_AttackerRef", typeof(EntityAspectReference<amc, amc>));
				this.c = (EntityAspectReference<amc, amc>)A_0.GetValue("_TargetRef", typeof(EntityAspectReference<amc, amc>));
				return;
			}
			this.a = (cwt)A_0.GetValue("ApplyHitEffectsAction+_AttackResult", typeof(cwt));
			this.b = (EntityAspectReference<amc, amc>)A_0.GetValue("ApplyHitEffectsAction+_AttackerRef", typeof(EntityAspectReference<amc, amc>));
			this.c = (EntityAspectReference<amc, amc>)A_0.GetValue("ApplyHitEffectsAction+_TargetRef", typeof(EntityAspectReference<amc, amc>));
		}
	}

	// Token: 0x06007219 RID: 29209 RVA: 0x002FF458 File Offset: 0x002FD658
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("AHEA:AR", this.a);
		info.AddValue("AHEA:AR1", this.b);
		info.AddValue("AHEA:TR", this.c);
		info.AddValue("AHEA:S", this.d);
	}

	// Token: 0x0600721A RID: 29210 RVA: 0x002FF4B4 File Offset: 0x002FD6B4
	public d2v(cwt A_0, EntityAspectReference<amc, amc> A_1, EntityAspectReference<amc, amc> A_2, cru A_3)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
	}

	// Token: 0x0600721B RID: 29211 RVA: 0x002FF4DC File Offset: 0x002FD6DC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a == null)
		{
			return dc4.e;
		}
		c1a c1a;
		if (this.c != null && this.c.ao() != null && this.c.ao().a8() != null && this.c.ao().a8().Zone != null)
		{
			c1a = this.c.ao().a8().Zone;
		}
		else
		{
			c1a = Enumerable.FirstOrDefault<c1a>(bpo.GetServiceOrThrow<b4b>().yn().Zones);
		}
		if (c1a == null)
		{
			return dc4.e;
		}
		if (this.a.g != null)
		{
			foreach (edm edm in this.a.g)
			{
				bs8 bs = dpo.a(edm.Name);
				if (bs != null)
				{
					bs.agr(this.b);
					bs.agt(this.c);
					bs.agx(this.a);
					bs.agv(edm);
					bs.agz(this.d);
					bs.ag3(this.a.ai ?? ((this.b != null && this.b.ao() != null) ? this.b.ao().aa().Offense.u() : null));
					if (this.c.ao() != null && this.c.ao().a8() != null && this.c.ao().a8().Area != null)
					{
						bs.ag1(new bt4(this.c.ao().a8().Area.y8(), this.c.ao().a8().Location));
					}
					c1a.ActionManager.g9(bs, atp.a);
				}
			}
		}
		return dc4.c;
	}

	// Token: 0x04002E8B RID: 11915
	private new cwt a;

	// Token: 0x04002E8C RID: 11916
	private EntityAspectReference<amc, amc> b;

	// Token: 0x04002E8D RID: 11917
	private EntityAspectReference<amc, amc> c;

	// Token: 0x04002E8E RID: 11918
	private cru d;
}
